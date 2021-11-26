
namespace Multitech_1._0._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFormKalibrasi = new System.Windows.Forms.Button();
            this.chkLogging = new System.Windows.Forms.CheckBox();
            this.btnBukaLog = new System.Windows.Forms.Button();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.btnReZero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeout = new System.Windows.Forms.TextBox();
            this.Start_timer = new System.Windows.Forms.Button();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Button_Disconnect = new System.Windows.Forms.Button();
            this.ComboBox_AvailableSerialPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextBox_ReceivedMessage = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.D1_toggle = new System.Windows.Forms.Button();
            this.D2_toggle = new System.Windows.Forms.Button();
            this.D3_toggle = new System.Windows.Forms.Button();
            this.D4_toggle = new System.Windows.Forms.Button();
            this.D5_toggle = new System.Windows.Forms.Button();
            this.D6_toggle = new System.Windows.Forms.Button();
            this.D7_toggle = new System.Windows.Forms.Button();
            this.D8_toggle = new System.Windows.Forms.Button();
            this.D9_toggle = new System.Windows.Forms.Button();
            this.D10_toggle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.namaFile = new System.Windows.Forms.TextBox();
            this.Btn_save = new System.Windows.Forms.Button();
            this.savePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorD1 = new System.Windows.Forms.ColorDialog();
            this.btnCD1 = new System.Windows.Forms.Button();
            this.btnCD2 = new System.Windows.Forms.Button();
            this.btnCD3 = new System.Windows.Forms.Button();
            this.btnCD4 = new System.Windows.Forms.Button();
            this.btnCD5 = new System.Windows.Forms.Button();
            this.btnCD6 = new System.Windows.Forms.Button();
            this.btnCD7 = new System.Windows.Forms.Button();
            this.btnCD8 = new System.Windows.Forms.Button();
            this.btnCD9 = new System.Windows.Forms.Button();
            this.btnCD10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFormKalibrasi);
            this.groupBox1.Controls.Add(this.chkLogging);
            this.groupBox1.Controls.Add(this.btnBukaLog);
            this.groupBox1.Controls.Add(this.btnClearChart);
            this.groupBox1.Controls.Add(this.btnReZero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.timeout);
            this.groupBox1.Controls.Add(this.Start_timer);
            this.groupBox1.Controls.Add(this.Button_Connect);
            this.groupBox1.Controls.Add(this.Button_Disconnect);
            this.groupBox1.Controls.Add(this.ComboBox_AvailableSerialPorts);
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrol alat";
            // 
            // btnFormKalibrasi
            // 
            this.btnFormKalibrasi.Location = new System.Drawing.Point(652, 18);
            this.btnFormKalibrasi.Name = "btnFormKalibrasi";
            this.btnFormKalibrasi.Size = new System.Drawing.Size(75, 23);
            this.btnFormKalibrasi.TabIndex = 10;
            this.btnFormKalibrasi.Text = "Kalibrasi";
            this.btnFormKalibrasi.UseVisualStyleBackColor = true;
            this.btnFormKalibrasi.Click += new System.EventHandler(this.btnFormKalibrasi_Click);
            // 
            // chkLogging
            // 
            this.chkLogging.AutoSize = true;
            this.chkLogging.Location = new System.Drawing.Point(582, 24);
            this.chkLogging.Name = "chkLogging";
            this.chkLogging.Size = new System.Drawing.Size(64, 17);
            this.chkLogging.TabIndex = 9;
            this.chkLogging.Text = "Logging";
            this.chkLogging.UseVisualStyleBackColor = true;
            this.chkLogging.CheckedChanged += new System.EventHandler(this.chkLogging_CheckedChanged);
            // 
            // btnBukaLog
            // 
            this.btnBukaLog.Location = new System.Drawing.Point(501, 19);
            this.btnBukaLog.Name = "btnBukaLog";
            this.btnBukaLog.Size = new System.Drawing.Size(75, 23);
            this.btnBukaLog.TabIndex = 8;
            this.btnBukaLog.Text = "Buka Log";
            this.btnBukaLog.UseVisualStyleBackColor = true;
            this.btnBukaLog.Click += new System.EventHandler(this.btnBukaLog_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(451, 19);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(44, 23);
            this.btnClearChart.TabIndex = 7;
            this.btnClearChart.Text = "Clear";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // btnReZero
            // 
            this.btnReZero.Location = new System.Drawing.Point(401, 19);
            this.btnReZero.Name = "btnReZero";
            this.btnReZero.Size = new System.Drawing.Size(44, 23);
            this.btnReZero.TabIndex = 6;
            this.btnReZero.Text = "Zero";
            this.btnReZero.UseVisualStyleBackColor = true;
            this.btnReZero.Click += new System.EventHandler(this.btnReZero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "second";
            // 
            // timeout
            // 
            this.timeout.Location = new System.Drawing.Point(291, 20);
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(56, 20);
            this.timeout.TabIndex = 4;
            this.timeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeout_KeyPress_1);
            // 
            // Start_timer
            // 
            this.Start_timer.Location = new System.Drawing.Point(210, 19);
            this.Start_timer.Name = "Start_timer";
            this.Start_timer.Size = new System.Drawing.Size(75, 23);
            this.Start_timer.TabIndex = 3;
            this.Start_timer.Text = "Record for";
            this.Start_timer.UseVisualStyleBackColor = true;
            this.Start_timer.Click += new System.EventHandler(this.Start_timer_Click);
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(146, 19);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(58, 23);
            this.Button_Connect.TabIndex = 2;
            this.Button_Connect.Text = "Record";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Button_Disconnect
            // 
            this.Button_Disconnect.Location = new System.Drawing.Point(86, 19);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(54, 23);
            this.Button_Disconnect.TabIndex = 1;
            this.Button_Disconnect.Text = "Stop";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // ComboBox_AvailableSerialPorts
            // 
            this.ComboBox_AvailableSerialPorts.FormattingEnabled = true;
            this.ComboBox_AvailableSerialPorts.Location = new System.Drawing.Point(7, 20);
            this.ComboBox_AvailableSerialPorts.Name = "ComboBox_AvailableSerialPorts";
            this.ComboBox_AvailableSerialPorts.Size = new System.Drawing.Size(73, 21);
            this.ComboBox_AvailableSerialPorts.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM8";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextBox_ReceivedMessage
            // 
            this.TextBox_ReceivedMessage.Location = new System.Drawing.Point(130, 133);
            this.TextBox_ReceivedMessage.Multiline = true;
            this.TextBox_ReceivedMessage.Name = "TextBox_ReceivedMessage";
            this.TextBox_ReceivedMessage.Size = new System.Drawing.Size(658, 53);
            this.TextBox_ReceivedMessage.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(130, 193);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Data1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Data2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Yellow;
            series3.Legend = "Legend1";
            series3.Name = "Data3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Lime;
            series4.Legend = "Legend1";
            series4.Name = "Data4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Cyan;
            series5.Legend = "Legend1";
            series5.Name = "Data5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Data6";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Fuchsia;
            series7.Legend = "Legend1";
            series7.Name = "Data7";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series8.Legend = "Legend1";
            series8.Name = "Data8";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series9.Legend = "Legend1";
            series9.Name = "Data9";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series10.Legend = "Legend1";
            series10.Name = "Data10";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(658, 373);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // D1_toggle
            // 
            this.D1_toggle.Location = new System.Drawing.Point(13, 133);
            this.D1_toggle.Name = "D1_toggle";
            this.D1_toggle.Size = new System.Drawing.Size(85, 23);
            this.D1_toggle.TabIndex = 3;
            this.D1_toggle.Text = "D1 Enabled";
            this.D1_toggle.UseVisualStyleBackColor = true;
            this.D1_toggle.Click += new System.EventHandler(this.D1_toggle_Click);
            // 
            // D2_toggle
            // 
            this.D2_toggle.Location = new System.Drawing.Point(13, 163);
            this.D2_toggle.Name = "D2_toggle";
            this.D2_toggle.Size = new System.Drawing.Size(85, 23);
            this.D2_toggle.TabIndex = 4;
            this.D2_toggle.Text = "D2 Enabled";
            this.D2_toggle.UseVisualStyleBackColor = true;
            this.D2_toggle.Click += new System.EventHandler(this.D2_toggle_Click);
            // 
            // D3_toggle
            // 
            this.D3_toggle.Location = new System.Drawing.Point(13, 193);
            this.D3_toggle.Name = "D3_toggle";
            this.D3_toggle.Size = new System.Drawing.Size(85, 23);
            this.D3_toggle.TabIndex = 5;
            this.D3_toggle.Text = "D3 Enabled";
            this.D3_toggle.UseVisualStyleBackColor = true;
            this.D3_toggle.Click += new System.EventHandler(this.D3_toggle_Click);
            // 
            // D4_toggle
            // 
            this.D4_toggle.Location = new System.Drawing.Point(13, 223);
            this.D4_toggle.Name = "D4_toggle";
            this.D4_toggle.Size = new System.Drawing.Size(85, 23);
            this.D4_toggle.TabIndex = 6;
            this.D4_toggle.Text = "D4 Enabled";
            this.D4_toggle.UseVisualStyleBackColor = true;
            this.D4_toggle.Click += new System.EventHandler(this.D4_toggle_Click);
            // 
            // D5_toggle
            // 
            this.D5_toggle.Location = new System.Drawing.Point(13, 253);
            this.D5_toggle.Name = "D5_toggle";
            this.D5_toggle.Size = new System.Drawing.Size(85, 23);
            this.D5_toggle.TabIndex = 7;
            this.D5_toggle.Text = "D5 Enabled";
            this.D5_toggle.UseVisualStyleBackColor = true;
            this.D5_toggle.Click += new System.EventHandler(this.D5_toggle_Click);
            // 
            // D6_toggle
            // 
            this.D6_toggle.Location = new System.Drawing.Point(13, 283);
            this.D6_toggle.Name = "D6_toggle";
            this.D6_toggle.Size = new System.Drawing.Size(85, 23);
            this.D6_toggle.TabIndex = 8;
            this.D6_toggle.Text = "D6 Enabled";
            this.D6_toggle.UseVisualStyleBackColor = true;
            this.D6_toggle.Click += new System.EventHandler(this.D6_toggle_Click);
            // 
            // D7_toggle
            // 
            this.D7_toggle.Location = new System.Drawing.Point(13, 313);
            this.D7_toggle.Name = "D7_toggle";
            this.D7_toggle.Size = new System.Drawing.Size(85, 23);
            this.D7_toggle.TabIndex = 9;
            this.D7_toggle.Text = "D7 Enabled";
            this.D7_toggle.UseVisualStyleBackColor = true;
            this.D7_toggle.Click += new System.EventHandler(this.D7_toggle_Click);
            // 
            // D8_toggle
            // 
            this.D8_toggle.Location = new System.Drawing.Point(13, 343);
            this.D8_toggle.Name = "D8_toggle";
            this.D8_toggle.Size = new System.Drawing.Size(85, 23);
            this.D8_toggle.TabIndex = 10;
            this.D8_toggle.Text = "D8 Enabled";
            this.D8_toggle.UseVisualStyleBackColor = true;
            this.D8_toggle.Click += new System.EventHandler(this.D8_toggle_Click);
            // 
            // D9_toggle
            // 
            this.D9_toggle.Location = new System.Drawing.Point(13, 373);
            this.D9_toggle.Name = "D9_toggle";
            this.D9_toggle.Size = new System.Drawing.Size(85, 23);
            this.D9_toggle.TabIndex = 11;
            this.D9_toggle.Text = "D9 Enabled";
            this.D9_toggle.UseVisualStyleBackColor = true;
            this.D9_toggle.Click += new System.EventHandler(this.D9_toggle_Click);
            // 
            // D10_toggle
            // 
            this.D10_toggle.Location = new System.Drawing.Point(13, 403);
            this.D10_toggle.Name = "D10_toggle";
            this.D10_toggle.Size = new System.Drawing.Size(85, 23);
            this.D10_toggle.TabIndex = 12;
            this.D10_toggle.Text = "D10 Enabled";
            this.D10_toggle.UseVisualStyleBackColor = true;
            this.D10_toggle.Click += new System.EventHandler(this.D10_toggle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.namaFile);
            this.groupBox2.Controls.Add(this.Btn_save);
            this.groupBox2.Controls.Add(this.savePath);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lokasi folder dan nama file";
            // 
            // namaFile
            // 
            this.namaFile.Location = new System.Drawing.Point(489, 20);
            this.namaFile.Name = "namaFile";
            this.namaFile.Size = new System.Drawing.Size(202, 20);
            this.namaFile.TabIndex = 2;
            this.namaFile.Tag = "Nama file";
            this.namaFile.TextChanged += new System.EventHandler(this.namaFile_TextChanged);
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(694, 15);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 28);
            this.Btn_save.TabIndex = 1;
            this.Btn_save.Text = "Browse";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(7, 20);
            this.savePath.Name = "savePath";
            this.savePath.ReadOnly = true;
            this.savePath.Size = new System.Drawing.Size(476, 20);
            this.savePath.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCD1
            // 
            this.btnCD1.BackColor = System.Drawing.Color.Transparent;
            this.btnCD1.Location = new System.Drawing.Point(104, 133);
            this.btnCD1.Name = "btnCD1";
            this.btnCD1.Size = new System.Drawing.Size(20, 23);
            this.btnCD1.TabIndex = 14;
            this.btnCD1.UseVisualStyleBackColor = false;
            this.btnCD1.Click += new System.EventHandler(this.btnCD1_Click);
            // 
            // btnCD2
            // 
            this.btnCD2.Location = new System.Drawing.Point(104, 162);
            this.btnCD2.Name = "btnCD2";
            this.btnCD2.Size = new System.Drawing.Size(20, 23);
            this.btnCD2.TabIndex = 15;
            this.btnCD2.UseVisualStyleBackColor = true;
            this.btnCD2.Click += new System.EventHandler(this.btnCD2_Click);
            // 
            // btnCD3
            // 
            this.btnCD3.Location = new System.Drawing.Point(104, 193);
            this.btnCD3.Name = "btnCD3";
            this.btnCD3.Size = new System.Drawing.Size(20, 23);
            this.btnCD3.TabIndex = 16;
            this.btnCD3.UseVisualStyleBackColor = true;
            this.btnCD3.Click += new System.EventHandler(this.btnCD3_Click);
            // 
            // btnCD4
            // 
            this.btnCD4.Location = new System.Drawing.Point(104, 223);
            this.btnCD4.Name = "btnCD4";
            this.btnCD4.Size = new System.Drawing.Size(20, 23);
            this.btnCD4.TabIndex = 17;
            this.btnCD4.UseVisualStyleBackColor = true;
            this.btnCD4.Click += new System.EventHandler(this.btnCD4_Click);
            // 
            // btnCD5
            // 
            this.btnCD5.Location = new System.Drawing.Point(104, 253);
            this.btnCD5.Name = "btnCD5";
            this.btnCD5.Size = new System.Drawing.Size(20, 23);
            this.btnCD5.TabIndex = 18;
            this.btnCD5.UseVisualStyleBackColor = true;
            this.btnCD5.Click += new System.EventHandler(this.btnCD5_Click);
            // 
            // btnCD6
            // 
            this.btnCD6.Location = new System.Drawing.Point(104, 283);
            this.btnCD6.Name = "btnCD6";
            this.btnCD6.Size = new System.Drawing.Size(20, 23);
            this.btnCD6.TabIndex = 19;
            this.btnCD6.UseVisualStyleBackColor = true;
            this.btnCD6.Click += new System.EventHandler(this.btnCD6_Click);
            // 
            // btnCD7
            // 
            this.btnCD7.Location = new System.Drawing.Point(104, 313);
            this.btnCD7.Name = "btnCD7";
            this.btnCD7.Size = new System.Drawing.Size(20, 23);
            this.btnCD7.TabIndex = 20;
            this.btnCD7.UseVisualStyleBackColor = true;
            this.btnCD7.Click += new System.EventHandler(this.btnCD7_Click);
            // 
            // btnCD8
            // 
            this.btnCD8.Location = new System.Drawing.Point(104, 343);
            this.btnCD8.Name = "btnCD8";
            this.btnCD8.Size = new System.Drawing.Size(20, 23);
            this.btnCD8.TabIndex = 21;
            this.btnCD8.UseVisualStyleBackColor = true;
            this.btnCD8.Click += new System.EventHandler(this.btnCD8_Click);
            // 
            // btnCD9
            // 
            this.btnCD9.Location = new System.Drawing.Point(104, 373);
            this.btnCD9.Name = "btnCD9";
            this.btnCD9.Size = new System.Drawing.Size(20, 23);
            this.btnCD9.TabIndex = 22;
            this.btnCD9.UseVisualStyleBackColor = true;
            this.btnCD9.Click += new System.EventHandler(this.btnCD9_Click);
            // 
            // btnCD10
            // 
            this.btnCD10.Location = new System.Drawing.Point(104, 403);
            this.btnCD10.Name = "btnCD10";
            this.btnCD10.Size = new System.Drawing.Size(20, 23);
            this.btnCD10.TabIndex = 23;
            this.btnCD10.UseVisualStyleBackColor = true;
            this.btnCD10.Click += new System.EventHandler(this.btnCD10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.btnCD10);
            this.Controls.Add(this.btnCD9);
            this.Controls.Add(this.btnCD8);
            this.Controls.Add(this.btnCD7);
            this.Controls.Add(this.btnCD6);
            this.Controls.Add(this.btnCD5);
            this.Controls.Add(this.btnCD4);
            this.Controls.Add(this.btnCD3);
            this.Controls.Add(this.btnCD2);
            this.Controls.Add(this.btnCD1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.D10_toggle);
            this.Controls.Add(this.D9_toggle);
            this.Controls.Add(this.D8_toggle);
            this.Controls.Add(this.D7_toggle);
            this.Controls.Add(this.D6_toggle);
            this.Controls.Add(this.D5_toggle);
            this.Controls.Add(this.D4_toggle);
            this.Controls.Add(this.D3_toggle);
            this.Controls.Add(this.D2_toggle);
            this.Controls.Add(this.D1_toggle);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.TextBox_ReceivedMessage);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Load Cell Multitek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.Button Button_Disconnect;
        private System.Windows.Forms.ComboBox ComboBox_AvailableSerialPorts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TextBox_ReceivedMessage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Start_timer;
        private System.Windows.Forms.Button D1_toggle;
        private System.Windows.Forms.Button D2_toggle;
        private System.Windows.Forms.Button D3_toggle;
        private System.Windows.Forms.Button D4_toggle;
        private System.Windows.Forms.Button D5_toggle;
        private System.Windows.Forms.Button D6_toggle;
        private System.Windows.Forms.Button D7_toggle;
        private System.Windows.Forms.Button D8_toggle;
        private System.Windows.Forms.Button D9_toggle;
        private System.Windows.Forms.Button D10_toggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnReZero;
        private System.Windows.Forms.TextBox namaFile;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.Button btnBukaLog;
        private System.Windows.Forms.CheckBox chkLogging;
        private System.Windows.Forms.ColorDialog colorD1;
        private System.Windows.Forms.Button btnCD1;
        private System.Windows.Forms.Button btnCD2;
        private System.Windows.Forms.Button btnCD3;
        private System.Windows.Forms.Button btnCD4;
        private System.Windows.Forms.Button btnCD5;
        private System.Windows.Forms.Button btnCD6;
        private System.Windows.Forms.Button btnCD7;
        private System.Windows.Forms.Button btnCD8;
        private System.Windows.Forms.Button btnCD9;
        private System.Windows.Forms.Button btnCD10;
        private System.Windows.Forms.Button btnFormKalibrasi;
        internal System.IO.Ports.SerialPort serialPort1;
    }
}

