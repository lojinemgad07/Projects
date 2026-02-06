#pragma once
#ifndef ABORTREQUEST_H
#define ABORTREQUEST_H


#include "Request.h"


class abortRequest :public Request
{
public:
	abortRequest(int RDay, int M_ID)
	{
		RequestDay = RDay;
		MissionID = M_ID;
	}
	void Operate(MarsStation* s) override;
	
};

#endif