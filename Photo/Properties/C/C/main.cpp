#define _CRT_SECURE_NO_WARNINGS
#include <clocale>
#include <stdio.h>

void main()
{
	setlocale(LC_ALL, "rus");
	int a = 0;
	int b = 0;
	printf("¬ведите числа: ");
	scanf("%d %d", &a, &b);
	if (b == 0)
	{
		printf("%d %d %d n/a\n", a + b, a - b, a * b);
	}
	else
	{
		printf("%d %d %d %d", a + b, a - b, a * b, a / b);
	}
}

