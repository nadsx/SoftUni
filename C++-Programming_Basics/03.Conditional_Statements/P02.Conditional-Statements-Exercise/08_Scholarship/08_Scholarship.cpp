#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double incomeInBGN, averageGrade, minSalary;

    cin >> incomeInBGN >> averageGrade >> minSalary;

    double socialScholarship, excellResultScholarship;

    if (averageGrade <= 4.50)
    {
        cout << "You cannot get a scholarship!" << endl;
    }
    else if (averageGrade < 5.50)
    {
        if (incomeInBGN < minSalary)
        {
            socialScholarship = floor(minSalary * 0.35);
            cout << "You get a Social scholarship " << socialScholarship << " BGN" << endl;
        }
        else
        {
            cout << "You cannot get a scholarship!" << endl;
        }
    }
    else
    {
        excellResultScholarship = floor(averageGrade * 25);
        socialScholarship = floor(minSalary * 0.35);

        if (socialScholarship > excellResultScholarship && incomeInBGN < minSalary)
        {
            cout << "You get a Social scholarship " 
                << socialScholarship << " BGN" << endl;
        }
        else
        {
            cout << "You get a scholarship for excellent results " 
                << excellResultScholarship << " BGN" << endl;
        }
    }

    return 0;
}