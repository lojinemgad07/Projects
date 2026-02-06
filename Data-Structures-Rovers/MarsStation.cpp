#include "MarsStation.h"
#include "NewRequest.h"
#include "abortRequest.h"
#include <fstream>
#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>
#include "UI.h"

using namespace std;


//List Getters
LinkedQueue<Request*>& MarsStation::getREQ_LIST() {
    return REQ_LIST;
}

LinkedQueue<Missions*>& MarsStation:: getRDY_DM() {
    return RDY_DM;
}

RDY_NM& MarsStation ::getRDY_NM_List() {
    return RDY_NM_List;
}
LinkedQueue<Missions*>& MarsStation::getRDY_PM() {
    return RDY_PM;
}

OUT_missions& MarsStation::getOUT_mission_List() {
    return OUT_mission_List;
}

priQueue<Missions*>& MarsStation::getEXEC_missions() {
    return EXEC_missions;
}
priQueue<Missions*>& MarsStation::getBACK_missions() {
    return BACK_missions;
}
LinkedQueue<Missions*>& MarsStation::getAborted_missions() {
    return Aborted_missions;
}
ArrayStack<Missions*>& MarsStation::getDONE_missions() {
    return DONE_missions;
}
LinkedQueue<Rovers*>& MarsStation::getAvail_PR() {
    return Avail_PR;
}
LinkedQueue<Rovers*>& MarsStation::getAvail_DR() {
    return Avail_DR;
}
LinkedQueue<Rovers*>& MarsStation::getAvail_NR() {
    return Avail_NR;
}
LinkedQueue<Rovers*>& MarsStation::getCheckup_PR() {
    return Checkup_PR;
}
LinkedQueue<Rovers*>& MarsStation::getCheckup_DR() {
    return Checkup_DR;
}
LinkedQueue<Rovers*>& MarsStation::getCheckup_NR() {
    return Checkup_NR;
}







//void MarsStation:: HandleDay() {
//    cout << "Day " << CurrentDay << ":\n";
//    ReturnRoverFromCheckup();
//    MoveMissionsBackToDone();
//    MoveMissionsOutToExec();
//    MoveMissionsExecToBack();
//    MoveRoversBack();
//    AssignMissionToRover();
//    CurrentDay++;
//    cout << "End of Day " << CurrentDay - 1 << ".\n\n";
//}


void MarsStation::AddRover(Rovers* rover)
{
    switch (rover->getType())
    {
    case PR:
        Avail_PR.enqueue(rover);
        break;
    case DR:
        Avail_DR.enqueue(rover);
        break;
    case NR:
        Avail_NR.enqueue(rover);
        break;
    }
}


void MarsStation::AddMission(Missions* mission)
{
   switch (mission->getType())
    {
	case DM:
		RDY_DM.enqueue(mission);
		break;
    case PM: 
		RDY_PM.enqueue(mission);
		break;
    case NM:
		RDY_NM_List.enqueue(mission);
		break;
    }
}



void MarsStation::AssignMissionToRover() {
    Missions* mission = nullptr;
    Rovers* rover = nullptr;

    while (!RDY_PM.isEmpty()) {
        if (!Avail_PR.isEmpty())
            Avail_PR.dequeue(rover);
        else if (!Avail_NR.isEmpty())
            Avail_NR.dequeue(rover);
        else if (!Avail_DR.isEmpty())
            Avail_DR.dequeue(rover);
        else break;

        RDY_PM.dequeue(mission);
        mission->AssignRover(rover, CurrentDay);
        OUT_mission_List.enqueue(mission, -1 * mission->getTravelDay());
        mission->toOut();
    }

    while (!RDY_DM.isEmpty()) {
        if (!Avail_DR.isEmpty())
            Avail_DR.dequeue(rover);
        else
            break;
        RDY_DM.dequeue(mission);
        mission->AssignRover(rover, CurrentDay);
        OUT_mission_List.enqueue(mission, -1 * mission->getTravelDay());
        mission->toOut();
    }

    while (!RDY_NM_List.isEmpty()) {
        if (!Avail_NR.isEmpty())
            Avail_NR.dequeue(rover);
        else if (!Avail_PR.isEmpty())
            Avail_PR.dequeue(rover);
        else break;
        RDY_NM_List.dequeue(mission);
        mission->AssignRover(rover, CurrentDay);
        OUT_mission_List.enqueue(mission, -1 * mission->getTravelDay());
        mission->toOut();
    }

}



