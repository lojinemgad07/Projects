using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataBaseProjectPawell
{
    class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        public DataTable CustomerData(int ssn)
        {
             string query = @"
             SELECT 
             U.UserSSN,
             U.First_Name,
             U.Last_Name,
             U.Email,
             U.Phone_Number,
             U.Governorate,
             U.City,
             U.Street,
             U.Building,
             U.Apartment,
             U.ZIP_Code,
             C.Card_Number,
             C.Bank
             FROM [User] U
             JOIN Customer C ON C.CustomerSSN = U.UserSSN
             WHERE U.UserSSN = " + ssn;

             DataTable dt = dbMan.ExecuteReader(query);
             return dt;
        }

        public int UpdateCustomerData(int ssn, string firstname, string lastname, string email, string phonenumber, string cardnumber, string bank, string governorate, string city, string street, string building, string apartment, string zipcode)
        { 
            string query = @"
            UPDATE [User]
            SET 
                First_Name = '" + firstname + @"',
                Last_Name = '" + lastname + @"',
                Email = '" + email + @"',
                Phone_Number = '" + phonenumber + @"',
                Governorate = '" + governorate + @"',
                City = '" + city + @"',
                Street = '" + street + @"',
                Building = '" + building + @"',
                Apartment = '" + apartment + @"',
                ZIP_Code = '" + zipcode + @"'
                WHERE UserSSN ="+ssn+@"; 
            UPDATE Customer
            SET 
                Card_Number = '" + cardnumber + @"',
                Bank = '" + bank + @"'
            WHERE CustomerSSN = "+ssn+";";
            int rowCount = dbMan.ExecuteNonQuery(query);
            return rowCount;

        }
        public DataTable RetrieveBookings()
        {
            string query = @"
                     SELECT 
                     A.VetSSN,
                     U.First_Name,
                     U.Last_Name,
                     VS.Specialization,
                     A.[Date],
                     A.Start_Time,
                     A.End_Time
                     FROM Availability A
                     JOIN Employee E ON A.VetSSN = E.EmployeeSSN
                     JOIN [User] U ON U.UserSSN = E.EmployeeSSN
                     LEFT JOIN VetSpecialization VS ON VS.VetSSN = E.EmployeeSSN
                     WHERE E.ISVET = 1
                     ORDER BY U.First_Name, A.[Date], A.Start_Time";

            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
        }
        public DataTable RetrieveAnimals(int ssn)
        { 
            string query=@"SELECT A_Name
                           FROM Animal
                           WHERE CustomerSSN="+ssn+";";

            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
        }
        public DataTable RetrieveCardnumber(int ssn)
        {
            string query = @"
                     SELECT 
                     Card_Number
                     FROM Customer
                     WHERE CustomerSSN = " + ssn;
            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
        }
        public int BookAppointment(string animalname, int customerssn, int vetsnn, DateTime date, TimeSpan starttime, DateTime BookingDateTime)
        {
            string query = @"
            INSERT INTO Appointment (A_Name, CustomerSSN, VetSSN, [Date], Start_Time, Booking_DateTime)
            VALUES ('"+animalname+"'," + customerssn + ", " + vetsnn + ", '" + date.ToString("yyyy-MM-dd") + "', '" + starttime.ToString(@"hh\:mm") + "', '" + BookingDateTime.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            int rowCount = dbMan.ExecuteNonQuery(query);
            return rowCount;

        }
        public int CheckAvailability(int vetsnn, DateTime date, TimeSpan starttime)
        {
            string query = @"
            SELECT COUNT(*) 
            FROM Appointment
            WHERE VetSSN = " + vetsnn + " AND [Date] = '" + date.ToString("yyyy-MM-dd") + "' AND Start_Time = '" + starttime.ToString(@"hh\:mm\:ss") + "';";
            object result = dbMan.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }
        public int InsertSpecies(string commonName, string genus, string species, string Class, string diet)
        {
            string query = @"
            INSERT INTO Species (Common_Name,Genus, Species, Class, Diet)
            VALUES ('"+commonName+"','"+genus+"','"+species+"','"+Class+"','"+diet+"');";
            int rowCount = dbMan.ExecuteNonQuery(query);
            return rowCount;
        }
        public int InsertBreed(string breedName, string speciesName, double avgWeight, int lifeExpectancy)
        {
            string query = @"
            INSERT INTO Breed
            (BreedName, S_Common_Name, Average_Weight, Life_Expectancy)
            VALUES ('" + breedName + "','"
                       + speciesName + "',' "
                       + avgWeight + "','"
                       + lifeExpectancy + "');";

            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected;
        }
        //JANA'S CODE HERE
        public DataTable GetUserByUsername(string username)
        {
            string query =
                "SELECT [Password] FROM [User] " +
                "WHERE Username = '" + username + "';";
            return dbMan.ExecuteReader(query);
        }


        public DataTable GetVetByUsername(string username)
        {
            string query =
                "SELECT U.[Password] " +
                "FROM [User] U, Employee E " +
                "WHERE U.Username = '" + username + "' " +
                "AND U.UserSSN = E.EmployeeSSN " +
                "AND E.ISVET = 1;";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAdminByUsername(string username)
        {
            string query =
                "SELECT U.[Password] " +
                "FROM [User] U, Employee E " +
                "WHERE U.Username = '" + username + "' " +
                "AND U.UserSSN = E.EmployeeSSN " +
                "AND E.ISVET = 0;";

            return dbMan.ExecuteReader(query);
        }

        public int GetUserSSNByUsername(string username)
        {
            string q =
                "SELECT UserSSN FROM [User] " +
                "WHERE Username = '" + username + "';";

            object result = dbMan.ExecuteScalar(q);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        public DataTable GetVetAvailability(int vetSSN)
        {
            string q =
                "SELECT [Date], Start_Time, End_Time " +
                "FROM [Availability] " +
                "WHERE VetSSN = " + vetSSN + ";";

            return dbMan.ExecuteReader(q);
        }

        //public DataTable GetVetAvailabilityByUsername(string username)
        //{
        //    int ssn = GetUserSSNByUsername(username);
        //    if (ssn == -1) return null;

        //    return GetVetAvailability(ssn);
        //}


        //public DataTable GetVetAvailabilityByUsername(string username)
        //{
        //    string q =
        //        "SELECT A.[Date], A.Start_Time, A.End_Time " +
        //        "FROM [Availability] A, [User] U, Employee E " +
        //        "WHERE U.Username = '" + username + "' " +
        //        "AND U.UserSSN = E.EmployeeSSN " +
        //        "AND E.EmployeeSSN = A.VetSSN " +
        //        "ORDER BY A.[Date], A.Start_Time;";

        //    return dbMan.ExecuteReader(q);
        //}
        public DataTable GetVetAvailabilityByUsername(string username)
        {
            username = username.Trim();

            string q =
                "SELECT A.[Date], A.Start_Time, A.End_Time " +
                "FROM [User] U, Employee E, [Availability] A " +
                "WHERE U.Username = '" + username + "' " +
                "AND U.UserSSN = E.EmployeeSSN " +
                "AND E.EmployeeSSN = A.VetSSN " +
                "ORDER BY A.[Date], A.Start_Time;";

            return dbMan.ExecuteReader(q);
        }


        public int AddAvailabilitySlot(int vetSSN, DateTime date, TimeSpan start, TimeSpan end)
        {
            string q =
                "INSERT INTO [Availability] (VetSSN, [Date], Start_Time, End_Time) VALUES (" +
                vetSSN + ", '" + date.ToString("yyyy-MM-dd") + "', '" +
                start.ToString(@"hh\:mm") + "', '" +
                end.ToString(@"hh\:mm") + "');";

            return dbMan.ExecuteNonQuery(q);
        }


        public int DeleteAvailability(int vetSSN, DateTime date, TimeSpan startTime)
        {
            string q =
                "DELETE FROM [Availability] " +
                "WHERE VetSSN = " + vetSSN +
                " AND [Date] = '" + date.ToString("yyyy-MM-dd") + "'" +
                " AND Start_Time = '" + startTime.ToString(@"hh\:mm\:ss") + "';";

            return dbMan.ExecuteNonQuery(q);
        }

        public int UpdateAvailability(int vetSSN, DateTime oldDate, TimeSpan oldStart, DateTime newDate, TimeSpan newStart,
                                    TimeSpan newEnd)
        {
            string q =
                "UPDATE [Availability] SET " +
                "[Date] = '" + newDate.ToString("yyyy-MM-dd") + "', " +
                "Start_Time = '" + newStart.ToString(@"hh\:mm\:ss") + "', " +
                "End_Time = '" + newEnd.ToString(@"hh\:mm\:ss") + "' " +
                "WHERE VetSSN = " + vetSSN +
                " AND [Date] = '" + oldDate.ToString("yyyy-MM-dd") + "'" +
                " AND Start_Time = '" + oldStart.ToString(@"hh\:mm\:ss") + "';";

            return dbMan.ExecuteNonQuery(q);
        }



        public DataTable GetVetBookedAppointments_ByUsername(string username)
        {
            int vetSSN = GetUserSSNByUsername(username);
            if (vetSSN == -1) return null;

            string q =
                "SELECT " +
                "A.[Date] AS ApptDate, " +
                "A.Start_Time AS StartTime, " +
                "A.A_Name AS AnimalName, " +
                "U.First_Name + ' ' + U.Last_Name AS OwnerName " +
                "FROM Appointment A, [User] U " +
                "WHERE A.CustomerSSN = U.UserSSN " +
                "AND A.VetSSN = " + vetSSN + ";";

            return dbMan.ExecuteReader(q);
        }


        public int AddAdmin(
        int ssn, string username, string password,
         string fname, string lname, string email, string phone,
          string gov, string city, string street,
         string building, string apartment, string zip)
        {
            string q1 =
                "INSERT INTO [User] VALUES (" +
                ssn + ", '" + username + "', '" + password + "', '" +
                fname + "', '" + lname + "', '" + email + "', '" + phone + "', '" +
                gov + "', '" + city + "', '" + street + "', '" +
                building + "', '" + apartment + "', '" + zip + "')";

            int r1 = dbMan.ExecuteNonQuery(q1);
            if (r1 == 0) return 0;

            string q2 =
                "INSERT INTO Employee VALUES (" +
                ssn + ", 0, GETDATE(), 'N/A', 'N/A', 0)"; // ISVET = 0

            return dbMan.ExecuteNonQuery(q2);
        }



        public DataTable GetVetProfileByUsername(string username)
        {
            string q =
                "SELECT U.Username, U.First_Name, U.Last_Name, U.Email, U.Phone_Number, " +
                "       U.Governorate, U.City, U.Street, U.Building, U.Apartment, U.ZIP_Code, " +
                "       E.E_Start_Date " +   // optional
                "FROM [User] U INNER JOIN Employee E ON U.UserSSN = E.EmployeeSSN " +
                "WHERE U.Username = '" + username + "' AND E.ISVET = 1;";

            return dbMan.ExecuteReader(q);
        }

        public DataTable GetVetDegrees(int vetSSN)
        {
            string q = "SELECT Degree FROM VetDegree WHERE VetSSN = " + vetSSN + ";";
            return dbMan.ExecuteReader(q);
        }

        public DataTable GetVetSpecializations(int vetSSN)
        {
            string q = "SELECT Specialization FROM VetSpecialization WHERE VetSSN = " + vetSSN + ";";
            return dbMan.ExecuteReader(q);
        }


        public int UpdateVetProfileByUsername(
      string username,
      string firstName, string lastName,
      string governorate, string city, string street,
      string building, string apartment, string zip)
        {
            string q =
                "UPDATE [User] SET " +
                "First_Name = '" + firstName + "', " +
                "Last_Name = '" + lastName + "', " +
                "Governorate = '" + governorate + "', " +
                "City = '" + city + "', " +
                "Street = '" + street + "', " +
                "Building = '" + building + "', " +
                "Apartment = '" + apartment + "', " +
                "ZIP_Code = '" + zip + "' " +
                "WHERE Username = '" + username.Trim() + "';";

            return dbMan.ExecuteNonQuery(q);
        }



        public string GetVetFullNameByUsername(string username)
        {
            username = username.Trim();

            string q =
                "SELECT U.First_Name + ' ' + U.Last_Name " +
                "FROM [User] U INNER JOIN Employee E ON U.UserSSN = E.EmployeeSSN " +
                "WHERE U.Username = '" + username + "' AND E.ISVET = 1;";

            object result = dbMan.ExecuteScalar(q);

            if (result == null || result == DBNull.Value)
                return "Doctor";   // fallback

            return result.ToString();
        }
        //END JANA'S CODE HERE
        //LUJI'S CODE HERE
        public string GetUserName(int ssn)
        {
            string query = "SELECT First_Name, Last_Name FROM [User] WHERE UserSSN = " + ssn + ";";

            DataTable dt = dbMan.ExecuteReader(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                string fName = dt.Rows[0]["First_Name"].ToString();
                string lName = dt.Rows[0]["Last_Name"].ToString();
                return fName + " " + lName;
            }

            return "Admin";
        }
        public int GetUserSSN(string username, string password)
        {
            string query = "SELECT UserSSN FROM [User] WHERE Username = '" + username + "' AND [Password] = '" + password + "';";

            object result = dbMan.ExecuteScalar(query);

            if (result == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(result);
            }
        }
        public DataTable GetAdminProfile(int ssn)
        {
            string query = "SELECT * " +
                   "FROM [User] U, Employee E " +
                   "WHERE U.UserSSN = E.EmployeeSSN " +
                   "AND U.UserSSN = " + ssn;
            return dbMan.ExecuteReader(query);
        }
        public int UpdateAdminProfile(int ssn, string fName, string lName, string password, string phone,
                                 string gov, string city, string street, string build, string apt, string zip)
        {
            string query = "UPDATE [User] SET " +
                           "First_Name = '" + fName + "', " +
                           "Last_Name = '" + lName + "', " +
                           "Password = '" + password + "', " +
                           "Phone_Number = '" + phone + "', " +
                           "Governorate = '" + gov + "', " +
                           "City = '" + city + "', " +
                           "Street = '" + street + "', " +
                           "Building = '" + build + "', " +
                           "Apartment = '" + apt + "', " +
                           "ZIP_Code = '" + zip + "' " +
                           "WHERE UserSSN = " + ssn;

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetAllCustomers()
        {
            return dbMan.ExecuteReader("SELECT CustomerSSN, (First_Name + ' ' + Last_Name) AS FullName FROM [User] U, Customer C WHERE U.UserSSN = C.CustomerSSN");
        }
        public DataTable GetAllSpecies()
        {
            return dbMan.ExecuteReader("SELECT Common_Name FROM Species");
        }
        public DataTable GetBreedsBySpecies(string speciesName)
        {
            return dbMan.ExecuteReader("SELECT BreedName FROM Breed WHERE S_Common_Name = '" + speciesName + "'");
        }
        public int AddAnimal(string aName, int ownerSSN, string breed, string species,
                         DateTime birthDate, decimal bWeight, decimal cWeight, string gender)
        {
            string dateStr = birthDate.ToString("yyyy-MM-dd");

            string query =
                "INSERT INTO Animal (A_Name, CustomerSSN, Breed_Name, S_Common_Name, Birth_Date, Birth_Weight, Current_Weight, Gender) " +
                "VALUES (" +
                "'" + aName + "', " +
                ownerSSN + ", " +
                "'" + breed + "', " +
                "'" + species + "', " +
                "'" + dateStr + "', " +
                bWeight + ", " +
                cWeight + ", " +
                "'" + gender + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public int AddVet(int ssn, string username, string password, string fName, string lName, string email, string phone,
                  string gov, string city, string street, string build, string apt, string zip,
                  decimal salary, DateTime startDate, string bank, string accNum,
                  string degree, string spec)
        {
            string dateStr = startDate.ToString("yyyy-MM-dd");

            string query =
                "INSERT INTO [User] (UserSSN, Username, Password, First_Name, Last_Name, Email, Phone_Number, Governorate, City, Street, Building, Apartment, ZIP_Code) " +
                "VALUES (" +
                ssn + ", '" + username + "', '" + password + "', '" + fName + "', '" + lName + "', '" +
                email + "', '" + phone + "', '" + gov + "', '" + city + "', '" + street + "', '" +
                build + "', '" + apt + "', '" + zip + "'); " +

                "INSERT INTO Employee (EmployeeSSN, Salary, E_Start_Date, Bank, Account_Number, ISVET) " +
                "VALUES (" +
                ssn + ", " + salary + ", '" + dateStr + "', '" + bank + "', '" + accNum + "', 1); " +

                "INSERT INTO VetDegree (VetSSN, Degree) " +
                "VALUES (" +
                ssn + ", '" + degree + "');" +

                "INSERT INTO VetSpecialization (VetSSN, Specialization) " +
                "VALUES (" +
                ssn + ", '" + spec + "');";


            return dbMan.ExecuteNonQuery(query);
        }

        public int AddCustomer(int ssn, string username, string password, string fName, string lName, string email, string phone,
                           string gov, string city, string street, string build, string apt, string zip,
                           string cardNum, string bank)
        {
            string query =
                "INSERT INTO [User] (UserSSN, Username, Password, First_Name, Last_Name, Email, Phone_Number, Governorate, City, Street, Building, Apartment, ZIP_Code) " +
                "VALUES (" +
                ssn + ", '" + username + "', '" + password + "', '" + fName + "', '" + lName + "', '" +
                email + "', '" + phone + "', '" + gov + "', '" + city + "', '" + street + "', '" +
                build + "', '" + apt + "', '" + zip + "'); " +

                "INSERT INTO Customer (CustomerSSN, Card_Number, Bank) " +
                "VALUES (" +
                ssn + ", '" + cardNum + "', '" + bank + "');";

            return dbMan.ExecuteNonQuery(query);
        }

        public int AddAdmin(int ssn, string username, string password, string fName, string lName, string email, string phone,
          string gov, string city, string street, string build, string apt, string zip,
          decimal salary, DateTime startDate, string bank, string accNum)
        {
            string dateStr = startDate.ToString("yyyy-MM-dd");

            string query =
                "INSERT INTO [User] (UserSSN, Username, [Password], First_Name, Last_Name, Email, Phone_Number, Governorate, City, Street, Building, Apartment, ZIP_Code) " +
                "VALUES (" +
                ssn + ", '" + username + "', '" + password + "', '" + fName + "', '" + lName + "', '" +
                email + "', '" + phone + "', '" + gov + "', '" + city + "', '" + street + "', '" +
                build + "', '" + apt + "', '" + zip + "'); " +

                "INSERT INTO Employee (EmployeeSSN, Salary, E_Start_Date, Bank, Account_Number, ISVET) " +
                "VALUES (" +
                ssn + ", " + salary + ", '" + dateStr + "', '" + bank + "', '" + accNum + "', 0);";

            return dbMan.ExecuteNonQuery(query);
        }
        //salma's code here 
        public DataTable GetAnimalBirthDate(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Birth_Date FROM Animal WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + "'";
            return dbMan.ExecuteReader(Query);
        }
        public string GetAnimalGender(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Gender FROM Animal WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + ";";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetCurrentWt(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Current_Weight FROM Animal WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + ";";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetBirthWt(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Birth_Weight FROM Animal WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + ";";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetSpecies(string CustomerID, string AnimalName)
        {
            string Query = "SELECT S_Common_Name FROM Animal WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + ";";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetDiet(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Diet FROM Animal, Species WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + " AND S_Common_Name = Common_Name;";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetBreed(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Breed_Name FROM Animal WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + ";";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetAvgBreedWt(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Average_Weight FROM Animal, Breed WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + " AND S_Common_Name = Common_Name AND Breed_Name = BreedName;";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetLifeExpectancy(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Life_Expectancy FROM Animal, Breed WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + " AND S_Common_Name = Common_Name AND Breed_Name = BreedName;";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public DataTable GetDiagnoses(string CustomerID, string AnimalName)
        {
            //string Query = "SELECT First_Name, Last_Name, AppointmentID, [Date], Diagnosis FROM [User], Appointment, AppointmentDiagnosis WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + " AND VetSSN = UserSSN AND AppointmentDiagnosis.AppointmentID = Appointment.AppointmentID;";
            string Query = "SELECT Diagnosis FROM Appointment, AppointmentDiagnosis WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + " AppointmentDiagnosis.AppointmentID = Appointment.AppointmentID;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetPrescriptions(string CustomerID, string AnimalName)
        {
            string Query = "SELECT First_Name, Last_Name, AppointmentID, [Date], Prescription FROM [User], Appointment, AppointmentDiagnosis WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + " AND VetSSN = UserSSN AND AppointmentPrescription.AppointmentID = Appointment.AppointmentID;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetProcedures(string CustomerID, string AnimalName)
        {
            string Query = "SELECT First_Name, Last_Name, AppointmentID, [Date], Procedure FROM [User], Appointment, AppointmentProcedure WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + " AND VetSSN = UserSSN AND AppointmentProceedure.AppointmentID = Appointment.AppointmentID;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetCompletedVaccines(string CustomerID, string AnimalName)
        {
            string Query = "SELECT Vaccine_Code, Trade_Name, Disease_Pathogen, Immunization_Date FROM Immunization, Vaccine WHERE A_Name = '" + AnimalName + "' AND CustomerSSN = " + CustomerID + "'";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetPendingVaccines(string CustomerID, string AnimalName)
        {
            string Query = "EXEC GetPendingVaccines @A_Name = '" + AnimalName + "' AND @C_SSN = " + CustomerID + ";";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetAllVaccineStock()
        {
            string Query = "SELECT * FROM Vaccine;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetAllVaccineRequirements()
        {
            string Query = "SELECT * FROM Requires;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetAllVaccineNames()
        {
            string Query = "SELECT Trade_Name FROM Vaccine;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetAllSpeciesCommonNames()
        {
            string Query = "SELECT Common_Name FROM Species;";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetVaccinesWithoutRequirements()
        {
            string Query = "SELECT Trade_Name FROM Vaccine WHERE Vaccine_Code NOT IN (SELECT VaccineCode FROM Requires);";
            return dbMan.ExecuteReader(Query);
        }
        public int AddVaccine(int Code, string Name, string Manufacturer, string Disease, int stock, string ExpiryDate)
        {
            string Query = "SELECT * FROM Vaccine WHERE Vaccine_Code = " + Code.ToString() + ";";
            if (dbMan.ExecuteReader(Query) != null)
                return 1;
            Query = "SELECT * FROM Vaccine WHERE Trade_Name = '" + Name + "';";
            if (dbMan.ExecuteReader(Query) != null)
                return 2;
            Query = "INSERT INTO Vaccine(Vaccine_Code, Trade_Name, Disease_Pathogen, Manufacturer, Stock_Number, Last_Expiry_Date) VALUES(" + Code.ToString() + ", '" + Name + "', '" + Disease + "', '" + Manufacturer + "', '" + ExpiryDate + "');";
            dbMan.ExecuteReader(Query);
            return 0;
        }
        public void AddRequirement(string Name, string Species, string Years, string Months)
        {
            string Query = "SELECT Vaccine_Code FROM Vaccine WHERE Trade_Name = '" + Name + ";";
            string Code = dbMan.ExecuteReader(Query).ToString();
            Query = "INSERT INTO Requires(VaccineCode, S_Common_Name, MinAge_Months, MinAge_Years) VALUES(" + Code + ", '" + Species + "', " + Months + ", " + Years + ");";
            dbMan.ExecuteReader(Query);
        }
        public void UpdateVaccineStock(string Name, string Stock, string ExpiryDate)
        {
            string Query = "UPDATE Vaccine SET Stock_Number = " + Stock + ", Last_Expiry_Date = '" + ExpiryDate + "' WHERE Trade_Name = " + Name + ";";
            dbMan.ExecuteReader(Query);
        }

        public DataTable GetAllUpcomingAvailabilities(bool ShowBooked)
        {
            string Query = "SELECT VetSSN, First_Name, Last_Name, [Date], Start_Time, End_Time FROM [Availability], [User] WHERE VetSSN = UserSSN AND [Date] > (SELECT CURRENT_DATE)";
            if (ShowBooked)
                Query = Query + ";";
            else
                Query = Query + "AND NOT EXISTS (SELECT * FROM Appointment WHERE Appointment.VetSSN = Availability.VetSSN AND Appointment.[Date] = Availability.[Date] AND Appointment.Start_Time = Availability.Start_Time);";
            return dbMan.ExecuteReader(Query);
        }
        public DataTable GetAllPastAppointments(bool ShowPaid)
        {
            string Query = "SELECT Booking_DateTime, Cost, Payment_Made, AppointmentID, [Date], Start_Time, End_Time, VetSSN, V.First_Name, V.Last_Name, CustomerSSN, C.First_Name, C.Last_Name, A_Name FROM [Availability], [User] V C, Appointment WHERE VetSSN = V.UserSSN AND [Date] <= (SELECT CURRENT_DATE) AND CustomerSSN = C.UserSSN AND Appointment.[Date] = Availability.[Date] AND Appointment.Start_Time = Availability.Start_Time";
            if (ShowPaid)
                Query = Query + ";";
            else
                Query = Query + " AND NOT Payment_Made;";
            return dbMan.ExecuteReader(Query);
        }
        public void ConfirmPayment(string ApptID)
        {
            string Query = "UPDATE Appointment SET Payment_Made = 1 WHERE Appointment ID = " + ApptID + ";";
            dbMan.ExecuteReader(Query);
        }

        public DataTable GetVetAppts(string VetID)
        {
            string Query = "SELECT AppointmentID, A_Name, [Date], Start_Time FROM Appointment WHERE VetSSN = " + VetID + ";";
            return dbMan.ExecuteReader(Query);
        }

        public string GetApptCustomer(string ApptID)
        {
            string Query = "SELECT CustomerSSN FROM Appointment WHERE AppointmentID = " + ApptID + ";";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public void AddDiagnosis(string ApptID, string NewDiagnosis)
        {
            string Query = "INSERT INTO AppointmentDiagnosis(Appointment, Diagnosis) VALUES (" + ApptID + ", '" + NewDiagnosis + "';";
            dbMan.ExecuteNonQuery(Query);
        }
        public void AddPrescription(string ApptID, string NewPrescription)
        {
            string Query = "INSERT INTO AppointmentPrescription(Appointment, Prescription) VALUES (" + ApptID + ", '" + NewPrescription + "';";
            dbMan.ExecuteNonQuery(Query);
        }
        public void AddProcedure(string ApptID, string NewProcedure)
        {
            string Query = "INSERT INTO AppointmentProcedure(Appointment, Procedure) VALUES (" + ApptID + ", '" + NewProcedure + "';";
            dbMan.ExecuteNonQuery(Query);
            Query = "UPDATE Appointment SET Cost = 60 * (SELECT COUNT(Procedure) FROM AppointmentProcedure WHERE AppointmentProcedure.AppointmentID = " + ApptID + ") WHERE Appointment.AppointmentID = " + ApptID + ";";
            dbMan.ExecuteNonQuery(Query);
        }

        public void DeleteRecord(string CustomerID, string AnimalName, string RecordType, string OriginalRecord)
        {
            string Query = "SELECT AppointmentID FROM Appointment, Appointment" + RecordType + " WHERE CustomerSSN = " + CustomerID + " AND A_Name = '" + AnimalName + "' AND '" + RecordType + "' = '" + OriginalRecord + "';";
            string ApptID = dbMan.ExecuteScalar(Query).ToString();
            Query = "DELETE FROM Appointment" + RecordType + " WHERE AppointmentID = " + ApptID + " AND " + RecordType + " = '" + OriginalRecord + "';";
            dbMan.ExecuteNonQuery(Query);
        }

        public void UpdateRecord(string CustomerID, string AnimalName, string RecordType, string OriginalRecord, string NewRecord)
        {
            string Query = "SELECT AppointmentID FROM Appointment, Appointment" + RecordType + " WHERE CustomerSSN = " + CustomerID + " AND A_Name = '" + AnimalName + "' AND " + RecordType + " = '" + OriginalRecord + "';";
            string ApptID = dbMan.ExecuteScalar(Query).ToString();
            Query = "UPDATE Appointment" + RecordType + " SET " + RecordType + " = '" + NewRecord + "' WHERE AppointmentID = " + ApptID + " AND " + RecordType + " = '" + OriginalRecord + "';";
            dbMan.ExecuteNonQuery(Query);
        }

        public void AddImmunization(string ApptID, string CustomerID, string AnimalName, string VaccineName)
        {
            string Query = "SELECT [Date] FROM Appointment WHERE AppointmentID = " + ApptID + ";";
            string ApptDate = dbMan.ExecuteScalar(Query).ToString();
            Query = "SELECT VaccineCode FROM Vaccine WHERE Trade_Name = '" + VaccineName + "';";
            string VaccineCode = dbMan.ExecuteScalar(Query).ToString();
            Query = "INSERT INTO Immunization(A_Name, VaccineCode, Immunization_Date, CustomerSSN) VALUES ('" + AnimalName + "', " + VaccineCode + ", '" + ApptDate + "', " + CustomerID + ";";
            dbMan.ExecuteNonQuery(Query);
        }

        public void UpdateWt(string CustomerID, string AnimalName, string CurrentWt)
        {
            string Query = "UPDATE Animal SET Current_Weight = " + CurrentWt + " WHERE CustomerSSN = " + CustomerID + " AND A_Name = '" + AnimalName + "';";
            dbMan.ExecuteNonQuery(Query);
        }

        public DataTable GetAvailabilitiesOverTime()
        {
            string Query = "SELECT VetSSN, COUNT (Animal_SSN) AS AnC FROM Appointment GROUP BY VetSSN;";
            //string Query = "SELECT [Date], COUNT([Date], Start_Time, VetSSN) AS AvailCount FROM [Availability] WHERE [DATE] > CAST(GETDATE() AS DATE) GROUP BY [DATE];";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetAppointmentsOverTime()
        {
            string Query = "SELECT [Date], COUNT(ApptID) AS ApptCount FROM [Availability] WHERE [DATE] > CAST(GETDATE() AS DATE) GROUP BY [DATE];";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetCustomerBanks()
        {
            string Query = "SELECT Bank, COUNT(CustomerSSN) AS CustNum FROM Customer GROUP BY BANK;";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetRecords(string CustomerID, string AnimalName, String Type)
        {
            string Query = "SELECT * FROM Appointment" + Type + ", Appointment WHERE CustomerSSN = " + CustomerID + " AND A_Name = '" + AnimalName + "' AND Appointment.AppointmentID = Appointment" + Type + ".AppointmentID;";
            return dbMan.ExecuteReader(Query);
        }

        public string GetTotalUpcomingAvailabilities()
        {
            string Query = "SELECT COUNT(*) FROM Availability WHERE [Date] > CAST(GETDATE() AS DATE);";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetAverageUpcomingAvailabilities()
        {
            string Query = "SELECT AVG(AvailCount) FROM (SELECT [Date], COUNT(*) AS AvailCount FROM Availability WHERE [Date] > CAST(GETDATE() AS DATE) GROUP BY [Date]);";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetTotalPastAppointments()
        {
            string Query = "SELECT Count(*) FROM Appointment WHERE [Date] <= CAST(GETDATE() AS DATE);";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetAveragePastAppointments()
        {
            string Query = "SELECT AVG(ApptCount) FROM (SELECT [Date], COUNT(*) AS ApptCount FROM Appointment WHERE [Date] <= CAST(GETDATE() AS DATE) GROUP BY [Date]);";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetMinVaccineStock()
        {
            string Query = "SELECT MIN(Stock_Number) FROM Vaccine;";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetMaxVaccineStock()
        {
            string Query = "SELECT MAX(Stock_Number) FROM Vaccine;";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetMinCompletedImmunizations()
        {
            string Query = "SELECT MIN(ImmNum) FROM (SELECT CustommerSSN, A_Name, COUNT(VaccineCode) AS ImmNum FROM Immunization GROUP BY CustomerSSN, A_Name);";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetMaxCompletedImmunizations()
        {
            string Query = "SELECT MAX(ImmNum) FROM (SELECT CustommerSSN, A_Name, COUNT(VaccineCode) AS ImmNum FROM Immunization GROUP BY CustomerSSN, A_Name);";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetAvgCompletedImmunizations()
        {
            string Query = "SELECT AVG(ImmNum) FROM (SELECT CustommerSSN, A_Name, COUNT(VaccineCode) AS ImmNum FROM Immunization GROUP BY CustomerSSN, A_Name);";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetTotalCompletedImmunizations()
        {
            string Query = "SELECT SUM(ImmNum) FROM (SELECT CustommerSSN, A_Name, COUNT(VaccineCode) AS ImmNum FROM Immunization GROUP BY CustomerSSN, A_Name);";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetMajorityCustBank()
        {
            string Query = "SELECT Bank FROM Customer b WHERE (SELECT COUNT(CustomerSSN) FROM Customer c WHERE b.BANK = c.BANK) = (SELECT MAX(BankCust) FROM (SELECT Bank, COUNT(CustomerSSN) AS BankCust FROM Customer GROUP BY Bank);";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetMajorityEmpBank()
        {
            string Query = "SELECT Bank FROM Employee b WHERE (SELECT COUNT(EmployeeSSN) FROM Employee e WHERE b.BANK = e.BANK) = (SELECT MAX(BankEmp) FROM (SELECT Bank, COUNT(EmployeeSSN) AS BankEmp FROM Employee GROUP BY Bank);";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetAvgAnimalsPerCustomer()
        {
            string Query = "SELECT AVG(AnimalNum) FROM (SELECT CustomerSSN, COUNT(A_Name) AS AnimalNum FROM Animal GROUP BY CustomerSSN);";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetMaxApptCost()
        {
            string Query = "SELECT MAX(Cost) FROM Appointment;";
            return dbMan.ExecuteScalar(Query).ToString();
        }
        public string GetMinApptCost()
        {
            string Query = "SELECT MIN(Cost) FROM Appointment;";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetAvgApptCost()
        {
            string Query = "SELECT AVG(Cost) FROM Appointment;";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public string GetTotalRevenue()
        {
            string Query = "SELECT SUM(Cost) FROM Appointment;";
            return dbMan.ExecuteScalar(Query).ToString();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
