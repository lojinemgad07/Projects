#include "UI.h"
#include "MarsStation.h"
#include <iostream>
using namespace std;

void UI::PrintDay(MarsStation& ms) {

	int readyCount = ms.getRDY_DM().getCount() + ms.getRDY_PM().getCount() + ms.getRDY_NM_List().getCount();
	int availCount = ms.getAvail_DR().getCount() + ms.getAvail_NR().getCount() + ms.getAvail_PR().getCount();

	cout << "Current Day:" << ms.getCurrentDay() << endl;
	cout << "================ Requests List =================" << endl;
	cout << ms.getREQ_LIST().getCount() << " requests remaining" << endl;
	//ms.getREQ_LIST().print(); 
	cout << "================ Ready List(s) =================" << endl;
	cout << readyCount << " Misssions: " << endl;
	cout << "DMs: ";
	ms.getRDY_DM().print();
	cout << "PMs: ";
	ms.getRDY_PM().print();
	cout << "NMs: ";
	ms.getRDY_NM_List().print();

	cout << "================ Available Rovers List(s) ===============" << endl;
	
	cout << availCount << " Available Rovers: " << endl;
	cout << "DR: ";
	ms.getAvail_PR().print();
	cout << "PR: ";
	ms.getAvail_DR().print();
	cout << "NR: ";
	ms.getAvail_NR().print();

	cout << "================ OUT List(s) ===============" << endl
		<< "Missions in OUT: " << ms.getOUT_mission_List().getCount() << endl;
	ms.getOUT_mission_List().print();

	cout << "================ EXEC List(s) ===============" << endl;
	cout << "Missions in EXEC: " << ms.getEXEC_missions().getCount() << endl;
	ms.getEXEC_missions().print();

	cout << "================ BACK List(s) ===============" << endl;
	cout << "Missions in BACK: " << ms.getBACK_missions().getCount() << endl;
	ms.getBACK_missions().print();

	cout << "================ Aborted List(s) ===============" << endl;
	cout << "Missions in Aborted: " << ms.getAborted_missions().getCount() << endl;
	ms.getAborted_missions().print();

	cout << "================ Checkup List(s) ===============" << endl;
	cout << "PR Rovers in Checkup: " << ms.getCheckup_PR().getCount() << endl;
	ms.getCheckup_PR().print();

	cout << "================ DONE List(s) ===============" << endl;
	cout << "Missions in DONE: " << ms.getDONE_missions().getCount() << endl;
	ms.getDONE_missions().print();

	cout << "\n\n";





}
