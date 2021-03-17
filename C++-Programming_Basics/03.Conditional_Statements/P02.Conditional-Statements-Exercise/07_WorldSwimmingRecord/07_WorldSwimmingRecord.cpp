#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double recordInSeconds, distanceInMeters, timeInSeconds;

    cin >> recordInSeconds >> distanceInMeters >> timeInSeconds;

    double swimTime = distanceInMeters * timeInSeconds;
    double delayTime = floor(distanceInMeters / 15) * 12.5;
    double totalTimeInSeconds = swimTime + delayTime;

    cout.setf(ios::fixed);
    cout.precision(2);

    if (recordInSeconds > totalTimeInSeconds)
    {
        cout << " Yes, he succeeded! The new world record is " <<
        totalTimeInSeconds << " seconds." << endl;
    }
    else
    {
        double unreachedTime = totalTimeInSeconds - recordInSeconds;

        cout << "No, he failed! He was " <<
        unreachedTime << " seconds slower." << endl;
    }

    return 0;
}