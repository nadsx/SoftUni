#include <iostream>

using namespace std;

int main()
{
    string nameOfArchitect;
    int numberOfProjects;

    cin >> nameOfArchitect;
    cin >> numberOfProjects;

    int hoursRequired = numberOfProjects * 3;

    cout << "The architect " << nameOfArchitect 
        << " will need " << hoursRequired 
        << " hours to complete " << numberOfProjects 
        << " project/s.";

    return 0;
}