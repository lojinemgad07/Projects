#pragma once
#include <iostream>
#include <string>
#include "Missions.h"
#include "Rovers.h"
#include "LinkedQueue.h"
#include "priQueue.h"
#include "ArrayStack.h"
#include "RDY_NM.h"
#include "OUT_missions.h"
#include "Request.h"
#include "NewRequest.h"
#include "abortRequest.h"



using namespace std;

class MarsStation
{
private:
    LinkedQueue<Request*> REQ_LIST;
    LinkedQueue<Missions*> RDY_DM;  
    RDY_NM RDY_NM_List;            
    LinkedQueue<Missions*> RDY_PM;  

    OUT_missions OUT_mission_List;
    priQueue<Missions*> EXEC_missions;    
    priQueue<Missions*> BACK_missions;   
    LinkedQueue<Missions*> Aborted_missions; 
    ArrayStack<Missions*> DONE_missions;  

    LinkedQueue<Rovers*> Avail_PR;   
    LinkedQueue<Rovers*> Avail_DR;   
    LinkedQueue<Rovers*> Avail_NR;

    LinkedQueue<Rovers*> Checkup_PR;
    LinkedQueue<Rovers*> Checkup_DR;
    LinkedQueue<Rovers*> Checkup_NR;

    Missions* sortedDoneMissions[1000];

    int CurrentDay;
    bool SilentMode;
    int polarmissions = 0;
    int NormalMissions = 0;
    int Diggingmissions = 0;
    float AvgWdays;
    float AvgMDUR;
    float AvgTdays;
public:
    LinkedQueue<Request*>& getREQ_LIST();
    
    LinkedQueue<Missions*>& getRDY_DM();
    RDY_NM& getRDY_NM_List();
	
    LinkedQueue<Missions*>& getRDY_PM();

    OUT_missions& getOUT_mission_List();
    priQueue<Missions*>& getEXEC_missions();
    priQueue<Missions*>& getBACK_missions();
    LinkedQueue<Missions*>& getAborted_missions();
        
	
    ArrayStack<Missions*>& getDONE_missions();
	
    LinkedQueue<Rovers*>& getAvail_PR();
    LinkedQueue<Rovers*>& getAvail_DR();
    LinkedQueue<Rovers*>& getAvail_NR();
    LinkedQueue<Rovers*>& getCheckup_PR();
    LinkedQueue<Rovers*>& getCheckup_DR();
	
    LinkedQueue<Rovers*>& getCheckup_NR();


    


    MarsStation(int mode) {
		CurrentDay = 1;
        if (mode == 2)
            SilentMode = true;
        else
            SilentMode = false;

    }

    int getCurrentDay() const {
		return CurrentDay;
    }

    void LoadData(const string&fileName);      
    void RunSimulation();                
    void HandleDay();

    void AddMission(Missions* mission);
    void AssignMissionToRover(); //assign ready missions to available rovers

    void CompleteMission(Missions* mission);

    void AbortMission(int missionID);
    //Missions* MoveMissionsBackToDone();
    void MoveMissionsBackToDone();
    void MoveMissionsRDYToOut();
    void MoveMissionsOutToExec();
    void MoveMissionsExecToBack();

    void AportPM();
    void AddRover(Rovers* rover);
    void RoverToCheckup(Missions* mission);
    void ReturnRoverFromCheckup(); //return rovers in checkup to available
    //void MoveRoversBack(Missions* mission); //move to available or checkup lists
    

    Rovers* GetRandomAvailableRover();
    bool AllMissionsDone();

    void CollectStatistics();                  
    void PrintDayDetails() const;
    void GenerateOutputFile();
    void SimulatorPhase1();
    void SimulatorPhase2();
    void sortDoneMissions(ArrayStack<Missions*> done);
    void generateOutputFile();


};

