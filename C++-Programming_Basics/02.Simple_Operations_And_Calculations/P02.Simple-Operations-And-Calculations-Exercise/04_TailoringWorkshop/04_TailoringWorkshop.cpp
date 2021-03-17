#include <iostream>

using namespace std;

int main()
{
    int tablesCount;
    double tablesLengthInM, tablesWidthInM;

    cin >> tablesCount
        >> tablesLengthInM
        >> tablesWidthInM; 

    double totalTableClothsArea = tablesCount * ((tablesLengthInM + 0.6) * (tablesWidthInM + 0.6)); // 2 * 0.30 => 30cm
    double totalTableClothsSecondArea = tablesCount * (tablesLengthInM / 2 * tablesLengthInM / 2);

    double totalPriceUsd = (totalTableClothsArea * 7) + (totalTableClothsSecondArea * 9);
    double totalPriceBgn = totalPriceUsd * 1.85;

    cout.setf(ios::fixed);
    cout.precision(2);

    cout << totalPriceUsd << " USD" << endl
        << totalPriceBgn << " BGN" << endl;

    return 0;
}