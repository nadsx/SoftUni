#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	int lengthInCm, widthInCm, heightInCm;
	double percentage;

	cin >> lengthInCm
		>> widthInCm
		>> heightInCm
		>> percentage;

	int volumeOfTheAquarium = lengthInCm * widthInCm * heightInCm;
	double totalLiters = volumeOfTheAquarium * 0.001;
	double neededLiters = totalLiters - totalLiters * (percentage / 100);

	cout.setf(ios::fixed);
	cout.precision(3);

	cout << neededLiters << endl;

	return 0;
}