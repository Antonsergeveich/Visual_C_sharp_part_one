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
		int i, j, z;
		i = j = z = x;
		int y = 1;
		while (i > 0 && i != 1)
		{
			i = i - 2;
		}
		
		while (j > 9)
		{
			j = j - 2;
		}
		if (i == 1 && j < 9) return true;
		//if (i == 1 && j != 9 && j > 9 && j == 1)
		while (z > 9)
		{
			z = z - 2;
		}
		if (i == 1 && z == 9 && j == 9)return true;
		if (i == 1 && z != 9 && z > 9 && y == 1)
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