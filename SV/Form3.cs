using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_wf
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            float vremMo = float.Parse(Properties.Settings.Default.Mo.Split(';')[1]) / 6.0f;
            monday.Text = Properties.Settings.Default.Mo.Split(';')[0] + "                         " + vremMo.ToString("F2");
            float vremTu = float.Parse(Properties.Settings.Default.Tu.Split(';')[1]) / 6.0f;
            tuesday.Text = Properties.Settings.Default.Tu.Split(';')[0] + "                         " + vremTu.ToString("F2");
            float vremWe = float.Parse(Properties.Settings.Default.We.Split(';')[1]) / 6.0f;
            wednesday.Text = Properties.Settings.Default.We.Split(';')[0] + "                         " + vremWe.ToString("F2");
            float vremTh = float.Parse(Properties.Settings.Default.Th.Split(';')[1]) / 6.0f;
            thursday.Text = Properties.Settings.Default.Th.Split(';')[0] + "                         " + vremTh.ToString("F2");
            float vremFr = float.Parse(Properties.Settings.Default.Fr.Split(';')[1]) / 6.0f;
            friday.Text = Properties.Settings.Default.Fr.Split(';')[0] + "                         " + vremFr.ToString("F2");
            float vremSa = float.Parse(Properties.Settings.Default.Sa.Split(';')[1]) / 6.0f;
            saturday.Text = Properties.Settings.Default.Sa.Split(';')[0] + "                         " + vremSa.ToString("F2");
            float vremSu = float.Parse(Properties.Settings.Default.Su.Split(';')[1]) / 6.0f;
            sunday.Text = Properties.Settings.Default.Su.Split(';')[0] + "                         " + vremSu.ToString("F2");
            this.label10.MaximumSize = new Size(100, 50);
            if (Properties.Settings.Default.vozrast <5 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu > 210)
            {
                label10.Text = "Вы превысили недельный лимит. Постарайтесь на следующей неделе меньше времени уделять гаджетам";
            }
            if (Properties.Settings.Default.vozrast < 5 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu < 210)
            {
                label10.Text = "Вы успешно соблюдаете режим. Продолжайте в том же духе";
            }
            if (Properties.Settings.Default.vozrast < 7 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu > 315)
            {
                label10.Text = "Вы превысили недельный лимит. Постарайтесь на следующей неделе меньше времени уделять гаджетам";
            }
            if (Properties.Settings.Default.vozrast < 7 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu < 315)
            {
                label10.Text = "Вы успешно соблюдаете режим. Продолжайте в том же духе";
            }
            if (Properties.Settings.Default.vozrast < 10 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu > 420)
            {
                label10.Text = "Вы превысили недельный лимит. Постарайтесь на следующей неделе меньше времени уделять гаджетам";
            }
            if (Properties.Settings.Default.vozrast < 10 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu < 420)
            {
                label10.Text = "Вы успешно соблюдаете режим. Продолжайте в том же духе";
            }
            if (Properties.Settings.Default.vozrast < 14 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu > 525)
            {
                label10.Text = "Вы превысили недельный лимит. Постарайтесь на следующей неделе меньше времени уделять гаджетам";
            }
            if (Properties.Settings.Default.vozrast < 14 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu < 525)
            {
                label10.Text = "Вы успешно соблюдаете режим. Продолжайте в том же духе";
            }
            if (Properties.Settings.Default.vozrast > 14 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu > 630)
            {
                label10.Text = "Вы превысили недельный лимит. Постарайтесь на следующей неделе меньше времени уделять гаджетам";
            }
            if (Properties.Settings.Default.vozrast > 14 && vremMo + vremTu + vremWe + vremTh + vremFr + vremSa + vremSu < 630)
            {
                label10.Text = "Вы успешно соблюдаете режим. Продолжайте в том же духе";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form vozr = new Form4();
            vozr.Show();
        }
    }
}
