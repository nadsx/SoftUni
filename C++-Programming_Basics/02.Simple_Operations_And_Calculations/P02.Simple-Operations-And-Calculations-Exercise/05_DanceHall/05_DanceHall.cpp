#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double lengthOfTheHallInM, widthOfTheHallInM, wardrobeSideInM;

	cin >> lengthOfTheHallInM
		>> widthOfTheHallInM
		>> wardrobeSideInM;

	//Convert to cm
	double hallSize = (widthOfTheHallInM * 100) * (lengthOfTheHallInM * 100); 
	double wardrobeSize = (wardrobeSideInM * 100) * (wardrobeSideInM * 100);

	double benchSize = hallSize / 10;
	double freeSpaceArea = hallSize - wardrobeSize - benchSize;
	double numberOfDancers = floor(freeSpaceArea / 7040);

	cout << numberOfDancers << endl;

	return 0;
}