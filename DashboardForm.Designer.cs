namespace WindowsFormsApplication1
{
    partial class DashboardForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblgas1 = new System.Windows.Forms.Label();
            this.lblgas2 = new System.Windows.Forms.Label();
            this.pnlLevels = new System.Windows.Forms.Panel();
            this.pnlGas2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.gas2 = new WindowsFormsApplication1.VerticalProgressBar();
            this.Pnlgas1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.gas1 = new WindowsFormsApplication1.VerticalProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlMonExp = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.pnlGasRate = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurRate = new System.Windows.Forms.Label();
            this.lblUpdOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.btnGasRate = new System.Windows.Forms.Button();
            this.btnMonExp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLevels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlLevels.SuspendLayout();
            this.pnlGas2.SuspendLayout();
            this.Pnlgas1.SuspendLayout();
            this.pnlMonExp.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGasRate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(34, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(273, 374);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblgas1
            // 
            this.lblgas1.AutoSize = true;
            this.lblgas1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgas1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.lblgas1.Location = new System.Drawing.Point(111, 414);
            this.lblgas1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgas1.Name = "lblgas1";
            this.lblgas1.Size = new System.Drawing.Size(60, 34);
            this.lblgas1.TabIndex = 6;
            this.lblgas1.Text = "___";
            this.lblgas1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgas2
            // 
            this.lblgas2.AutoSize = true;
            this.lblgas2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgas2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.lblgas2.Location = new System.Drawing.Point(122, 414);
            this.lblgas2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgas2.Name = "lblgas2";
            this.lblgas2.Size = new System.Drawing.Size(60, 34);
            this.lblgas2.TabIndex = 6;
            this.lblgas2.Text = "___";
            // 
            // pnlLevels
            // 
            this.pnlLevels.Controls.Add(this.pnlGas2);
            this.pnlLevels.Controls.Add(this.Pnlgas1);
            this.pnlLevels.Controls.Add(this.label8);
            this.pnlLevels.Location = new System.Drawing.Point(239, 85);
            this.pnlLevels.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLevels.Name = "pnlLevels";
            this.pnlLevels.Size = new System.Drawing.Size(676, 586);
            this.pnlLevels.TabIndex = 7;
            // 
            // pnlGas2
            // 
            this.pnlGas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlGas2.Controls.Add(this.label11);
            this.pnlGas2.Controls.Add(this.lblgas2);
            this.pnlGas2.Controls.Add(this.gas2);
            this.pnlGas2.Controls.Add(this.pictureBox2);
            this.pnlGas2.Location = new System.Drawing.Point(345, 85);
            this.pnlGas2.Name = "pnlGas2";
            this.pnlGas2.Size = new System.Drawing.Size(311, 483);
            this.pnlGas2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label11.Location = new System.Drawing.Point(73, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Gas Cylinder 2";
            // 
            // gas2
            // 
            this.gas2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gas2.Location = new System.Drawing.Point(97, 165);
            this.gas2.Margin = new System.Windows.Forms.Padding(4);
            this.gas2.Minimum = 20;
            this.gas2.Name = "gas2";
            this.gas2.Size = new System.Drawing.Size(118, 158);
            this.gas2.TabIndex = 4;
            this.gas2.Value = 20;
            this.gas2.Visible = false;
            // 
            // Pnlgas1
            // 
            this.Pnlgas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pnlgas1.Controls.Add(this.label9);
            this.Pnlgas1.Controls.Add(this.lblgas1);
            this.Pnlgas1.Controls.Add(this.gas1);
            this.Pnlgas1.Controls.Add(this.pictureBox1);
            this.Pnlgas1.Location = new System.Drawing.Point(10, 85);
            this.Pnlgas1.Name = "Pnlgas1";
            this.Pnlgas1.Size = new System.Drawing.Size(311, 483);
            this.Pnlgas1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(70, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Gas Cylinder 1";
            // 
            // gas1
            // 
            this.gas1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gas1.Location = new System.Drawing.Point(85, 165);
            this.gas1.Margin = new System.Windows.Forms.Padding(4);
            this.gas1.Minimum = 20;
            this.gas1.Name = "gas1";
            this.gas1.Size = new System.Drawing.Size(118, 158);
            this.gas1.TabIndex = 4;
            this.gas1.Value = 20;
            this.gas1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.label8.Location = new System.Drawing.Point(264, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gas Levels";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMonExp
            // 
            this.pnlMonExp.Controls.Add(this.panel8);
            this.pnlMonExp.Controls.Add(this.panel7);
            this.pnlMonExp.Controls.Add(this.panel1);
            this.pnlMonExp.Controls.Add(this.lblMonth);
            this.pnlMonExp.Location = new System.Drawing.Point(239, 85);
            this.pnlMonExp.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMonExp.Name = "pnlMonExp";
            this.pnlMonExp.Size = new System.Drawing.Size(676, 586);
            this.pnlMonExp.TabIndex = 8;
            this.pnlMonExp.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.btnPrint);
            this.panel8.Location = new System.Drawing.Point(373, 324);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 241);
            this.panel8.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(79, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Get Report";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPrint.Location = new System.Drawing.Point(73, 112);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(139, 56);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel7.Controls.Add(this.lblTotal);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(371, 85);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(282, 221);
            this.panel7.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTotal.Location = new System.Drawing.Point(77, 118);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 34);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label10.Location = new System.Drawing.Point(63, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total for Month";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 480);
            this.panel1.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label12.Location = new System.Drawing.Point(39, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Gas Expense";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.lblMonth.Location = new System.Drawing.Point(79, 10);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(520, 32);
            this.lblMonth.TabIndex = 11;
            this.lblMonth.Text = "Monthly Expense for Gas  _____________";
            // 
            // pnlGasRate
            // 
            this.pnlGasRate.Controls.Add(this.panel3);
            this.pnlGasRate.Controls.Add(this.label1);
            this.pnlGasRate.Controls.Add(this.panel2);
            this.pnlGasRate.Location = new System.Drawing.Point(239, 85);
            this.pnlGasRate.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGasRate.Name = "pnlGasRate";
            this.pnlGasRate.Size = new System.Drawing.Size(676, 586);
            this.pnlGasRate.TabIndex = 10;
            this.pnlGasRate.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtRate);
            this.panel3.Controls.Add(this.btnChange);
            this.panel3.Location = new System.Drawing.Point(20, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 232);
            this.panel3.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label14.Location = new System.Drawing.Point(244, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Change Rates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(139, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Rate (Rs.) ";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(77, 142);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(280, 38);
            this.txtRate.TabIndex = 1;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnChange.Location = new System.Drawing.Point(394, 89);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 91);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblCurRate);
            this.panel2.Controls.Add(this.lblUpdOn);
            this.panel2.Location = new System.Drawing.Point(20, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 228);
            this.panel2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label13.Location = new System.Drawing.Point(154, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(335, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "Current and Last Updated Rates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(386, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Updated On ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(105, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Rate ";
            // 
            // lblCurRate
            // 
            this.lblCurRate.AutoSize = true;
            this.lblCurRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCurRate.Location = new System.Drawing.Point(132, 155);
            this.lblCurRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurRate.Name = "lblCurRate";
            this.lblCurRate.Size = new System.Drawing.Size(60, 34);
            this.lblCurRate.TabIndex = 0;
            this.lblCurRate.Text = "___";
            // 
            // lblUpdOn
            // 
            this.lblUpdOn.AutoSize = true;
            this.lblUpdOn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblUpdOn.Location = new System.Drawing.Point(440, 155);
            this.lblUpdOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdOn.Name = "lblUpdOn";
            this.lblUpdOn.Size = new System.Drawing.Size(60, 34);
            this.lblUpdOn.TabIndex = 0;
            this.lblUpdOn.Text = "___";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(255, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Gas Rate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.lblDate.Location = new System.Drawing.Point(13, 61);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.lblTime.Location = new System.Drawing.Point(13, 98);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.PnlNav);
            this.panel4.Controls.Add(this.btnGasRate);
            this.panel4.Controls.Add(this.lblTime);
            this.panel4.Controls.Add(this.btnMonExp);
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.btnLevels);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 751);
            this.panel4.TabIndex = 13;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 239);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(4, 300);
            this.PnlNav.TabIndex = 13;
            // 
            // btnGasRate
            // 
            this.btnGasRate.FlatAppearance.BorderSize = 0;
            this.btnGasRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGasRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGasRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.btnGasRate.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_cost_32px;
            this.btnGasRate.Location = new System.Drawing.Point(4, 534);
            this.btnGasRate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGasRate.Name = "btnGasRate";
            this.btnGasRate.Size = new System.Drawing.Size(227, 137);
            this.btnGasRate.TabIndex = 0;
            this.btnGasRate.Text = "Gas Rate";
            this.btnGasRate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGasRate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGasRate.UseVisualStyleBackColor = true;
            this.btnGasRate.Click += new System.EventHandler(this.btnGasRate_Click);
            this.btnGasRate.Leave += new System.EventHandler(this.btnGasRate_Leave);
            // 
            // btnMonExp
            // 
            this.btnMonExp.FlatAppearance.BorderSize = 0;
            this.btnMonExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonExp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.btnMonExp.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_general_ledger_32px;
            this.btnMonExp.Location = new System.Drawing.Point(4, 353);
            this.btnMonExp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonExp.Name = "btnMonExp";
            this.btnMonExp.Size = new System.Drawing.Size(227, 137);
            this.btnMonExp.TabIndex = 0;
            this.btnMonExp.Text = "Monthly Expense";
            this.btnMonExp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMonExp.UseVisualStyleBackColor = true;
            this.btnMonExp.Click += new System.EventHandler(this.btnMonExp_Click);
            this.btnMonExp.Leave += new System.EventHandler(this.btnMonExp_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label7.Location = new System.Drawing.Point(496, 704);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "© CodeHex™";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Moon", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(300, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(496, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "GAS MONITORING SYSTEM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::WindowsFormsApplication1.Properties.Resources.min;
            this.btnMinimize.Location = new System.Drawing.Point(848, 11);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 33);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WindowsFormsApplication1.Properties.Resources.close1;
            this.btnClose.Location = new System.Drawing.Point(882, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.asUntitled_2;
            this.pictureBox2.Location = new System.Drawing.Point(86, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 305);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.asUntitled_2;
            this.pictureBox1.Location = new System.Drawing.Point(75, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 305);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLevels
            // 
            this.btnLevels.FlatAppearance.BorderSize = 0;
            this.btnLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevels.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.btnLevels.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_gas_bottle_32px_31;
            this.btnLevels.Location = new System.Drawing.Point(4, 173);
            this.btnLevels.Margin = new System.Windows.Forms.Padding(4);
            this.btnLevels.Name = "btnLevels";
            this.btnLevels.Size = new System.Drawing.Size(227, 137);
            this.btnLevels.TabIndex = 0;
            this.btnLevels.Text = "Gas Levels";
            this.btnLevels.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLevels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLevels.UseVisualStyleBackColor = true;
            this.btnLevels.Click += new System.EventHandler(this.btnLevels_Click);
            this.btnLevels.Leave += new System.EventHandler(this.btnLevels_Leave);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(928, 751);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlLevels);
            this.Controls.Add(this.pnlGasRate);
            this.Controls.Add(this.pnlMonExp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlLevels.ResumeLayout(false);
            this.pnlLevels.PerformLayout();
            this.pnlGas2.ResumeLayout(false);
            this.pnlGas2.PerformLayout();
            this.Pnlgas1.ResumeLayout(false);
            this.Pnlgas1.PerformLayout();
            this.pnlMonExp.ResumeLayout(false);
            this.pnlMonExp.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGasRate.ResumeLayout(false);
            this.pnlGasRate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private VerticalProgressBar gas1;
        private VerticalProgressBar gas2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblgas1;
        private System.Windows.Forms.Label lblgas2;
        private System.Windows.Forms.Panel pnlLevels;
        private System.Windows.Forms.Panel pnlMonExp;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlGasRate;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblUpdOn;
        private System.Windows.Forms.Label lblCurRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGasRate;
        private System.Windows.Forms.Button btnMonExp;
        private System.Windows.Forms.Button btnLevels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel Pnlgas1;
        private System.Windows.Forms.Panel pnlGas2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}