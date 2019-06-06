namespace WindowsFormsApp1
{
    partial class EditTool
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
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.rotateButton = new System.Windows.Forms.RadioButton();
            this.linearButton = new System.Windows.Forms.RadioButton();
            this.actuatorBox = new System.Windows.Forms.CheckBox();
            this.brakeCheck = new System.Windows.Forms.CheckBox();
            this.IOBox = new System.Windows.Forms.CheckBox();
            this.DEBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.torqueUnit = new System.Windows.Forms.ComboBox();
            this.speedUnit = new System.Windows.Forms.ComboBox();
            this.thrustUnit = new System.Windows.Forms.ComboBox();
            this.pitchUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.torqueBox = new System.Windows.Forms.NumericUpDown();
            this.speedBox = new System.Windows.Forms.NumericUpDown();
            this.dutyBox = new System.Windows.Forms.NumericUpDown();
            this.thrustBox = new System.Windows.Forms.NumericUpDown();
            this.pitchBox = new System.Windows.Forms.NumericUpDown();
            this.strokeBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.torqueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thrustBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Location = new System.Drawing.Point(546, 435);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 46);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Save";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.Exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Torque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thrust";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pitch";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(179, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(267, 26);
            this.nameBox.TabIndex = 10;
            // 
            // rotateButton
            // 
            this.rotateButton.AutoSize = true;
            this.rotateButton.Checked = true;
            this.rotateButton.Location = new System.Drawing.Point(83, 67);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(95, 24);
            this.rotateButton.TabIndex = 11;
            this.rotateButton.TabStop = true;
            this.rotateButton.Text = "Rotation";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.CheckedChanged += new System.EventHandler(this.Rotate);
            // 
            // linearButton
            // 
            this.linearButton.AutoSize = true;
            this.linearButton.Location = new System.Drawing.Point(295, 67);
            this.linearButton.Name = "linearButton";
            this.linearButton.Size = new System.Drawing.Size(130, 24);
            this.linearButton.TabIndex = 12;
            this.linearButton.Text = "Linear Motion";
            this.linearButton.UseVisualStyleBackColor = true;
            // 
            // actuatorBox
            // 
            this.actuatorBox.AutoSize = true;
            this.actuatorBox.Location = new System.Drawing.Point(295, 97);
            this.actuatorBox.Name = "actuatorBox";
            this.actuatorBox.Size = new System.Drawing.Size(235, 24);
            this.actuatorBox.TabIndex = 13;
            this.actuatorBox.Text = "Size an actuator with stroke:";
            this.actuatorBox.UseVisualStyleBackColor = true;
            // 
            // brakeCheck
            // 
            this.brakeCheck.AutoSize = true;
            this.brakeCheck.Location = new System.Drawing.Point(40, 387);
            this.brakeCheck.Name = "brakeCheck";
            this.brakeCheck.Size = new System.Drawing.Size(77, 24);
            this.brakeCheck.TabIndex = 14;
            this.brakeCheck.Text = "Brake";
            this.brakeCheck.UseVisualStyleBackColor = true;
            // 
            // IOBox
            // 
            this.IOBox.AutoSize = true;
            this.IOBox.Location = new System.Drawing.Point(194, 387);
            this.IOBox.Name = "IOBox";
            this.IOBox.Size = new System.Drawing.Size(89, 24);
            this.IOBox.TabIndex = 15;
            this.IOBox.Text = "24V I/O";
            this.IOBox.UseVisualStyleBackColor = true;
            // 
            // DEBox
            // 
            this.DEBox.AutoSize = true;
            this.DEBox.Location = new System.Drawing.Point(359, 387);
            this.DEBox.Name = "DEBox";
            this.DEBox.Size = new System.Drawing.Size(125, 24);
            this.DEBox.TabIndex = 16;
            this.DEBox.Text = "Drive Enable";
            this.DEBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Options:";
            // 
            // torqueUnit
            // 
            this.torqueUnit.FormattingEnabled = true;
            this.torqueUnit.Items.AddRange(new object[] {
            "Nm",
            "oz-in",
            "ft-lb",
            "in-lb"});
            this.torqueUnit.Location = new System.Drawing.Point(306, 140);
            this.torqueUnit.Name = "torqueUnit";
            this.torqueUnit.Size = new System.Drawing.Size(90, 28);
            this.torqueUnit.TabIndex = 23;
            this.torqueUnit.Text = "oz-in";
            // 
            // speedUnit
            // 
            this.speedUnit.FormattingEnabled = true;
            this.speedUnit.Items.AddRange(new object[] {
            "RPM",
            "m/s",
            "in/s"});
            this.speedUnit.Location = new System.Drawing.Point(306, 181);
            this.speedUnit.Name = "speedUnit";
            this.speedUnit.Size = new System.Drawing.Size(90, 28);
            this.speedUnit.TabIndex = 24;
            this.speedUnit.Text = "RPM";
            // 
            // thrustUnit
            // 
            this.thrustUnit.FormattingEnabled = true;
            this.thrustUnit.Items.AddRange(new object[] {
            "N",
            "lbs"});
            this.thrustUnit.Location = new System.Drawing.Point(306, 260);
            this.thrustUnit.Name = "thrustUnit";
            this.thrustUnit.Size = new System.Drawing.Size(90, 28);
            this.thrustUnit.TabIndex = 26;
            this.thrustUnit.Text = "N";
            // 
            // pitchUnit
            // 
            this.pitchUnit.FormattingEnabled = true;
            this.pitchUnit.Items.AddRange(new object[] {
            "mm",
            "in"});
            this.pitchUnit.Location = new System.Drawing.Point(306, 296);
            this.pitchUnit.Name = "pitchUnit";
            this.pitchUnit.Size = new System.Drawing.Size(90, 28);
            this.pitchUnit.TabIndex = 27;
            this.pitchUnit.Text = "mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "%";
            // 
            // torqueBox
            // 
            this.torqueBox.Location = new System.Drawing.Point(151, 141);
            this.torqueBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.torqueBox.Name = "torqueBox";
            this.torqueBox.Size = new System.Drawing.Size(126, 26);
            this.torqueBox.TabIndex = 29;
            this.torqueBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // speedBox
            // 
            this.speedBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.speedBox.Location = new System.Drawing.Point(151, 179);
            this.speedBox.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(126, 26);
            this.speedBox.TabIndex = 30;
            this.speedBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // dutyBox
            // 
            this.dutyBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dutyBox.Location = new System.Drawing.Point(151, 219);
            this.dutyBox.Name = "dutyBox";
            this.dutyBox.Size = new System.Drawing.Size(126, 26);
            this.dutyBox.TabIndex = 31;
            this.dutyBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // thrustBox
            // 
            this.thrustBox.BackColor = System.Drawing.SystemColors.Window;
            this.thrustBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.thrustBox.Location = new System.Drawing.Point(151, 260);
            this.thrustBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.thrustBox.Name = "thrustBox";
            this.thrustBox.Size = new System.Drawing.Size(126, 26);
            this.thrustBox.TabIndex = 32;
            this.thrustBox.TabStop = false;
            // 
            // pitchBox
            // 
            this.pitchBox.BackColor = System.Drawing.SystemColors.Window;
            this.pitchBox.Location = new System.Drawing.Point(151, 298);
            this.pitchBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.pitchBox.Name = "pitchBox";
            this.pitchBox.Size = new System.Drawing.Size(126, 26);
            this.pitchBox.TabIndex = 33;
            // 
            // strokeBox
            // 
            this.strokeBox.Location = new System.Drawing.Point(529, 95);
            this.strokeBox.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.strokeBox.Name = "strokeBox";
            this.strokeBox.Size = new System.Drawing.Size(95, 26);
            this.strokeBox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(630, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "mm";
            // 
            // EditTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 493);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.strokeBox);
            this.Controls.Add(this.pitchBox);
            this.Controls.Add(this.thrustBox);
            this.Controls.Add(this.dutyBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.torqueBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pitchUnit);
            this.Controls.Add(this.thrustUnit);
            this.Controls.Add(this.speedUnit);
            this.Controls.Add(this.torqueUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DEBox);
            this.Controls.Add(this.IOBox);
            this.Controls.Add(this.brakeCheck);
            this.Controls.Add(this.actuatorBox);
            this.Controls.Add(this.linearButton);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Name = "EditTool";
            this.Text = "Edit Axis Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            ((System.ComponentModel.ISupportInitialize)(this.torqueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thrustBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RadioButton rotateButton;
        private System.Windows.Forms.RadioButton linearButton;
        private System.Windows.Forms.CheckBox actuatorBox;
        private System.Windows.Forms.CheckBox brakeCheck;
        private System.Windows.Forms.CheckBox IOBox;
        private System.Windows.Forms.CheckBox DEBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox torqueUnit;
        private System.Windows.Forms.ComboBox speedUnit;
        private System.Windows.Forms.ComboBox thrustUnit;
        private System.Windows.Forms.ComboBox pitchUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown torqueBox;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.NumericUpDown dutyBox;
        private System.Windows.Forms.NumericUpDown thrustBox;
        private System.Windows.Forms.NumericUpDown pitchBox;
        private System.Windows.Forms.NumericUpDown strokeBox;
        private System.Windows.Forms.Label label9;
    }
}