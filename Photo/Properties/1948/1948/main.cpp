#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<stdbool.h>

bool is_prime(int num);

int main()
{
	int num;
	scanf("%d", &num);
	if (is_prime(num) == true) {
		printf("Yes");
	}
	else {
		printf("No");
	}

}
bool is_prime(int x)
{
	if (x > 1)
	{
		int i, j;
		i = j = x;
		while (i > 0)
		{
			i -= 2;
		}
		while (j > 9)
		{
			j = j - 2;
		}
		
		if (i == 1 || (j != 9 && j > 9))
		{
			return true;
		}
		return false;
	}
	else
	{
		return false;
	}
}