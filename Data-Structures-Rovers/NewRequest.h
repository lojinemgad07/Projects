#pragma once
using namespace std;
#include "Request.h" 
#include <iostream>
#include "priQueue.h"
#include "Missions.h" 
#ifndef NEWREQUEST_H 

#define NEWREQUEST_H 


class NewRequest : public Request { 
private: MissionType type; 
int targetLocation; 
int missionDuration;
public: NewRequest(int RDay, int M_ID, MissionType mType, int tLocation, int mDuration) {
	RequestDay = RDay; 
	MissionID = M_ID; 
	type = mType; 
	targetLocation = tLocation;
	missionDuration = mDuration; } 
	 
	  void Operate(MarsStation* s) override;
}; 
#endif