using DimaProj.DB.Model;
using System.Data;

namespace DimaProj
{
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var cities = db.Cities.ToList();
                comboBox1.DataSource = cities.Select(s => s.Name).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var flight = new Flight
                    {
                        Name = textBox2.Text,
                        FlyTime = dateTimePicker1.Value.ToUniversalTime(),
                        CityId = comboBox1.SelectedIndex + 1
                    };
                    db.Flights.Add(flight);
                    db.SaveChanges();
                    MessageBox.Show($"Добавлен новый рейс {flight.Name}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var flight = db.Flights
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (flight is null)
                    {
                        MessageBox.Show("Нет такого направления");
                        return;
                    }

                    flight.Name = textBox2.Text;
                    flight.FlyTime = dateTimePicker1.Value.ToUniversalTime();
                    flight.CityId = comboBox1.SelectedIndex + 1;

                    db.Flights.Update(flight);
                    db.SaveChanges();
                    MessageBox.Show($"Изменен рейс {flight.Name}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var flight = db.Flights
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (flight is null)
                    {
                        MessageBox.Show("Нет такого факультета");
                        return;
                    }

                    db.Flights.Remove(flight);
                    db.SaveChanges();
                    MessageBox.Show($"Удален рейс {flight.Name}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }

            }
        }
    }
}
