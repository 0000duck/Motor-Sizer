namespace WindowsFormsApp1
{
    partial class SizerMain
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
            this.axesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CommDropd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MoistureBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.disclaimer = new System.Windows.Forms.Label();
            this.toolTipComms = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEnv = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // axesListBox
            // 
            this.axesListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.axesListBox.ItemHeight = 20;
            this.axesListBox.Location = new System.Drawing.Point(92, 182);
            this.axesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axesListBox.Name = "axesListBox";
            this.axesListBox.Size = new System.Drawing.Size(355, 144);
            this.axesListBox.TabIndex = 0;
            this.axesListBox.SelectedIndexChanged += new System.EventHandler(this.selection_change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Axes";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(110, 337);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(64, 31);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(219, 337);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(64, 31);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(345, 337);
            this.DelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(64, 31);
            this.DelButton.TabIndex = 4;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Communication";
            // 
            // CommDropd
            // 
            this.CommDropd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommDropd.FormattingEnabled = true;
            this.CommDropd.Items.AddRange(new object[] {
            "RS232",
            "RS485",
            "CANopen",
            "DeviceNet",
            "Profibus",
            "Ethernet/IP",
            "EtherCAT",
            "Profinet"});
            this.CommDropd.Location = new System.Drawing.Point(316, 408);
            this.CommDropd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CommDropd.Name = "CommDropd";
            this.CommDropd.Size = new System.Drawing.Size(181, 28);
            this.CommDropd.TabIndex = 6;
            this.CommDropd.SelectionChangeCommitted += new System.EventHandler(this.Protocol_set);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Environment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 531);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 595);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Moisture";
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(273, 531);
            this.tempBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(85, 26);
            this.tempBox.TabIndex = 10;
            this.tempBox.Text = "25";
            this.tempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tempBox.TextChanged += new System.EventHandler(this.Temperature_set);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 542);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Celsius";
            // 
            // MoistureBox
            // 
            this.MoistureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MoistureBox.FormattingEnabled = true;
            this.MoistureBox.Items.AddRange(new object[] {
            "Normal humidity",
            "Splash/rain",
            "Washdown"});
            this.MoistureBox.Location = new System.Drawing.Point(276, 591);
            this.MoistureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoistureBox.Name = "MoistureBox";
            this.MoistureBox.Size = new System.Drawing.Size(170, 28);
            this.MoistureBox.TabIndex = 12;
            this.MoistureBox.SelectionChangeCommitted += new System.EventHandler(this.Moisture_set);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(841, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Solution(s):";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submit.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(523, 262);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(160, 82);
            this.Submit.TabIndex = 17;
            this.Submit.Text = "Size";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Size_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(998, 566);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 78);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.finish_click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(546, 55);
            this.label7.TabIndex = 19;
            this.label7.Text = "SmartMotor Sizing Tool";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(706, 209);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(462, 330);
            this.outputBox.TabIndex = 20;
            // 
            // disclaimer
            // 
            this.disclaimer.AutoSize = true;
            this.disclaimer.Location = new System.Drawing.Point(710, 551);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(255, 20);
            this.disclaimer.TabIndex = 21;
            this.disclaimer.Text = "* All sizing assumes 48V DC power";
            this.disclaimer.Visible = false;
            // 
            // toolTipComms
            // 
            this.toolTipComms.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipEnv
            // 
            this.toolTipEnv.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // SizerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.disclaimer);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MoistureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CommDropd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axesListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SizerMain";
            this.Text = "Motor Sizing Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox axesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CommDropd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MoistureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label disclaimer;
        private System.Windows.Forms.ToolTip toolTipComms;
        private System.Windows.Forms.ToolTip toolTipEnv;
    }
}