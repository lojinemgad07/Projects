#include <iostream>
#include "ArrayStack.h"
#include "LinkedQueue.h"
#include "PriQueue.h"
#include "Missions.h"
#include "NewRequest.h"
#include "MarsStation.h"
#include "Rovers.h"

using namespace std;

int main()
{
    int mode;
    cout << "Select The Program Mode:" << endl;
    cout << "1. Interactive Mode" << endl;
    cout << "2. Silent Mode" << endl;
    cin >> mode;
    MarsStation ms(mode);

    ms.SimulatorPhase2();

    return 0;
}



