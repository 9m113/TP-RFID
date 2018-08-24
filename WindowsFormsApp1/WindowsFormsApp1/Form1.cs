using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data;

namespace WindowsFormsApp1
{
    

    public partial class Form1 : Form
    {   
       

        string sBaudRate = "null";
        string sPortNo = "null";
        string portName = "null";

        int PortNo = 0;
        int BaudRate = 0;

        //def data struct 
        struct DATA
        {
            public string UNI;
            public string TEAM;
            public int CARNO;
            public int LAPS;
            public Double SPEED;
        };

        DATA[ ] Gameinfo = new DATA[128];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {

            //dataGridView1.DataSource = createSouce();// connect data and data source
           // DataGridViewRowCollection rows = dataGridView1.Rows;
           // rows.Add(new Object[] { "TU Braunschweig", "Lown 1",12,2,12.6});

        }


       // private DataTable createSouce()//creat data table

        //{

            //DataTable dt = new DataTable("GamingInfo");//creat DataTable 

           // dt.Columns.Add("UNI", typeof(string));
           // dt.Columns.Add("TEAM", typeof(string));
           // dt.Columns.Add("CARNO", typeof(int));
           // dt.Columns.Add("LAPS", typeof(int));
            //dt.Columns.Add("SPEED", typeof(float));

                // for (int i = 0; i < 128; i++)

           // {
                //Initialize the row
              //  DataRow dr = dt.NewRow();
              //  dr["UNI"] = "TU Braunschweig";
               // dr["TEAM"] = "Lown 1";
              //  dr["CARNO"] = 12;
              //  dr["LAPS"] = 2;
              //  dr["SPEED"] = 12.6;

               // dt.Rows.Add(dr);//add row

                //dr[0] = i;//添加第一列数据

                //dr[1] = Convert.ToString((i + 80) / 3);//添加第二列数据

                //dt.Rows.Add(dr);//把行加入到；列表中     

           // }

           // return dt;

           // }

        private void button1_Click(object sender, EventArgs e)
        {
            //PortNo = int.Parse(sPortNo);
            //BaudRate = int.Parse(sBaudRate);
            //[DllImport("QM100.dll", EntryPoint = "ConnectDev")]
            //static private extern bool ConnectDev(int PortNo, int BaudRate);

            // find COM port
            comPOTNO.Items.Clear();
            for (int i = 0; i < 128; i++)
            { try
               {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    comPOTNO.Items.Add("COM" + (i + 1).ToString());
                 }
               catch(Exception)
                {
                    comSTATUS.Text = "COM" + (i + 1).ToString() + " unavailable";
                    continue;
                }
                SetPortProperty();     
                
            }

            void SetPortProperty()
            { //set serial port property
                SerialPort sp = new SerialPort();
                sp.PortName = comPOTNO.Text.Trim();//set port name
                sp.BaudRate = Convert.ToInt32(comBAUDRAT.Text.Trim());//set baud rate
                sp.Parity = Parity.None;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.Handshake = Handshake.None;
                sp.ReadTimeout = -1;

                //open serial port
                try
                {
                    sp.Open();
                   
                }
                catch (Exception)
                {
                    const string ErrorText1 = "An error when try to open serial port!";
                    MessageBox.Show(ErrorText1);
                }

            }

            // Displays the MessageBox.

            MessageBox.Show("Connecting Successful!");

        }

       private bool CheckPortSetting()
        {
            if (comBAUDRAT.Text.Trim() == " ") return false;
            if (comPOTNO.Text.Trim() == " ") return false;
            return true;

        }

        private bool CheckSendData()
        {
           // if (txbDate.Text.Trim()=="") return false;
            return true;
        }

        void SetPortProperty()
        { //set serial port property
            SerialPort sp = new SerialPort();
            sp.PortName = comPOTNO.Text.Trim();//set port name
            sp.BaudRate = Convert.ToInt32(comBAUDRAT.Text.Trim());//set baud rate
            sp.Parity = Parity.None;
            sp.DataBits = 8;
            sp.StopBits = StopBits.One;
            sp.Handshake = Handshake.None;
            sp.ReadTimeout = -1;

            //open serial port
            try
            { sp.Open();
               //is Open = true;
            }
            catch(Exception)
            {
                const string ErrorText1 = "An error when try to open serial port!";
                MessageBox.Show(ErrorText1);
            }

        }


        private void comPOTNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            sPortNo = comPOTNO.Text;
            portName = comPOTNO.Text;
            int selectedIndex = comPOTNO.SelectedIndex;
            object selectedItem = comPOTNO.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());

        }

        private void comBAUDRAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            sBaudRate = comBAUDRAT.Text;
            int selectedIndex = comBAUDRAT.SelectedIndex;
            object selectedItem = comBAUDRAT.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());

        }

       

        private void comSTATUS_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“demoDataSet.RFIDINFO”中。您可以根据需要移动或删除它。
            this.rFIDINFOTableAdapter.Fill(this.demoDataSet.RFIDINFO);

        }

       
    }

}

