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
    }
}