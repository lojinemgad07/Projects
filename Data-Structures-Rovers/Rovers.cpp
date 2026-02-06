#include "Rovers.h"

int Rovers:: getID() const {
	return RoeverID;
}

RoverType Rovers:: getType() const {
	return Type;
}

int Rovers:: getSpeed() const {
	return Speed;
}

int Rovers:: getCheckupDuration() const {
	return CheckupDuration;
}

int Rovers:: getMissionsBeforeCheckup() const {
	return MissionsBeforeCheckup;
}


RoverStatus Rovers:: getStatus() const {
	return Status;
}


bool Rovers:: CheckupNeeded() {
	if (DoneMissionsCount >= MissionsBeforeCheckup)
		return true;
	else
		return false;
}

void Rovers:: StartCheckup(int currentDay) {
	Status = CHECKUP;
	CheckupEndDay = currentDay + CheckupDuration;
	DoneMissionsCount = 0;
}

bool Rovers:: DoneCheckup(int currentDay) {
	if (currentDay >= CheckupEndDay)
		return true;
	else
		return false;

}

string Rovers:: getTypeString() const {
	switch (Type) {
	case DR: return "Digging";
	case PR: return "Polar";
	case NR: return "Normal";
	}
}

ostream& operator<<(ostream& out, const Rovers& r) {
	out << " " << r.getID()
		/*<< ", Type: " << r.getTypeString()
		<< ", Speed: " << r.getSpeed()
		<< ", Checkup Duration: " << r.getCheckupDuration() << "]"*/;
	return out;
}