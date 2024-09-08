namespace Payroll_Pellosis
{
    partial class Form1
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.nmrDays = new System.Windows.Forms.NumericUpDown();
            this.outputPayroll = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrDays)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(133, 64);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(135, 20);
            this.txtEmpName.TabIndex = 0;
            this.txtEmpName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEname
            // 
            this.txtEname.AutoSize = true;
            this.txtEname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEname.Location = new System.Drawing.Point(17, 64);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(110, 17);
            this.txtEname.TabIndex = 1;
            this.txtEname.Text = "Employee Name:";
            this.txtEname.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Permanent",
            "Probationary",
            "Contractual"});
            this.cmbStatus.Location = new System.Drawing.Point(133, 90);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(135, 21);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Laging Lugi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Days Worked:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(21, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Info";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(133, 144);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(135, 36);
            this.btnCompute.TabIndex = 8;
            this.btnCompute.Text = "Compute Payroll";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.button2_Click);
            // 
            // nmrDays
            // 
            this.nmrDays.Location = new System.Drawing.Point(133, 118);
            this.nmrDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nmrDays.Name = "nmrDays";
            this.nmrDays.Size = new System.Drawing.Size(135, 20);
            this.nmrDays.TabIndex = 9;
            this.nmrDays.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // outputPayroll
            // 
            this.outputPayroll.Location = new System.Drawing.Point(11, 190);
            this.outputPayroll.Name = "outputPayroll";
            this.outputPayroll.ReadOnly = true;
            this.outputPayroll.Size = new System.Drawing.Size(257, 216);
            this.outputPayroll.TabIndex = 10;
            this.outputPayroll.Text = "";
            this.outputPayroll.TextChanged += new System.EventHandler(this.outputPayroll_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(18, 44);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(19, 13);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "CJ";
            this.lblDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(160, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(19, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "CJ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 416);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.outputPayroll);
            this.Controls.Add(this.nmrDays);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEmpName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label txtEname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.NumericUpDown nmrDays;
        private System.Windows.Forms.RichTextBox outputPayroll;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

