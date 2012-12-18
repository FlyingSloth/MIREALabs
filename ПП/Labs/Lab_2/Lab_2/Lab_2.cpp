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

//��������� ��� ����������
struct Options
{
	int stepN; //����� ����� ���������
	int threadNum;//����� �������
	double trkat;//����� ������� ���������
	double stepS;//������ ���� ���������
};

//������������� ���������� ������
Options popt = {auto_step_num, auto_thread_num, auto_trkat_num, auto_trkat_num/auto_step_num};
//��������� �������: ����� � ����
char *servAd = serv_address; 
int servPort = auto_port;
//����� ������ (������/������)
bool isClient;
//������� �����������
double func(double x, double y)
{
	return abs(x*x - y*y);
};

//������ ���������� ��������� ������
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
				printf("������! ��������������� ����� �������!");
				exit(-1);
			}
		break;
		case 'n':
			popt.stepN = atoi(optarg);
			if (popt.stepN > 0)
				popt.stepS = popt.trkat / popt.stepN;
			else 
				{
					printf("������! ������� ��� ������������� ����� �����!");
					exit(-1);
				}
		break;
		case 'a':
			popt.trkat = atof(optarg);
			if(popt.trkat != 0)
				popt.stepS = popt.trkat / popt.stepN;
			else 
				{
					printf("������� �����");
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

//������
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

//��������� ������� � ������� � ������������ ������
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
	//����� �������, �� ������� ���������� ������
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

	//��������� ��������� ������
	ReadOptions(argc,argv);

	//������������� ������
	WSADATA lpWSAData;
	if (::WSAStartup(MAKEWORD(1, 1), &lpWSAData) != 0)
		printf("������ ��� ������������� WinSock. � %d", (int)GetLastError());

	SOCKET sock = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
	struct	sockaddr_in san = {0};
	san.sin_family = AF_INET;
	san.sin_port = htons(servPort);
	san.sin_addr.s_addr = inet_addr(servAd);
	
	if (sock == INVALID_SOCKET)
		printf("������ ��� �������� ������. � %d", (int)GetLastError());

	if (isClient)
	{
		struct Request req = {0};
		struct Reply rep = {0};

		if (connect(sock, (sockaddr*)&san,sizeof(san)) == -1)
		{
			printf("������ ����������� � �������! � %d", (int)GetLastError());
			exit(-1);
		}

		//��������� ������� �� �������
		FullReceive(sock, &req, sizeof(req), 0);
		popt = req.opt;
		printf("����� �������: %d\n����� ������� ���������: %f\n����� ����� ���������: %d\n������ ����: %f\n\n", popt.threadNum, popt.trkat, popt.stepN, popt.stepS);

		ClRequest(req, rep);
		send(sock, (char*)&rep, sizeof(rep),0);
		Graceful(sock);
	}
	else
	{
		printf("����� �������: %d\n����� ������� ���������: %f\n����� ����� ���������: %d\n������ ����: %f\n\n", popt.threadNum, popt.trkat, popt.stepN, popt.stepS);

		if (bind(sock, (const struct sockaddr *)&san, sizeof(san)) == -1)
			printf("������ ����������. � %d", (int)GetLastError());
		if (listen(sock, SOMAXCONN) == -1)
			printf("������ �������. � %d", (int)GetLastError());

		SOCKET *socks = new SOCKET[popt.threadNum];

		for (int i = 0; i < popt.threadNum; ++i)
		{
			struct Request req = {0};
			req.opt = popt;
			req.begin = int(sqrt((double)i / popt.threadNum) * popt.stepN);
			req.end = int(sqrt((double)(i+1) / popt.threadNum) * popt.stepN);

			socks[i] = accept(sock, NULL, NULL);
			printf("������ %d\n",i);
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

			printf("��������� ������ #%d: %f\n", i, rep.result);

			res +=rep.result;
		}
		printf("�������� �����: %f\n", res);
		delete[] socks;
	}
	closesocket(sock);
	return 0;
}