#pragma once
#include "Rovers.h"

#include <cmath>
#include <iostream>

enum MissionType { DM, PM, NM };

enum MissionStatus {  NEW, READY, OUT, EXEC, BACK, DONE, ABORTED };

class Missions
{
private:

	MissionType Type;
	int RDay;
	int MissionID;
	int TargetLocation;
	int Duration;

	MissionStatus status = NEW;
	int LDay = -1;
	int WDay = 0;
	int TDay = 0;
	int FDay = -1;
	int travel_day = 0;
	int travel_time = 0;
	int exec_day = 0;
	Rovers* RoverAssigned = nullptr;
public:
	Missions(MissionType type, int rDay, int missionID, int targetLocation, int duration)
		: Type(type), RDay(rDay), MissionID(missionID), TargetLocation(targetLocation), Duration(duration)
		
	{
	}


	MissionType getType() const;

	int getExecDay() const;

	int getTravelDay() const;
	int getTravelTime()const;
	int getRDay() const;
	int getFDay() const;
	int getMissionID() const;
	int getTargetLocation() const;
	int getDuration() const;
	int getLDay() const;
	void setLDay(int lDay);

	Rovers* getRoverAssigned() const;

	

	int calcWDay() const;


	int calcTurnaroundDays() const;
	int calcTravelTime()const;

	int calcFinishDay()  const;

	int calcTravelDay()  const;
	int calcExecDay()  const;

	void AssignRover(Rovers* rover, int CurrentDay);


	void toReady();
	void toOut();
	void toExec();
	void toBack();
	void toDone();
	void abort();


	int getWDay() const;
	int getTDay() const;

	string getTypeString() const;
};
ostream& operator<<(ostream& out, const Missions& m);
