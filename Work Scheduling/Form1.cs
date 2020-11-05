using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Work_Scheduling
{
    public partial class Form1 : Form
    {
        private DesireList desireList;
        private List<Employee> availableEmployees;
        private WorkSchedule workSchedule;
        public Form1()
        {
            InitializeComponent();
            desireList = new DesireList();
            availableEmployees = new List<Employee>();
            workSchedule = new WorkSchedule();
            UpdateScheduleList();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            cbxWeekdays.Items.Add(Day.Monday);
            cbxWeekdays.Items.Add(Day.Tuesday);
            cbxWeekdays.Items.Add(Day.Wednesday);
            cbxWeekdays.Items.Add(Day.Thursday);
            cbxWeekdays.Items.Add(Day.Friday);
            cbxWeekdays.Items.Add(Day.Saturday);
            cbxWeekdays.Items.Add(Day.Sunday);
        }
        private void UpdateScheduleList()
        {
            lbxWeekSchedule.Items.Clear();
            foreach (var kvp in workSchedule.schedule)
            {
                string employeesForTheDay = String.Empty;
                foreach (var emp in kvp.Value)
                {
                    employeesForTheDay += emp.Name + ", ";
                }
                lbxWeekSchedule.Items.Add($"{kvp.Key}: {employeesForTheDay}");
            }
        }
        private void UpdateEmployeesList()
        {
            lbxEmployees.Items.Clear();

            foreach (var availableEmployee in availableEmployees)
            {
                lbxEmployees.Items.Add($"{availableEmployee.Name} - {availableEmployee.Salary}");
                desireList.AddEmployee(availableEmployee);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string employeeName = tbxEmployeeName.Text;
            try
            {
                int employeeSalary = int.Parse(tbxEmployeeSalary.Text);

                //if (int.TryParse(tbxEmployeeSalary.Text, out employeeSalary))
                //{
                //    employeeSalary = int.Parse(tbxEmployeeSalary.Text);
                //}
                //else
                //{
                //    MessageBox.Show("Invalid Salary Value");
                //    tbxEmployeeName.Clear();
                //    tbxEmployeeSalary.Clear();
                //    return;
                //}


                Employee employee = new Employee(employeeName, employeeSalary);
                foreach (var emp in availableEmployees)
                {
                    if (emp.Name == employee.Name)
                    {
                        throw new ArgumentException($"{employeeName} is already in the list");
                    }
                }
                availableEmployees.Add(employee);
                UpdateEmployeesList();
                tbxEmployeeName.Clear();
                tbxEmployeeSalary.Clear();
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message);
                tbxEmployeeName.Clear();
                tbxEmployeeSalary.Clear();
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid Salary Value");
                tbxEmployeeName.Clear();
                tbxEmployeeSalary.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbxEmployeeName.Clear();
                tbxEmployeeSalary.Clear();
            }
        }
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            string selectedEmployee = lbxEmployees.SelectedItem.ToString();

            if (selectedEmployee == null)
            {
                //Error
            }
            else
            {
                //George - 35
                string[] employeeData = selectedEmployee.Split('-'); //{"George" , "35"}
                string employeeName = employeeData[0].TrimEnd(); //George
                int employeeSalary = int.Parse(employeeData[1].TrimStart()); //35

                Employee employeeToRemove = new Employee(employeeName, employeeSalary);
                //workSchedule.RemoveEmployee(employeeToRemove);
                RemoveEmployee(employeeToRemove);
                lblWeeklySalary.Text = "€0";
                UpdateScheduleList();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedEmployeeIndex = lbxEmployees.SelectedIndex;
                Employee selectedEmployee = availableEmployees[selectedEmployeeIndex];

                string selectedWeekday = cbxWeekdays.SelectedItem.ToString();
                Day dayOfWeek = (Day)Enum.Parse(typeof(Day), selectedWeekday);

                workSchedule.AssignEmployee(dayOfWeek, selectedEmployee);
                UpdateWeeklySalary(selectedEmployee);
                UpdateScheduleList();
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an employee first");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a day to which you want to assign this employee");
            }
        }

        private bool CheckExistence(Employee employee)
        {
            foreach (var e in availableEmployees)
            {
                if (e.Name == employee.Name &&
                    e.Salary == employee.Salary)
                {
                    return true;
                }
            }
            return false;
        }

        private void RemoveEmployee(Employee employeeToRemove)
        {
            if (CheckExistence(employeeToRemove))
            {
                foreach (var e in availableEmployees)
                {
                    if (e.Name == employeeToRemove.Name &&
                    e.Salary == employeeToRemove.Salary)
                    {
                        availableEmployees.Remove(e);
                        UpdateEmployeesList();
                        return;
                    }
                }
            }
        }

        private void UpdateWeeklySalary(Employee emp)
        {
            lblWeeklySalary.Text = "€" + emp.WeeklySalary.ToString();
        }
        private void lbxEmployees_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = lbxEmployees.SelectedIndex;
                Employee selectedEmployee = availableEmployees[selectedIndex];
                UpdateWeeklySalary(selectedEmployee);
            }
            catch
            {
            }
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEmployeesList();
        }
        private void rbtnUnassigned_CheckedChanged(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            foreach (var emp in availableEmployees)
            {
                if (emp.WorkdaysCount == 0)
                {
                    lbxEmployees.Items.Add($"{emp.Name} - {emp.Salary}");
                }
            }
        }

        private void rbtnAssigned_CheckedChanged(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            foreach (var emp in availableEmployees)
            {
                if (emp.WorkdaysCount > 0)
                {
                    lbxEmployees.Items.Add($"{emp.Name} - {emp.Salary}");
                }
            }
        }

        private void btnDesireList_Click(object sender, EventArgs e)
        {
            desireList.ShowDialog();
        }
    }
}
