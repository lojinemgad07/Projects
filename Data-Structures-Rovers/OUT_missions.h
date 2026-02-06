#pragma once
#include "priQueue.h"
#include "Missions.h"
#include "MarsStation.h"

using namespace std;


class OUT_missions: public priQueue<Missions*>
{
public:
	Missions* AbortMission(int missionID) {
		if (!head)
			return nullptr;	
		priNode<Missions*>* temp = head;
		priNode<Missions*>* prev = nullptr;
		while (temp)
		{
			int p;
			Missions* abortedMission = temp->getItem(p);
			if (abortedMission->getMissionID() == missionID)
			{
				if (prev == nullptr) 
				{
					dequeue(abortedMission, p);
					return abortedMission;
				}
				else 
				{
					prev->setNext(temp->getNext());
					delete(temp);
					count--;
					return abortedMission;
				}
			}
			prev = temp;
			temp = temp->getNext();
		}
		return nullptr;
	}
	/*void print() const {
		priNode<Missions*>* current = head;
		while (current) {
			int p;
			Missions* mission = current->getItem(p);
			cout << mission->getMissionID() << ", Priority: " << p << endl;
			current = current->getNext();
		}
	}*/
};

