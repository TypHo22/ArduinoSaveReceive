

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;
using System.Diagnostics;
using System.IO.Ports;

namespace Arduino_Save_Receive_v2
{
    


    public partial class Form1 : Form
    {
        string reg;
        string timedistance;
        private SerialPort myport;
        private DateTime datetime;
        private string in_data;    // before private string
        String[] dataArray;  // includes all the measurement values
     
        public Form1()
        {
            InitializeComponent();
        }

       kayChart serialDataChart;

        private void start_btn_Click(object sender, EventArgs e)
        {
            int baud_rate;
            baud_rate = Convert.ToInt32(baud_tb.Text);

                myport = new SerialPort();
                myport.BaudRate = baud_rate;
                myport.PortName = port_name_tb.Text;
                myport.Parity = Parity.None;
                myport.DataBits = 8;
                myport.StopBits = StopBits.One;
                myport.DataReceived += myport_DataReceived;
                myport.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);
                try
                {

                    myport.Open();
                    data_tb.Text = " ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Wrong COM Port selected");
                }

        }
       
      
        void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
            in_data = myport.ReadLine(); // Writing received Data into in_data

            dataArray = in_data.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);  //splitting incoming messages from serial monitor into an Array with ";"as separator

             this.Invoke(new EventHandler(displaydata_event));
        }
     
        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
    
          

           

            // initialization of chart update
            double data;  // handshake variable for graph
            bool result = Double.TryParse(dataArray[0], out data);
            if (result)
            {


                
                serialDataChart.TriggeredUpdate(data / 100); // writing into diagramm /100. 273.15 should not be interpreted as 27315 

            }

        }
        private void Form1_Load_1(object sender, EventArgs e)  // MUSS EXTRA DURCH DOPPELKLICK in die FORM erzeugt werden, abschreiben funktinoniert nicht (war ein fehler warum der graph nicht funktioniert hat)
        {
            serialDataChart = new kayChart(chart1, 60);
            serialDataChart.serieName = "Out1";
        }



        private void displaydata_event(object sender, EventArgs e)   //display into textbox
        {

            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            data_tb.AppendText(time + "\t\t\t" + in_data + "\n"); //"\t\t\t"  // Multilineversion

            try
            {
                val_lbl.Text = dataArray[0];     // Visualisation actual value
                set_lbl.Text = dataArray[1];  // Visualisation actual set value
                out_lbl.Text = dataArray[2];  // Visualisation actual output
                temp_lbl.Text = dataArray[3]; // Visualisation actual temperature
                temp_set_lbl.Text = dataArray[4]; // Visualisation actual set temperature value
                temp_out_lbl.Text = dataArray[5]; // visualisation actual output for temperature
                time_lbl.Text = dataArray[6];  // visualisation of time which has been passed since program start
           }
            catch (Exception)

            { }
        }


        

        private void send_btn_Click(object sender, EventArgs e)
        {

            string text1 = p_tb.Text;
            string text2 = i_tb.Text;
            string text3 = d_tb.Text;
            string text = sendflow_tb.Text;
            string text4 = p_tb_temp.Text;
            string text5 = i_tb_temp.Text;
            string text6 = d_tb_temp.Text;
            string text7 = sendtemp_tb.Text;
            string text8 = reg; //it is a string. So there is no .Text needed
            string text9 = timedistance; //it is a string. So there is no .Text needed
            string text10 = interval1_to.Text;
            string text11 = interval2_to.Text;
            string text12 = interval3_to.Text;
            string text13 = interval1_set_flow.Text;
            string text14 = interval2_set_flow.Text;
            string text15 = interval3_set_flow.Text;
            string text16 = interval1_set_temp.Text;
            string text17 = interval2_set_temp.Text;
            string text18 = interval3_set_temp.Text;


            myport.WriteLine(";");
            myport.WriteLine(text1);
            myport.WriteLine(";");
            myport.WriteLine(text2);
            myport.WriteLine(";");
            myport.WriteLine(text3);
            myport.WriteLine(";");
            myport.WriteLine(text);
            myport.WriteLine(";");
            myport.WriteLine(text4);
            myport.WriteLine(";");
            myport.WriteLine(text5);
            myport.WriteLine(";");
            myport.WriteLine(text6);
            myport.WriteLine(";");
            myport.WriteLine(text7);
            myport.WriteLine(";");
            myport.WriteLine(text8);
            myport.WriteLine(";");
            myport.WriteLine(text9);
            myport.WriteLine(";");
            myport.WriteLine(text10);
            myport.WriteLine(";");
            myport.WriteLine(text11);
            myport.WriteLine(";");
            myport.WriteLine(text12);
            myport.WriteLine(";");
            myport.WriteLine(text13);
            myport.WriteLine(";");
            myport.WriteLine(text14);
            myport.WriteLine(";");
            myport.WriteLine(text15);
            myport.WriteLine(";");
            myport.WriteLine(text16);
            myport.WriteLine(";");
            myport.WriteLine(text17);
            myport.WriteLine(";");
            myport.WriteLine(text18);
            myport.WriteLine(";");
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            try
            {
                string verzeichnis = verzeichnis_tb.Text;
                string pathfile = @verzeichnis;    // Directory where the measurement should be safed
                string filename = "Measurement  " + datetime.Day + "." + datetime.Month + "." + datetime.Year + ".txt";                        // Dateiname
                System.IO.File.WriteAllText(pathfile + filename, data_tb.Text);  //Acess command for windows
                MessageBox.Show("Data has been saved to" + pathfile, "Save File");
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message, "Error");
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Close();  // Cloeses the serial port
                MessageBox.Show("->!!SPEICHERN NICHT VERGESSEN!!<-");
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");
            }
        }

       

        


        

        private void reset_btn_Click(object sender, EventArgs e)
        {

            string text1 = p_tb.Text;
            string text2 = i_tb.Text;
            string text3 = d_tb.Text;
            string text = sendflow_tb.Text;
            string text4 = p_tb_temp.Text;
            string text5 = i_tb_temp.Text;
            string text6 = d_tb_temp.Text;
            string text7 = sendtemp_tb.Text;
            string text8 = reg; //it is a string. So there is no .Text needed
            string text9 = timedistance; //it is a string. So there is no .Text needed
            string text10 = interval1_to.Text;
            string text11 = interval2_to.Text;
            string text12 = interval3_to.Text;
            string text13 = interval1_set_flow.Text;
            string text14 = interval2_set_flow.Text;
            string text15 = interval3_set_flow.Text;
            string text16 = interval1_set_temp.Text;
            string text17 = interval2_set_temp.Text;
            string text18 = interval3_set_temp.Text;
            string text19 = "1";

            myport.WriteLine(";");
            myport.WriteLine(text1);
            myport.WriteLine(";");
            myport.WriteLine(text2);
            myport.WriteLine(";");
            myport.WriteLine(text3);
            myport.WriteLine(";");
            myport.WriteLine(text);
            myport.WriteLine(";");
            myport.WriteLine(text4);
            myport.WriteLine(";");
            myport.WriteLine(text5);
            myport.WriteLine(";");
            myport.WriteLine(text6);
            myport.WriteLine(";");
            myport.WriteLine(text7);
            myport.WriteLine(";");
            myport.WriteLine(text8);
            myport.WriteLine(";");
            myport.WriteLine(text9);
            myport.WriteLine(";");
            myport.WriteLine(text10);
            myport.WriteLine(";");
            myport.WriteLine(text11);
            myport.WriteLine(";");
            myport.WriteLine(text12);
            myport.WriteLine(";");
            myport.WriteLine(text13);
            myport.WriteLine(";");
            myport.WriteLine(text14);
            myport.WriteLine(";");
            myport.WriteLine(text15);
            myport.WriteLine(";");
            myport.WriteLine(text16);
            myport.WriteLine(";");
            myport.WriteLine(text17);
            myport.WriteLine(";");
            myport.WriteLine(text18);
            myport.WriteLine(";");
            myport.WriteLine(text19);
            myport.WriteLine(";");


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acknowledgement: This work has benefitted from funding through the CleanSky2 Programme under Grant Agreement" +
                "CS2 - LPA - GAM - 2016 - 2017 - 01.The authors are responsible for the content of this publication " + Environment.NewLine
          +"Company: Fraunhofer IBP" + Environment.NewLine
          +"Author: Andreas Bernatzky " + Environment.NewLine
          +"Programm: Serial Control Manager " + Environment.NewLine
          +"Date:26.05.2018" + Environment.NewLine
          + "The author is not responsible for any damage to persons or machines caused by this software" + Environment.NewLine
         + "Description: This GUI was written to visualize Datas send from an Arduino or any other Serial Device");


         
        }

        private void manual_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the correct COM-Port of your Serial Device. If your serial device is connected at Com-Port 8 you have to write COM8 for Port Name." + Environment.NewLine
               + "It is essential that you choose the same BAUD-Rate as your Serial Device is working with. For a BAUD-Rate of 9600 just write 9600 into Baud-Rate" + Environment.NewLine
               + "To establish the Connection you have to press Startbutton once. Terminate the Connection via Stopbutton" + Environment.NewLine
               +"To save your File into a directory you have to write for example:   C:BackslashMeasurementsBackslash   and press the Savebutton" + Environment.NewLine
               + "For changing control or regulation behaviour you have to apply every changing with the Sendbutton");
             



        }

        private void Yes_radio_CheckedChanged_1(object sender, EventArgs e)
        {
            timedistance = "1";
        }

        private void No_radio_CheckedChanged_1(object sender, EventArgs e)
        {
            timedistance = "0";
        }

        private void Control_radio_CheckedChanged_1(object sender, EventArgs e)
        {
            reg = "0";
        }

        private void Regulation_radio_CheckedChanged_1(object sender, EventArgs e)
        {
            reg = "1";
        }
    }


}
