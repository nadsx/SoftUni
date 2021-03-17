#include <iostream>

using namespace std;

int main()
{
    int startHours, startMinutes;

    cin >> startHours >> startMinutes;

    int timeInMinutes = startHours * 60 + startMinutes;
    int timePlus15Min = timeInMinutes + 15;

    int finalHours = timePlus15Min / 60;
    int finalMinutes = timePlus15Min % 60;

    if (finalHours >= 24)
    {
        finalHours -= 24;
    }

    if (finalMinutes >= 60)
    {
        finalMinutes -= 60;
    }

    if (finalMinutes < 10)
    {
        cout << finalHours << ":0" << finalMinutes << endl;
    }
    else
    {
        cout << finalHours << ":" << finalMinutes << endl;
    }

    return 0;
}