#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    int  numberOfDogs;
    int numberOfOtherAnimals;

    cin >> numberOfDogs;
    cin >> numberOfOtherAnimals;

    double totalMoney = numberOfDogs * 2.50 + numberOfOtherAnimals * 4.0;

    cout << setprecision(2) << fixed << totalMoney << " lv.";

    return 0;
}