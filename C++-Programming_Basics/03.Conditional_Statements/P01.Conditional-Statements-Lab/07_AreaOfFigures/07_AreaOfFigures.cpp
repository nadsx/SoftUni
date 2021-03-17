#include <iostream>

using namespace std;

int main()
{
    string typeOfFigure;

    cin >> typeOfFigure;

    double area = 0;

    if (typeOfFigure == "square")
    {
        double a;

        cin >> a;

        area = a * a;
    }
    else if (typeOfFigure == "rectangle")
    {
        double a, b;

        cin >> a >> b;

        area = a * b;
    }
    else if (typeOfFigure == "circle")
    {
        double r, pi = 3.14159265359;

        cin >> r;

        area = pi * r * r;
    }
    else if (typeOfFigure == "triangle")
    {
        double side, height;

        cin >> side >> height;

        area = side * height / 2;
    }

    cout.setf(ios::fixed);
    cout.precision(3);

    cout << area << endl;

    return 0;
}