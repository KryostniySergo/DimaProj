using DimaProj.DB.Model;

namespace DimaProj
{
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var city = new City { Name = textBox2.Text };
                    db.Cities.Add(city);
                    db.SaveChanges();
                    MessageBox.Show($"Добавлен новый город {textBox2.Text}");
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
                    var city = db.Cities
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (city is null)
                    {
                        MessageBox.Show("Нет такого факультета");
                        return;
                    }


                    city.Name = textBox2.Text;

                    db.Cities.Update(city);
                    db.SaveChanges();
                    MessageBox.Show($"Изменен город {textBox2.Text}");
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
                    var city = db.Cities
                    .FirstOrDefault(f => f.Id == int.Parse(textBox1.Text));

                    if (city is null)
                    {
                        MessageBox.Show("Нет такого факультета");
                        return;
                    }

                    db.Cities.Remove(city);
                    db.SaveChanges();
                    MessageBox.Show($"Удален город {city.Name}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Что то пошло не так");
                }

            }
        }
    }
}
