#include <iostream>

using namespace std;

int main()
{
    double priceOfExcursion;
    int puzzleCount, dollsCount, tedyCount, minionsCount, trucksCount;

    cin >> priceOfExcursion >> puzzleCount >> dollsCount >> tedyCount >> minionsCount >> trucksCount;

    double profit = puzzleCount * 2.60 + dollsCount * 3 + tedyCount * 4.10 +
                    minionsCount * 8.20 + trucksCount * 2;

    int toysCount = puzzleCount + dollsCount + tedyCount + minionsCount + trucksCount;

    if (toysCount >= 50)
    {
        profit = profit * 0.75;
    }

    profit = profit * 0.90;

    cout.setf(ios::fixed);
    cout.precision(2);

    if (profit >= priceOfExcursion)
    {
        cout << "Yes! " << profit - priceOfExcursion << " lv left." << endl;
    }
    else
    {
        cout << "Not enough money! " << priceOfExcursion - profit << " lv needed." << endl;
    }

    return 0;
}