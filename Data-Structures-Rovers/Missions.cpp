#include "Missions.h"

MissionType  Missions:: getType() const {
	return Type;
}

int Missions::getTravelTime() const {
	return travel_time;
}

int Missions:: getExecDay() const {
	return exec_day;
}
int Missions:: getTravelDay() const {
	return travel_day;
}

int Missions:: getRDay() const {
	return RDay;
}

int Missions:: getFDay() const {
	return FDay;
}

int Missions::getMissionID() const {
	return MissionID;
}
int Missions:: getTargetLocation() const {
	return TargetLocation;
}
int Missions:: getDuration() const {
	return Duration;
}
int Missions:: getLDay() const {
	return LDay;
}
void Missions:: setLDay(int lDay) {
	LDay = lDay;
}

Rovers* Missions:: getRoverAssigned() const {
	return RoverAssigned;
}




int Missions:: calcWDay() const {
	return LDay - RDay;
}

int Missions::calcTravelTime() const {
	if (!RoverAssigned)
		return 0;
	double distance = TargetLocation;
	double speed = RoverAssigned->getSpeed();
	double denominator=speed*25;

	double days = distance / denominator;
	int TravelTime = (int)ceil(days);

	return TravelTime;
}

int Missions:: calcTurnaroundDays() const {
	int traveltime=calcTravelTime();
	return (2 * traveltime + Duration);

}


int Missions:: calcFinishDay()  const {
	return LDay + calcTurnaroundDays();
}


int Missions::calcTravelDay()  const {

	int traveltime = calcTravelTime();
	return (traveltime + LDay);
	//return LDay + ceil((TargetLocation / (RoverAssigned->getSpeed()) / 25));
}
int Missions::calcExecDay()  const {
	//return LDay + travel_day + Duration;
	return(calcTravelDay() + Duration);
}

void Missions:: AssignRover(Rovers* rover, int CurrentDay) {
	RoverAssigned = rover;
	LDay = CurrentDay;
	WDay = calcWDay();
	TDay = calcTurnaroundDays();
	FDay = calcFinishDay();
	travel_day = calcTravelDay();
	exec_day = calcExecDay();
	travel_time = calcTravelTime();
}



void Missions::toReady() { status = READY; }
void Missions::toOut() { status = OUT; }
void Missions::toExec() { status = EXEC; }
void Missions::toBack() { status = BACK; }
void Missions::toDone() { status = DONE; }
void Missions::abort() { status = ABORTED; }




int Missions::getWDay() const {
	return calcWDay();
}

int Missions::getTDay() const {
	return calcTurnaroundDays();
}

string Missions::  getTypeString() const {
	switch (Type) {
	case DM: return "Digging";
	case PM: return "Polar";
	case NM: return "Normal";
	}
}

ostream& operator<<(ostream& out, const Missions& m) {
	out << " " << m.getMissionID()
		/*<< ", Type: " << m.getTypeString()
		<< ", Target: " << m.getTargetLocation() << " km"
		<< ", Duration: " << m.getDuration() << " days]"*/;
	return out;
}





