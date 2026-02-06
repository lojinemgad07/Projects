


using System;
using System.Drawing;
using System.Windows.Forms;
namespace DataBaseProjectPawell
{
    partial class HospitalStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back_bt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AvailAppts_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Appt_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Avail_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ApptAvg_tb = new System.Windows.Forms.TextBox();
            this.ApptTotal_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AvailAvg_tb = new System.Windows.Forms.TextBox();
            this.AvailTotal_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vaccines_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
//            this.Vaccine_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalImm_tb = new System.Windows.Forms.TextBox();
            this.AvgImm_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MaxImm_tb = new System.Windows.Forms.TextBox();
            this.MinImm_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MaxStock_tb = new System.Windows.Forms.TextBox();
            this.MinStock_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustFin_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Bank_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Revenue_tb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MinCost_tb = new System.Windows.Forms.TextBox();
            this.MaxCost_tb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.AvgCost_tb = new System.Windows.Forms.TextBox();
            this.CustAnimals_tb = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.EmpBank_tb = new System.Windows.Forms.TextBox();
            this.CustBank_tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AvailAppts_tab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appt_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avail_ch)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Vaccines_tab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.Vaccine_ch)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.CustFin_tab.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_ch)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 67);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 520);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Back_bt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 470);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 48);
            this.panel2.TabIndex = 1;
            // 
            // Back_bt
            // 
            this.Back_bt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Back_bt.Location = new System.Drawing.Point(694, 12);
            this.Back_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_bt.Name = "Back_bt";
            this.Back_bt.Size = new System.Drawing.Size(94, 23);
            this.Back_bt.TabIndex = 9;
            this.Back_bt.Text = "Back";
            this.Back_bt.UseVisualStyleBackColor = true;
            this.Back_bt.Click += new System.EventHandler(this.Back_bt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AvailAppts_tab);
            this.tabControl1.Controls.Add(this.Vaccines_tab);
            this.tabControl1.Controls.Add(this.CustFin_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // AvailAppts_tab
            // 
            this.AvailAppts_tab.Controls.Add(this.tableLayoutPanel3);
            this.AvailAppts_tab.Location = new System.Drawing.Point(4, 25);
            this.AvailAppts_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailAppts_tab.Name = "AvailAppts_tab";
            this.AvailAppts_tab.Size = new System.Drawing.Size(784, 383);
            this.AvailAppts_tab.TabIndex = 2;
            this.AvailAppts_tab.Text = "Availabilities and Appointments";
            this.AvailAppts_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Appt_ch, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Avail_ch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(784, 383);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // Appt_ch
            // 
            chartArea1.Name = "ChartArea1";
            this.Appt_ch.ChartAreas.Add(chartArea1);
            this.Appt_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Appt_ch.Legends.Add(legend1);
            this.Appt_ch.Location = new System.Drawing.Point(395, 3);
            this.Appt_ch.Name = "Appt_ch";
            this.Appt_ch.Size = new System.Drawing.Size(386, 281);
            this.Appt_ch.TabIndex = 9;
            this.Appt_ch.Text = "chart1";
            // 
            // Avail_ch
            // 
            chartArea2.Name = "ChartArea1";
            this.Avail_ch.ChartAreas.Add(chartArea2);
            this.Avail_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.Avail_ch.Legends.Add(legend2);
            this.Avail_ch.Location = new System.Drawing.Point(3, 3);
            this.Avail_ch.Name = "Avail_ch";
            this.Avail_ch.Size = new System.Drawing.Size(386, 281);
            this.Avail_ch.TabIndex = 8;
            this.Avail_ch.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ApptAvg_tb);
            this.panel3.Controls.Add(this.ApptTotal_tb);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(395, 289);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 92);
            this.panel3.TabIndex = 5;
            // 
            // ApptAvg_tb
            // 
            this.ApptAvg_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ApptAvg_tb.Location = new System.Drawing.Point(143, 54);
            this.ApptAvg_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApptAvg_tb.Name = "ApptAvg_tb";
            this.ApptAvg_tb.ReadOnly = true;
            this.ApptAvg_tb.Size = new System.Drawing.Size(125, 22);
            this.ApptAvg_tb.TabIndex = 7;
            // 
            // ApptTotal_tb
            // 
            this.ApptTotal_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ApptTotal_tb.Location = new System.Drawing.Point(143, 27);
            this.ApptTotal_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApptTotal_tb.Name = "ApptTotal_tb";
            this.ApptTotal_tb.ReadOnly = true;
            this.ApptTotal_tb.Size = new System.Drawing.Size(125, 22);
            this.ApptTotal_tb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Average Per Day:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Number: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AvailAvg_tb);
            this.panel4.Controls.Add(this.AvailTotal_tb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 289);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 92);
            this.panel4.TabIndex = 4;
            // 
            // AvailAvg_tb
            // 
            this.AvailAvg_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailAvg_tb.Location = new System.Drawing.Point(142, 54);
            this.AvailAvg_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailAvg_tb.Name = "AvailAvg_tb";
            this.AvailAvg_tb.ReadOnly = true;
            this.AvailAvg_tb.Size = new System.Drawing.Size(125, 22);
            this.AvailAvg_tb.TabIndex = 3;
            // 
            // AvailTotal_tb
            // 
            this.AvailTotal_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailTotal_tb.Location = new System.Drawing.Point(142, 27);
            this.AvailTotal_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailTotal_tb.Name = "AvailTotal_tb";
            this.AvailTotal_tb.ReadOnly = true;
            this.AvailTotal_tb.Size = new System.Drawing.Size(125, 22);
            this.AvailTotal_tb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Average Per Day:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Number: ";
            // 
            // Vaccines_tab
            // 
            this.Vaccines_tab.Controls.Add(this.tableLayoutPanel4);
            this.Vaccines_tab.Location = new System.Drawing.Point(4, 25);
            this.Vaccines_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vaccines_tab.Name = "Vaccines_tab";
            this.Vaccines_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vaccines_tab.Size = new System.Drawing.Size(784, 383);
            this.Vaccines_tab.TabIndex = 1;
            this.Vaccines_tab.Text = "Vaccines and Immunizations";
            this.Vaccines_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            //this.tableLayoutPanel4.Controls.Add(this.Vaccine_ch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(778, 379);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // Vaccine_ch
            // 
            //chartArea3.Name = "ChartArea1";
            //this.Vaccine_ch.ChartAreas.Add(chartArea3);
            //this.Vaccine_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            //legend3.Name = "Legend1";
            //this.Vaccine_ch.Legends.Add(legend3);
            //this.Vaccine_ch.Location = new System.Drawing.Point(3, 3);
            //this.Vaccine_ch.Name = "Vaccine_ch";
            //this.Vaccine_ch.Size = new System.Drawing.Size(383, 278);
            //this.Vaccine_ch.TabIndex = 9;
            //this.Vaccine_ch.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.TotalImm_tb);
            this.panel5.Controls.Add(this.AvgImm_tb);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.MaxImm_tb);
            this.panel5.Controls.Add(this.MinImm_tb);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(392, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.tableLayoutPanel4.SetRowSpan(this.panel5, 2);
            this.panel5.Size = new System.Drawing.Size(383, 375);
            this.panel5.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 28);
            this.label12.TabIndex = 16;
            this.label12.Text = "Completed Immunizations";
            // 
            // TotalImm_tb
            // 
            this.TotalImm_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalImm_tb.Location = new System.Drawing.Point(152, 240);
            this.TotalImm_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalImm_tb.Name = "TotalImm_tb";
            this.TotalImm_tb.ReadOnly = true;
            this.TotalImm_tb.Size = new System.Drawing.Size(125, 22);
            this.TotalImm_tb.TabIndex = 15;
            // 
            // AvgImm_tb
            // 
            this.AvgImm_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvgImm_tb.Location = new System.Drawing.Point(152, 213);
            this.AvgImm_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvgImm_tb.Name = "AvgImm_tb";
            this.AvgImm_tb.ReadOnly = true;
            this.AvgImm_tb.Size = new System.Drawing.Size(125, 22);
            this.AvgImm_tb.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Average Number:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Number:";
            // 
            // MaxImm_tb
            // 
            this.MaxImm_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxImm_tb.Location = new System.Drawing.Point(152, 150);
            this.MaxImm_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxImm_tb.Name = "MaxImm_tb";
            this.MaxImm_tb.ReadOnly = true;
            this.MaxImm_tb.Size = new System.Drawing.Size(125, 22);
            this.MaxImm_tb.TabIndex = 11;
            // 
            // MinImm_tb
            // 
            this.MinImm_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinImm_tb.Location = new System.Drawing.Point(152, 124);
            this.MinImm_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinImm_tb.Name = "MinImm_tb";
            this.MinImm_tb.ReadOnly = true;
            this.MinImm_tb.Size = new System.Drawing.Size(125, 22);
            this.MinImm_tb.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Minimum Number:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Maximum Number:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.MaxStock_tb);
            this.panel6.Controls.Add(this.MinStock_tb);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 286);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 91);
            this.panel6.TabIndex = 4;
            // 
            // MaxStock_tb
            // 
            this.MaxStock_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxStock_tb.Location = new System.Drawing.Point(145, 48);
            this.MaxStock_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxStock_tb.Name = "MaxStock_tb";
            this.MaxStock_tb.ReadOnly = true;
            this.MaxStock_tb.Size = new System.Drawing.Size(125, 22);
            this.MaxStock_tb.TabIndex = 7;
            // 
            // MinStock_tb
            // 
            this.MinStock_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinStock_tb.Location = new System.Drawing.Point(145, 22);
            this.MinStock_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinStock_tb.Name = "MinStock_tb";
            this.MinStock_tb.ReadOnly = true;
            this.MinStock_tb.Size = new System.Drawing.Size(125, 22);
            this.MinStock_tb.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maximum Stock: ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Minimum Stock: ";
            // 
            // CustFin_tab
            // 
            this.CustFin_tab.Controls.Add(this.tableLayoutPanel5);
            this.CustFin_tab.Location = new System.Drawing.Point(4, 25);
            this.CustFin_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustFin_tab.Name = "CustFin_tab";
            this.CustFin_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustFin_tab.Size = new System.Drawing.Size(784, 383);
            this.CustFin_tab.TabIndex = 0;
            this.CustFin_tab.Text = "Customers and Financials";
            this.CustFin_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Bank_ch, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(778, 379);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // Bank_ch
            // 
            chartArea4.Name = "ChartArea1";
            this.Bank_ch.ChartAreas.Add(chartArea4);
            this.Bank_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.Bank_ch.Legends.Add(legend4);
            this.Bank_ch.Location = new System.Drawing.Point(3, 3);
            this.Bank_ch.Name = "Bank_ch";
            this.Bank_ch.Size = new System.Drawing.Size(383, 278);
            this.Bank_ch.TabIndex = 9;
            this.Bank_ch.Text = "chart1";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Revenue_tb);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.MinCost_tb);
            this.panel7.Controls.Add(this.MaxCost_tb);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.AvgCost_tb);
            this.panel7.Controls.Add(this.CustAnimals_tb);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(392, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.tableLayoutPanel5.SetRowSpan(this.panel7, 2);
            this.panel7.Size = new System.Drawing.Size(383, 375);
            this.panel7.TabIndex = 6;
            // 
            // Revenue_tb
            // 
            this.Revenue_tb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Revenue_tb.Location = new System.Drawing.Point(245, 296);
            this.Revenue_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Revenue_tb.Name = "Revenue_tb";
            this.Revenue_tb.ReadOnly = true;
            this.Revenue_tb.Size = new System.Drawing.Size(125, 22);
            this.Revenue_tb.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 16);
            this.label20.TabIndex = 26;
            this.label20.Text = "Total Revenue:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 28);
            this.label15.TabIndex = 25;
            this.label15.Text = "Hospital Earnings";
            // 
            // MinCost_tb
            // 
            this.MinCost_tb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinCost_tb.Location = new System.Drawing.Point(245, 251);
            this.MinCost_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinCost_tb.Name = "MinCost_tb";
            this.MinCost_tb.ReadOnly = true;
            this.MinCost_tb.Size = new System.Drawing.Size(125, 22);
            this.MinCost_tb.TabIndex = 24;
            // 
            // MaxCost_tb
            // 
            this.MaxCost_tb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaxCost_tb.Location = new System.Drawing.Point(245, 203);
            this.MaxCost_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxCost_tb.Name = "MaxCost_tb";
            this.MaxCost_tb.ReadOnly = true;
            this.MaxCost_tb.Size = new System.Drawing.Size(125, 22);
            this.MaxCost_tb.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Maximum Appointment Cost:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "Minimum Appointment Cost:";
            // 
            // AvgCost_tb
            // 
            this.AvgCost_tb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvgCost_tb.Location = new System.Drawing.Point(245, 157);
            this.AvgCost_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvgCost_tb.Name = "AvgCost_tb";
            this.AvgCost_tb.ReadOnly = true;
            this.AvgCost_tb.Size = new System.Drawing.Size(125, 22);
            this.AvgCost_tb.TabIndex = 20;
            // 
            // CustAnimals_tb
            // 
            this.CustAnimals_tb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CustAnimals_tb.Location = new System.Drawing.Point(245, 113);
            this.CustAnimals_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustAnimals_tb.Name = "CustAnimals_tb";
            this.CustAnimals_tb.ReadOnly = true;
            this.CustAnimals_tb.Size = new System.Drawing.Size(125, 22);
            this.CustAnimals_tb.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(262, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Average Number of Animals Per Customer:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "Average Appointment Cost:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.EmpBank_tb);
            this.panel8.Controls.Add(this.CustBank_tb);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 286);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(383, 91);
            this.panel8.TabIndex = 4;
            // 
            // EmpBank_tb
            // 
            this.EmpBank_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmpBank_tb.Location = new System.Drawing.Point(187, 47);
            this.EmpBank_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpBank_tb.Name = "EmpBank_tb";
            this.EmpBank_tb.ReadOnly = true;
            this.EmpBank_tb.Size = new System.Drawing.Size(125, 22);
            this.EmpBank_tb.TabIndex = 11;
            // 
            // CustBank_tb
            // 
            this.CustBank_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustBank_tb.Location = new System.Drawing.Point(187, 20);
            this.CustBank_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustBank_tb.Name = "CustBank_tb";
            this.CustBank_tb.ReadOnly = true;
            this.CustBank_tb.Size = new System.Drawing.Size(125, 22);
            this.CustBank_tb.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Majority Employee Bank:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Majority Customer Bank:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 48);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hospital Statistics";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 655);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // HospitalStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HospitalStatistics";
            this.Text = "Hospital Statistics";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.AvailAppts_tab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Appt_ch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avail_ch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Vaccines_tab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.Vaccine_ch)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.CustFin_tab.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bank_ch)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Button Back_bt;
        private TabControl tabControl1;
        private TabPage AvailAppts_tab;
        private TabPage Vaccines_tab;
        private TabPage CustFin_tab;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel8;
        private Label label3;
        private Label label2;
        private TextBox ApptAvg_tb;
        private TextBox ApptTotal_tb;
        private Label label4;
        private Label label5;
        private TextBox AvailAvg_tb;
        private TextBox AvailTotal_tb;
        private TextBox MaxStock_tb;
        private TextBox MinStock_tb;
        private Label label6;
        private Label label7;
        private Panel panel5;
        private Panel panel7;
        private Label label12;
        private TextBox TotalImm_tb;
        private TextBox AvgImm_tb;
        private Label label10;
        private Label label11;
        private TextBox MaxImm_tb;
        private TextBox MinImm_tb;
        private Label label9;
        private Label label8;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private TextBox EmpBank_tb;
        private TextBox CustBank_tb;
        private Label label13;
        private Label label14;
        private TextBox Revenue_tb;
        private Label label20;
        private Label label15;
        private TextBox MinCost_tb;
        private TextBox MaxCost_tb;
        private Label label16;
        private Label label17;
        private TextBox AvgCost_tb;
        private TextBox CustAnimals_tb;
        private Label label18;
        private Label label19;
        private System.Windows.Forms.DataVisualization.Charting.Chart Appt_ch;
        private System.Windows.Forms.DataVisualization.Charting.Chart Avail_ch;
        private System.Windows.Forms.DataVisualization.Charting.Chart Avail_chVaccine_ch;
        private System.Windows.Forms.DataVisualization.Charting.Chart Bank_ch;
    }
}