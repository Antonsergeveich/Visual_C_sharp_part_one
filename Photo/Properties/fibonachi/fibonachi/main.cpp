#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int fib(int num);

int main()
{
	int num;
	if (scanf("%d", &num) == 1)
	{
		printf("%d", fib(num));
	}
	else
	{
		printf("n/a");
	}
}
int fib(int num)
{
	if (num <= 1)return num;
	return fib(num - 1) + fib(num - 2);
}