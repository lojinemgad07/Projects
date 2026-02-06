#include "NewRequest.h"
#include "MarsStation.h"


void NewRequest:: Operate(MarsStation* s) 
{
	Missions* mission = new Missions(type, RequestDay, MissionID, targetLocation, missionDuration);
	s->AddMission(mission);
	mission->toReady();
}
