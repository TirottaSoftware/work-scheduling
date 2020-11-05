using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Scheduling
{
    public class Employee
    {
        private string name;
        private int salary;
        private int workdaysCount;
        private int desiredDays;

        public int DesiredDays
        {
            get { return desiredDays; }
            set 
            {
                if (value < 0 || value > 7)
                {
                    throw new ArgumentException("Desired workdays must be in a range ( 0-7 )");
                }  
                desiredDays = value; 
            }
        }


        public int WorkdaysCount
        {
            get { return workdaysCount; }
            set { workdaysCount = value; }
        }


        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
            this.WorkdaysCount = 0;
        }
        public int WeeklySalary => this.Salary * this.WorkdaysCount;
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value <= 0)
                {
                    throw new NoNullAllowedException("Salary cannot be 0 or less");
                }
                else
                {
                    salary = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NoNullAllowedException("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }

    }
}
