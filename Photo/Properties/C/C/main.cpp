#define _CRT_SECURE_NO_WARNINGS
#include <clocale>
#include <stdio.h>

void main()
{
	setlocale(LC_ALL, "rus");
	int a = 0;
	int b = 0;
	while (a == 0 || b == 0)
	{
		printf("¬ведите числа: ");
		scanf("%d %d", &a, &b);

	}

	printf("%d %d %d %d", a + b, a - b, a * b, a / b);

}
