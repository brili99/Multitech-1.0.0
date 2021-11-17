using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Multitech_1._0._0
{
    public partial class Form1 : Form
    {

        Stopwatch sw = new Stopwatch();
        int b_sw = 0;
        String ReceivedMessage;
        public double[] newtonData = new double[10];
        string fileName = @"kosong";
        int baudRate = 115200;
        string tmpdata, tmpdata2;
        double tmpdata3;
        public bool loggingState = false;
        public long[] lastTime = new long[2];
        public double[] data1 = new double[500];
        public double[] data2 = new double[500];
        public double[] data3 = new double[500];
        public double[] data4 = new double[500];
        public double[] data5 = new double[500];
        public double[] data6 = new double[500];
        public double[] data7 = new double[500];
        public double[] data8 = new double[500];
        public double[] data9 = new double[500];
        public double[] data10 = new double[500];
        public double[] current_data = new double[10];
        public double[] kalibrasi_data = new double[10];

        private void chkLogging_CheckedChanged(object sender, EventArgs e)
        {
            loggingState = chkLogging.Checked;
        }

        private void btnReZero_Click(object sender, EventArgs e)
        {
            //for (int x = 0; x < kalibrasi_data.Length; x++)
            //{
            //    kalibrasi_data[x] = current_data[x];
            //}
            //kirim perintah 't' ke device
            loggingBox("Mengirim signal tare");
            serialPort1.WriteLine("t");
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            data1 = new double[500];
            data2 = new double[500];
            data3 = new double[500];
            data4 = new double[500];
            data5 = new double[500];
            data6 = new double[500];
            data7 = new double[500];
            data8 = new double[500];
            data9 = new double[500];
            data10 = new double[500];
            chart1.Series[0].Points.DataBindY(data1);
            chart1.Series[1].Points.DataBindY(data2);
            chart1.Series[2].Points.DataBindY(data3);
            chart1.Series[3].Points.DataBindY(data4);
            chart1.Series[4].Points.DataBindY(data5);
            chart1.Series[5].Points.DataBindY(data6);
            chart1.Series[6].Points.DataBindY(data7);
            chart1.Series[7].Points.DataBindY(data8);
            chart1.Series[8].Points.DataBindY(data9);
            chart1.Series[9].Points.DataBindY(data10);
        }

        public void Main(string[] args)
        {
            loggingBox("test loadded");
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int x = 0; x < kalibrasi_data.Length; x++)
            {
                kalibrasi_data[x] = 0;
                current_data[x] = 0;
            }

            foreach (String
                AvailableSerialPorts
                in
                System.IO.Ports.SerialPort.GetPortNames()
            )
            {
                ComboBox_AvailableSerialPorts.Items.Add(AvailableSerialPorts);
                ComboBox_AvailableSerialPorts.Text = AvailableSerialPorts;
                serialPort1.ReadTimeout = 2000;
                Button_Connect.Visible = true;
                Button_Disconnect.Visible = false;
                TextBox_ReceivedMessage.ScrollBars = ScrollBars.Vertical;
            }

            btnCD1.BackColor = chart1.Series[0].Color;
            btnCD2.BackColor = chart1.Series[1].Color;
            btnCD3.BackColor = chart1.Series[2].Color;
            btnCD4.BackColor = chart1.Series[3].Color;
            btnCD5.BackColor = chart1.Series[4].Color;
            btnCD6.BackColor = chart1.Series[5].Color;
            btnCD7.BackColor = chart1.Series[6].Color;
            btnCD8.BackColor = chart1.Series[7].Color;
            btnCD9.BackColor = chart1.Series[8].Color;
            btnCD10.BackColor = chart1.Series[9].Color;

        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            //if (fileName == "kosong")
            //{
            //    System.Windows.Forms.MessageBox.Show("Please input save log location.");
            //    return;
            //}
            try
            {
                serialPort1.PortName =
                (String)ComboBox_AvailableSerialPorts.SelectedItem;
            }
            catch (InvalidOperationException err)
            {
                System.Windows.Forms.MessageBox.Show("Port serial sedang digunakan oleh program lain. Invalid Operation");
                loggingBox("Port serial sedang digunakan oleh program lain. Invalid Operation");
                serialPort1.Close();
                return;
            }
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.Open();
                }
                catch (UnauthorizedAccessException err)
                {
                    System.Windows.Forms.MessageBox.Show("Port serial sedang digunakan oleh program lain. Unauthorized Access");
                    loggingBox("Port serial sedang digunakan oleh program lain. Unauthorized Access");
                    return;
                }

            }
            serialPort1.BaudRate = baudRate;

            //create_file_logging();
            Button_Connect.Visible = false;
            Button_Disconnect.Visible = true;
            timer1.Enabled = true;

            b_sw = 3;
            Start_timer.Visible = false;
            lastTime[0] = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        private void Button_Disconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
            Button_Connect.Visible = true;
            Button_Disconnect.Visible = false;
            timer1.Enabled = false;

            if (b_sw == 1)
            {
                b_sw = 0;
            }
            Start_timer.Visible = true;
        }

        private void Start_timer_Click(object sender, EventArgs e)
        {
            //if (fileName == "kosong")
            //{
            //    System.Windows.Forms.MessageBox.Show("Please input save log location.");
            //    return;
            //}
            serialPort1.BaudRate = baudRate;
            try
            {
                serialPort1.PortName =
                (String)ComboBox_AvailableSerialPorts.SelectedItem;
            }
            catch (InvalidOperationException)
            {
                System.Windows.Forms.MessageBox.Show("Port serial sedang digunakan oleh program lain. Invalid Operation");
                loggingBox("Port serial sedang digunakan oleh program lain. Invalid Operation");
                serialPort1.Close();
                return;
            }
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.Open();
                }
                catch (UnauthorizedAccessException)
                {
                    System.Windows.Forms.MessageBox.Show("Port serial sedang digunakan oleh program lain. Unauthorized Access");
                    loggingBox("Port serial sedang digunakan oleh program lain. Unauthorized Access");
                    return;
                }
            }
            //create_file_logging();
            sw.Start();
            b_sw = 1;
            timer1.Enabled = true;
            Start_timer.Visible = false;
            Button_Connect.Visible = false;
            Button_Disconnect.Visible = true;
            lastTime[0] = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        private void loggingBox(String data)
        {
            TextBox_ReceivedMessage.Text =
                        TextBox_ReceivedMessage.Text + data + Environment.NewLine;
            TextBox_ReceivedMessage.SelectionStart =
                TextBox_ReceivedMessage.TextLength;
            TextBox_ReceivedMessage.ScrollToCaret();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b_sw == 1)
            {
                try
                {
                    if (sw.ElapsedMilliseconds > (Int32.Parse(timeout.Text) * 1000))
                    {
                        b_sw = 0;
                        sw.Stop();
                        sw.Reset();
                        Start_timer.Visible = true;
                    }
                }
                catch (FormatException)
                {
                    b_sw = 0;
                    System.Windows.Forms.MessageBox.Show("Please input timeout value.");
                    loggingBox("Please input timeout value.");
                    return;
                }
            }

            if (b_sw == 0)
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Close();
                }
                Button_Connect.Visible = true;
                Button_Disconnect.Visible = false;
                timer1.Enabled = false;
                Start_timer.Visible = true;
            }
            if (serialPort1.IsOpen == true)
            {
                //read serial port
                try
                {
                    try
                    {
                        ReceivedMessage = serialPort1.ReadLine();
                    }
                    catch (TimeoutException)
                    {
                        loggingBox("Timeout");
                        return;
                        //long interval = lastTime[1] - lastTime[0];
                        //timer1.Stop();
                        //timer1.Interval = (int)interval + 10;
                        //timer1.Start();
                    }
                    //loggingBox(ReceivedMessage);

                }
                catch (IOException)
                {
                    loggingBox("Something wrong");
                    disconnect();
                    //long interval = lastTime[1] - lastTime[0];
                    //timer1.Interval = (int)interval + 1000;
                    //serialPort1.ReadTimeout = (int)interval + 1000;
                    return;
                }
                //last successfull receving data
                lastTime[0] = lastTime[1];
                lastTime[1] = DateTimeOffset.Now.ToUnixTimeMilliseconds();

                if (ReceivedMessage.First() == '~')
                {
                    //data filter
                    ReceivedMessage = ReceivedMessage.Replace("~", "");
                    ReceivedMessage = ReceivedMessage.Replace("#", "");
                    ReceivedMessage.Trim();

                    String[] dataReadline = ReceivedMessage.Split(' ');
                    if (dataReadline.Length != 10)
                    {
                        return;
                    }
                    for (int x = 0; x < 10; x++)
                    {
                        try
                        {
                            tmpdata3 = double.Parse(dataReadline[x]);
                            current_data[x] = tmpdata3 / 100;
                            //newtonData[x] = 0.0098 * (current_data[x] - kalibrasi_data[x]);
                            newtonData[x] = 0.0098 * (current_data[x]);
                        }
                        catch (FormatException) { return; }
                    }

                    //konversi ke newton

                    ////loggingBox(tmpdata2);
                    //tmpdata2 = null;

                    if (loggingState)
                    {
                        //logging
                        create_file_logging();
                        loggingData(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff"), newtonData);
                    }



                    //Thread t1 = new Thread(() => loggingData(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff"), dataReadline));
                    //t1.Start();

                    //for chart
                    chartingData(newtonData);
                }
            }
        }

        private void chartingData(double[] dataMasuk)
        {
            try
            {
                try
                {
                    //Array.Copy(data1, 1, data1, 0, data1.Length - 1);
                    //data1[data1.Length - 1] = double.Parse(dataReadline[0]);
                    //Array.Copy(data2, 1, data2, 0, data2.Length - 1);
                    //data2[data2.Length - 1] = double.Parse(dataReadline[1]);
                    //Array.Copy(data3, 1, data3, 0, data3.Length - 1);
                    //data3[data3.Length - 1] = double.Parse(dataReadline[2]);
                    //Array.Copy(data4, 1, data4, 0, data4.Length - 1);
                    //data4[data4.Length - 1] = double.Parse(dataReadline[3]);
                    //Array.Copy(data5, 1, data5, 0, data5.Length - 1);
                    //data5[data5.Length - 1] = double.Parse(dataReadline[4]);
                    //Array.Copy(data6, 1, data6, 0, data6.Length - 1);
                    //data6[data6.Length - 1] = double.Parse(dataReadline[5]);
                    //Array.Copy(data7, 1, data7, 0, data7.Length - 1);
                    //data7[data7.Length - 1] = double.Parse(dataReadline[6]);
                    //Array.Copy(data8, 1, data8, 0, data8.Length - 1);
                    //data8[data8.Length - 1] = double.Parse(dataReadline[7]);
                    //Array.Copy(data9, 1, data9, 0, data9.Length - 1);
                    //data9[data9.Length - 1] = double.Parse(dataReadline[8]);
                    //Array.Copy(data10, 1, data10, 0, data10.Length - 1);
                    //data10[data10.Length - 1] = double.Parse(dataReadline[9]);

                    Array.Copy(data1, 1, data1, 0, data1.Length - 1);
                    data1[data1.Length - 1] = dataMasuk[0];
                    Array.Copy(data2, 1, data2, 0, data2.Length - 1);
                    data2[data2.Length - 1] = dataMasuk[1];
                    Array.Copy(data3, 1, data3, 0, data3.Length - 1);
                    data3[data3.Length - 1] = dataMasuk[2];
                    Array.Copy(data4, 1, data4, 0, data4.Length - 1);
                    data4[data4.Length - 1] = dataMasuk[3];
                    Array.Copy(data5, 1, data5, 0, data5.Length - 1);
                    data5[data5.Length - 1] = dataMasuk[4];
                    Array.Copy(data6, 1, data6, 0, data6.Length - 1);
                    data6[data6.Length - 1] = dataMasuk[5];
                    Array.Copy(data7, 1, data7, 0, data7.Length - 1);
                    data7[data7.Length - 1] = dataMasuk[6];
                    Array.Copy(data8, 1, data8, 0, data8.Length - 1);
                    data8[data8.Length - 1] = dataMasuk[7];
                    Array.Copy(data9, 1, data9, 0, data9.Length - 1);
                    data9[data9.Length - 1] = dataMasuk[8];
                    Array.Copy(data10, 1, data10, 0, data10.Length - 1);
                    data10[data10.Length - 1] = dataMasuk[9];
                }
                catch (FormatException)
                {
                    return;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            chart1.Series[0].Points.DataBindY(data1);
            chart1.Series[1].Points.DataBindY(data2);
            chart1.Series[2].Points.DataBindY(data3);
            chart1.Series[3].Points.DataBindY(data4);
            chart1.Series[4].Points.DataBindY(data5);
            chart1.Series[5].Points.DataBindY(data6);
            chart1.Series[6].Points.DataBindY(data7);
            chart1.Series[7].Points.DataBindY(data8);
            chart1.Series[8].Points.DataBindY(data9);
            chart1.Series[9].Points.DataBindY(data10);
        }

        private void loggingData(String time, double[] dataMasuk)
        {
            if (namaFile.Text == "" || namaFile.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Mohon isi nama file terlebih dahulu");
                loggingBox("Mohon isi nama file terlebih dahulu");
                chkLogging.Checked = false;
                loggingState = false;
                return;
            }
            if (fileName == "kosong" || fileName == null || fileName == "")
            {
                System.Windows.Forms.MessageBox.Show("Mohon buka folder simpan file");
                loggingBox("Mohon buka folder simpan file");
                chkLogging.Checked = false;
                loggingState = false;
                return;
            }
            //Logging v2 to excel, basically still txt lol
            tmpdata += "<tr>";
            tmpdata += "<td>";
            tmpdata += time;
            //tmpdata += DateTime.Now.ToString();
            tmpdata += "</td>";
            //foreach (String x in dataReadline)
            //{
            //    tmpdata += "<td>";
            //    tmpdata += x;
            //    tmpdata += "</td>";
            //}
            for (int x = 0; x < 10; x++)
            {
                tmpdata += "<td>";
                tmpdata += dataMasuk[x];
                tmpdata += "</td>";
            }
            tmpdata += "</tr>";

            //write to nextline file
            try
            {
                try
                {
                    try
                    {
                        File.AppendAllText(fileName, tmpdata);
                    }
                    catch (System.ArgumentException)
                    {

                        chkLogging.Checked = false;
                        loggingState = false;
                        loggingBox("Mohon gunakan aturan penamaan file dengan benar");
                        System.Windows.Forms.MessageBox.Show("Mohon gunakan aturan penamaan file dengan benar");
                        return;
                    }

                }
                catch (UnauthorizedAccessException)
                {

                    chkLogging.Checked = false;
                    loggingState = false;
                    loggingBox("Ada yang salah, sepertinya anda belum memasukan folder logging.");
                    System.Windows.Forms.MessageBox.Show("Ada yang salah, sepertinya anda belum memasukan folder logging.");
                    return;
                }
            }
            catch (IOException)
            {
                chkLogging.Checked = false;
                loggingState = false;
                loggingBox("Ada yang salah, sepertinya file diakses oleh program lain.");
                return;
            }


            //clear the tmp data
            tmpdata = null;
        }

        private void D1_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Enabled == true)
            {
                chart1.Series[0].Enabled = false;
                D1_toggle.Text = "D1 Disabled";
            }
            else
            {
                chart1.Series[0].Enabled = true;
                D1_toggle.Text = "D1 Enabled";
            }
        }

        private void D2_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[1].Enabled == true)
            {
                chart1.Series[1].Enabled = false;
                D2_toggle.Text = "D2 Disabled";
            }
            else
            {
                chart1.Series[1].Enabled = true;
                D2_toggle.Text = "D2 Enabled";
            }
        }

        private void D3_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[2].Enabled == true)
            {
                chart1.Series[2].Enabled = false;
                D3_toggle.Text = "D3 Disabled";
            }
            else
            {
                chart1.Series[2].Enabled = true;
                D3_toggle.Text = "D3 Enabled";
            }
        }

        private void D4_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[3].Enabled == true)
            {
                chart1.Series[3].Enabled = false;
                D4_toggle.Text = "D4 Disabled";
            }
            else
            {
                chart1.Series[3].Enabled = true;
                D4_toggle.Text = "D4 Enabled";
            }
        }

        private void D5_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[4].Enabled == true)
            {
                chart1.Series[4].Enabled = false;
                D5_toggle.Text = "D5 Disabled";
            }
            else
            {
                chart1.Series[4].Enabled = true;
                D5_toggle.Text = "D5 Enabled";
            }
        }

        private void D6_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[5].Enabled == true)
            {
                chart1.Series[5].Enabled = false;
                D6_toggle.Text = "D6 Disabled";
            }
            else
            {
                chart1.Series[5].Enabled = true;
                D6_toggle.Text = "D6 Enabled";
            }
        }

        private void D7_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[6].Enabled == true)
            {
                chart1.Series[6].Enabled = false;
                D7_toggle.Text = "D7 Disabled";
            }
            else
            {
                chart1.Series[6].Enabled = true;
                D7_toggle.Text = "D7 Enabled";
            }
        }

        private void D8_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[7].Enabled == true)
            {
                chart1.Series[7].Enabled = false;
                D8_toggle.Text = "D8 Disabled";
            }
            else
            {
                chart1.Series[7].Enabled = true;
                D8_toggle.Text = "D8 Enabled";
            }
        }

        private void D9_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[8].Enabled == true)
            {
                chart1.Series[8].Enabled = false;
                D9_toggle.Text = "D9 Disabled";
            }
            else
            {
                chart1.Series[8].Enabled = true;
                D9_toggle.Text = "D9 Enabled";
            }
        }

        private void D10_toggle_Click(object sender, EventArgs e)
        {
            if (chart1.Series[9].Enabled == true)
            {
                chart1.Series[9].Enabled = false;
                D10_toggle.Text = "D10 Disabled";
            }
            else
            {
                chart1.Series[9].Enabled = true;
                D10_toggle.Text = "D10 Enabled";
            }
        }

        private void timeout_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (namaFile.Text == "" || namaFile.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Mohon isi nama file terlebih dahulu");
                loggingBox("Mohon isi nama file terlebih dahulu");
                return;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath.Text = folderBrowserDialog1.SelectedPath;
                namaFile.Text.Trim();
                fileName = savePath.Text + @"\" + namaFile.Text + @".xls";

                //create_file_logging();
            }
        }

        private void btnBukaLog_Click(object sender, EventArgs e)
        {
            if(chkLogging.Checked)
            {

                System.Windows.Forms.MessageBox.Show("Matikan terlebih dahulu loggingnya");
                loggingBox("Matikan terlebih dahulu loggingnya");
                return;
            }
            if (namaFile.Text == "" || namaFile.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Mohon isi nama file terlebih dahulu");
                loggingBox("Mohon isi nama file terlebih dahulu");
                return;
            }
            if (fileName == "kosong" || fileName == null)
            {
                System.Windows.Forms.MessageBox.Show("Mohon buka folder simpan file");
                loggingBox("Mohon buka folder simpan file");
                return;
            }
            try { Process.Start(fileName); }
            catch (System.ComponentModel.Win32Exception)
            {
                System.Windows.Forms.MessageBox.Show("File tidak ditemukan");
                loggingBox("File tidak ditemukan");
                return;
            }

        }

        private void namaFile_TextChanged(object sender, EventArgs e)
        {
            fileName = savePath.Text + @"\" + namaFile.Text + @".xls";
        }

        ColorDialog color1 = new ColorDialog();
        ColorDialog color2 = new ColorDialog();
        ColorDialog color3 = new ColorDialog();
        ColorDialog color4 = new ColorDialog();
        ColorDialog color5 = new ColorDialog();
        ColorDialog color6 = new ColorDialog();
        ColorDialog color7 = new ColorDialog();
        ColorDialog color8 = new ColorDialog();
        ColorDialog color9 = new ColorDialog();
        ColorDialog color10 = new ColorDialog();

        private void btnCD1_Click(object sender, EventArgs e)
        {
            if (color1.ShowDialog() == DialogResult.OK)
            {
                btnCD1.BackColor = color1.Color;
                chart1.Series[0].Color = color1.Color;
            }
        }

        private void btnCD2_Click(object sender, EventArgs e)
        {
            if (color2.ShowDialog() == DialogResult.OK)
            {
                btnCD2.BackColor = color2.Color;
                chart1.Series[1].Color = color2.Color;
            }
        }

        private void btnCD3_Click(object sender, EventArgs e)
        {
            if (color3.ShowDialog() == DialogResult.OK)
            {
                btnCD3.BackColor = color3.Color;
                chart1.Series[2].Color = color3.Color;
            }
        }

        private void btnCD4_Click(object sender, EventArgs e)
        {
            if (color4.ShowDialog() == DialogResult.OK)
            {
                btnCD4.BackColor = color4.Color;
                chart1.Series[3].Color = color4.Color;
            }
        }

        private void btnCD5_Click(object sender, EventArgs e)
        {
            if (color5.ShowDialog() == DialogResult.OK)
            {
                btnCD5.BackColor = color5.Color;
                chart1.Series[4].Color = color5.Color;
            }
        }

        private void btnCD6_Click(object sender, EventArgs e)
        {
            if (color6.ShowDialog() == DialogResult.OK)
            {
                btnCD6.BackColor = color6.Color;
                chart1.Series[5].Color = color6.Color;
            }
        }

        private void btnCD7_Click(object sender, EventArgs e)
        {
            if (color7.ShowDialog() == DialogResult.OK)
            {
                btnCD7.BackColor = color7.Color;
                chart1.Series[6].Color = color7.Color;
            }
        }

        private void btnCD8_Click(object sender, EventArgs e)
        {
            if (color8.ShowDialog() == DialogResult.OK)
            {
                btnCD8.BackColor = color8.Color;
                chart1.Series[7].Color = color8.Color;
            }
        }

        private void btnCD9_Click(object sender, EventArgs e)
        {
            if (color9.ShowDialog() == DialogResult.OK)
            {
                btnCD9.BackColor = color9.Color;
                chart1.Series[8].Color = color9.Color;
            }
        }

        private void btnCD10_Click(object sender, EventArgs e)
        {
            if (color10.ShowDialog() == DialogResult.OK)
            {
                btnCD10.BackColor = color10.Color;
                chart1.Series[9].Color = color10.Color;
            }
        }

        public void create_file_logging()
        {
            if (namaFile.Text == "" || namaFile.Text == null)
            {
                chkLogging.Checked = false;
                loggingState = false;
                //System.Windows.Forms.MessageBox.Show("Mohon isi nama file terlebih dahulu");
                loggingBox("Mohon isi nama file terlebih dahulu");
                return;
            }
            if (fileName == "kosong" || fileName == null || savePath.Text == "" || savePath.Text == null)
            {
                chkLogging.Checked = false;
                loggingState = false;
                //System.Windows.Forms.MessageBox.Show("Mohon buka folder simpan file");
                loggingBox("Mohon buka folder simpan file");
                return;
            }
            // Check if file logging not exists. If yes, create it.
            if (!File.Exists(fileName))
            {
                try
                {
                    try
                    {
                        // Create a new file     
                        using (FileStream fs = File.Create(fileName))
                        {
                            // Add some text to file    
                            //Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                            //fs.Write(title, 0, title.Length);
                            //byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                            //fs.Write(author, 0, author.Length);

                            //Logging v2
                            byte[] table = new UTF8Encoding(true).GetBytes("<table>");
                            fs.Write(table, 0, table.Length);
                            byte[] tablehead = new UTF8Encoding(true).GetBytes("<tr><th>Time</th><th>Data 1</th><th>Data 2</th><th>Data 3</th><th>Data 4</th><th>Data 5</th><th>Data 6</th><th>Data 7</th><th>Data 8</th><th>Data 9</th><th>Data 10</th></tr>");
                            fs.Write(tablehead, 0, tablehead.Length);
                        }
                    }
                    catch (System.ArgumentException)
                    {
                        chkLogging.Checked = false;
                        loggingState = false;
                        System.Windows.Forms.MessageBox.Show("Mohon gunakan aturan penamaan file dengan benar");
                        loggingBox("Mohon gunakan aturan penamaan file dengan benar");
                        return;
                    }

                }
                catch (UnauthorizedAccessException)
                {
                    chkLogging.Checked = false;
                    loggingState = false;
                    System.Windows.Forms.MessageBox.Show("Mohon masukan folder terlebih dahulu untuk penyimpanan file");
                    loggingBox("Mohon masukan folder terlebih dahulu untuk penyimpanan file");
                    return;
                }

            }
        }
    }
}
