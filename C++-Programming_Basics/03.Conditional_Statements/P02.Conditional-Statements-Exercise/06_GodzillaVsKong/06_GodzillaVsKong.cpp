#include <iostream>

using namespace std;

int main()
{
    double movieBudget, priceForClothing;
    int numberOfExtras;

    cin >> movieBudget >> numberOfExtras >> priceForClothing;

    double movieDecorPrice = movieBudget * 0.10;
    double clothesPrice = numberOfExtras * priceForClothing;

    if (numberOfExtras > 150)
    {
        clothesPrice = clothesPrice * 0.90;
    }

    double totalMovieAmount = movieDecorPrice + clothesPrice;

    cout.setf(ios::fixed);
    cout.precision(2);

    if (totalMovieAmount > movieBudget)
    {
        double neededMoney = totalMovieAmount - movieBudget;

        cout << "Not enough money!" << endl
            << "Wingard needs " << neededMoney << " leva more." << endl;
    }
    else
    {
        double moneyLeft = movieBudget - totalMovieAmount;

        cout << "Action!" << endl
            << "Wingard starts filming with " << moneyLeft << " leva left." << endl;
    }

    return 0;
}