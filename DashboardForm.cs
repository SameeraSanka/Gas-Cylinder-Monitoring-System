using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class DashboardForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public DashboardForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            PnlNav.Height = btnLevels.Height;
            PnlNav.Top = btnLevels.Top;
            PnlNav.Left = btnLevels.Left;
            btnLevels.BackColor = Color.FromArgb(46, 51, 73);
        }

        public string conString = "Data Source=.\\data\\local.db;Version=3;";
        public String downloadString1;
        public String downloadString2;

        public double currentReading1;
        public double currentReading1R;
        public double currentReading2;
        public double currentReading2R;
        public double lastReading1;
        public double lastReading2;
        public int skip1 = 0;
        public int skip2 = 0;
        public double gRt;
 
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            timer3.Start();
            backgroundWorker1.RunWorkerAsync();        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += 0.2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Application.Exit();
            }
            Opacity -= 0.2;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
  
            try 
            {
                WebClient client = new WebClient();

                downloadString1 = client.DownloadString("http://192.168.4.1/data.txt");
                downloadString2 = client.DownloadString("http://192.168.4.1/data1.txt");    

            }catch(Exception)
            {
                
                RetryExitMessageBox.Show("GasMonitor Wifi Disconnected.\nPlease Reconnect and Try again", "Connection Error!");
                
                DialogResult res = RetryExitMessageBox.MsgBox.DialogResult;

                if (res == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else if (res == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            currentReading1 = double.Parse(downloadString1);
            currentReading1R = Math.Round((double)currentReading1, 2);

            currentReading2 = double.Parse(downloadString2);
            currentReading2R = Math.Round((double)currentReading2, 2);

            try
            {
                SQLiteConnection conn = new SQLiteConnection(conString);
                conn.Open();
                String qry = "SELECT lReading FROM lastReading where readingID=1";
                String qry2 = "SELECT lReading FROM lastReading where readingID=2";
                SQLiteCommand commd = new SQLiteCommand(qry, conn);
                SQLiteDataReader rdr = commd.ExecuteReader();
                rdr.Read();

                lastReading1 = rdr.GetDouble(0);

                commd.Dispose();
                rdr.Dispose();


                SQLiteCommand cmmnd = new SQLiteCommand(qry2, conn);
                SQLiteDataReader rdr2 = cmmnd.ExecuteReader();
                rdr2.Read();

                lastReading2 = rdr2.GetDouble(0);

                cmmnd.Dispose();
                rdr2.Dispose();

                conn.Close();
            }
            catch(Exception en)
            {
                MessageBox.Show(en.Message);
            }

            if ((currentReading1R > -5) && (currentReading2R > -5))
            {
                if(currentReading1R<1.25)
                {
                    if(skip1==0)
                    {
                        if(gas1.Visible==true)
                        {
                            OKMsgBox.Show("Gas Tank 1 is Low", "Attention");
                            skip1 = 1;
                        }
                        
                    }
                }
                else
                {
                    skip1 = 0;
                }

                if(currentReading2R<1.25)
                {
                    if (skip2 == 0)
                    {
                        if(gas2.Visible==true)
                        {
                            OKMsgBox.Show("Gas Tank 2 is Low", "Attention");
                            skip2 = 1;
                        }
                        
                    }
                }
                else
                {
                    skip2 = 2;
                }

                if(currentReading1R-0.25>lastReading1)
                {
                    getGRate();
                    insertExp(gRt);
                    OKMsgBox.Show("Gas Tank 1 Added/Changed", "Attention");
                }

                if(currentReading2R-0.25>lastReading2)
                {
                    getGRate();
                    insertExp(gRt);
                    OKMsgBox.Show("Gas Tank 2 Added/Changed", "Attention");
                    
                }

                if (currentReading1 < 0.4)
                {
                    gas1.Visible = false;
                }
                else
                {
                    gas1.Visible = true;
                }

                if (currentReading2 < 0.4)
                {
                    gas2.Visible = false;
                }
                else
                {
                    gas2.Visible = true;
                }

                int cr1 = (int)(currentReading1R * 50.0f);
                int cr2 = (int)(currentReading2R * 50.0f);

                if (cr1 > 0)
                {
                    if (cr1 < 28)
                    {
                        gas1.Value = 20;
                    }
                    else
                    {

                        if (cr1 > 100)
                        {
                            gas1.Value = 100;
                        }
                        else
                        {
                            gas1.Value = (int)(currentReading1R * 50.0f);
                        }
                    }
                }
                else
                {
                    gas1.Value = 20;
                }


                if (cr2 > 0)
                {

                    if (cr2 < 28)
                    {
                        gas2.Value = 20;
                    }
                    else
                    {

                        if (cr2 > 100)
                        {
                            gas2.Value = 100;
                        }
                        else
                        {
                            gas2.Value = (int)(currentReading2R * 50.0f);
                        }
                    }
                }
                else
                {
                    gas2.Value = 20;
                }

                if (gas1.Visible == true)
                {
                    if (cr1 < 28)
                    {
                        lblgas1.Text = "0% Left";
                    }
                    else
                    {
                        if ((int)(((currentReading1R - 0.45) / 1.55) * 100) > 0)
                        {
                            if ((int)(((currentReading1R - 0.45) / 1.55) * 100) > 100)
                            {
                                lblgas1.Text = "100% Left";
                            }
                            else
                            {
                                lblgas1.Text = ((int)(((currentReading1R - 0.45) / 1.55) * 100)).ToString() + "% Left";
                            }

                        }
                        else
                        {
                            lblgas1.Text = "0% Left";
                        }
                    }
                }
                else
                {
                        lblgas1.Text = "No Tank";
                }


                if (gas2.Visible == true)
                {
                    if (cr2 < 28)
                    {
                        lblgas2.Text = "0% Left";
                    }
                    else
                    {
                        if ((int)(((currentReading2R - 0.45) / 1.55) * 100) > 0)
                        {
                            if ((int)(((currentReading2R - 0.45) / 1.55) * 100) > 100)
                            {
                                lblgas2.Text = "100% Left";
                            }
                            else
                            {
                                lblgas2.Text = ((int)(((currentReading2R - 0.45) / 1.55) * 100)).ToString() + "% Left";
                            }

                        }
                        else
                        {
                            lblgas2.Text = "0% Left";
                        }
                    }
                }
                else
                {
                        lblgas2.Text = "No Tank";            
                }

                updateLastReading(currentReading1R,1);
                updateLastReading(currentReading2R,2);

                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                RetryExitMessageBox.Show("Check Sensors and Wires", "Sensor or Wiring Error!");

                DialogResult rest = RetryExitMessageBox.MsgBox.DialogResult;

                if (rest == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else if (rest == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }

        private void btnLevels_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnLevels.Height;
            PnlNav.Top = btnLevels.Top;
            PnlNav.Left = btnLevels.Left;
            btnLevels.BackColor = Color.FromArgb(46, 51, 73);

            pnlMonExp.Visible = false;
            pnlGasRate.Visible = false;
            pnlLevels.Visible = true;


        }

        private void btnMonExp_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnMonExp.Height;
            PnlNav.Top = btnMonExp.Top;
            btnMonExp.BackColor = Color.FromArgb(46, 51, 73);

            pnlGasRate.Visible = false;
            pnlLevels.Visible = false;


            viewGasExp();

            pnlMonExp.Visible = true;
            lblMonth.Text = "MONTHLY EXPENSE FOR GAS - " + DateTime.Now.ToString("MMMM yyyy").ToUpper();
            this.dataGridView1.ClearSelection();
        }

        private void btnGasRate_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnGasRate.Height;
            PnlNav.Top = btnGasRate.Top;
            btnGasRate.BackColor = Color.FromArgb(46, 51, 73);

            pnlLevels.Visible = false;
            pnlMonExp.Visible = false;
            pnlGasRate.Visible = true;
            viewRate();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(lblMonth.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 125, 20);
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 300, 150);
            e.Graphics.DrawString("Total = " + lblTotal.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 125, 1000);
            e.Graphics.DrawString("Signature (Executive Chef)", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 500, 1000);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = printDocument1;
            printDlg.AllowSelection = false;
            printDlg.AllowSomePages = false; 
            if (printDlg.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void viewGasExp()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(conString);
                conn.Open();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                String cmd = "SELECT expDate AS 'DATE',expAmt AS 'GAS RATE' FROM gasExpenses WHERE strftime('%Y %m','now') = strftime('%Y %m',expDate)";

                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd, conn);
                conn.Close();

                da.Fill(dt);
                dataGridView1.ReadOnly = true;
                this.dataGridView1.DataSource = dt;
                da.Dispose();

                conn.Open();
                String qr = "SELECT SUM(expAmt) FROM gasExpenses WHERE strftime('%Y %m','now') = strftime('%Y %m',expDate)";
                SQLiteCommand cmmd = new SQLiteCommand(qr, conn);
                SQLiteDataReader rdr = cmmd.ExecuteReader();
                rdr.Read();

                double tot = rdr.GetDouble(0);

                lblTotal.Text = "Rs. " + tot.ToString();

                cmmd.Dispose();
                rdr.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewRate()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(conString);
                conn.Open();
                String qry = "SELECT gRate,updDate FROM gasRate WHERE rateID = 1";
                SQLiteCommand cmmd = new SQLiteCommand(qry, conn);
                SQLiteDataReader rdr = cmmd.ExecuteReader();
                rdr.Read();

                double rt = rdr.GetDouble(0);
                string date = rdr.GetString(1);

                lblCurRate.Text = "Rs. " + rt.ToString();
                lblUpdOn.Text = date;

                cmmd.Dispose();
                rdr.Dispose();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtRate.Text.Equals(""))
            {
                OKMsgBox.Show("Please Enter a Rate", "Attention");
            }
            else
            {          
                updRate();
                viewRate();
                txtRate.Text = "";
            }
        }

        private void updRate() 
        {
            try{
			        SQLiteConnection con = new SQLiteConnection(conString);
                    SQLiteCommand comd = new SQLiteCommand();
					con.Open();
					comd.Connection = con;
					String qr = "UPDATE gasRate SET gRate='"+txtRate.Text+"',updDate=date('now') WHERE rateID=1";
                    comd.CommandText = qr;
					comd.ExecuteNonQuery();

                    comd.Dispose();
                    con.Close();

                    OKMsgBox.Show("Gas Rate Updated", "Successful");
                    		
			    }
		        catch(Exception ex)
                {
			        MessageBox.Show(ex.Message);
		        }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void getGRate()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(conString);
                conn.Open();
                String qry = "SELECT gRate FROM gasRate WHERE rateID = 1";
                SQLiteCommand cmmd = new SQLiteCommand(qry, conn);
                SQLiteDataReader rder = cmmd.ExecuteReader();
                rder.Read();

                gRt = rder.GetDouble(0);

                cmmd.Dispose();
                rder.Dispose();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void insertExp(double gr)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(conString);
                SQLiteCommand comd = new SQLiteCommand();
                con.Open();
                comd.Connection = con;
                String qr = "INSERT INTO gasExpenses(expAmt) VALUES ('"+gr+"')";
                comd.CommandText = qr;
                comd.ExecuteNonQuery();

                comd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateLastReading(double crd,int rID)
        {
            try
            {
                SQLiteConnection cotnn = new SQLiteConnection(conString);
                SQLiteCommand commd = new SQLiteCommand();
                cotnn.Open();
                commd.Connection = cotnn;
                String qr = "UPDATE lastReading SET lReading='"+crd+"' WHERE readingID='"+rID+"'";
                commd.CommandText = qr;
                commd.ExecuteNonQuery();

                commd.Dispose();
                cotnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLevels_Leave(object sender, EventArgs e)
        {
            btnLevels.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMonExp_Leave(object sender, EventArgs e)
        {
            btnMonExp.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnGasRate_Leave(object sender, EventArgs e)
        {
            btnGasRate.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}
