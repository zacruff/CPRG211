namespace InheritanceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("employees.txt");
            List<Employee> employees = new List<Employee>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(":");
                string id = columns[0];
                string name = columns[1];
                string address = columns[2];
                string phone = columns[3];
                string sinString = columns[4];
                long sin = Convert.ToInt64(sinString);
                string dob = columns[5];
                string dept = columns[6];
                char firstDigitOfId = id[0];
                if (firstDigitOfId == '0' || firstDigitOfId == '1' || firstDigitOfId == '2' || firstDigitOfId == '3' || firstDigitOfId == '4') 
                { 
                    // Salaried Employee
                    string salaryString = columns[7];
                    double salary = Convert.ToDouble(salaryString);
                    Employee employee = new Salaried(id, name, address, phone, sin, dob, dept, salary);
                    employees.Add(employee);
                }
                else if (firstDigitOfId == '5' || firstDigitOfId == '6' || firstDigitOfId == '7')
                {
                    // Wage Employee
                    string rateString = columns[7];
                    string hoursString = columns[8];
                    double rate = Convert.ToDouble(rateString);
                    double hours = Convert.ToDouble(hoursString);
                    Employee employee = new Wages(id, name, address, phone, sin, dob, dept, rate, hours);
                    employees.Add(employee);
                }
                else if (firstDigitOfId == '8' || firstDigitOfId== '9')
                {
                    // PartTime Employee
                    string rateString = columns[7];
                    string hoursString = columns[8];
                    double rate = Convert.ToDouble(rateString);
                    double hours = Convert.ToDouble(hoursString);
                    Employee employee = new PartTime(id, name, address, phone, sin, dob, dept, rate, hours);
                    employees.Add(employee);
                }

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}