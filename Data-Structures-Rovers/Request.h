#pragma once

#ifndef REQUEST_H
#define REQUEST_H

class MarsStation;

class Request
{protected:
	int RequestDay;
	int MissionID;
public:
	virtual void Operate(MarsStation* s) = 0;
	int getRequestDay() const {
		return RequestDay;
	}
};


#endif 