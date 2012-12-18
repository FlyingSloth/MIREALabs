#include <cstdio>
#include <ctime>
#include <cmath>
#include <clocale>

#include <windows.h>
#include <WinSock.h>

#include "../../opts/getopt.h"

enum Default
{
	auto_step_num = 2,
	auto_thread_num = 2,
	auto_trkat_num = 2,
	auto_port = 1234,
};

#define serv_address ("127.0.0.1");

//параметры для вычислений
struct Options
{
	int stepN; //число шагов разбиения
	int threadNum;//число потоков
	double trkat;//длина стороны основания
	double stepS;//размер шага разбиения
};

//инициализация параметров задачи
Options popt = {auto_step_num, auto_thread_num, auto_trkat_num, auto_trkat_num/auto_step_num};
//параметры сервера: адрес и порт
char *servAd = serv_address; 
int servPort = auto_port;
//режим работы (клиент/сервер)
bool isClient;
//функция поверхности
double func(double x, double y)
{
	return abs(x*x - y*y);
};

//чтение аргументов командной строки
void ReadOptions(int argc, char *argv[])
{
	static struct option params[] = 
	{
		{ "threadNum",		1,	NULL, 't' },
		{ "stepN",			1,	NULL, 'n' },
		{ "trkat",			1,	NULL, 'a' },
		{ "server",			0,	NULL, 's' },
		{ "client",			0,	NULL, 'c' },
		{ NULL, NULL, NULL, NULL }
	};

	int opt = 0;
	int optionIndex = 0;

	while (opt != -1)
	{
		switch (opt = getopt_long(argc, argv, "t:n:a:sc", params, &optionIndex))
		{
		case 't':
			popt.threadNum = atoi(optarg);
			if (popt.threadNum <= 0)
			{
				printf("Ошибка! Неположительное число потоков!");
				exit(-1);
			}
		break;
		case 'n':
			popt.stepN = atoi(optarg);
			if (popt.stepN > 0)
				popt.stepS = popt.trkat / popt.stepN;
			else 
				{
					printf("Ошибка! Нулевое или отрицательное число шагов!");
					exit(-1);
				}
		break;
		case 'a':
			popt.trkat = atof(optarg);
			if(popt.trkat != 0)
				popt.stepS = popt.trkat / popt.stepN;
			else 
				{
					printf("Нулевой объём");
					exit(0);
				}
		break;
		case 's':
			isClient = false;//strncpy(servAd, optarg, sizeof(servAd));
		break;
		case 'c':
			isClient = true;
		break;
		default:
		break;
		}
	}
};

//запрос
struct Request
{
	int begin;
	int end;
	struct Options opt;
};

struct Reply
{
	double result;
};

//обработка запроса к серверу и формирование ответа
void ClRequest(Request &req, Reply &rep)
{
	for (int i = req.begin; i < req.end; ++i)
	{
		for (int j = 0; j <= i; ++j)
		{
			double x = (req.opt.stepN - i - 0.5) * req.opt.stepS;
			double y = (j + 0.5) * req.opt.stepS;
			double coef = 0.0;
			if (j < i) coef = 1.0;
			else coef = 0.5;
			rep.result += func(x, y) * (req.opt.stepS * req.opt.stepS) * coef;
		}
	}
};

int FullReceive(int sock, void* buf, int len, int f)
{
	int rc, cur = 0;
	do
		rc = recv(sock, &((char*)buf)[cur], len-cur,f);
	while (rc > 0 && (cur += rc) < len);
	return (rc<0)?rc:len;
}

int Graceful(int sock)
{
	int rc, dummy;
	shutdown(sock, 1);
	do
		rc = recv(sock, (char *)&dummy,sizeof(dummy),0);
	while (rc > 0);
	return rc;
}

int GetReady(SOCKET sock[], int num)
{
	int rc, i, nfds = 0;
	fd_set fdread;

	FD_ZERO(&fdread);

	for (i = 0; i < num; ++i)
	{
		if (sock[i] > 0)
		{
			FD_SET(sock[i], &fdread);
			nfds = ((int)sock[i] > nfds) ? sock[i] : nfds;
		}
	}
	//выбор сокетов, по которым получаются данные
	rc = select(nfds + 1, &fdread, NULL, NULL, NULL);

	for (i = 0; i < num; ++i)
	{
		if (sock[i] > 0 && FD_ISSET(sock[i], &fdread))
		{
			rc = i;
			break;
		}
	}
	return rc;
}

int main(int argc, char* argv[])
{
	setlocale(LC_ALL, "Russian");

	//параметры командной строки
	ReadOptions(argc,argv);

	//инициализация сокета
	WSADATA lpWSAData;
	if (::WSAStartup(MAKEWORD(1, 1), &lpWSAData) != 0)
		printf("Ошибка при инициализации WinSock. № %d", (int)GetLastError());

	SOCKET sock = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
	struct	sockaddr_in san = {0};
	san.sin_family = AF_INET;
	san.sin_port = htons(servPort);
	san.sin_addr.s_addr = inet_addr(servAd);
	
	if (sock == INVALID_SOCKET)
		printf("Ошибка при открытии сокета. № %d", (int)GetLastError());

	if (isClient)
	{
		struct Request req = {0};
		struct Reply rep = {0};

		if (connect(sock, (sockaddr*)&san,sizeof(san)) == -1)
		{
			printf("Ошибка подключения к серверу! № %d", (int)GetLastError());
			exit(-1);
		}

		//получение запроса от сервера
		FullReceive(sock, &req, sizeof(req), 0);
		popt = req.opt;
		printf("Число потоков: %d\nДлина стороны основания: %f\nЧисло шагов разбиения: %d\nРазмер шага: %f\n\n", popt.threadNum, popt.trkat, popt.stepN, popt.stepS);

		ClRequest(req, rep);
		send(sock, (char*)&rep, sizeof(rep),0);
		Graceful(sock);
	}
	else
	{
		printf("Число потоков: %d\nДлина стороны основания: %f\nЧисло шагов разбиения: %d\nРазмер шага: %f\n\n", popt.threadNum, popt.trkat, popt.stepN, popt.stepS);

		if (bind(sock, (const struct sockaddr *)&san, sizeof(san)) == -1)
			printf("Ошибка связывания. № %d", (int)GetLastError());
		if (listen(sock, SOMAXCONN) == -1)
			printf("Ошибка сервера. № %d", (int)GetLastError());

		SOCKET *socks = new SOCKET[popt.threadNum];

		for (int i = 0; i < popt.threadNum; ++i)
		{
			struct Request req = {0};
			req.opt = popt;
			req.begin = int(sqrt((double)i / popt.threadNum) * popt.stepN);
			req.end = int(sqrt((double)(i+1) / popt.threadNum) * popt.stepN);

			socks[i] = accept(sock, NULL, NULL);
			printf("Клиент %d\n",i);
			send(socks[i], (char*)&req,sizeof(req),0);
		}

		double res = 0.0;

		for (int i = 0; i < popt.threadNum; ++i)
		{
			int ind = GetReady(socks, popt.threadNum);

			struct Reply rep = {0};

			FullReceive(socks[ind], &rep,sizeof(rep),0);
			Graceful(socks[ind]);
			closesocket(socks[ind]);
			socks[ind] = -1;

			printf("Результат потока #%d: %f\n", i, rep.result);

			res +=rep.result;
		}
		printf("Итоговый объём: %f\n", res);
		delete[] socks;
	}
	closesocket(sock);
	return 0;
}