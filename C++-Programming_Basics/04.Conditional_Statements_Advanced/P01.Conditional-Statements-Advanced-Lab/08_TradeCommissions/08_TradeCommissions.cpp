#include <iostream>

using namespace std;

int main()
{
	string city;
	double sales;
	cin >> city >> sales;

	double commission = -1.0;

	if (city == "Sofia")
	{
		if (0 <= sales && sales <= 500)
		{
			commission = 0.05;
		}
		else if (500 < sales && sales <= 1000)
		{
			commission = 0.07;
		}
		else if (1000 < sales && sales <= 10000)
		{
			commission = 0.08;
		}
		else if (sales > 10000)
		{
			commission = 0.12;
		}
	}
	else if (city == "Varna")
	{
		if (0 <= sales && sales <= 500)
		{
			commission = 0.045;
		}
		else if (500 < sales && sales <= 1000)
		{
			commission = 0.075;
		}
		else if (1000 < sales && sales <= 10000)
		{
			commission = 0.10;
		}
		else if (sales > 10000)
		{
			commission = 0.13;
		}
	}
	else if (city == "Plovdiv")
	{
		if (0 <= sales && sales <= 500)
		{
			commission = 0.055;
		}
		else if (500 < sales && sales <= 1000)
		{
			commission = 0.08;
		}
		else if (1000 < sales && sales <= 10000)
		{
			commission = 0.12;
		}
		else if (sales > 10000)
		{
			commission = 0.145;
		}
	}

	cout.setf(ios::fixed);
	cout.precision(2);

	if (commission >= 0)
	{
		cout << sales * commission << endl;
	}
	else
	{
		cout << "error" << endl;
	}

	return 0;
}