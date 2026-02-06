#pragma once
#include <iostream>
#include <ostream>
using namespace std;

enum RoverType { DR, NR, PR };
enum RoverStatus { AVAILABLE, BUSY, CHECKUP };

class Rovers
{
private:
	int RoeverID;
	RoverType Type;
	int Speed;
	int CheckupDuration;
	int MissionsBeforeCheckup;

	RoverStatus Status = AVAILABLE;
	int DoneMissionsCount = 0;
	int CheckupEndDay = -1;
	int BusyEndDay = -1;


public:
	Rovers(int id, RoverType type, int speed, int checkupDuration, int missionsBeforeCheckup)
		: RoeverID(id), Type(type), Speed(speed), CheckupDuration(checkupDuration), MissionsBeforeCheckup(missionsBeforeCheckup)
	{
	}

	int getID() const;

	RoverType getType() const;

	int getSpeed() const;

	int getCheckupDuration() const;

	int getMissionsBeforeCheckup() const;

	RoverStatus getStatus() const;


	bool CheckupNeeded();

	void StartCheckup(int currentDay);

	bool DoneCheckup(int currentDay);

	string getTypeString() const;
};

ostream& operator<<(ostream& out, const Rovers& r);