void MarsStation::LoadData(const string& fileName) {
    ifstream input(fileName);
    if (!input)
    {
        cout << "Error: Cannot open file " << fileName << endl;
        return;
    }

    cout << "Loading data from file: " << fileName << endl;

    int numDR, numPR, numNR;
    input >> numDR >> numPR >> numNR;

    int spDR, spPR, spNR;
    input >> spDR >> spPR >> spNR;

    int M, CD, CP, CN;
    input >> M >> CD >> CP >> CN;

    for (int i = 0; i < numDR; i++)
        AddRover(new Rovers(i + 1, DR, spDR, CD, M));

    for (int i = 0; i < numPR; i++)
        AddRover(new Rovers(numDR + i + 1, PR, spPR, CP, M));

    for (int i = 0; i < numNR; i++)
        AddRover(new Rovers(numDR + numPR + i + 1, NR, spNR, CN, M));

    int K;
    input >> K;

    for (int i = 0; i < K; i++)
    {
        char eventType;
        input >> eventType;

        if (eventType == 'R')
        {
            char missionType;
            int rD, ID, Target, Duration;
            input >> missionType >> rD >> ID >> Target >> Duration;

            MissionType type;
            switch (missionType)
            {
            case 'D': type = DM; break;
            case 'P': type = PM; break;
            case 'N': type = NM; break;
            default: continue;
            }

           /* Missions* mission = new Missions(type, rD, ID, Target, Duration);
            AddMission(mission);*/

            NewRequest* req = new  NewRequest(rD, ID, type, Target, Duration);
            //req->Operate(this);
            // Add request to REQUESTS LIST
            REQ_LIST.enqueue(req);

        }
        else if (eventType == 'X')
        {
            int ED, ID;
            input >> ED >> ID;
            Request* req = new  abortRequest(ED, ID);
			REQ_LIST.enqueue(req);
            //AbortMission(ID);
        }
    }

    input.close();
    cout << "File loaded successfully!" << endl;
}









void MarsStation::MoveMissionsOutToExec() {
    Missions* mission = nullptr;
    int pri; 

    while (!OUT_mission_List.isEmpty() && OUT_mission_List.peek(mission, pri)&& mission->getTravelDay() <= CurrentDay)
    {
            OUT_mission_List.dequeue(mission, pri);
            mission->toExec();

            EXEC_missions.enqueue(mission, -1 * mission->getExecDay());
        
    }
}

void MarsStation::MoveMissionsExecToBack() {
    Missions* mission = nullptr;
    int pri;
    while (!EXEC_missions.isEmpty() && EXEC_missions.peek(mission, pri)&& mission->getExecDay() <= CurrentDay) {
            EXEC_missions.dequeue(mission, pri);
            mission->toBack();

            BACK_missions.enqueue(mission, -1 * mission->getFDay());
        }
        
    }


void MarsStation::MoveMissionsBackToDone() {
    Missions* mission = nullptr;
    int pri;
    while (!BACK_missions.isEmpty() && BACK_missions.peek(mission, pri)&& mission->getFDay() <= CurrentDay)
    {
            BACK_missions.dequeue(mission, pri);
            mission->toDone();
            DONE_missions.push(mission);
            RoverToCheckup(mission);
        }
        
    }




