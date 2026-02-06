namespace DataBaseProjectPawell
{
    partial class Form2
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnback = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtbw = new System.Windows.Forms.TextBox();
            this.lblbw = new System.Windows.Forms.Label();
            this.cmbbreed = new System.Windows.Forms.ComboBox();
            this.lblbreed = new System.Windows.Forms.Label();
            this.cmbspecies = new System.Windows.Forms.ComboBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.cmbcust = new System.Windows.Forms.ComboBox();
            this.txtcw = new System.Windows.Forms.TextBox();
            this.lblcw = new System.Windows.Forms.Label();
            this.lblspecies = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Navy;
            this.guna2Panel1.Controls.Add(this.btnback);
            this.guna2Panel1.Location = new System.Drawing.Point(-4, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(158, 575);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Silver;
            this.btnback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnback.FillColor = System.Drawing.Color.Silver;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(26, 35);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(110, 26);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.btnadd);
            this.guna2Panel2.Controls.Add(this.dtp1);
            this.guna2Panel2.Controls.Add(this.lbldate);
            this.guna2Panel2.Controls.Add(this.txtbw);
            this.guna2Panel2.Controls.Add(this.lblbw);
            this.guna2Panel2.Controls.Add(this.cmbbreed);
            this.guna2Panel2.Controls.Add(this.lblbreed);
            this.guna2Panel2.Controls.Add(this.cmbspecies);
            this.guna2Panel2.Controls.Add(this.cmbgender);
            this.guna2Panel2.Controls.Add(this.cmbcust);
            this.guna2Panel2.Controls.Add(this.txtcw);
            this.guna2Panel2.Controls.Add(this.lblcw);
            this.guna2Panel2.Controls.Add(this.lblspecies);
            this.guna2Panel2.Controls.Add(this.lblgender);
            this.guna2Panel2.Controls.Add(this.txtname);
            this.guna2Panel2.Controls.Add(this.lblname);
            this.guna2Panel2.Controls.Add(this.lblcust);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Location = new System.Drawing.Point(224, 115);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(638, 411);
            this.guna2Panel2.TabIndex = 23;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.FillColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(447, 353);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 28);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(447, 246);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(132, 22);
            this.dtp1.TabIndex = 19;
            this.dtp1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(354, 245);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(87, 23);
            this.lbldate.TabIndex = 18;
            this.lbldate.Text = "Birth Date";
            // 
            // txtbw
            // 
            this.txtbw.Location = new System.Drawing.Point(181, 293);
            this.txtbw.Name = "txtbw";
            this.txtbw.Size = new System.Drawing.Size(121, 22);
            this.txtbw.TabIndex = 17;
            // 
            // lblbw
            // 
            this.lblbw.AutoSize = true;
            this.lblbw.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbw.Location = new System.Drawing.Point(52, 291);
            this.lblbw.Name = "lblbw";
            this.lblbw.Size = new System.Drawing.Size(105, 23);
            this.lblbw.TabIndex = 16;
            this.lblbw.Text = "Birth Weight";
            // 
            // cmbbreed
            // 
            this.cmbbreed.FormattingEnabled = true;
            this.cmbbreed.Location = new System.Drawing.Point(447, 200);
            this.cmbbreed.Name = "cmbbreed";
            this.cmbbreed.Size = new System.Drawing.Size(121, 24);
            this.cmbbreed.TabIndex = 15;
            this.cmbbreed.SelectedIndexChanged += new System.EventHandler(this.cmbbreed_SelectedIndexChanged);
            // 
            // lblbreed
            // 
            this.lblbreed.AutoSize = true;
            this.lblbreed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbreed.Location = new System.Drawing.Point(381, 198);
            this.lblbreed.Name = "lblbreed";
            this.lblbreed.Size = new System.Drawing.Size(54, 23);
            this.lblbreed.TabIndex = 14;
            this.lblbreed.Text = "Breed";
            // 
            // cmbspecies
            // 
            this.cmbspecies.FormattingEnabled = true;
            this.cmbspecies.Location = new System.Drawing.Point(447, 151);
            this.cmbspecies.Name = "cmbspecies";
            this.cmbspecies.Size = new System.Drawing.Size(121, 24);
            this.cmbspecies.TabIndex = 13;
            this.cmbspecies.SelectedIndexChanged += new System.EventHandler(this.cmbspecies_SelectedIndexChanged);
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Location = new System.Drawing.Point(181, 198);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(121, 24);
            this.cmbgender.TabIndex = 12;
            // 
            // cmbcust
            // 
            this.cmbcust.FormattingEnabled = true;
            this.cmbcust.Location = new System.Drawing.Point(181, 105);
            this.cmbcust.Name = "cmbcust";
            this.cmbcust.Size = new System.Drawing.Size(121, 24);
            this.cmbcust.TabIndex = 11;
            // 
            // txtcw
            // 
            this.txtcw.Location = new System.Drawing.Point(181, 245);
            this.txtcw.Name = "txtcw";
            this.txtcw.Size = new System.Drawing.Size(121, 22);
            this.txtcw.TabIndex = 10;
            // 
            // lblcw
            // 
            this.lblcw.AutoSize = true;
            this.lblcw.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcw.Location = new System.Drawing.Point(30, 243);
            this.lblcw.Name = "lblcw";
            this.lblcw.Size = new System.Drawing.Size(127, 23);
            this.lblcw.TabIndex = 9;
            this.lblcw.Text = "Current Weight";
            // 
            // lblspecies
            // 
            this.lblspecies.AutoSize = true;
            this.lblspecies.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspecies.Location = new System.Drawing.Point(375, 151);
            this.lblspecies.Name = "lblspecies";
            this.lblspecies.Size = new System.Drawing.Size(66, 23);
            this.lblspecies.TabIndex = 7;
            this.lblspecies.Text = "Species";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(91, 196);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(66, 23);
            this.lblgender.TabIndex = 5;
            this.lblgender.Text = "Gender";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(181, 150);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 22);
            this.txtname.TabIndex = 4;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(39, 148);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(125, 23);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Animal\'s Name";
            // 
            // lblcust
            // 
            this.lblcust.AutoSize = true;
            this.lblcust.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust.Location = new System.Drawing.Point(18, 103);
            this.lblcust.Name = "lblcust";
            this.lblcust.Size = new System.Drawing.Size(146, 23);
            this.lblcust.TabIndex = 2;
            this.lblcust.Text = "Choose Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(217, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 41);
            this.label5.TabIndex = 37;
            this.label5.Text = "Add Animal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 571);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnback;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.TextBox txtcw;
        private System.Windows.Forms.Label lblcw;
        private System.Windows.Forms.Label lblspecies;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblcust;
        private System.Windows.Forms.ComboBox cmbcust;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ComboBox cmbspecies;
        private System.Windows.Forms.ComboBox cmbbreed;
        private System.Windows.Forms.Label lblbreed;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtbw;
        private System.Windows.Forms.Label lblbw;
        private System.Windows.Forms.DateTimePicker dtp1;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}