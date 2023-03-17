using Microsoft.EntityFrameworkCore;
using Q1.Models;

namespace Q1
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;
        public Form1()
        {
            employees = new List<Employee>();
            InitializeComponent();
            getAll();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void getAll()
        {
            employees.Clear();
            var context = new PRN221_Spr22Context();
            context.Employees.ToList().ForEach(e =>
            {
                employees.Add(new Employee()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Gender = e.Gender,
                    Dob = e.Dob,
                    Phone = e.Phone,
                    Idnumber = e.Idnumber,
                });
            });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var employeeID = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            textBoxID.Text = employeeID;
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            var MaleOrFemale = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            if (MaleOrFemale.Equals("Male")) { radioButtonMale.Checked = true; } else radioButtonFemale.Checked = true;
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
            textBoxPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            textBoxIDnumber.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var context = new PRN221_Spr22Context();
            string sex = "";
            if (radioButtonMale.Checked) sex = "Male";
            else sex = "Female";
            try
            {
                context.Employees.Add(new Employee()
                {
                    Name = textBoxName.Text,
                    Gender = sex,
                    Dob = dateTimePicker1.Value,
                    Phone = textBoxPhone.Text,
                    Idnumber = textBoxIDnumber.Text,
                });
                context.SaveChanges();
                getAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var context = new PRN221_Spr22Context();
            string sex = "";
            if (radioButtonMale.Checked) sex = "Male";
            else sex = "Female";
            try
            {
                context.Entry<Employee>(new Employee()
                {
                    Name = textBoxName.Text,
                    Gender = sex,
                    Dob = dateTimePicker1.Value,
                    Phone = textBoxPhone.Text,
                    Idnumber = textBoxIDnumber.Text,
                }).State = EntityState.Modified;
                context.SaveChanges();
                getAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            textBoxPhone.Text = string.Empty;
            textBoxIDnumber.Text = string.Empty;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}