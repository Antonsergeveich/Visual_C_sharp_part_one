#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

void sift(int* a, int n, int i) {
    while (1) {
        int max = i, l = 2 * i + 1, r = l + 1;
        if (l < n && a[l] > a[max]) max = l;
        if (r < n && a[r] > a[max]) max = r;
        if (max == i) break;
        int t = a[i]; a[i] = a[max]; a[max] = t;
        i = max;
    }
}

void heap_sort(int* a, int n) {
    for (int i = n / 2 - 1; i >= 0; i--) sift(a, n, i);
    for (int i = n - 1; i > 0; i--) {
        int t = a[0]; a[0] = a[i]; a[i] = t;
        sift(a, i, 0);
    }
}

void swap(int* a, int* b) {
    int t = *a; *a = *b; *b = t;
}

void qsort(int* a, int n) {
    if (n < 2) return;
    int pivot = a[n / 2], * l = a, * r = a + n - 1;
    while (l <= r) {
        while (*l < pivot) l++;
        while (*r > pivot) r--;
        if (l <= r) swap(l++, r--);
    }
    qsort(a, r - a + 1);
    qsort(l, a + n - l);
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

int main() {
    const int size = 10;
    int arr[size];
    if (input(arr, size) != 0)return 1;
    heap_sort(arr, size);
    output(arr, size);
    printf("\n");
    qsort(arr, size);
    output(arr, size);
    return 0;
}