using EmployeePayroll;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_EmpDetails_Data()
        {
            List<EmployeeModel> employeeDetails = new List<EmployeeModel>();
            employeeDetails.Add(new EmployeeModel(employeeId: 1, employeeName: "Rajesh", phoneNumber: "7898625487", address: "Bemetara", departMent: "cse"));
            employeeDetails.Add(new EmployeeModel(employeeId: 2, employeeName: "Vivek", phoneNumber: "9698625487", address: "Raipur", departMent: "me"));
            employeeDetails.Add(new EmployeeModel(employeeId: 3, employeeName: "Govind", phoneNumber: "6325625487", address: "Bhilai", departMent: "civil"));
            employeeDetails.Add(new EmployeeModel(employeeId: 4, employeeName: "Deepak", phoneNumber: "9018625487", address: "Durg", departMent: "physics"));
            employeeDetails.Add(new EmployeeModel(employeeId: 5, employeeName: "Ramesh", phoneNumber: "9198625487", address: "Kanker", departMent: "EEE"));

            Operations emppayroll = new Operations();
            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(employeeDetails);
            DateTime StopDateTimes = DateTime.Now;

            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));
        }
    }
}