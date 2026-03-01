Smart Home Automation System
Arduino | Embedded C/C++ | UART | Sensors | Servo Control

Overview:
Developed a smart home and smart garage automation system using an Arduino microcontroller.
The firmware integrates environmental sensing, secure Bluetooth access control, motion-based lighting, smoke detection, and automated parking management.

Focus: Embedded systems design, real-time logic, UART communication, and hardware/software integration.

Key Features:
Bluetooth PIN Authentication
4-digit password verification
Servo-controlled smart door lock
Lockout after 3 failed attempts

Environmental Monitoring:
DHT11 temperature & humidity sensing
Real-time LCD display (I2C)

Smart Lighting:
LDR-based night detection
PIR motion sensing
Manual override switch

Smoke Detection System:
Analog gas sensor monitoring
Non-blocking LED alert using millis()

Smart Garage Management:
Entry/exit PIR sensors
Parking availability tracking (max = 2)
Automatic servo-controlled gate
LED parking indicators

Technical Highlights:
Embedded C/C++ firmware design
UART communication via SoftwareSerial
I2C LCD integration
Servo motor control
Non-blocking timing using millis()
Real-time sensor fusion and decision logic
Hardware/software debugging and integration testing

Technologies & Components:
Arduino UNO
DHT11
PIR Sensors
LDR
Smoke Sensor (Analog)
HC-05 Bluetooth Module
16x2 I2C LCD
Servo Motors

Outcome
Successfully built and tested a fully functional prototype demonstrating:
Secure embedded access control
Real-time environmental monitoring
Event-driven automation
Integrated multi-sensor system design
