using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataBaseProjectPawell
{
    partial class AvailableVaccines
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameError_lb = new System.Windows.Forms.Label();
            this.CodeError_lb = new System.Windows.Forms.Label();
            this.StockError_lb = new System.Windows.Forms.Label();
            this.YearsError_lb = new System.Windows.Forms.Label();
            this.EmptyField_lb = new System.Windows.Forms.Label();
            this.Back_bt = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.UpdateExpiry_dtpck = new System.Windows.Forms.DateTimePicker();
            this.UpdateStock_tb = new System.Windows.Forms.TextBox();
            this.UpdateStock_bt = new System.Windows.Forms.Button();
            this.UpdateStockVaccine_cmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Years_tb = new System.Windows.Forms.TextBox();
            this.AddReq_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Months_cmb = new System.Windows.Forms.ComboBox();
            this.AddReqVaccine_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Species_cmb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddName_tb = new System.Windows.Forms.TextBox();
            this.AddDisease_tb = new System.Windows.Forms.TextBox();
            this.AddStock_tb = new System.Windows.Forms.TextBox();
            this.AddCode_tb = new System.Windows.Forms.TextBox();
            this.AddExpiry_dtpck = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AddManufacturer_tb = new System.Windows.Forms.TextBox();
            this.AddVaccine_bt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Requirements_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Vaccine_dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Requirements_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vaccine_dgv)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 753);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 77);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 598);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NameError_lb);
            this.panel2.Controls.Add(this.CodeError_lb);
            this.panel2.Controls.Add(this.StockError_lb);
            this.panel2.Controls.Add(this.YearsError_lb);
            this.panel2.Controls.Add(this.EmptyField_lb);
            this.panel2.Controls.Add(this.Back_bt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 537);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 59);
            this.panel2.TabIndex = 4;
            // 
            // NameError_lb
            // 
            this.NameError_lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameError_lb.AutoSize = true;
            this.NameError_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameError_lb.ForeColor = System.Drawing.Color.Red;
            this.NameError_lb.Location = new System.Drawing.Point(391, 37);
            this.NameError_lb.Name = "NameError_lb";
            this.NameError_lb.Size = new System.Drawing.Size(207, 20);
            this.NameError_lb.TabIndex = 17;
            this.NameError_lb.Text = "Trade name must be unique!";
            // 
            // CodeError_lb
            // 
            this.CodeError_lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CodeError_lb.AutoSize = true;
            this.CodeError_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeError_lb.ForeColor = System.Drawing.Color.Red;
            this.CodeError_lb.Location = new System.Drawing.Point(391, 21);
            this.CodeError_lb.Name = "CodeError_lb";
            this.CodeError_lb.Size = new System.Drawing.Size(214, 20);
            this.CodeError_lb.TabIndex = 16;
            this.CodeError_lb.Text = "Vaccine code must be unique!";
            // 
            // StockError_lb
            // 
            this.StockError_lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StockError_lb.AutoSize = true;
            this.StockError_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockError_lb.ForeColor = System.Drawing.Color.Red;
            this.StockError_lb.Location = new System.Drawing.Point(5, 37);
            this.StockError_lb.Name = "StockError_lb";
            this.StockError_lb.Size = new System.Drawing.Size(380, 20);
            this.StockError_lb.TabIndex = 15;
            this.StockError_lb.Text = "Stock amount value must be positive a integer or zero!";
            // 
            // YearsError_lb
            // 
            this.YearsError_lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.YearsError_lb.AutoSize = true;
            this.YearsError_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearsError_lb.ForeColor = System.Drawing.Color.Red;
            this.YearsError_lb.Location = new System.Drawing.Point(5, 21);
            this.YearsError_lb.Name = "YearsError_lb";
            this.YearsError_lb.Size = new System.Drawing.Size(325, 20);
            this.YearsError_lb.TabIndex = 14;
            this.YearsError_lb.Text = "Years value must be positive a integer or zero!";
            // 
            // EmptyField_lb
            // 
            this.EmptyField_lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmptyField_lb.AutoSize = true;
            this.EmptyField_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyField_lb.ForeColor = System.Drawing.Color.Red;
            this.EmptyField_lb.Location = new System.Drawing.Point(5, 5);
            this.EmptyField_lb.Name = "EmptyField_lb";
            this.EmptyField_lb.Size = new System.Drawing.Size(245, 20);
            this.EmptyField_lb.TabIndex = 12;
            this.EmptyField_lb.Text = "Associated fields cannot be empty!";
            // 
            // Back_bt
            // 
            this.Back_bt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Back_bt.Location = new System.Drawing.Point(693, 29);
            this.Back_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_bt.Name = "Back_bt";
            this.Back_bt.Size = new System.Drawing.Size(94, 23);
            this.Back_bt.TabIndex = 13;
            this.Back_bt.Text = "Back";
            this.Back_bt.UseVisualStyleBackColor = true;
            this.Back_bt.Click += new System.EventHandler(this.Back_bt_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.UpdateExpiry_dtpck);
            this.groupBox5.Controls.Add(this.UpdateStock_tb);
            this.groupBox5.Controls.Add(this.UpdateStock_bt);
            this.groupBox5.Controls.Add(this.UpdateStockVaccine_cmb);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 454);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(792, 79);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update Existing Stock";
            // 
            // UpdateExpiry_dtpck
            // 
            this.UpdateExpiry_dtpck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateExpiry_dtpck.Location = new System.Drawing.Point(419, 51);
            this.UpdateExpiry_dtpck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateExpiry_dtpck.Name = "UpdateExpiry_dtpck";
            this.UpdateExpiry_dtpck.Size = new System.Drawing.Size(250, 22);
            this.UpdateExpiry_dtpck.TabIndex = 22;
            // 
            // UpdateStock_tb
            // 
            this.UpdateStock_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateStock_tb.Location = new System.Drawing.Point(151, 50);
            this.UpdateStock_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateStock_tb.Name = "UpdateStock_tb";
            this.UpdateStock_tb.Size = new System.Drawing.Size(125, 22);
            this.UpdateStock_tb.TabIndex = 26;
            // 
            // UpdateStock_bt
            // 
            this.UpdateStock_bt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UpdateStock_bt.Location = new System.Drawing.Point(692, 47);
            this.UpdateStock_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateStock_bt.Name = "UpdateStock_bt";
            this.UpdateStock_bt.Size = new System.Drawing.Size(94, 23);
            this.UpdateStock_bt.TabIndex = 23;
            this.UpdateStock_bt.Text = "Update";
            this.UpdateStock_bt.UseVisualStyleBackColor = true;
            this.UpdateStock_bt.Click += new System.EventHandler(this.UpdateStock_bt_Click);
            // 
            // UpdateStockVaccine_cmb
            // 
            this.UpdateStockVaccine_cmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateStockVaccine_cmb.FormattingEnabled = true;
            this.UpdateStockVaccine_cmb.Location = new System.Drawing.Point(125, 23);
            this.UpdateStockVaccine_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateStockVaccine_cmb.Name = "UpdateStockVaccine_cmb";
            this.UpdateStockVaccine_cmb.Size = new System.Drawing.Size(151, 24);
            this.UpdateStockVaccine_cmb.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "New Expiry Date:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Trade Name:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "New Stock Amount:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Years_tb);
            this.groupBox4.Controls.Add(this.AddReq_bt);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Months_cmb);
            this.groupBox4.Controls.Add(this.AddReqVaccine_cmb);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Species_cmb);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 371);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(792, 79);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Vaccination Requirement";
            // 
            // Years_tb
            // 
            this.Years_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Years_tb.Location = new System.Drawing.Point(154, 51);
            this.Years_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Years_tb.Name = "Years_tb";
            this.Years_tb.Size = new System.Drawing.Size(125, 22);
            this.Years_tb.TabIndex = 53;
            // 
            // AddReq_bt
            // 
            this.AddReq_bt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddReq_bt.Location = new System.Drawing.Point(692, 47);
            this.AddReq_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddReq_bt.Name = "AddReq_bt";
            this.AddReq_bt.Size = new System.Drawing.Size(94, 23);
            this.AddReq_bt.TabIndex = 48;
            this.AddReq_bt.Text = "Add";
            this.AddReq_bt.UseVisualStyleBackColor = true;
            this.AddReq_bt.Click += new System.EventHandler(this.AddReq_bt_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "months";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Trade Name:";
            // 
            // Months_cmb
            // 
            this.Months_cmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Months_cmb.FormattingEnabled = true;
            this.Months_cmb.Location = new System.Drawing.Point(353, 50);
            this.Months_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Months_cmb.Name = "Months_cmb";
            this.Months_cmb.Size = new System.Drawing.Size(151, 24);
            this.Months_cmb.TabIndex = 51;
            // 
            // AddReqVaccine_cmb
            // 
            this.AddReqVaccine_cmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddReqVaccine_cmb.FormattingEnabled = true;
            this.AddReqVaccine_cmb.Location = new System.Drawing.Point(128, 23);
            this.AddReqVaccine_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddReqVaccine_cmb.Name = "AddReqVaccine_cmb";
            this.AddReqVaccine_cmb.Size = new System.Drawing.Size(151, 24);
            this.AddReqVaccine_cmb.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "years";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Species:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Minimum Age:";
            // 
            // Species_cmb
            // 
            this.Species_cmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Species_cmb.FormattingEnabled = true;
            this.Species_cmb.Location = new System.Drawing.Point(353, 24);
            this.Species_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Species_cmb.Name = "Species_cmb";
            this.Species_cmb.Size = new System.Drawing.Size(151, 24);
            this.Species_cmb.TabIndex = 47;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddName_tb);
            this.groupBox3.Controls.Add(this.AddDisease_tb);
            this.groupBox3.Controls.Add(this.AddStock_tb);
            this.groupBox3.Controls.Add(this.AddCode_tb);
            this.groupBox3.Controls.Add(this.AddExpiry_dtpck);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.AddManufacturer_tb);
            this.groupBox3.Controls.Add(this.AddVaccine_bt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 264);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(792, 103);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Vaccine";
            // 
            // AddName_tb
            // 
            this.AddName_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddName_tb.Location = new System.Drawing.Point(419, 23);
            this.AddName_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddName_tb.Name = "AddName_tb";
            this.AddName_tb.Size = new System.Drawing.Size(125, 22);
            this.AddName_tb.TabIndex = 43;
            // 
            // AddDisease_tb
            // 
            this.AddDisease_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddDisease_tb.Location = new System.Drawing.Point(419, 47);
            this.AddDisease_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDisease_tb.Name = "AddDisease_tb";
            this.AddDisease_tb.Size = new System.Drawing.Size(125, 22);
            this.AddDisease_tb.TabIndex = 42;
            // 
            // AddStock_tb
            // 
            this.AddStock_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddStock_tb.Location = new System.Drawing.Point(151, 73);
            this.AddStock_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddStock_tb.Name = "AddStock_tb";
            this.AddStock_tb.Size = new System.Drawing.Size(125, 22);
            this.AddStock_tb.TabIndex = 41;
            // 
            // AddCode_tb
            // 
            this.AddCode_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddCode_tb.Location = new System.Drawing.Point(151, 23);
            this.AddCode_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCode_tb.Name = "AddCode_tb";
            this.AddCode_tb.Size = new System.Drawing.Size(125, 22);
            this.AddCode_tb.TabIndex = 40;
            // 
            // AddExpiry_dtpck
            // 
            this.AddExpiry_dtpck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddExpiry_dtpck.Location = new System.Drawing.Point(419, 72);
            this.AddExpiry_dtpck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddExpiry_dtpck.Name = "AddExpiry_dtpck";
            this.AddExpiry_dtpck.Size = new System.Drawing.Size(250, 22);
            this.AddExpiry_dtpck.TabIndex = 35;
            this.AddExpiry_dtpck.Value = new System.DateTime(2025, 12, 12, 11, 7, 13, 0);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "Stock Amout:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(282, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "Stock Expiry Date:";
            // 
            // AddManufacturer_tb
            // 
            this.AddManufacturer_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddManufacturer_tb.Location = new System.Drawing.Point(151, 47);
            this.AddManufacturer_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddManufacturer_tb.Name = "AddManufacturer_tb";
            this.AddManufacturer_tb.Size = new System.Drawing.Size(125, 22);
            this.AddManufacturer_tb.TabIndex = 37;
            // 
            // AddVaccine_bt
            // 
            this.AddVaccine_bt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddVaccine_bt.Location = new System.Drawing.Point(692, 70);
            this.AddVaccine_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddVaccine_bt.Name = "AddVaccine_bt";
            this.AddVaccine_bt.Size = new System.Drawing.Size(94, 23);
            this.AddVaccine_bt.TabIndex = 31;
            this.AddVaccine_bt.Text = "Add";
            this.AddVaccine_bt.UseVisualStyleBackColor = true;
            this.AddVaccine_bt.Click += new System.EventHandler(this.AddVaccine_bt_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Vaccine Code:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Disease/Pathogen:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Trade Name:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Manufacturer:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 211);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Requirements_dgv);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(399, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(390, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existing Vaccine Requirements";
            // 
            // Requirements_dgv
            // 
            this.Requirements_dgv.AllowUserToAddRows = false;
            this.Requirements_dgv.AllowUserToDeleteRows = false;
            this.Requirements_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Requirements_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Requirements_dgv.Location = new System.Drawing.Point(3, 17);
            this.Requirements_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Requirements_dgv.Name = "Requirements_dgv";
            this.Requirements_dgv.ReadOnly = true;
            this.Requirements_dgv.RowHeadersWidth = 51;
            this.Requirements_dgv.Size = new System.Drawing.Size(384, 188);
            this.Requirements_dgv.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Vaccine_dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(390, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Vaccine Stock";
            // 
            // Vaccine_dgv
            // 
            this.Vaccine_dgv.AllowUserToAddRows = false;
            this.Vaccine_dgv.AllowUserToDeleteRows = false;
            this.Vaccine_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vaccine_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vaccine_dgv.Location = new System.Drawing.Point(3, 17);
            this.Vaccine_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vaccine_dgv.Name = "Vaccine_dgv";
            this.Vaccine_dgv.ReadOnly = true;
            this.Vaccine_dgv.RowHeadersWidth = 51;
            this.Vaccine_dgv.Size = new System.Drawing.Size(384, 188);
            this.Vaccine_dgv.TabIndex = 1;
            this.Vaccine_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vaccine_dgv_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hospital Vaccine Stock";
            // 
            // AvailableVaccines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AvailableVaccines";
            this.Text = "Available Vaccines";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Requirements_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Vaccine_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Panel panel2;
        private DataGridView Requirements_dgv;
        private DataGridView Vaccine_dgv;
        private Label label1;
        private TextBox AddName_tb;
        private TextBox AddDisease_tb;
        private TextBox AddStock_tb;
        private TextBox AddCode_tb;
        private DateTimePicker AddExpiry_dtpck;
        private Label label14;
        private Label label15;
        private TextBox AddManufacturer_tb;
        private Button AddVaccine_bt;
        private Label label13;
        private Label label10;
        private Label label12;
        private Label label11;
        private TextBox Years_tb;
        private Button AddReq_bt;
        private Label label5;
        private Label label6;
        private ComboBox Months_cmb;
        private ComboBox AddReqVaccine_cmb;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox Species_cmb;
        private DateTimePicker UpdateExpiry_dtpck;
        private TextBox UpdateStock_tb;
        private Button UpdateStock_bt;
        private ComboBox UpdateStockVaccine_cmb;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label NameError_lb;
        private Label CodeError_lb;
        private Label StockError_lb;
        private Label YearsError_lb;
        private Label EmptyField_lb;
        private Button Back_bt;
    }
}