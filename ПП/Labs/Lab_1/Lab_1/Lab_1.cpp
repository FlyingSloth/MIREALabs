#include "../../opts/getopt.h"
#include <cstdio>
#include <ctime>
#include <cmath>
#include <clocale>
#include <Windows.h>

#include <iostream>
using namespace std;

//�������� �� ���������
enum Default
{
	auto_step_num = 2,
	auto_thread_num = 2,
	auto_trkat_num = 2,
};

int stepN = auto_step_num; //����� ����� ���������
int threadNum = auto_thread_num;//����� �������
double trkat = auto_trkat_num;//����� ������� ���������
double stepS = trkat / stepN;//������ ���� ���������

//������� �����������
double func(double x, double y)
{
	return abs(x*x - y*y);
};

//������ ���������� ��������� ������
void Options(int argc, char *argv[])
{
	static struct option params[] = 
	{
		{ "threadNum",		1,	NULL, 't' },
		{ "stepN",			1,	NULL, 'n' },
		{ "trkat",			1,	NULL, 'a' },
		{ NULL, NULL, NULL, NULL }
	};

	int opt = 0;
	int optionIndex = 0;

	while (opt != -1)
	{
		switch (opt = getopt_long(argc, argv, "t:n:a:", params, &optionIndex))
		{
		case 't':
			threadNum = atoi(optarg);
			if (threadNum <= 0)
			{
				printf("������! ��������������� ����� �������!");
				exit(-1);
			}
		break;
		case 'n':
			stepN = atoi(optarg);
			if (stepN > 0)
				stepS = trkat / stepN;
			else 
				{
					printf("������! ������� ��� ������������� ����� �����!");
					exit(-1);
				}
		break;
		case 'a':
			trkat = atof(optarg);
			if(trkat != 0)
				stepS = trkat / stepN;
			else 
				{
					printf("������� �����");
					exit(0);
				}
		break;
		default:
		break;
		}
	}
};

//��������� ���������� ������
struct thrParam
{
	int begin;
	int end;
	double result;
};

//������� ������
DWORD WINAPI threadProc(LPVOID param)
{
	thrParam &p = *static_cast<thrParam *>(param);
	for (int i = p.begin; i < p.end; ++i)
	{
		for (int j = 0; j <= i; ++j)
		{
			double x = (stepN - i - 0.5) * stepS;
			double y = (j + 0.5) * stepS;
			double coef = 0.0;
			if (j < i) coef = 1.0;
			else coef = 0.5;
			p.result += func(x, y) * (stepS * stepS) * coef;
		}
	}
	return 0;
};

int main(int argc, char *argv[])
{
	setlocale(LC_ALL, "Russian");
	//������ ���������� ��������� ������
	Options(argc,argv);

	printf("����� �������: %d\n����� ������� ���������: %f\n����� ����� ���������: %d\n������ ����: %f\n\n", threadNum, trkat, stepN, stepS);
	time_t start = clock();

	//�������� ������� � ���������� �� ����������
	thrParam *param = new thrParam[threadNum];
	
	HANDLE *hdl = new HANDLE[threadNum];
    DWORD *dwId = new DWORD[threadNum];
	for (int i = 0; i < threadNum; ++i)
	{
		param[i].begin = int(sqrt((double)i / threadNum) * stepN);
		param[i].end = int(sqrt((double)(i+1) / threadNum) * stepN);
		param[i].result = 0.0;

		hdl[i] = ::CreateThread(NULL, 0, threadProc, &param[i], 0, &dwId[i]);
	}

	//�������� ���������� ������ �������
	::WaitForMultipleObjects(threadNum, hdl, TRUE, INFINITE);
	time_t totalTime = clock() - start;
	
	// ������������
	double res = 0.0;
	for (int i = 0; i < threadNum; ++i)
	{
		res += param[i].result;
		printf("��������� ������ #%d [%d, %d): %f\n", i, param[i].begin, param[i].end, param[i].result);
	}

	printf("\n\n�������� ����� ������: %f\n", res);
	printf("\n����������� �����: %f", (double)totalTime / CLOCKS_PER_SEC);
	
	// ������������ ��������
    for (int i = 0; i < threadNum; ++i)
        ::CloseHandle(hdl[i]);
	delete [] dwId;
	delete [] hdl;
	delete [] param;
	return 0;
}