void MarsStation::RoverToCheckup(Missions* mission) {
    
    if (!mission) return;

        Rovers* rover = mission->getRoverAssigned();

        if (!rover) return;

        bool checkupNeeded = rover->CheckupNeeded();
        if (checkupNeeded) {
            rover->StartCheckup(CurrentDay);
            switch (rover->getType()) {
            case PR:
                Checkup_PR.enqueue(rover);
                break;
            case DR:
                Checkup_DR.enqueue(rover);
                break;
            case NR:
                Checkup_NR.enqueue(rover);
                break;
            }
        }
        else {
            switch (rover->getType()) {
            case PR:
                Avail_PR.enqueue(rover);
                break;
            case DR:
                Avail_DR.enqueue(rover);
                break;
            case NR:
                Avail_NR.enqueue(rover);
                break;
            }
        }
    
}


void MarsStation::ReturnRoverFromCheckup() {
    Rovers* rover = nullptr;
    while (!Checkup_PR.isEmpty()) {
        Checkup_PR.peek(rover);
        if (rover->DoneCheckup(CurrentDay)) {
            Checkup_PR.dequeue(rover);
            Avail_PR.enqueue(rover);
        }
        else break;

    }
    while (!Checkup_DR.isEmpty()) {
        Checkup_DR.peek(rover);
        if (rover->DoneCheckup(CurrentDay)) {
            Checkup_DR.dequeue(rover);
            Avail_DR.enqueue(rover);
        }
        else break;
    }
    while (!Checkup_NR.isEmpty()) {
        Checkup_NR.peek(rover);
        if (rover->DoneCheckup(CurrentDay)) {
            Checkup_NR.dequeue(rover);
            Avail_NR.enqueue(rover);
        }
        else break;
    }

}


void MarsStation::AportPM() {
    Missions* mission;
    while (!RDY_PM.isEmpty()) {

        RDY_PM.peek(mission);
        int wd = CurrentDay - mission->getRDay();
        int DoubleDuration = 2 * mission->getDuration();
        if (wd > DoubleDuration) {
            RDY_PM.dequeue(mission);
            Aborted_missions.enqueue(mission);
        }
        else
            break;

    }
}



void MarsStation::AbortMission(int missionID) {
    Missions* abortedMission = nullptr;

    abortedMission = RDY_NM_List.AbortMission(missionID);
    if (abortedMission) {
        abortedMission->abort();
        Aborted_missions.enqueue(abortedMission);
        return;
    }

    abortedMission = OUT_mission_List.AbortMission(missionID);
    if (abortedMission) {

        Rovers* rover = abortedMission->getRoverAssigned();
        if (rover)
        {
            switch (rover->getType())
            {
            case PR: Avail_PR.enqueue(rover); break;
            case DR: Avail_DR.enqueue(rover); break;
            case NR: Avail_NR.enqueue(rover); break;
            }
        }
        abortedMission->abort();
        Aborted_missions.enqueue(abortedMission);
        return;
    }
}







bool MarsStation::AllMissionsDone() {

	return REQ_LIST.isEmpty() && RDY_DM.isEmpty() && RDY_PM.isEmpty() && RDY_NM_List.isEmpty() &&
		OUT_mission_List.isEmpty() && EXEC_missions.isEmpty() && BACK_missions.isEmpty();
}


void MarsStation::SimulatorPhase2() 
{
	CurrentDay = 1;
    UI ui;

    this->LoadData("input.txt");
    if (SilentMode) {
        cout << "Silent Mode" << endl;
        cout << "Simulation Starts..." << endl;
    }

    while (!AllMissionsDone()) 
    { 
    
       while (!REQ_LIST.isEmpty())
       {
            Request* req = nullptr;
            REQ_LIST.peek(req);
            if (req->getRequestDay() <= CurrentDay)
            {
                REQ_LIST.dequeue(req);
                req->Operate(this);
                delete req;
            }
            else break;
	   }

       AportPM();

       AssignMissionToRover();

       MoveMissionsOutToExec();

	   MoveMissionsExecToBack();

       MoveMissionsBackToDone();


	   ReturnRoverFromCheckup();

       if (!SilentMode) {
           ui.PrintDay(*this);
           
       }


       CurrentDay++;
    }

	generateOutputFile();
    if (SilentMode) {
        cout << "Simulation ends, Output file created" << endl;
    }
}

