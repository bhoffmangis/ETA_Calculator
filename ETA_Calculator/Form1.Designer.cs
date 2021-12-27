namespace ETA_Calculator
{
    partial class ETA_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ETA_Calculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.txtStartMin = new System.Windows.Forms.TextBox();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.txtEndMin = new System.Windows.Forms.TextBox();
            this.lblETAHour = new System.Windows.Forms.Label();
            this.lblETAMin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpStartAMPM = new System.Windows.Forms.GroupBox();
            this.rdoStartPM = new System.Windows.Forms.RadioButton();
            this.rdoStartAM = new System.Windows.Forms.RadioButton();
            this.grpEndAMPM = new System.Windows.Forms.GroupBox();
            this.rdoEndPM = new System.Windows.Forms.RadioButton();
            this.rdoEndAM = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStartAMPM.SuspendLayout();
            this.grpEndAMPM.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time";
            this.toolTip1.SetToolTip(this.label1, "Enter start time");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Time";
            this.toolTip1.SetToolTip(this.label2, "Enter end time");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elapsed";
            this.toolTip1.SetToolTip(this.label3, "Displays elapsed time in HH : MM format");
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(102, 47);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(40, 20);
            this.txtStartHour.TabIndex = 1;
            this.txtStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartMin
            // 
            this.txtStartMin.Location = new System.Drawing.Point(161, 47);
            this.txtStartMin.Name = "txtStartMin";
            this.txtStartMin.Size = new System.Drawing.Size(40, 20);
            this.txtStartMin.TabIndex = 2;
            this.txtStartMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(102, 85);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(40, 20);
            this.txtEndHour.TabIndex = 3;
            this.txtEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMin
            // 
            this.txtEndMin.Location = new System.Drawing.Point(161, 85);
            this.txtEndMin.Name = "txtEndMin";
            this.txtEndMin.Size = new System.Drawing.Size(40, 20);
            this.txtEndMin.TabIndex = 4;
            this.txtEndMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblETAHour
            // 
            this.lblETAHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblETAHour.Location = new System.Drawing.Point(102, 125);
            this.lblETAHour.Name = "lblETAHour";
            this.lblETAHour.Size = new System.Drawing.Size(40, 20);
            this.lblETAHour.TabIndex = 7;
            this.lblETAHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblETAMin
            // 
            this.lblETAMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblETAMin.Location = new System.Drawing.Point(161, 125);
            this.lblETAMin.Name = "lblETAMin";
            this.lblETAMin.Size = new System.Drawing.Size(40, 20);
            this.lblETAMin.TabIndex = 8;
            this.lblETAMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = ":";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(32, 207);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "Calculates elapsed time");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(146, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clears all form fields");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpStartAMPM
            // 
            this.grpStartAMPM.Controls.Add(this.rdoStartPM);
            this.grpStartAMPM.Controls.Add(this.rdoStartAM);
            this.grpStartAMPM.Location = new System.Drawing.Point(207, 32);
            this.grpStartAMPM.Name = "grpStartAMPM";
            this.grpStartAMPM.Size = new System.Drawing.Size(50, 44);
            this.grpStartAMPM.TabIndex = 18;
            this.grpStartAMPM.TabStop = false;
            // 
            // rdoStartPM
            // 
            this.rdoStartPM.AutoSize = true;
            this.rdoStartPM.Location = new System.Drawing.Point(6, 24);
            this.rdoStartPM.Name = "rdoStartPM";
            this.rdoStartPM.Size = new System.Drawing.Size(41, 17);
            this.rdoStartPM.TabIndex = 4;
            this.rdoStartPM.TabStop = true;
            this.rdoStartPM.Text = "PM";
            this.rdoStartPM.UseVisualStyleBackColor = true;
            // 
            // rdoStartAM
            // 
            this.rdoStartAM.AutoSize = true;
            this.rdoStartAM.Location = new System.Drawing.Point(6, 7);
            this.rdoStartAM.Name = "rdoStartAM";
            this.rdoStartAM.Size = new System.Drawing.Size(41, 17);
            this.rdoStartAM.TabIndex = 3;
            this.rdoStartAM.TabStop = true;
            this.rdoStartAM.Text = "AM";
            this.rdoStartAM.UseVisualStyleBackColor = true;
            // 
            // grpEndAMPM
            // 
            this.grpEndAMPM.Controls.Add(this.rdoEndPM);
            this.grpEndAMPM.Controls.Add(this.rdoEndAM);
            this.grpEndAMPM.Location = new System.Drawing.Point(207, 70);
            this.grpEndAMPM.Name = "grpEndAMPM";
            this.grpEndAMPM.Size = new System.Drawing.Size(50, 44);
            this.grpEndAMPM.TabIndex = 19;
            this.grpEndAMPM.TabStop = false;
            // 
            // rdoEndPM
            // 
            this.rdoEndPM.AutoSize = true;
            this.rdoEndPM.Location = new System.Drawing.Point(6, 24);
            this.rdoEndPM.Name = "rdoEndPM";
            this.rdoEndPM.Size = new System.Drawing.Size(41, 17);
            this.rdoEndPM.TabIndex = 8;
            this.rdoEndPM.TabStop = true;
            this.rdoEndPM.Text = "PM";
            this.rdoEndPM.UseVisualStyleBackColor = true;
            // 
            // rdoEndAM
            // 
            this.rdoEndAM.AutoSize = true;
            this.rdoEndAM.Location = new System.Drawing.Point(6, 7);
            this.rdoEndAM.Name = "rdoEndAM";
            this.rdoEndAM.Size = new System.Drawing.Size(41, 17);
            this.rdoEndAM.TabIndex = 7;
            this.rdoEndAM.TabStop = true;
            this.rdoEndAM.Text = "AM";
            this.rdoEndAM.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Decimal";
            this.toolTip1.SetToolTip(this.label7, "Displays elapsed time in decimal format");
            // 
            // lblDecimal
            // 
            this.lblDecimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDecimal.Location = new System.Drawing.Point(102, 163);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(100, 23);
            this.lblDecimal.TabIndex = 9;
            this.lblDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // ETA_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(280, 262);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblETAMin);
            this.Controls.Add(this.lblETAHour);
            this.Controls.Add(this.txtEndMin);
            this.Controls.Add(this.txtEndHour);
            this.Controls.Add(this.txtStartMin);
            this.Controls.Add(this.txtStartHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpStartAMPM);
            this.Controls.Add(this.grpEndAMPM);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ETA_Calculator";
            this.Text = "Elapsed Time Calculator";
            this.Load += new System.EventHandler(this.ETA_Calculator_Load);
            this.grpStartAMPM.ResumeLayout(false);
            this.grpStartAMPM.PerformLayout();
            this.grpEndAMPM.ResumeLayout(false);
            this.grpEndAMPM.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.TextBox txtStartMin;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.TextBox txtEndMin;
        private System.Windows.Forms.Label lblETAHour;
        private System.Windows.Forms.Label lblETAMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpStartAMPM;
        private System.Windows.Forms.RadioButton rdoStartPM;
        private System.Windows.Forms.RadioButton rdoStartAM;
        private System.Windows.Forms.GroupBox grpEndAMPM;
        private System.Windows.Forms.RadioButton rdoEndPM;
        private System.Windows.Forms.RadioButton rdoEndAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

