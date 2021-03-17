#include <iostream>

using namespace std;

int main()
{
	int num;

	cin >> num;

	double bonusPoints = 0.0;

	if (num <= 100)
	{
		bonusPoints = 5;
	}
	else if (num > 1000)
	{
		bonusPoints = num * 0.1;
	}
	else
	{
		bonusPoints = num * 0.2;
	}

	if (num % 2 == 0)
	{
		bonusPoints++;
	}
	else if (num % 10 == 5)
	{
		bonusPoints += 2;
	}

	cout << bonusPoints << endl;
	cout << num + bonusPoints << endl;

	return 0;
}