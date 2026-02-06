#pragma once
#include "LinkedQueue.h"
#include "Missions.h"
#include "MarsStation.h"


using namespace std;

class RDY_NM : public LinkedQueue<Missions*>
{
public:
	Missions* AbortMission(int missionID) {
		if (!frontPtr)
			return nullptr;

		Node<Missions*>* temp = frontPtr;
		Node<Missions*>* prev = nullptr;
		while (temp)
		{
			Missions* abortedMission = temp->getItem();
			if (abortedMission->getMissionID() == missionID)
			{
				if (prev == nullptr)
				{
					dequeue(abortedMission);
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
		Node<Missions*>* current = frontPtr;
		cout << "Ready NM Missions Queue: ";
		while (current != nullptr) {
			Missions* mission = current->getItem();
			cout << "[ID: " << mission->getMissionID() << ", RDay: " << mission->getRDay() << "] -> ";
			current = current->getNext();
		}
		cout << "NULL" << endl;
	}*/
};

