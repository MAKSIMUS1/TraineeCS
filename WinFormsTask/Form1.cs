namespace WinFormsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Tick += Timer1_Tick;
        }

        private async void button_Connect_DB_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Подключение к базе данных";

            Random rnd = new Random();
            int delay = rnd.Next(3000, 5000);
            await Task.Delay(delay);

            textBox1.Text = "Подключен к базе данных";

            timer1.Start();
        }

        private async void button_Disconnect_DB_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Отключение от базы";

            await Task.Delay(2000);

            timer1.Stop();
            textBox1.Text = "Отключено от базы данных";
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "Данные получены";
        }
    }
}
