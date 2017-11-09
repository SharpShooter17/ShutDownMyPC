using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownMyPc
{
    public partial class Form1 : Form
    {
        private int czas_ustalony;
        private int czas;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            czas = 0;
            czas_ustalony = Convert.ToInt32(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true && czas <= czas_ustalony)
            {
                czas += 1;
                label2.Text = Convert.ToString(czas_ustalony - czas);
            }
            else if (czas >= czas_ustalony && timer1.Enabled == true )
            {
                timer1.Stop();
                timer1.Enabled = false;
                process1.Start();
                this.Close();
            }
        }
    }
}
