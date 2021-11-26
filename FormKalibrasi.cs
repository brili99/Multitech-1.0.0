using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multitech_1._0._0
{
    public partial class FormKalibrasi : Form
    {
        public FormKalibrasi()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;

        public FormKalibrasi(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void setKalibrasi(String device, String nilai)
        {
            if (mainForm.serialPort1.IsOpen == true)
            {
                String data = device + "_" + nilai;
                mainForm.serialPort1.WriteLine(data);
                mainForm.serialPort1.DiscardOutBuffer();
                mainForm.loggingBox(data);
            }
            else
            {
                mainForm.loggingBox("Mohon koneksikan device terlebih dahulu");
            }
        }

        private void btnKalibrasi1_Click(object sender, EventArgs e)
        {
            setKalibrasi("1", inputValLoad1.Text);
        }

        private void btnKalibrasi2_Click(object sender, EventArgs e)
        {
            setKalibrasi("2", inputValLoad2.Text);
        }

        private void btnKalibrasi3_Click(object sender, EventArgs e)
        {
            setKalibrasi("3", inputValLoad3.Text);
        }

        private void btnKalibrasi4_Click(object sender, EventArgs e)
        {
            setKalibrasi("4", inputValLoad4.Text);
        }

        private void btnKalibrasi5_Click(object sender, EventArgs e)
        {
            setKalibrasi("5", inputValLoad5.Text);
        }

        private void btnKalibrasi6_Click(object sender, EventArgs e)
        {
            setKalibrasi("6", inputValLoad6.Text);
        }

        private void btnKalibrasi7_Click(object sender, EventArgs e)
        {
            setKalibrasi("7", inputValLoad7.Text);
        }

        private void btnKalibrasi8_Click(object sender, EventArgs e)
        {
            setKalibrasi("8", inputValLoad8.Text);
        }

        private void btnKalibrasi9_Click(object sender, EventArgs e)
        {
            setKalibrasi("9", inputValLoad9.Text);
        }

        private void btnKalibrasi10_Click(object sender, EventArgs e)
        {
            setKalibrasi("10", inputValLoad10.Text);
        }

        private void FormKalibrasi_Load(object sender, EventArgs e)
        {
            if (mainForm.serialPort1.IsOpen == true)
            {
                mainForm.serialPort1.WriteLine("g");
                String ReceivedMessage = mainForm.serialPort1.ReadLine();
                if (ReceivedMessage.First() == '|')
                {
                    ReceivedMessage = ReceivedMessage.Replace("|", "");
                    ReceivedMessage = ReceivedMessage.Replace("#", "");
                    ReceivedMessage.Trim();

                    String[] dataReadline = ReceivedMessage.Split(' ');
                    float[] dataReadFloat = new float[10];
                    for (int x = 0; x < 10; x++)
                    {
                        dataReadFloat[x] = float.Parse(dataReadline[x]) / 100;
                    }
                    inputValLoad1.Text = dataReadFloat[0].ToString("0.00");
                    inputValLoad2.Text = dataReadFloat[1].ToString("0.00");
                    inputValLoad3.Text = dataReadFloat[2].ToString("0.00");
                    inputValLoad4.Text = dataReadFloat[3].ToString("0.00");
                    inputValLoad5.Text = dataReadFloat[4].ToString("0.00");
                    inputValLoad6.Text = dataReadFloat[5].ToString("0.00");
                    inputValLoad7.Text = dataReadFloat[6].ToString("0.00");
                    inputValLoad8.Text = dataReadFloat[7].ToString("0.00");
                    inputValLoad9.Text = dataReadFloat[8].ToString("0.00");
                    inputValLoad10.Text = dataReadFloat[9].ToString("0.00");
                }
            }
        }

    }
}
