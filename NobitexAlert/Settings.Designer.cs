
namespace NobitexAlert
{
    partial class Settings
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
            btnKill = new System.Windows.Forms.Button();
            txtSymbol = new System.Windows.Forms.TextBox();
            btnOK = new System.Windows.Forms.Button();
            numUpDwnOpacity = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            numUpDwnAlertTimes = new System.Windows.Forms.NumericUpDown();
            txtBelow = new MyFloatTextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtAbove = new MyFloatTextBox();
            chkEnableAlert = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            radiobtnGlobal = new System.Windows.Forms.RadioButton();
            radiobtnRIAL = new System.Windows.Forms.RadioButton();
            radiobtnUSDT = new System.Windows.Forms.RadioButton();
            radiobtnIRT = new System.Windows.Forms.RadioButton();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            numUpDwnUpdateInterval = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numUpDwnOpacity).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDwnAlertTimes).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDwnUpdateInterval).BeginInit();
            SuspendLayout();
            // 
            // btnKill
            // 
            btnKill.Location = new System.Drawing.Point(13, 269);
            btnKill.Name = "btnKill";
            btnKill.Size = new System.Drawing.Size(75, 23);
            btnKill.TabIndex = 0;
            btnKill.Text = "Kill App";
            btnKill.UseVisualStyleBackColor = true;
            btnKill.Click += btnKill_Click;
            // 
            // txtSymbol
            // 
            txtSymbol.Location = new System.Drawing.Point(13, 13);
            txtSymbol.MaxLength = 50;
            txtSymbol.Name = "txtSymbol";
            txtSymbol.PlaceholderText = "Insert Crypto Symbol here to get its current price";
            txtSymbol.Size = new System.Drawing.Size(352, 23);
            txtSymbol.TabIndex = 1;
            txtSymbol.TextChanged += txtSymbol_TextChanged;
            // 
            // btnOK
            // 
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(13, 240);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(75, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // numUpDwnOpacity
            // 
            numUpDwnOpacity.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDwnOpacity.Location = new System.Drawing.Point(306, 271);
            numUpDwnOpacity.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDwnOpacity.Name = "numUpDwnOpacity";
            numUpDwnOpacity.Size = new System.Drawing.Size(58, 23);
            numUpDwnOpacity.TabIndex = 3;
            numUpDwnOpacity.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDwnOpacity.ValueChanged += numUpDwnOpacity_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(252, 274);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Opacity";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numUpDwnAlertTimes);
            groupBox1.Controls.Add(txtBelow);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAbove);
            groupBox1.Controls.Add(chkEnableAlert);
            groupBox1.Location = new System.Drawing.Point(141, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(223, 110);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alert options";
            // 
            // numUpDwnAlertTimes
            // 
            numUpDwnAlertTimes.Location = new System.Drawing.Point(89, 75);
            numUpDwnAlertTimes.Name = "numUpDwnAlertTimes";
            numUpDwnAlertTimes.Size = new System.Drawing.Size(61, 23);
            numUpDwnAlertTimes.TabIndex = 5;
            numUpDwnAlertTimes.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtBelow
            // 
            txtBelow.Location = new System.Drawing.Point(53, 46);
            txtBelow.Name = "txtBelow";
            txtBelow.PlaceholderText = "Price";
            txtBelow.Size = new System.Drawing.Size(97, 23);
            txtBelow.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 79);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Alert Times";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 49);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Below";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Above";
            // 
            // txtAbove
            // 
            txtAbove.Location = new System.Drawing.Point(53, 17);
            txtAbove.Name = "txtAbove";
            txtAbove.PlaceholderText = "Price";
            txtAbove.Size = new System.Drawing.Size(97, 23);
            txtAbove.TabIndex = 1;
            // 
            // chkEnableAlert
            // 
            chkEnableAlert.AutoSize = true;
            chkEnableAlert.Location = new System.Drawing.Point(156, 32);
            chkEnableAlert.Name = "chkEnableAlert";
            chkEnableAlert.Size = new System.Drawing.Size(61, 19);
            chkEnableAlert.TabIndex = 0;
            chkEnableAlert.Text = "Enable";
            chkEnableAlert.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radiobtnGlobal);
            groupBox2.Controls.Add(radiobtnRIAL);
            groupBox2.Controls.Add(radiobtnUSDT);
            groupBox2.Controls.Add(radiobtnIRT);
            groupBox2.Location = new System.Drawing.Point(13, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(351, 62);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Currency";
            // 
            // radiobtnGlobal
            // 
            radiobtnGlobal.AutoSize = true;
            radiobtnGlobal.Location = new System.Drawing.Point(283, 26);
            radiobtnGlobal.Name = "radiobtnGlobal";
            radiobtnGlobal.Size = new System.Drawing.Size(59, 19);
            radiobtnGlobal.TabIndex = 0;
            radiobtnGlobal.TabStop = true;
            radiobtnGlobal.Text = "Global";
            radiobtnGlobal.UseVisualStyleBackColor = true;
            // 
            // radiobtnRIAL
            // 
            radiobtnRIAL.AutoSize = true;
            radiobtnRIAL.Location = new System.Drawing.Point(98, 26);
            radiobtnRIAL.Name = "radiobtnRIAL";
            radiobtnRIAL.Size = new System.Drawing.Size(49, 19);
            radiobtnRIAL.TabIndex = 0;
            radiobtnRIAL.TabStop = true;
            radiobtnRIAL.Text = "RIAL";
            radiobtnRIAL.UseVisualStyleBackColor = true;
            // 
            // radiobtnUSDT
            // 
            radiobtnUSDT.AutoSize = true;
            radiobtnUSDT.Location = new System.Drawing.Point(189, 26);
            radiobtnUSDT.Name = "radiobtnUSDT";
            radiobtnUSDT.Size = new System.Drawing.Size(52, 19);
            radiobtnUSDT.TabIndex = 0;
            radiobtnUSDT.TabStop = true;
            radiobtnUSDT.Text = "USDT";
            radiobtnUSDT.UseVisualStyleBackColor = true;
            // 
            // radiobtnIRT
            // 
            radiobtnIRT.AutoSize = true;
            radiobtnIRT.Location = new System.Drawing.Point(16, 26);
            radiobtnIRT.Name = "radiobtnIRT";
            radiobtnIRT.Size = new System.Drawing.Size(40, 19);
            radiobtnIRT.TabIndex = 0;
            radiobtnIRT.TabStop = true;
            radiobtnIRT.Text = "IRT";
            radiobtnIRT.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(numUpDwnUpdateInterval);
            groupBox3.Location = new System.Drawing.Point(15, 43);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(120, 110);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update Interval";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 25);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 15);
            label5.TabIndex = 6;
            label5.Text = "In miliseconds:";
            // 
            // numUpDwnUpdateInterval
            // 
            numUpDwnUpdateInterval.Location = new System.Drawing.Point(14, 43);
            numUpDwnUpdateInterval.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numUpDwnUpdateInterval.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numUpDwnUpdateInterval.Name = "numUpDwnUpdateInterval";
            numUpDwnUpdateInterval.Size = new System.Drawing.Size(100, 23);
            numUpDwnUpdateInterval.TabIndex = 5;
            numUpDwnUpdateInterval.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numUpDwnUpdateInterval.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(19, 75);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(84, 15);
            label6.TabIndex = 6;
            label6.Text = "Rerun to apply";
            // 
            // Settings
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(378, 306);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(numUpDwnOpacity);
            Controls.Add(btnOK);
            Controls.Add(txtSymbol);
            Controls.Add(btnKill);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            Text = "Settings";
            TopMost = true;
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)numUpDwnOpacity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDwnAlertTimes).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDwnUpdateInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown numUpDwnOpacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUpDwnAlertTimes;
        private MyFloatTextBox txtBelow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MyFloatTextBox txtAbove;
        private System.Windows.Forms.CheckBox chkEnableAlert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobtnGlobal;
        private System.Windows.Forms.RadioButton radiobtnUSDT;
        private System.Windows.Forms.RadioButton radiobtnIRT;
        private System.Windows.Forms.RadioButton radiobtnRIAL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUpDwnUpdateInterval;
        private System.Windows.Forms.Label label6;
    }
}