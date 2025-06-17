#include<stdio.h>
#include<math.h>

#define M_PI 3.14159265358979323846

int main()
{
	double va, lb, qg;
	int n = 42; //Количество измерений
	double count = 0.1495997;
	double x = -3.1415927;   //Значение абциссы
	for (int i = -21; i <= 21; i++)
	{
		//Варзьера Аньези
		va = pow(1, 3) / (pow(1, 2) + pow(x, 2));
		double sq = sqrt(pow(1, 4) + 4 * pow(x, 2) * pow(1, 2));
		//Лемниската Бернулли
		lb = sqrt(sq - pow(x, 2) - pow(1, 2));
		//Квадратичная гипербола
		qg = 1 / pow(x, 2);
		if (isnan(lb))
		{
			printf("%.7lf|%.7lf|-|", x, va, lb);
			printf("%.7lf\n", qg);
		}
		else
		{
			printf("%.7lf|%.7lf|%.7lf|%.7lf\n", x, va, lb, qg);
		}
		x += count;
	}
	return 0;
}