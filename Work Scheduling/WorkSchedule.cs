using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Scheduling
{
    public class WorkSchedule
    {
        internal Dictionary<Day, List<Employee>> schedule;

        public WorkSchedule()
        {
            schedule = new Dictionary<Day, List<Employee>>
            {
                { Day.Monday, new List<Employee>() },
                { Day.Tuesday, new List<Employee>() },
                { Day.Wednesday, new List<Employee>() },
                { Day.Thursday, new List<Employee>() },
                { Day.Friday, new List<Employee>() },
                { Day.Saturday, new List<Employee>() },
                { Day.Sunday, new List<Employee>() },
            };
        }

        public void AssignEmployee(Day day, Employee employee)
        {
            //if (String.IsNullOrEmpty(employee.Name))
            //{
            //    throw new NoNullAllowedException("Please Select an Employee first.");
            //}
            if (schedule[day].Contains(employee))
            {
                MessageBox.Show("Cannot assign an employee to the same day more than once");
            }
            else
            {
                schedule[day].Add(employee);
                employee.WorkdaysCount++;
            }
        }
    }
}
