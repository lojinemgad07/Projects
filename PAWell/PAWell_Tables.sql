CREATE DATABASE PAWell;
GO

use PAWell
CREATE TABLE [User] (
    UserSSN          INT  PRIMARY KEY,
    Username        VARCHAR(50)  NOT NULL UNIQUE,
    [Password]      VARCHAR(255) NOT NULL,   
    First_Name      VARCHAR(50)  NOT NULL,
    Last_Name       VARCHAR(50)  NOT NULL,

    Email           VARCHAR(100) NOT NULL UNIQUE,
    Phone_Number    VARCHAR(20)  NULL,

    -- Address (composite attribute)
    Governorate     VARCHAR(50)  NULL,
    City            VARCHAR(50)  NULL,
    Street          VARCHAR(100) NULL,
    Building        VARCHAR(20)  NULL,
    Apartment       VARCHAR(20)  NULL,
    ZIP_Code        VARCHAR(10)  NULL
);



CREATE TABLE Customer (
    CustomerSSN     INT NOT NULL PRIMARY KEY,
    Card_Number     VARCHAR(30)  NOT NULL,
    Bank            VARCHAR(50)  NOT NULL,
    CONSTRAINT FK_Customer_User
        FOREIGN KEY (CustomerSSN) REFERENCES [User](UserSSN)
            ON DELETE CASCADE
);


CREATE TABLE Employee (
    EmployeeSSN      INT NOT NULL PRIMARY KEY,
    Salary          DECIMAL(10,2) NOT NULL,
    E_Start_Date      DATE          NOT NULL,
    Bank              VARCHAR(50)  NOT NULL,
    Account_Number    VARCHAR(50)  NOT NULL,
    ISVET              BIT          NOT NULL,

    CONSTRAINT FK_Employee_User
        FOREIGN KEY (EmployeeSSN) REFERENCES [User](UserSSN)
            ON DELETE CASCADE
);

CREATE TABLE VetDegree (
    VetSSN   INT NOT NULL,
    Degree  VARCHAR(100) NOT NULL,

    CONSTRAINT PK_VetDegree
        PRIMARY KEY (VetSSN, Degree),

    CONSTRAINT FK_VetDegree_Vet
        FOREIGN KEY (VetSSN) REFERENCES Employee(EmployeeSSN)
            ON DELETE CASCADE
);


CREATE TABLE VetSpecialization (
    VetSSN         INT NOT NULL,
    Specialization VARCHAR(100) NOT NULL,

    CONSTRAINT PK_VetSpecialization
        PRIMARY KEY (VetSSN, Specialization),

    CONSTRAINT FK_VetSpecialization_Vet
        FOREIGN KEY (VetSSN) REFERENCES Employee(EmployeeSSN)
            ON DELETE CASCADE
);


CREATE TABLE Species (
    Common_Name     VARCHAR(100)  PRIMARY KEY NOT NULL,
    Genus            VARCHAR(100) NULL,
    Species            VARCHAR(100) NULL,
    Class           VARCHAR(50)  NULL,      
    Diet            VARCHAR(20)  NULL
);


CREATE TABLE Breed (
    BreedName        VARCHAR(100)  NOT NULL,
    S_Common_Name    VARCHAR(100)  NOT NULL,
    Average_Weight  DECIMAL(6,2)  NULL,
    Life_Expectancy INT           NULL
   

    PRIMARY KEY (BreedName, S_Common_Name),

    CONSTRAINT FK_Breed_Species
        FOREIGN KEY (S_Common_Name) REFERENCES Species(Common_Name)
            ON DELETE CASCADE
);


CREATE TABLE Animal (
    A_Name        VARCHAR(100) NOT NULL,
    CustomerSSN     INT NOT NULL,  -- owner (OWNS)
    Breed_Name        VARCHAR(100)  NOT NULL,  -- BELONGS_TO (and via Part_of → Species)
    S_Common_Name    VARCHAR(100)  NOT NULL,
    Birth_Date      DATE  NULL,
   -- Age             AS (DATEDIFF(YEAR, Birth_Date, GETDATE())),
    Birth_Weight    DECIMAL(6,2) NOT NULL,
    Current_Weight  DECIMAL(6,2)  NOT NULL,
    Gender          VARCHAR(10) NOT NULL,      -- Male / Female / Other

    
    PRIMARY KEY (A_Name, CustomerSSN),

    CONSTRAINT FK_Animal_Customer
        FOREIGN KEY (CustomerSSN) REFERENCES Customer(CustomerSSN)
            ON DELETE CASCADE,

    CONSTRAINT FK_Animal_Breed
        FOREIGN KEY (Breed_Name,S_Common_Name) REFERENCES Breed(BreedName,S_Common_Name)
         ON DELETE CASCADE
);



CREATE TABLE Vaccine (
    Vaccine_Code    INT  NOT NULL PRIMARY KEY,
    Trade_Name      VARCHAR(100) NOT NULL,
    Disease_Pathogen VARCHAR(200) NOT NULL,
    Manufacturer    VARCHAR(100) NOT NULL,
    Stock_Number    INT           NOT NULL DEFAULT 0,
    Last_Expiry_Date DATE         NOT NULL
);

