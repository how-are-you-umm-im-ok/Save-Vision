using System;
using System.Windows.Forms;

namespace test_wf
{
    public partial class Form1 : Form
    {

        long ActiveTime = 0;
        int Chislo;
        string DenNedely;
        string VremyaZaDen;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            // делаем невидимой нашу иконку в трее
            //notifyIcon1.Visible = false;
            // добавляем Эвент или событие по 2му клику мышки, 
            //вызывая функцию  notifyIcon1_MouseDoubleClick
            //this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);

            // добавляем событие на изменение окна
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.TopMost = true;
            this.Activate();
            
           
            Properties.Settings.Default.Save();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReadingMode_Click(object sender, EventArgs e)
        {




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tmrPause_Tick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sms.wav");
            player.PlaySync();
            player.SoundLocation = "sound.wav";
            player.Load();
            player.Play();
            tmrPause.Enabled = false;
            Form f = new Form2();
            f.Show();
            f.FormClosed += (obj, args) => tmrPause.Enabled = true;
        }

        private void tmrSeans_Tick(object sender, EventArgs e)
        {
            Shell32.Shell sh = new Shell32.Shell();
            sh.MinimizeAll();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sms.wav");
            player.Play();
            tmrSeans.Enabled = false;
            tmrPause.Enabled = false;
            tmrPred.Enabled = false;
            MessageBox.Show("Сеанс окончен.");

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            tmrSeans.Interval = (int)numSeans.Value * 60000;
            tmrPause.Interval = (int)numPause.Value * 60000;
            tmrPred.Interval = (int)numSeans.Value * 60000 - 60000;
            tmrSeans.Enabled = true;
            tmrPause.Enabled = true;
            tmrPred.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numSeans.Text = Properties.Settings.Default.Save_text; // Загружаем ранее сохраненный текст
            if (numSeans.Text == "0") { numSeans.Text = "30"; }
            numPause.Text = Properties.Settings.Default.Save_text2;
            if (numPause.Text == "0") { numPause.Text = "30"; }
            tmrSeans.Interval = (int)numSeans.Value * 60000;
            tmrPause.Interval = (int)numPause.Value * 60000;
            tmrPred.Interval = (int)numSeans.Value * 60000 - 60000;
            tmrSeans.Enabled = true;
            tmrPause.Enabled = true;
            tmrPred.Enabled = true;
            DateTime date = DateTime.Today;
            //Console.WriteLine(date.ToString("dd"));
            Chislo = int.Parse(date.ToString("dd"));
            //Console.WriteLine(Chislo);
            DayOfWeek dn = date.DayOfWeek;
            DenNedely = dn.ToString();
            //Console.WriteLine(DenNedely);
            DenNedely = DenNedely[0].ToString() + DenNedely[1].ToString();
            string curData = "";
            if (DenNedely == "Mo")
            {
                string yacheika = Properties.Settings.Default.Mo;//17;90
                curData = (yacheika.Split(';'))[0];
                VremyaZaDen = (yacheika.Split(';'))[1];
                if (Chislo.ToString() == curData)
                {
                    ActiveTime = long.Parse(VremyaZaDen);
                }
                else
                {
                    ActiveTime = 0;
                }
            }
            if (DenNedely == "Tu")
            {
                string yacheika = Properties.Settings.Default.Tu;//17;90
                curData = (yacheika.Split(';'))[0];
                VremyaZaDen = (yacheika.Split(';'))[1];
                if (Chislo.ToString() == curData)
                {
                    ActiveTime = long.Parse(VremyaZaDen);
                }
                else
                {
                    ActiveTime = 0;
                }
            }
            if (DenNedely == "We")
            {
                string yacheika = Properties.Settings.Default.We;//17;90
                curData = (yacheika.Split(';'))[0];
                VremyaZaDen = (yacheika.Split(';'))[1];
                if (Chislo.ToString() == curData)
                {
                    ActiveTime = long.Parse(VremyaZaDen);
                }
                else
                {
                    ActiveTime = 0;
                }
            }
            if (DenNedely == "Th")
            {
                string yacheika = Properties.Settings.Default.Th;//17;90
                curData = (yacheika.Split(';'))[0];
                VremyaZaDen = (yacheika.Split(';'))[1];
                if (Chislo.ToString() == curData)
                {
                    ActiveTime = long.Parse(VremyaZaDen);
                }
                else
                {
                    ActiveTime = 0;
                }
            }
            if (DenNedely == "Fr")
            {
                string yacheika = Properties.Settings.Default.Fr;//17;90
                curData = (yacheika.Split(';'))[0];
                VremyaZaDen = (yacheika.Split(';'))[1];
                if (Chislo.ToString() == curData)
                {
                    ActiveTime = long.Parse(VremyaZaDen);
                }
                else
                {
                    ActiveTime = 0;
                }
            }
            if (DenNedely == "Sa")
            {
                string yacheika = Properties.Settings.Default.Sa;//17;90
                curData = (yacheika.Split(';'))[0];
                VremyaZaDen = (yacheika.Split(';'))[1];
                if (Chislo.ToString() == curData)
                {
                    ActiveTime = long.Parse(VremyaZaDen);
                }
                else
                {
                    ActiveTime = 0;
                }
            }
            if (DenNedely == "Su")
            {
                string yacheika = Properties.Settings.Default.Su;//17;90
                curData = (yacheika.Split(';'))[0];
                VremyaZaDen = (yacheika.Split(';'))[1];
                if (Chislo.ToString() == curData)
                {
                    ActiveTime = long.Parse(VremyaZaDen);
                }
                else
                {
                    ActiveTime = 0;
                }
            }
            Console.WriteLine(Properties.Settings.Default.Tu);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                //this.ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            //this.ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            if (DenNedely == "Mo")
            {
                Properties.Settings.Default.Mo = Chislo.ToString() + ";" + ActiveTime.ToString();
            }
            if (DenNedely == "Tu")
            {
                Properties.Settings.Default.Tu = Chislo.ToString() + ";" + ActiveTime.ToString();
            }
            if (DenNedely == "We")
            {
                Properties.Settings.Default.We = Chislo.ToString() + ";" + ActiveTime.ToString();
            }
            if (DenNedely == "Th")
            {
                Properties.Settings.Default.Th = Chislo.ToString() + ";" + ActiveTime.ToString();
            }
            if (DenNedely == "Fr")
            {
                Properties.Settings.Default.Fr = Chislo.ToString() + ";" + ActiveTime.ToString();
            }
            if (DenNedely == "Sa")
            {
                Properties.Settings.Default.Sa = Chislo.ToString() + ";" + ActiveTime.ToString();
            }
            if (DenNedely == "Su")
            {
                Properties.Settings.Default.Su = Chislo.ToString() + ";" + ActiveTime.ToString();
            }
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            Environment.Exit(0);
        }

        private void numPause_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save_text = numSeans.Value.ToString();
            Properties.Settings.Default.Save_text2 = numPause.Value.ToString();// Записываем содержимое richTextBox1 в Save_text
            Properties.Settings.Default.Save(); // Сохраняем переменные.
            MessageBox.Show("Параметры сохранены");
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void tmrPred_Tick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("1minute.wav");
            player.PlaySync();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tmrSttstc_Tick(object sender, EventArgs e)
        {
            //listBox1.Items.Add(Win32.GetIdleTime().ToString());
            if (Win32.GetIdleTime() < 10000) // 1 minute
            {
                ActiveTime = ActiveTime + 1;
                Console.WriteLine(ActiveTime);
                //textBox1.Text = "SLEEPING NOW";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            MessageBox.Show("Saved Settings");
            Application.Restart();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form stat = new Form3();
            stat.Show();
        }

        private void numSeans_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
