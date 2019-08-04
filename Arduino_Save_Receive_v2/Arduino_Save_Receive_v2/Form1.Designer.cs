namespace Arduino_Save_Receive_v2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.out_lbl = new System.Windows.Forms.Label();
            this.set_lbl = new System.Windows.Forms.Label();
            this.val_lbl = new System.Windows.Forms.Label();
            this.temp_out_lbl = new System.Windows.Forms.Label();
            this.temp_set_lbl = new System.Windows.Forms.Label();
            this.temp_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.data_tb = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.p_tb = new System.Windows.Forms.RichTextBox();
            this.i_tb = new System.Windows.Forms.RichTextBox();
            this.d_tb = new System.Windows.Forms.RichTextBox();
            this.d_tb_temp = new System.Windows.Forms.RichTextBox();
            this.i_tb_temp = new System.Windows.Forms.RichTextBox();
            this.p_tb_temp = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.port_name_tb = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.sendflow_tb = new System.Windows.Forms.RichTextBox();
            this.sendtemp_tb = new System.Windows.Forms.RichTextBox();
            this.Control_radio = new System.Windows.Forms.RadioButton();
            this.Regulation_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Yes_radio = new System.Windows.Forms.RadioButton();
            this.No_radio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.interval1_to = new System.Windows.Forms.RichTextBox();
            this.interval2_to = new System.Windows.Forms.RichTextBox();
            this.interval3_to = new System.Windows.Forms.RichTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.interval3_set_flow = new System.Windows.Forms.RichTextBox();
            this.interval2_set_flow = new System.Windows.Forms.RichTextBox();
            this.interval1_set_flow = new System.Windows.Forms.RichTextBox();
            this.interval3_set_temp = new System.Windows.Forms.RichTextBox();
            this.interval2_set_temp = new System.Windows.Forms.RichTextBox();
            this.interval1_set_temp = new System.Windows.Forms.RichTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.baud_tb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.info_btn = new System.Windows.Forms.Button();
            this.verzeichnis_tb = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.manual_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actual Out1 Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actual Out1 Set Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actual Out1 Outpt Value:";
            // 
            // out_lbl
            // 
            this.out_lbl.AutoSize = true;
            this.out_lbl.Location = new System.Drawing.Point(167, 313);
            this.out_lbl.Name = "out_lbl";
            this.out_lbl.Size = new System.Drawing.Size(0, 13);
            this.out_lbl.TabIndex = 5;
            // 
            // set_lbl
            // 
            this.set_lbl.AutoSize = true;
            this.set_lbl.Location = new System.Drawing.Point(167, 290);
            this.set_lbl.Name = "set_lbl";
            this.set_lbl.Size = new System.Drawing.Size(0, 13);
            this.set_lbl.TabIndex = 4;
            // 
            // val_lbl
            // 
            this.val_lbl.AutoSize = true;
            this.val_lbl.Location = new System.Drawing.Point(167, 268);
            this.val_lbl.Name = "val_lbl";
            this.val_lbl.Size = new System.Drawing.Size(0, 13);
            this.val_lbl.TabIndex = 3;
            // 
            // temp_out_lbl
            // 
            this.temp_out_lbl.AutoSize = true;
            this.temp_out_lbl.Location = new System.Drawing.Point(409, 313);
            this.temp_out_lbl.Name = "temp_out_lbl";
            this.temp_out_lbl.Size = new System.Drawing.Size(0, 13);
            this.temp_out_lbl.TabIndex = 11;
            // 
            // temp_set_lbl
            // 
            this.temp_set_lbl.AutoSize = true;
            this.temp_set_lbl.Location = new System.Drawing.Point(408, 290);
            this.temp_set_lbl.Name = "temp_set_lbl";
            this.temp_set_lbl.Size = new System.Drawing.Size(0, 13);
            this.temp_set_lbl.TabIndex = 10;
            // 
            // temp_lbl
            // 
            this.temp_lbl.AutoSize = true;
            this.temp_lbl.Location = new System.Drawing.Point(408, 268);
            this.temp_lbl.Name = "temp_lbl";
            this.temp_lbl.Size = new System.Drawing.Size(0, 13);
            this.temp_lbl.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Actual Out2 Output Value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Actual Out2 Set Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Actual Out2 Value:";
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(29, 12);
            this.data_tb.Name = "data_tb";
            this.data_tb.Size = new System.Drawing.Size(429, 238);
            this.data_tb.TabIndex = 12;
            this.data_tb.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 474);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "D:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "I:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 425);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "P:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 393);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Control Parameters Out1:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 393);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Control Parameters Out2:";
            // 
            // p_tb
            // 
            this.p_tb.Location = new System.Drawing.Point(65, 420);
            this.p_tb.Name = "p_tb";
            this.p_tb.Size = new System.Drawing.Size(63, 23);
            this.p_tb.TabIndex = 21;
            this.p_tb.Text = "";
            // 
            // i_tb
            // 
            this.i_tb.Location = new System.Drawing.Point(65, 445);
            this.i_tb.Name = "i_tb";
            this.i_tb.Size = new System.Drawing.Size(63, 23);
            this.i_tb.TabIndex = 22;
            this.i_tb.Text = "";
            // 
            // d_tb
            // 
            this.d_tb.Location = new System.Drawing.Point(65, 470);
            this.d_tb.Name = "d_tb";
            this.d_tb.Size = new System.Drawing.Size(63, 23);
            this.d_tb.TabIndex = 23;
            this.d_tb.Text = "";
            // 
            // d_tb_temp
            // 
            this.d_tb_temp.Location = new System.Drawing.Point(255, 465);
            this.d_tb_temp.Name = "d_tb_temp";
            this.d_tb_temp.Size = new System.Drawing.Size(63, 23);
            this.d_tb_temp.TabIndex = 29;
            this.d_tb_temp.Text = "";
            // 
            // i_tb_temp
            // 
            this.i_tb_temp.Location = new System.Drawing.Point(255, 440);
            this.i_tb_temp.Name = "i_tb_temp";
            this.i_tb_temp.Size = new System.Drawing.Size(63, 23);
            this.i_tb_temp.TabIndex = 28;
            this.i_tb_temp.Text = "";
            // 
            // p_tb_temp
            // 
            this.p_tb_temp.Location = new System.Drawing.Point(255, 415);
            this.p_tb_temp.Name = "p_tb_temp";
            this.p_tb_temp.Size = new System.Drawing.Size(63, 21);
            this.p_tb_temp.TabIndex = 72;
            this.p_tb_temp.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(223, 469);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "D:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(223, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "I:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(223, 420);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "P:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1251, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Port Name:";
            // 
            // port_name_tb
            // 
            this.port_name_tb.Location = new System.Drawing.Point(1373, 248);
            this.port_name_tb.Name = "port_name_tb";
            this.port_name_tb.Size = new System.Drawing.Size(63, 23);
            this.port_name_tb.TabIndex = 31;
            this.port_name_tb.Text = "";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1251, 186);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "Setpoint Out1:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1251, 215);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Setpoint Out2:";
            // 
            // sendflow_tb
            // 
            this.sendflow_tb.Location = new System.Drawing.Point(1373, 183);
            this.sendflow_tb.Name = "sendflow_tb";
            this.sendflow_tb.Size = new System.Drawing.Size(63, 23);
            this.sendflow_tb.TabIndex = 34;
            this.sendflow_tb.Text = "";
            // 
            // sendtemp_tb
            // 
            this.sendtemp_tb.Location = new System.Drawing.Point(1373, 212);
            this.sendtemp_tb.Name = "sendtemp_tb";
            this.sendtemp_tb.Size = new System.Drawing.Size(63, 23);
            this.sendtemp_tb.TabIndex = 35;
            this.sendtemp_tb.Text = "";
            // 
            // Control_radio
            // 
            this.Control_radio.AutoSize = true;
            this.Control_radio.Location = new System.Drawing.Point(21, 33);
            this.Control_radio.Name = "Control_radio";
            this.Control_radio.Size = new System.Drawing.Size(110, 17);
            this.Control_radio.TabIndex = 36;
            this.Control_radio.TabStop = true;
            this.Control_radio.Text = "Open-loop Control";
            this.Control_radio.UseVisualStyleBackColor = true;
            this.Control_radio.CheckedChanged += new System.EventHandler(this.Control_radio_CheckedChanged_1);
            // 
            // Regulation_radio
            // 
            this.Regulation_radio.AutoSize = true;
            this.Regulation_radio.Location = new System.Drawing.Point(21, 73);
            this.Regulation_radio.Name = "Regulation_radio";
            this.Regulation_radio.Size = new System.Drawing.Size(116, 17);
            this.Regulation_radio.TabIndex = 37;
            this.Regulation_radio.TabStop = true;
            this.Regulation_radio.Text = "Closed-loop Control";
            this.Regulation_radio.UseVisualStyleBackColor = true;
            this.Regulation_radio.CheckedChanged += new System.EventHandler(this.Regulation_radio_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Regulation_radio);
            this.groupBox1.Controls.Add(this.Control_radio);
            this.groupBox1.Location = new System.Drawing.Point(1251, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 106);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation Mode:";
            // 
            // Yes_radio
            // 
            this.Yes_radio.AutoSize = true;
            this.Yes_radio.Location = new System.Drawing.Point(19, 19);
            this.Yes_radio.Name = "Yes_radio";
            this.Yes_radio.Size = new System.Drawing.Size(43, 17);
            this.Yes_radio.TabIndex = 39;
            this.Yes_radio.TabStop = true;
            this.Yes_radio.Text = "Yes";
            this.Yes_radio.UseVisualStyleBackColor = true;
            this.Yes_radio.CheckedChanged += new System.EventHandler(this.Yes_radio_CheckedChanged_1);
            // 
            // No_radio
            // 
            this.No_radio.AutoSize = true;
            this.No_radio.Location = new System.Drawing.Point(110, 19);
            this.No_radio.Name = "No_radio";
            this.No_radio.Size = new System.Drawing.Size(39, 17);
            this.No_radio.TabIndex = 40;
            this.No_radio.TabStop = true;
            this.No_radio.Text = "No";
            this.No_radio.UseVisualStyleBackColor = true;
            this.No_radio.CheckedChanged += new System.EventHandler(this.No_radio_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.No_radio);
            this.groupBox2.Controls.Add(this.Yes_radio);
            this.groupBox2.Location = new System.Drawing.Point(1254, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 48);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Measurementschedule:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1103, 453);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(145, 13);
            this.label24.TabIndex = 42;
            this.label24.Text = "Use Measurement Intervals ?";
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.SystemColors.Control;
            this.send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send_btn.Location = new System.Drawing.Point(1106, 178);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(122, 50);
            this.send_btn.TabIndex = 43;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(1106, 241);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(122, 48);
            this.start_btn.TabIndex = 75;
            this.start_btn.Text = "Start";
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Location = new System.Drawing.Point(1106, 297);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(122, 50);
            this.save_btn.TabIndex = 45;
            this.save_btn.Text = "Save Data";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_btn.Location = new System.Drawing.Point(1106, 353);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(122, 50);
            this.stop_btn.TabIndex = 46;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(930, 498);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(121, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "Measurement Interval 1:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(930, 532);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 13);
            this.label26.TabIndex = 51;
            this.label26.Text = "Measurement Interval 2:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(930, 568);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(121, 13);
            this.label27.TabIndex = 52;
            this.label27.Text = "Measurement Interval 3:";
            // 
            // interval1_to
            // 
            this.interval1_to.Location = new System.Drawing.Point(1057, 495);
            this.interval1_to.Name = "interval1_to";
            this.interval1_to.Size = new System.Drawing.Size(63, 23);
            this.interval1_to.TabIndex = 53;
            this.interval1_to.Text = "";
            // 
            // interval2_to
            // 
            this.interval2_to.Location = new System.Drawing.Point(1057, 529);
            this.interval2_to.Name = "interval2_to";
            this.interval2_to.Size = new System.Drawing.Size(63, 23);
            this.interval2_to.TabIndex = 54;
            this.interval2_to.Text = "";
            // 
            // interval3_to
            // 
            this.interval3_to.Location = new System.Drawing.Point(1057, 562);
            this.interval3_to.Name = "interval3_to";
            this.interval3_to.Size = new System.Drawing.Size(63, 23);
            this.interval3_to.TabIndex = 55;
            this.interval3_to.Text = "";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1138, 498);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 13);
            this.label28.TabIndex = 56;
            this.label28.Text = "Set Out1:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(1138, 532);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 13);
            this.label29.TabIndex = 57;
            this.label29.Text = "Set Out1:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1138, 565);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 13);
            this.label30.TabIndex = 58;
            this.label30.Text = "Set Out1:";
            // 
            // interval3_set_flow
            // 
            this.interval3_set_flow.Location = new System.Drawing.Point(1197, 562);
            this.interval3_set_flow.Name = "interval3_set_flow";
            this.interval3_set_flow.Size = new System.Drawing.Size(63, 23);
            this.interval3_set_flow.TabIndex = 61;
            this.interval3_set_flow.Text = "";
            // 
            // interval2_set_flow
            // 
            this.interval2_set_flow.Location = new System.Drawing.Point(1197, 529);
            this.interval2_set_flow.Name = "interval2_set_flow";
            this.interval2_set_flow.Size = new System.Drawing.Size(63, 23);
            this.interval2_set_flow.TabIndex = 60;
            this.interval2_set_flow.Text = "";
            // 
            // interval1_set_flow
            // 
            this.interval1_set_flow.Location = new System.Drawing.Point(1197, 495);
            this.interval1_set_flow.Name = "interval1_set_flow";
            this.interval1_set_flow.Size = new System.Drawing.Size(63, 23);
            this.interval1_set_flow.TabIndex = 59;
            this.interval1_set_flow.Text = "";
            // 
            // interval3_set_temp
            // 
            this.interval3_set_temp.Location = new System.Drawing.Point(1369, 562);
            this.interval3_set_temp.Name = "interval3_set_temp";
            this.interval3_set_temp.Size = new System.Drawing.Size(63, 23);
            this.interval3_set_temp.TabIndex = 67;
            this.interval3_set_temp.Text = "";
            // 
            // interval2_set_temp
            // 
            this.interval2_set_temp.Location = new System.Drawing.Point(1369, 529);
            this.interval2_set_temp.Name = "interval2_set_temp";
            this.interval2_set_temp.Size = new System.Drawing.Size(63, 23);
            this.interval2_set_temp.TabIndex = 66;
            this.interval2_set_temp.Text = "";
            // 
            // interval1_set_temp
            // 
            this.interval1_set_temp.Location = new System.Drawing.Point(1369, 495);
            this.interval1_set_temp.Name = "interval1_set_temp";
            this.interval1_set_temp.Size = new System.Drawing.Size(63, 23);
            this.interval1_set_temp.TabIndex = 65;
            this.interval1_set_temp.Text = "";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(1276, 565);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 13);
            this.label31.TabIndex = 64;
            this.label31.Text = "Set Out2:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(1276, 532);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 13);
            this.label32.TabIndex = 63;
            this.label32.Text = "Set Out2:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(1276, 498);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 13);
            this.label33.TabIndex = 62;
            this.label33.Text = "Set Out2:";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(929, 658);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(122, 33);
            this.reset_btn.TabIndex = 68;
            this.reset_btn.Text = "Reset Timer";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(1057, 668);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(190, 13);
            this.label34.TabIndex = 69;
            this.label34.Text = "Time passed since Measurement Start:";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(1253, 668);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(0, 13);
            this.time_lbl.TabIndex = 70;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(1326, 706);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(110, 13);
            this.label36.TabIndex = 71;
            this.label36.Text = "by Andreas Bernatzky";
            // 
            // baud_tb
            // 
            this.baud_tb.Location = new System.Drawing.Point(1373, 272);
            this.baud_tb.Name = "baud_tb";
            this.baud_tb.Size = new System.Drawing.Size(63, 23);
            this.baud_tb.TabIndex = 74;
            this.baud_tb.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1251, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Baud Rate:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(470, 15);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Out1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(624, 390);
            this.chart1.TabIndex = 76;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1135, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // info_btn
            // 
            this.info_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.info_btn.Location = new System.Drawing.Point(36, 656);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(105, 55);
            this.info_btn.TabIndex = 79;
            this.info_btn.Text = "INFO";
            this.info_btn.UseVisualStyleBackColor = false;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // verzeichnis_tb
            // 
            this.verzeichnis_tb.Location = new System.Drawing.Point(1194, 409);
            this.verzeichnis_tb.Name = "verzeichnis_tb";
            this.verzeichnis_tb.Size = new System.Drawing.Size(241, 19);
            this.verzeichnis_tb.TabIndex = 80;
            this.verzeichnis_tb.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1066, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Save Destination Folder:";
            // 
            // manual_btn
            // 
            this.manual_btn.Location = new System.Drawing.Point(161, 658);
            this.manual_btn.Name = "manual_btn";
            this.manual_btn.Size = new System.Drawing.Size(105, 53);
            this.manual_btn.TabIndex = 82;
            this.manual_btn.Text = "Quick Start";
            this.manual_btn.UseVisualStyleBackColor = true;
            this.manual_btn.Click += new System.EventHandler(this.manual_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 728);
            this.Controls.Add(this.manual_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.verzeichnis_tb);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.baud_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.interval3_set_temp);
            this.Controls.Add(this.interval2_set_temp);
            this.Controls.Add(this.interval1_set_temp);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.interval3_set_flow);
            this.Controls.Add(this.interval2_set_flow);
            this.Controls.Add(this.interval1_set_flow);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.interval3_to);
            this.Controls.Add(this.interval2_to);
            this.Controls.Add(this.interval1_to);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendtemp_tb);
            this.Controls.Add(this.sendflow_tb);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.port_name_tb);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.d_tb_temp);
            this.Controls.Add(this.i_tb_temp);
            this.Controls.Add(this.p_tb_temp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.d_tb);
            this.Controls.Add(this.i_tb);
            this.Controls.Add(this.p_tb);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.data_tb);
            this.Controls.Add(this.temp_out_lbl);
            this.Controls.Add(this.temp_set_lbl);
            this.Controls.Add(this.temp_lbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.out_lbl);
            this.Controls.Add(this.set_lbl);
            this.Controls.Add(this.val_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Control Manager";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label out_lbl;
        private System.Windows.Forms.Label set_lbl;
        private System.Windows.Forms.Label val_lbl;
        private System.Windows.Forms.Label temp_out_lbl;
        private System.Windows.Forms.Label temp_set_lbl;
        private System.Windows.Forms.Label temp_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox data_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox p_tb;
        private System.Windows.Forms.RichTextBox i_tb;
        private System.Windows.Forms.RichTextBox d_tb;
        private System.Windows.Forms.RichTextBox d_tb_temp;
        private System.Windows.Forms.RichTextBox i_tb_temp;
        private System.Windows.Forms.RichTextBox p_tb_temp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox port_name_tb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RichTextBox sendflow_tb;
        private System.Windows.Forms.RichTextBox sendtemp_tb;
        private System.Windows.Forms.RadioButton Control_radio;
        private System.Windows.Forms.RadioButton Regulation_radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Yes_radio;
        private System.Windows.Forms.RadioButton No_radio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RichTextBox interval1_to;
        private System.Windows.Forms.RichTextBox interval2_to;
        private System.Windows.Forms.RichTextBox interval3_to;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RichTextBox interval3_set_flow;
        private System.Windows.Forms.RichTextBox interval2_set_flow;
        private System.Windows.Forms.RichTextBox interval1_set_flow;
        private System.Windows.Forms.RichTextBox interval3_set_temp;
        private System.Windows.Forms.RichTextBox interval2_set_temp;
        private System.Windows.Forms.RichTextBox interval1_set_temp;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.RichTextBox baud_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.RichTextBox verzeichnis_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button manual_btn;
    }
}