CREATE TABLE Immunization (
    A_Name        VARCHAR(100) NOT NULL,
    VaccineCode       INT NOT NULL,
    Immunization_Date DATE NOT NULL,
    CustomerSSN     INT NOT NULL, 

    CONSTRAINT PK_Immunization PRIMARY KEY (A_Name, VaccineCode),

    CONSTRAINT FK_Immunization_Animal
        FOREIGN KEY (A_Name,CustomerSSN) REFERENCES Animal(A_Name,CustomerSSN)
            ON DELETE CASCADE,

    CONSTRAINT FK_Immunization_Vaccine
        FOREIGN KEY (VaccineCode) REFERENCES Vaccine(Vaccine_Code)
            ON DELETE CASCADE
);

CREATE TABLE Requires (
    VaccineCode INT NOT NULL PRIMARY KEY,
    S_Common_Name VARCHAR(100) NOT NULL,
    -- Minimum Age (Composite relationship attribute)
    MinAge_Months INT NULL,
    MinAge_Years INT NULL,
    FOREIGN KEY (VaccineCode) REFERENCES Vaccine(Vaccine_Code)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (S_Common_Name) REFERENCES Species(Common_Name)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
GO

CREATE PROCEDURE GetPendingVaccines @A_Name VARCHAR(100), @C_SSN INT
AS
BEGIN
    SELECT Vaccine_Code, Trade_Name, Disease_Pathogen
        FROM Vaccine, Animal, Requires
        WHERE Vaccine_Code NOT IN
            (SELECT VaccineCode
            FROM Immunization
            WHERE A_Name = @A_Name AND CustomerSSN = @C_SSN)
        AND (MinAge_Years * 12 + MinAge_Months) < DATEDIFF(month, Birth_Date, (CAST (GETDATE() AS DATE)));
END
GO

CREATE TABLE [Availability](
    VetSSN       INT     NOT NULL,
    [Date]      DATE    NOT NULL,
    Start_Time  TIME(0) NOT NULL,
    End_Time    TIME(0) NOT NULL,

    PRIMARY KEY (VetSSN, [Date], Start_Time),

    CONSTRAINT FK_Availability_Vet
        FOREIGN KEY (VetSSN) REFERENCES Employee(EmployeeSSN)
            ON DELETE CASCADE,

    CONSTRAINT CK_Availability_Time
        CHECK (End_Time > Start_Time)
);


CREATE TABLE Appointment (
    AppointmentID       INT  IDENTITY(1,1) PRIMARY KEY,
    A_Name            VARCHAR(100) NOT NULL,
    CustomerSSN       INT NOT NULL,

    VetSSN       INT     NOT NULL,
    [Date]      DATE    NOT NULL,
    Start_Time  TIME(0) NOT NULL,
   

    Booking_DateTime    DATETIME2 NOT NULL, -- when customer booked
    Cost                DECIMAL(10,2) NOT NULL DEFAULT 0,
    Payment_Made        BIT NOT NULL DEFAULT 0,

    CONSTRAINT FK_Appointment_Animal
        FOREIGN KEY (A_Name,CustomerSSN) REFERENCES Animal(A_Name,CustomerSSN),

    CONSTRAINT FK_Appointment_Availability
        FOREIGN KEY (VetSSN,[Date],Start_Time) REFERENCES [Availability] (VetSSN,[Date],Start_Time),

    -- Ensure availability is booked by at most one appointment (1:1)
    --CONSTRAINT UQ_Appointment_Availability UNIQUE ()
);

CREATE TABLE AppointmentDiagnosis (
    AppointmentID   INT NOT NULL,
    Diagnosis       VARCHAR(100) NOT NULL,
   

    CONSTRAINT PK_AppointmentDiagnosis
        PRIMARY KEY (AppointmentID, Diagnosis),
       

    CONSTRAINT FK_AppointmentDiagnosis_Appointment
        FOREIGN KEY (AppointmentID) REFERENCES Appointment(AppointmentID)
        ON DELETE CASCADE
);

CREATE TABLE AppointmentPrescription (
    AppointmentID   INT NOT NULL,
    Prescription     NVARCHAR(500) NOT NULL,

    CONSTRAINT PK_AppointmentPrescription
        PRIMARY KEY (AppointmentID, Prescription),

    CONSTRAINT FK_AppointmentPrescription_Appointment
        FOREIGN KEY (AppointmentID)  REFERENCES Appointment(AppointmentID)
        ON DELETE CASCADE
);


CREATE TABLE AppointmentProcedure (
    AppointmentID   INT NOT NULL,
    [Procedure]      NVARCHAR(500) NOT NULL,

    CONSTRAINT PK_AppointmentProcedure
        PRIMARY KEY (AppointmentID, [Procedure]),

    CONSTRAINT FK_AppointmentProcedure_Appointment FOREIGN KEY (AppointmentID)
        REFERENCES Appointment(AppointmentID)
        ON DELETE CASCADE
);
GO
