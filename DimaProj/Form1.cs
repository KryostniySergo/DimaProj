using Microsoft.EntityFrameworkCore;

namespace DimaProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var cities = db.Cities.ToList();
                var flights = db.Flights.ToList();
                comboBox1.DataSource = cities
                    .Select(s => s.Name).ToList();
                comboBox2.DataSource = flights
                    .Select(s => s.FlyTime.Date).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.Rows.Clear();

                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "Имя";
                dataGridView1.Columns[1].Name = "Фамилия";
                dataGridView1.Columns[2].Name = "Отчество";
                dataGridView1.Columns[3].Name = "Название борта";

                var pass = db.Passenger
                    .Include(s => s.Flight)
                    .Where(s => s.Flight.CityId == comboBox1.SelectedIndex + 1)
                    .ToList();

                foreach (var item in pass)
                {
                    dataGridView1.Rows.Add(
                        item.Name,
                        item.SecondName,
                        item.Surname,
                        item.Flight.Name
                        );
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.Rows.Clear();

                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "Имя";
                dataGridView1.Columns[1].Name = "Фамилия";
                dataGridView1.Columns[2].Name = "Отчество";
                dataGridView1.Columns[3].Name = "Название борта";

                var pass = db.Passenger
                    .Include(s => s.Flight)
                    .Where(s => s.Flight.FlyTime.Date == (DateTime)comboBox2.SelectedItem)
                    .ToList();

                foreach (var item in pass)
                {
                    dataGridView1.Rows.Add(
                        item.Name,
                        item.SecondName,
                        item.Surname,
                        item.Flight.Name
                        );
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FlightForm().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new PassagerForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CityForm().Show();
        }
    }
}