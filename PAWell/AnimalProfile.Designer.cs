

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataBaseProjectPawell
{
    partial class AnimalProfile
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Info_tab = new System.Windows.Forms.TabPage();
            this.LifeExp_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AvgWt_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Breed_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Diet_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Species_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentWt_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BirtthWt_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Gender_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Age_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Appt_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Procedures_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Prescriptions_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Diagnoses_dgv = new System.Windows.Forms.DataGridView();
            this.Immune_tab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CompletedVaccines_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PendingVaccines_dgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Animal_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Back_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Info_tab.SuspendLayout();
            this.Appt_tab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Procedures_dgv)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prescriptions_dgv)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Diagnoses_dgv)).BeginInit();
            this.Immune_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedVaccines_dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PendingVaccines_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 67);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 520);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Info_tab);
            this.tabControl1.Controls.Add(this.Appt_tab);
            this.tabControl1.Controls.Add(this.Immune_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 90);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 391);
            this.tabControl1.TabIndex = 3;
            // 
            // Info_tab
            // 
            this.Info_tab.Controls.Add(this.LifeExp_tb);
            this.Info_tab.Controls.Add(this.label6);
            this.Info_tab.Controls.Add(this.AvgWt_tb);
            this.Info_tab.Controls.Add(this.label10);
            this.Info_tab.Controls.Add(this.Breed_tb);
            this.Info_tab.Controls.Add(this.label11);
            this.Info_tab.Controls.Add(this.Diet_tb);
            this.Info_tab.Controls.Add(this.label8);
            this.Info_tab.Controls.Add(this.Species_tb);
            this.Info_tab.Controls.Add(this.label9);
            this.Info_tab.Controls.Add(this.CurrentWt_tb);
            this.Info_tab.Controls.Add(this.label4);
            this.Info_tab.Controls.Add(this.BirtthWt_tb);
            this.Info_tab.Controls.Add(this.label5);
            this.Info_tab.Controls.Add(this.Gender_tb);
            this.Info_tab.Controls.Add(this.label3);
            this.Info_tab.Controls.Add(this.Age_tb);
            this.Info_tab.Controls.Add(this.label7);
            this.Info_tab.Location = new System.Drawing.Point(4, 25);
            this.Info_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Info_tab.Name = "Info_tab";
            this.Info_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Info_tab.Size = new System.Drawing.Size(784, 362);
            this.Info_tab.TabIndex = 0;
            this.Info_tab.Text = "General Information";
            this.Info_tab.UseVisualStyleBackColor = true;
            // 
            // LifeExp_tb
            // 
            this.LifeExp_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LifeExp_tb.Location = new System.Drawing.Point(490, 280);
            this.LifeExp_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LifeExp_tb.Name = "LifeExp_tb";
            this.LifeExp_tb.ReadOnly = true;
            this.LifeExp_tb.Size = new System.Drawing.Size(125, 22);
            this.LifeExp_tb.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Life Expectancy";
            // 
            // AvgWt_tb
            // 
            this.AvgWt_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvgWt_tb.Location = new System.Drawing.Point(160, 280);
            this.AvgWt_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvgWt_tb.Name = "AvgWt_tb";
            this.AvgWt_tb.ReadOnly = true;
            this.AvgWt_tb.Size = new System.Drawing.Size(125, 22);
            this.AvgWt_tb.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Average Weight (kg)";
            // 
            // Breed_tb
            // 
            this.Breed_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Breed_tb.Location = new System.Drawing.Point(160, 251);
            this.Breed_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Breed_tb.Name = "Breed_tb";
            this.Breed_tb.ReadOnly = true;
            this.Breed_tb.Size = new System.Drawing.Size(125, 22);
            this.Breed_tb.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Breed";
            // 
            // Diet_tb
            // 
            this.Diet_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Diet_tb.Location = new System.Drawing.Point(160, 181);
            this.Diet_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Diet_tb.Name = "Diet_tb";
            this.Diet_tb.ReadOnly = true;
            this.Diet_tb.Size = new System.Drawing.Size(125, 22);
            this.Diet_tb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Diet";
            // 
            // Species_tb
            // 
            this.Species_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Species_tb.Location = new System.Drawing.Point(160, 151);
            this.Species_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Species_tb.Name = "Species_tb";
            this.Species_tb.ReadOnly = true;
            this.Species_tb.Size = new System.Drawing.Size(125, 22);
            this.Species_tb.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Species";
            // 
            // CurrentWt_tb
            // 
            this.CurrentWt_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentWt_tb.Location = new System.Drawing.Point(490, 75);
            this.CurrentWt_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentWt_tb.Name = "CurrentWt_tb";
            this.CurrentWt_tb.ReadOnly = true;
            this.CurrentWt_tb.Size = new System.Drawing.Size(125, 22);
            this.CurrentWt_tb.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current Weight (kg)";
            // 
            // BirtthWt_tb
            // 
            this.BirtthWt_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BirtthWt_tb.Location = new System.Drawing.Point(490, 46);
            this.BirtthWt_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirtthWt_tb.Name = "BirtthWt_tb";
            this.BirtthWt_tb.ReadOnly = true;
            this.BirtthWt_tb.Size = new System.Drawing.Size(125, 22);
            this.BirtthWt_tb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Birth Weight (kg)";
            // 
            // Gender_tb
            // 
            this.Gender_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Gender_tb.Location = new System.Drawing.Point(160, 75);
            this.Gender_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gender_tb.Name = "Gender_tb";
            this.Gender_tb.ReadOnly = true;
            this.Gender_tb.Size = new System.Drawing.Size(125, 22);
            this.Gender_tb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender";
            // 
            // Age_tb
            // 
            this.Age_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Age_tb.Location = new System.Drawing.Point(160, 46);
            this.Age_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Age_tb.Name = "Age_tb";
            this.Age_tb.ReadOnly = true;
            this.Age_tb.Size = new System.Drawing.Size(125, 22);
            this.Age_tb.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Age";
            // 
            // Appt_tab
            // 
            this.Appt_tab.Controls.Add(this.tableLayoutPanel3);
            this.Appt_tab.Location = new System.Drawing.Point(4, 25);
            this.Appt_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Appt_tab.Name = "Appt_tab";
            this.Appt_tab.Size = new System.Drawing.Size(784, 362);
            this.Appt_tab.TabIndex = 2;
            this.Appt_tab.Text = "Diagnoses/Prescriptions/Procedures";
            this.Appt_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(784, 362);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Procedures_dgv);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(525, 2);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(256, 358);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Past Procedures";
            // 
            // Procedures_dgv
            // 
            this.Procedures_dgv.AllowUserToAddRows = false;
            this.Procedures_dgv.AllowUserToDeleteRows = false;
            this.Procedures_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Procedures_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Procedures_dgv.Location = new System.Drawing.Point(3, 17);
            this.Procedures_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Procedures_dgv.Name = "Procedures_dgv";
            this.Procedures_dgv.ReadOnly = true;
            this.Procedures_dgv.RowHeadersWidth = 51;
            this.Procedures_dgv.Size = new System.Drawing.Size(250, 339);
            this.Procedures_dgv.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Prescriptions_dgv);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(264, 2);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(255, 358);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Past Prescriprions";
            // 
            // Prescriptions_dgv
            // 
            this.Prescriptions_dgv.AllowUserToAddRows = false;
            this.Prescriptions_dgv.AllowUserToDeleteRows = false;
            this.Prescriptions_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prescriptions_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prescriptions_dgv.Location = new System.Drawing.Point(3, 17);
            this.Prescriptions_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prescriptions_dgv.Name = "Prescriptions_dgv";
            this.Prescriptions_dgv.ReadOnly = true;
            this.Prescriptions_dgv.RowHeadersWidth = 51;
            this.Prescriptions_dgv.Size = new System.Drawing.Size(249, 339);
            this.Prescriptions_dgv.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Diagnoses_dgv);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(255, 358);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Past Diagnoses";
            // 
            // Diagnoses_dgv
            // 
            this.Diagnoses_dgv.AllowUserToAddRows = false;
            this.Diagnoses_dgv.AllowUserToDeleteRows = false;
            this.Diagnoses_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Diagnoses_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Diagnoses_dgv.Location = new System.Drawing.Point(3, 17);
            this.Diagnoses_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Diagnoses_dgv.Name = "Diagnoses_dgv";
            this.Diagnoses_dgv.ReadOnly = true;
            this.Diagnoses_dgv.RowHeadersWidth = 51;
            this.Diagnoses_dgv.Size = new System.Drawing.Size(249, 339);
            this.Diagnoses_dgv.TabIndex = 0;
            // 
            // Immune_tab
            // 
            this.Immune_tab.Controls.Add(this.splitContainer2);
            this.Immune_tab.Location = new System.Drawing.Point(4, 25);
            this.Immune_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Immune_tab.Name = "Immune_tab";
            this.Immune_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Immune_tab.Size = new System.Drawing.Size(784, 362);
            this.Immune_tab.TabIndex = 1;
            this.Immune_tab.Text = "Immunization";
            this.Immune_tab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 2);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(778, 358);
            this.splitContainer2.SplitterDistance = 389;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CompletedVaccines_dgv);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(389, 358);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Completed";
            // 
            // CompletedVaccines_dgv
            // 
            this.CompletedVaccines_dgv.AllowUserToAddRows = false;
            this.CompletedVaccines_dgv.AllowUserToDeleteRows = false;
            this.CompletedVaccines_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedVaccines_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompletedVaccines_dgv.Location = new System.Drawing.Point(3, 17);
            this.CompletedVaccines_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompletedVaccines_dgv.Name = "CompletedVaccines_dgv";
            this.CompletedVaccines_dgv.ReadOnly = true;
            this.CompletedVaccines_dgv.RowHeadersWidth = 51;
            this.CompletedVaccines_dgv.Size = new System.Drawing.Size(383, 339);
            this.CompletedVaccines_dgv.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PendingVaccines_dgv);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(385, 358);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pending";
            // 
            // PendingVaccines_dgv
            // 
            this.PendingVaccines_dgv.AllowUserToAddRows = false;
            this.PendingVaccines_dgv.AllowUserToDeleteRows = false;
            this.PendingVaccines_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingVaccines_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingVaccines_dgv.Location = new System.Drawing.Point(3, 17);
            this.PendingVaccines_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PendingVaccines_dgv.Name = "PendingVaccines_dgv";
            this.PendingVaccines_dgv.ReadOnly = true;
            this.PendingVaccines_dgv.RowHeadersWidth = 51;
            this.PendingVaccines_dgv.Size = new System.Drawing.Size(379, 339);
            this.PendingVaccines_dgv.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Animal_cmb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 32);
            this.panel2.TabIndex = 1;
            // 
            // Animal_cmb
            // 
            this.Animal_cmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Animal_cmb.FormattingEnabled = true;
            this.Animal_cmb.Location = new System.Drawing.Point(128, 5);
            this.Animal_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Animal_cmb.Name = "Animal_cmb";
            this.Animal_cmb.Size = new System.Drawing.Size(151, 24);
            this.Animal_cmb.TabIndex = 3;
            this.Animal_cmb.SelectedIndexChanged += new System.EventHandler(this.Animal_cmb_SelectedIndexChanged_1);
            this.Animal_cmb.Click += new System.EventHandler(this.Animal_cmb_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Animal:";
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
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Animals\' Information";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Back_bt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 485);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 33);
            this.panel3.TabIndex = 4;
            // 
            // Back_bt
            // 
            this.Back_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_bt.Location = new System.Drawing.Point(694, 4);
            this.Back_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_bt.Name = "Back_bt";
            this.Back_bt.Size = new System.Drawing.Size(94, 23);
            this.Back_bt.TabIndex = 8;
            this.Back_bt.Text = "Back";
            this.Back_bt.UseVisualStyleBackColor = true;
            this.Back_bt.Click += new System.EventHandler(this.Back_bt_Click);
            // 
            // AnimalProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1006, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnimalProfile";
            this.Text = "Animal Profile";
            this.Load += new System.EventHandler(this.AnimalProfile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Info_tab.ResumeLayout(false);
            this.Info_tab.PerformLayout();
            this.Appt_tab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Procedures_dgv)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prescriptions_dgv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Diagnoses_dgv)).EndInit();
            this.Immune_tab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompletedVaccines_dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PendingVaccines_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private ComboBox Animal_cmb;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage Info_tab;
        private TextBox LifeExp_tb;
        private Label label6;
        private TextBox AvgWt_tb;
        private Label label10;
        private TextBox Breed_tb;
        private Label label11;
        private TextBox Diet_tb;
        private Label label8;
        private TextBox Species_tb;
        private Label label9;
        private TextBox CurrentWt_tb;
        private Label label4;
        private TextBox BirtthWt_tb;
        private Label label5;
        private TextBox Gender_tb;
        private Label label3;
        private TextBox Age_tb;
        private Label label7;
        private TabPage Appt_tab;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox6;
        private DataGridView Procedures_dgv;
        private GroupBox groupBox5;
        private DataGridView Prescriptions_dgv;
        private GroupBox groupBox4;
        private DataGridView Diagnoses_dgv;
        private TabPage Immune_tab;
        private SplitContainer splitContainer2;
        private GroupBox groupBox2;
        private DataGridView CompletedVaccines_dgv;
        private GroupBox groupBox3;
        private DataGridView PendingVaccines_dgv;
        private Panel panel3;
        private Button Back_bt;
    }
}