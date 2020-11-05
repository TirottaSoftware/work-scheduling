using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Scheduling
{
    public partial class DesireList : Form
    {
        private List<Employee> employees;

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public DesireList()
        {
            InitializeComponent();
            employees = new List<Employee>();
        }

        private void DesireList_Load(object sender, EventArgs e)
        {
            UpdateEmployeesList();
        }
        public void UpdateEmployeesList()
        {
            lbxEmployees.Items.Clear();
            foreach (var emp in this.Employees)
            {
                lbxEmployees.Items.Add($"{emp.Name} : {emp.DesiredDays}");
            }
        }
        public void AddEmployee(Employee employee)
        {
            foreach (var emp in this.Employees)
            {
                if (emp.Name == employee.Name)
                {
                    return;
                }
            }
            this.Employees.Add(employee);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedEmployeeIndex = lbxEmployees.SelectedIndex;
                this.Employees[selectedEmployeeIndex].DesiredDays = int.Parse(tbxDesiredDays.Text);
                tbxDesiredDays.Clear();
                UpdateEmployeesList();
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an employee first");
                tbxDesiredDays.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the employee's desired workdays");
                tbxDesiredDays.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbxDesiredDays.Clear();
            }
        }
    }
}
