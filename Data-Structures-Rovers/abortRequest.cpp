#include "abortRequest.h"

#include "MarsStation.h"
void abortRequest::Operate(MarsStation* s)
{
	s->AbortMission(MissionID);
}