void MarsStation::PrintDayDetails() const
    {
        cout << "Current Day: " << CurrentDay << endl;

        cout << "------------------------------------------" << endl;
        cout << "Waiting Missions: "
            << "PM(" << RDY_PM.getCount() << ") "
           
            << "DM(" << RDY_DM.getCount() << ") "
            << "NM(" << RDY_NM_List.getCount() << ")" << endl;

        cout << "In-Execution Missions: " << EXEC_missions.getCount() << endl;
		EXEC_missions.print();
        cout << "Mission In Check-Up (Back): " << BACK_missions.getCount() << endl;
		BACK_missions.print();
        cout << "Done Missions: " << DONE_missions.getCount() << endl;
        DONE_missions.print();
        cout << "------------------------------------------" << endl << endl;
    }

void MarsStation:: sortDoneMissions(ArrayStack<Missions*> done) //in fescending order of fday
{
    Missions* mission;
    //int max=0;
    int count= done.getCount();
    for (int i = 0; i < count; i++)
    {
        done.pop(mission);
        sortedDoneMissions[i] = mission;
    }

    for (int i = 0; i < count-1; i++)
    {

        for (int j = 0; j < count-i-1; j++)
        {
            if (sortedDoneMissions[j]->getFDay() < sortedDoneMissions[j + 1]->getFDay())
            {
                Missions* temp = sortedDoneMissions[j + 1];
                sortedDoneMissions[j + 1] = sortedDoneMissions[j];
                sortedDoneMissions[j] = temp;

            }
        }
    }

}

void MarsStation:: generateOutputFile()
{
    Missions** array;
    sortDoneMissions(getDONE_missions());
    
    ofstream out("Output_file.txt");
    if (out.is_open())
    {
        out << "Fday\tID\tRday\tWdays\tMDUR\tTdays\n";
        for (int i = 0; i<DONE_missions.getCount(); i++)
        {
            Missions* m = sortedDoneMissions[i];
            out << m->getFDay() << "\t"
                << m->getMissionID() << "\t"
                << m->getRDay() << "\t"
                << m->getWDay() << "\t"
                << m->getDuration() << "\t"
                << m->getTDay() << "\n";
        }
        out << "------------------------------------\n";
        out << "------------------------------------\n";

        CollectStatistics();

        int percentage;
        percentage = (AvgWdays / AvgMDUR) * 100;
        out << "total number of days: " << CurrentDay<<endl;
        out << "Missions: " << DONE_missions.getCount() + Aborted_missions.getCount() << endl;
        out << "[N: " << NormalMissions << ", P: " << polarmissions << ", D: " << Diggingmissions << "]\t[" <<DONE_missions.getCount()<<" DONE, "<<Aborted_missions.getCount()<<" Aborted]\n";
        out << "Avg Wdays=" << AvgWdays << " Avg MDUR=" << AvgMDUR << " Avg Tdays=" << AvgTdays << endl;
        out << "% Avg_Wdays/ Avg_MDUR=" << percentage << "%, Auto-Aborted=" ;

        out.close();

        //float 
    }
    else
        return;

}

void MarsStation:: CollectStatistics()
{
    ArrayStack<Missions*> missions = DONE_missions;
    Missions* m;
    int sumWdays=0;
    int sumDUR=0;
    int sumTdays = 0;
    int percentagem = 0;

    for (int i = 0; i < DONE_missions.getCount();i++)
    {
        missions.pop(m);
        MissionType type=m->getType();
        int num = m->getWDay();
        int dur = m->getDuration();
        int tdays = m->getTDay();
        sumWdays += num;
        sumDUR += dur;
        sumTdays += tdays;

        switch (type)
        {
        case(DM):
            Diggingmissions++;
            break;
            
        case(PM):
            polarmissions++;
            break;

        case(NM):
            NormalMissions++;
            break;
        }
    }

    AvgWdays = sumWdays / DONE_missions.getCount();
    AvgMDUR= sumDUR/ DONE_missions.getCount();
    AvgTdays= sumTdays/ DONE_missions.getCount();
   

}


