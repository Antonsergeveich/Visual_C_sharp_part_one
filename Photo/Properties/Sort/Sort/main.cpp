#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int input(int* arr, int n);
int output(int* arr, int n);
int sort(int* arr, int n);

int main()
{
	const int size = 10;
	int arr[size];
	if (input(arr, size) != 0)return 1;
	sort(arr, size);
	output(arr, size);
	return 0;
}
int input(int* arr, int n)
{
	for (int i = 0; i < n; i++) {
		if (scanf("%d", &arr[i]) != 1)
		{
			printf("n/a");
			return 1;
		}
	}
	return 0;
}
int output(int* arr, int n)
{
	for (int i = 0; i < n; i++) {
		printf("%d ", arr[i]);
	}
	return 0;
}
int sort(int* arr, int n)
{
	for (int i = 1; i < n; i++)
	{
		int buf = arr[i];
		int j = i - 1;
		while (j >= 0 && arr[j] > buf)
		{
			arr[j + 1] = arr[j];
			j--;
		}
		arr[j + 1] = buf;
	}
	return 0;
}