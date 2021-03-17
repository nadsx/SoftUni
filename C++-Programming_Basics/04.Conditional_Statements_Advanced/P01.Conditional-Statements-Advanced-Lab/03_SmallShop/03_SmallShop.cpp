#include <iostream>

using namespace std;

int main()
{
    string productName, city;
    double quantity;
    cin >> productName >> city >> quantity;

    if (city == "Sofia")
    {
        if (productName == "coffee") 
            cout << 0.50 * quantity << endl;

        else if (productName == "water") 
            cout << 0.80 * quantity << endl;

        else if (productName == "beer") 
            cout << 1.20 * quantity << endl;

        else if (productName == "sweets") 
            cout << 1.45 * quantity << endl;

        else if (productName == "peanuts") 
            cout << 1.60 * quantity << endl;
    }
    else if (city == "Plovdiv")
    {
        if (productName == "coffee") 
            cout << 0.40 * quantity << endl;

        else if (productName == "water") 
            cout << 0.70 * quantity << endl;

        else if (productName == "beer") 
            cout << 1.15 * quantity << endl;

        else if (productName == "sweets") 
            cout << 1.30 * quantity << endl;

        else if (productName == "peanuts") 
            cout << 1.50 * quantity << endl;
    }
    else if (city == "Varna")
    {
        if (productName == "coffee") 
            cout << 0.45 * quantity << endl;

        else if (productName == "water") 
            cout << 0.70 * quantity << endl;

        else if (productName == "beer") 
            cout << 1.10 * quantity << endl;

        else if (productName == "sweets") 
            cout << 1.35 * quantity << endl;

        else if (productName == "peanuts") 
            cout << 1.55 * quantity << endl;
    }

    return 0;
}