//
//Rovers* MarsStation::GetRandomAvailableRover() {
//
//    bool hasPR = !Avail_PR.isEmpty();
//    bool hasDR = !Avail_DR.isEmpty();
//    bool hasNR = !Avail_NR.isEmpty();
//
//    int count = (hasPR ? 1 : 0) + (hasDR ? 1 : 0) + (hasNR ? 1 : 0);
//
//    if (count == 0)
//        return nullptr;
//
//    int choice = rand() % count + 1;
//
//    Rovers* rover = nullptr;
//
//    if (hasPR && choice == 1)
//    {
//        Avail_PR.dequeue(rover);
//        return rover;
//    }
//}

//void MarsStation::ReturnRoverFromCheckup() {
//
//    int y = rand() % 100;
//
//    if (y >= 70) return;
//
//    Rovers* rover = nullptr;
//
//    if (!Checkup_DR.isEmpty()) {
//        Checkup_DR.dequeue(rover);
//        Avail_DR.enqueue(rover);
//        return;
//    }
//
//    if (!Checkup_PR.isEmpty()) {
//        Checkup_PR.dequeue(rover);
//        Avail_PR.enqueue(rover);
//        return;
//    }
//
//    if (!Checkup_NR.isEmpty()) {
//        Checkup_NR.dequeue(rover);
//        Avail_NR.enqueue(rover);
//        return;
//    }
//
//}




//void MarsStation::SimulatorPhase1() {
//    CurrentDay = 1;
//    UI ui;
//
//    // Load the input file
//    this->LoadData("C:/Users/khale/Documents/GitHub/Data-Structures/x64/Debug/input.txt"); //Add file path
//    while (!AllMissionsDone()) {
//
//
//        while (!REQ_LIST.isEmpty()) {
//            Request* req = nullptr;
//            REQ_LIST.peek(req);
//            if (req->getRequestDay() <= CurrentDay) {
//                REQ_LIST.dequeue(req);
//                req->Operate(this);
//                delete req;
//            }
//            else break;
//
//        }
//
//        
//        ReturnRoverFromCheckup();
//        
//
//		Missions* mission = MoveMissionsBackToDone();
//        if (mission) {
//            MoveRoversBack(mission);
//        };
//
//            
//
//        for (int i = 0; i < 2; i++) {
//            MoveMissionsExecToBack();
//        }
//
//
//        MoveMissionsOutToExec();
//
//        MoveMissionsRDYToOut();
//
//
//        //PrintDayDetails();
//
//		ui.PrintDay(*this);
//
//        CurrentDay++;
//    }
//}


//void MarsStation::MoveMissionsRDYToOut() {
//            if (!RDY_PM.isEmpty())
//        {
//            Missions* mission = nullptr;
//            RDY_PM.dequeue(mission);
//
//            Rovers* rover = GetRandomAvailableRover();
//            if (rover)
//             {
//                mission->AssignRover(rover, CurrentDay);
//                OUT_mission_List.enqueue(mission, 1);
//             }
//            else
//                RDY_PM.enqueue(mission);
//        }
//
//        if (!RDY_DM.isEmpty())
//        {
//            Missions* mission = nullptr;
//            RDY_DM.dequeue(mission);
//
//            Rovers* rover = GetRandomAvailableRover();
//            if (rover)
//            {
//                mission->AssignRover(rover, CurrentDay);
//                OUT_mission_List.enqueue(mission, 1);
//            }
//            else
//                RDY_DM.enqueue(mission);
//        }
//
//        if (!RDY_NM_List.isEmpty())
//        {
//            Missions* mission = nullptr;
//            RDY_NM_List.dequeue(mission);
//
//            Rovers* rover = GetRandomAvailableRover();
//            if (rover)
//            {
//                mission->AssignRover(rover, CurrentDay);
//                OUT_mission_List.enqueue(mission, 1);
//            }
//            else
//                RDY_NM_List.enqueue(mission);
//        }
//}

