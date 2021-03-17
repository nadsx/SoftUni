#include <iostream>

using namespace std;

int main()
{
    double value;
    string inputMetric, outputMetric;

    cin >> value >> inputMetric >> outputMetric;

    if (inputMetric == "mm")
    {
        value /= 1000;
    }
    else if (inputMetric == "cm")
    {
        value /= 100;
    }

    if (outputMetric == "mm")
    {
        value *= 1000;
    }
    else if (outputMetric == "cm")
    {
        value *= 100;
    }

    cout.setf(ios::fixed);
    cout.precision(3);

    cout << value << endl;

    return 0;
}