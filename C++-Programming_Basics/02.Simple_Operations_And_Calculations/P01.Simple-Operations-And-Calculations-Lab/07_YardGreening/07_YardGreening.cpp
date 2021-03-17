#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    double sqMeters;

    cin >> sqMeters;

    double price = sqMeters * 7.61;
    double discount = (sqMeters * 7.61) * 0.18;
    double totalPrice = price - discount;

    cout.setf(ios::fixed);
    cout.precision(2);

    cout << "The final price is: " << totalPrice << " lv.\n"
        << "The discount is: " << discount << " lv."
        << endl;

    return 0;
}