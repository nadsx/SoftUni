#include <iostream>

using namespace std;

int main()
{
	int days, confectioners, cakes, waffles, pancakes;

	cin >> days
		>> confectioners
		>> cakes
		>> waffles
		>> pancakes;

	double cakesPricePerDayPerConfectioner = cakes * 45.0;
	double wafflesPricePerDayPerConfectioner = waffles * 5.80;
	double pancakesPricePerDayPerConfectioner = pancakes * 3.20;

	double totalPricePerDay = (cakesPricePerDayPerConfectioner +
		wafflesPricePerDayPerConfectioner +
		pancakesPricePerDayPerConfectioner) *
		confectioners;

	double totalPriceForEntireCampaign = totalPricePerDay * days;
	//totalPriceForEntireCampaign = totalPriceForEntireCampaign * 7 / 8;
	totalPriceForEntireCampaign = totalPriceForEntireCampaign - (totalPriceForEntireCampaign / 8);

	cout.setf(ios::fixed);
	cout.precision(2);

	cout << totalPriceForEntireCampaign << endl;

	return 0;
}