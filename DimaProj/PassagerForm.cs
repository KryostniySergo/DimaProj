using DimaProj.DB.Model;
using System.Data;

namespace DimaProj
{
    public partial class PassagerForm : Form
    {
        public PassagerForm()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var flights = db.Flights.ToList();
                comboBox1.DataSource = flights.Select(s => s.Name).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var passenger = new Passenger
                    {
                        Name = textBox2.Text,
                        SecondName = textBox3.Text,
                        Surname = textBox4.Text,
                        FlightId = comboBox1.SelectedIndex + 1
                    };
                    db.Passenger.Add(passenger);
                    db.SaveChanges();
                    MessageBox.Show($"Добавлен новый пассажир {passenger.Name}");
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
                    var passenger = db.Passenger
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (passenger is null)
                    {
                        MessageBox.Show("Нет такого направления");
                        return;
                    }

                    passenger.Name = textBox2.Text;
                    passenger.SecondName = textBox3.Text;
                    passenger.Surname = textBox4.Text;
                    passenger.FlightId = comboBox1.SelectedIndex + 1;

                    db.Passenger.Update(passenger);
                    db.SaveChanges();
                    MessageBox.Show($"Изменен пассажир {passenger.Name}");
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
                    var passenger = db.Passenger
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (passenger is null)
                    {
                        MessageBox.Show("Нет такого факультета");
                        return;
                    }

                    db.Passenger.Remove(passenger);
                    db.SaveChanges();
                    MessageBox.Show($"Удален пассажир {passenger.Name}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }

            }
        }
    }
}
