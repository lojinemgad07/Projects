using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;



using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataBaseProjectPawell
{
    partial class AdminAvailAppt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AlreadyConfirmed_lb = new System.Windows.Forms.Label();
            this.SelectionError_lb = new System.Windows.Forms.Label();
            this.Back_bt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Availabilities_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Availabilities_dgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowBooked_cb = new System.Windows.Forms.CheckBox();
            this.Appointments_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Appointments_dgv = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ShowPaid_cb = new System.Windows.Forms.CheckBox();
            this.ConfirmPayment_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Availabilities_tab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Availabilities_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.Appointments_tab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_dgv)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 67);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 520);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments and Availabilities - Admin View";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AlreadyConfirmed_lb);
            this.panel3.Controls.Add(this.SelectionError_lb);
            this.panel3.Controls.Add(this.Back_bt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 470);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 48);
            this.panel3.TabIndex = 4;
            // 
            // AlreadyConfirmed_lb
            // 
            this.AlreadyConfirmed_lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AlreadyConfirmed_lb.AutoSize = true;
            this.AlreadyConfirmed_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyConfirmed_lb.ForeColor = System.Drawing.Color.Red;
            this.AlreadyConfirmed_lb.Location = new System.Drawing.Point(5, 23);
            this.AlreadyConfirmed_lb.Name = "AlreadyConfirmed_lb";
            this.AlreadyConfirmed_lb.Size = new System.Drawing.Size(414, 20);
            this.AlreadyConfirmed_lb.TabIndex = 12;
            this.AlreadyConfirmed_lb.Text = "Payment for this appointment has already been confirmed!";
            // 
            // SelectionError_lb
            // 
            this.SelectionError_lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectionError_lb.AutoSize = true;
            this.SelectionError_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionError_lb.ForeColor = System.Drawing.Color.Red;
            this.SelectionError_lb.Location = new System.Drawing.Point(5, 7);
            this.SelectionError_lb.Name = "SelectionError_lb";
            this.SelectionError_lb.Size = new System.Drawing.Size(446, 20);
            this.SelectionError_lb.TabIndex = 11;
            this.SelectionError_lb.Text = "An appointment must be selected before payment confirmation!";
            // 
            // Back_bt
            // 
            this.Back_bt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Back_bt.Location = new System.Drawing.Point(693, 11);
            this.Back_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_bt.Name = "Back_bt";
            this.Back_bt.Size = new System.Drawing.Size(94, 23);
            this.Back_bt.TabIndex = 10;
            this.Back_bt.Text = "Back";
            this.Back_bt.UseVisualStyleBackColor = true;
            this.Back_bt.Click += new System.EventHandler(this.Back_bt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Availabilities_tab);
            this.tabControl1.Controls.Add(this.Appointments_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 412);
            this.tabControl1.TabIndex = 5;
            // 
            // Availabilities_tab
            // 
            this.Availabilities_tab.Controls.Add(this.tableLayoutPanel3);
            this.Availabilities_tab.Location = new System.Drawing.Point(4, 25);
            this.Availabilities_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Availabilities_tab.Name = "Availabilities_tab";
            this.Availabilities_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Availabilities_tab.Size = new System.Drawing.Size(784, 383);
            this.Availabilities_tab.TabIndex = 0;
            this.Availabilities_tab.Text = "Upcoming Availabilities";
            this.Availabilities_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Availabilities_dgv, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 379);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Availabilities_dgv
            // 
            this.Availabilities_dgv.AllowUserToAddRows = false;
            this.Availabilities_dgv.AllowUserToDeleteRows = false;
            this.Availabilities_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Availabilities_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Availabilities_dgv.Location = new System.Drawing.Point(3, 2);
            this.Availabilities_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Availabilities_dgv.Name = "Availabilities_dgv";
            this.Availabilities_dgv.ReadOnly = true;
            this.Availabilities_dgv.RowHeadersWidth = 51;
            this.Availabilities_dgv.Size = new System.Drawing.Size(772, 337);
            this.Availabilities_dgv.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ShowBooked_cb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 343);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 34);
            this.panel2.TabIndex = 0;
            // 
            // ShowBooked_cb
            // 
            this.ShowBooked_cb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ShowBooked_cb.AutoSize = true;
            this.ShowBooked_cb.Location = new System.Drawing.Point(573, 7);
            this.ShowBooked_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowBooked_cb.Name = "ShowBooked_cb";
            this.ShowBooked_cb.Size = new System.Drawing.Size(196, 20);
            this.ShowBooked_cb.TabIndex = 1;
            this.ShowBooked_cb.Text = "Show booked appointments";
            this.ShowBooked_cb.UseVisualStyleBackColor = true;
            this.ShowBooked_cb.CheckedChanged += new System.EventHandler(this.ShowBooked_cb_CheckedChanged);
            // 
            // Appointments_tab
            // 
            this.Appointments_tab.Controls.Add(this.tableLayoutPanel4);
            this.Appointments_tab.Location = new System.Drawing.Point(4, 25);
            this.Appointments_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Appointments_tab.Name = "Appointments_tab";
            this.Appointments_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Appointments_tab.Size = new System.Drawing.Size(784, 383);
            this.Appointments_tab.TabIndex = 1;
            this.Appointments_tab.Text = "Past Appointments";
            this.Appointments_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Appointments_dgv, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(778, 379);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Appointments_dgv
            // 
            this.Appointments_dgv.AllowUserToAddRows = false;
            this.Appointments_dgv.AllowUserToDeleteRows = false;
            this.Appointments_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointments_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Appointments_dgv.Location = new System.Drawing.Point(3, 2);
            this.Appointments_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Appointments_dgv.Name = "Appointments_dgv";
            this.Appointments_dgv.ReadOnly = true;
            this.Appointments_dgv.RowHeadersWidth = 51;
            this.Appointments_dgv.Size = new System.Drawing.Size(772, 337);
            this.Appointments_dgv.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ShowPaid_cb);
            this.panel4.Controls.Add(this.ConfirmPayment_bt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 343);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 34);
            this.panel4.TabIndex = 0;
            // 
            // ShowPaid_cb
            // 
            this.ShowPaid_cb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ShowPaid_cb.AutoSize = true;
            this.ShowPaid_cb.Location = new System.Drawing.Point(593, 8);
            this.ShowPaid_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowPaid_cb.Name = "ShowPaid_cb";
            this.ShowPaid_cb.Size = new System.Drawing.Size(176, 20);
            this.ShowPaid_cb.TabIndex = 4;
            this.ShowPaid_cb.Text = "Show paid appointments";
            this.ShowPaid_cb.UseVisualStyleBackColor = true;
            this.ShowPaid_cb.CheckedChanged += new System.EventHandler(this.ShowPaid_cb_CheckedChanged);
            // 
            // ConfirmPayment_bt
            // 
            this.ConfirmPayment_bt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConfirmPayment_bt.Location = new System.Drawing.Point(3, 7);
            this.ConfirmPayment_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmPayment_bt.Name = "ConfirmPayment_bt";
            this.ConfirmPayment_bt.Size = new System.Drawing.Size(362, 23);
            this.ConfirmPayment_bt.TabIndex = 3;
            this.ConfirmPayment_bt.Text = "Confirm Payment for Selected Appointment";
            this.ConfirmPayment_bt.UseVisualStyleBackColor = true;
            this.ConfirmPayment_bt.Click += new System.EventHandler(this.ConfirmPayment_bt_Click);
            // 
            // AdminAvailAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminAvailAppt";
            this.Text = "Availabilities and Appointments - Admin View";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Availabilities_tab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Availabilities_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Appointments_tab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_dgv)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage Availabilities_tab;
        private TabPage Appointments_tab;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView Availabilities_dgv;
        private Panel panel2;
        private CheckBox ShowBooked_cb;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private DataGridView Appointments_dgv;
        private Label AlreadyConfirmed_lb;
        private Label SelectionError_lb;
        private Button Back_bt;
        private CheckBox ShowPaid_cb;
        private Button ConfirmPayment_bt;
    }
}