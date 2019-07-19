//manish kumar
//project question 1
#include "stdafx.h"
#include "stdlib.h"
#include<iostream>
#include<vector>
using namespace std;
int j, n,x;
int i = 1;
double h;
vector <double> arr(0);
double maxi1, max = 0, min = 0, mini1, sum = 0, pound;
//functions
double p_k(double p);//conversion pounds to kilograms
double k_p(double k);//conversion kilograms to pounds
double maxi(double y, int x);//finding max
double mini(double y, int x);//finding min
void printresult();//displaying result 
int main()
{
	
	do {
		cout << "What type of conversion do you want?\n";
		cout << "1. pounds to kilograms\n";
		cout << "2. kilograms to pounds\n";
		cout << "3. to quit\n";
		cin >> n;
		switch (n)
		{
		case 1:
			// converting pounds to kilograms
			do
			{
				cout << "enter the weight or 0 to find max ,min and average or a negative number to quit :\n";
				cin >> h;

				if (h == 0)
				{
					printresult();
					i = 16;
				}
				else if (h > 0)
				{
					arr.push_back(h);
					cout << "the given weight is " << p_k(h) << " kilograms" << endl;
					max = maxi(h, i);// finding max
					min = mini(h, i);// finding min
					if (i == 15)
					{
						printresult();// displaying result
					}
					i++;
				}
				

			} while (h > 0 && i != 16);
			i = 1;
			x = arr.size();
			//removing the previous elements
			for (j = 0; j < x; j++)
			{
				arr.pop_back();
			}
			break;
		case 2:
			do
			{
				cout << "enter the weight or 0 to find max ,min and average or a negative number to quit :\n";
				cin >> h;

				if (h == 0)
				{
					printresult();// displaying result
					i = 16;
				}
				else if(h>0)
				{
					arr.push_back(h);
					cout << "the given weight is " << k_p(h) << " pounds " << endl;
					max = maxi(h, i);// finding max
					min = mini(h, i);// finding min
					if (i == 15)
					{
						printresult();// displaying result
					}
					i++;
				}
				

			} while (h > 0 && i != 16);
			i = 1;
			x = arr.size();
			//removing the previous elements
			for (j = 0; j < x; j++)
			{
				arr.pop_back();
			}
			break;
		case 3:
			cout << "bye\n";
			break;
		default:
			cout << "choose a correct option\n";
		}
	} while (n != 3);
	system("pause");
	return 0;
}

double p_k(double p)
{
	return p / 2.02046;
}

double k_p(double k)
{
	return 2.2046*k;
}

double maxi(double y, int x)
{

	if (x == 1)
	{
		maxi1 = y;
	}
	else if (y > maxi1)
	{
		maxi1 = y;
	}
	return maxi1;
}

double mini(double y, int x)
{

	if (x == 1)
	{
		mini1 = y;
	}
	else if (y < mini1)
	{
		mini1 = y;
	}
	return mini1;
}

void printresult()
{

	for (j = 0; j < arr.size(); j++)
	{
		sum = sum + arr[j];

	}
	if (n == 1)
	{
		for (j = 0; j < arr.size(); j++)
		{
			if (j == 0)
			{
				cout << "You entered :\n";
				cout << j + 1 << " ." << " " << arr[j] << " pounds" << endl;
			}
			else
				cout << j + 1 << " ." << " " << arr[j] << " pounds" << endl;
		}
		cout << "the average is " << sum / arr.size() << " pounds" << endl;
		cout << "the max is " << max << " pounds  " << endl;
		cout << "the min is " << min << " pounds  " << endl;
		sum = 0;

	}
	else if (n == 2)
	{
		for (j = 0; j < arr.size(); j++)
		{
			if (j == 0)
			{
				cout << "You entered :\n";
				cout << j + 1 << " ." << " " << arr[j] << " kilograms" << endl;
			}
			else
				cout << j + 1 << " ." << " " << arr[j] << " kilograms" << endl;
		}
		cout << "the average is " << sum / arr.size() << " kilograms" << endl;
		cout << "the max is " << max << " kilograms  " << endl;
		cout << "the min is " << min << " kilograms  " << endl;
		sum = 0;

	}
	system("pause");
	system("CLS");
}