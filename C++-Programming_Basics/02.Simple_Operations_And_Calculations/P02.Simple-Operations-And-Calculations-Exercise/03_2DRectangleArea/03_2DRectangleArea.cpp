#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double x1, y1, x2, y2;

    cin >> x1
        >> y1
        >> x2
        >> y2;

    double length = abs(x1 - x2);
    double width = abs(y1 - y2);

    double area = length * width;
    double perimeter = 2 * (length + width);

    cout.setf(ios::fixed);
    cout.precision(2);

    cout << area << endl;
    cout << perimeter << endl;

    return 0;
}