//Rovers* MarsStation::GetRandomAvailableRover(){
//
//        bool hasPR = !Avail_PR.isEmpty();
//        bool hasDR = !Avail_DR.isEmpty();
//        bool hasNR = !Avail_NR.isEmpty();
//
//        int count = (hasPR ? 1 : 0) + (hasDR ? 1 : 0) + (hasNR ? 1 : 0);
//
//        if (count == 0)
//            return nullptr; 
//
//        int choice = rand() % count + 1;
//
//        Rovers* rover = nullptr;
//
//        if (hasPR && choice == 1)
//        {
//            Avail_PR.dequeue(rover);
//            return rover;
//        }
//
//        if (hasDR && ((hasPR ? choice == 2 : choice == 1)))
//        {
//            Avail_DR.dequeue(rover);
//            return rover;
//        }
//
//        Avail_NR.dequeue(rover);
//        return rover;
//    }

//void MarsStation::ReturnRoverFromCheckup() {
//    
//        int y = rand() % 100;
//
//        if (y >= 70) return;
//
//        Rovers* rover = nullptr;
//
//        if (!Checkup_DR.isEmpty()) {
//            Checkup_DR.dequeue(rover);
//            Avail_DR.enqueue(rover);
//            return;
//        }
//
//        if (!Checkup_PR.isEmpty()) {
//            Checkup_PR.dequeue(rover);
//            Avail_PR.enqueue(rover);
//            return;
//        }
//
//        if (!Checkup_NR.isEmpty()) {
//            Checkup_NR.dequeue(rover);
//            Avail_NR.enqueue(rover);
//            return;
//        }
//
//    }

//Missions* MarsStation::MoveMissionsBackToDone() {
//    if (!BACK_missions.isEmpty()) {
//        Missions* mission = nullptr;
//        int pri;
//        BACK_missions.dequeue(mission, pri);
//        DONE_missions.push(mission);
//        return mission;
//    }
//	return nullptr;
//}

//void MarsStation::MoveMissionsOutToExec() {
//    if (!OUT_mission_List.isEmpty()) {
//        Missions* mission = nullptr;
//        int pri;
//        OUT_mission_List.dequeue(mission, pri);
//        EXEC_missions.enqueue(mission, pri);
//
//    }
//}

//void MarsStation::MoveMissionsExecToBack() {
//    if (!EXEC_missions.isEmpty()) {
//
//        Missions* mission = nullptr;
//        int pri;
//        EXEC_missions.dequeue(mission, pri);
//        BACK_missions.enqueue(mission, pri);
//
//    }
//}

//void MarsStation::MoveRoversBack(Missions* mission) {
//    int X = rand() % 100 + 1;
//    Rovers* rover = mission->getRoverAssigned();
//    if (X < 20) {
//        //DONE_missions.pop(mission);
//
//        switch (rover->getType()) {
//        case PR:
//            Checkup_PR.enqueue(rover);
//            break;
//        case DR:
//            Checkup_DR.enqueue(rover);
//            break;
//        case NR:
//            Checkup_NR.enqueue(rover);
//            break;
//        }
//
//
//    }
//
//    else {
//        switch (rover->getType()) {
//        case PR:
//            Avail_PR.enqueue(rover);
//            break;
//        case DR:
//            Avail_DR.enqueue(rover);
//            break;
//        case NR:
//            Avail_NR.enqueue(rover);
//            break;
//        }
//
//    }
//
//
//}
