namespace WindowsFormsApp1
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
            this.Choicebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AwayComboBox = new System.Windows.Forms.ComboBox();
            this.HomeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeCombobox = new System.Windows.Forms.ComboBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Choicebutton
            // 
            this.Choicebutton.Location = new System.Drawing.Point(330, 308);
            this.Choicebutton.Name = "Choicebutton";
            this.Choicebutton.Size = new System.Drawing.Size(75, 23);
            this.Choicebutton.TabIndex = 0;
            this.Choicebutton.Text = "Choice";
            this.Choicebutton.UseVisualStyleBackColor = true;
            this.Choicebutton.Click += new System.EventHandler(this.ChoiceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Away";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Home";
            // 
            // AwayComboBox
            // 
            this.AwayComboBox.FormattingEnabled = true;
            this.AwayComboBox.Location = new System.Drawing.Point(32, 164);
            this.AwayComboBox.Name = "AwayComboBox";
            this.AwayComboBox.Size = new System.Drawing.Size(121, 21);
            this.AwayComboBox.TabIndex = 6;
            // 
            // HomeComboBox
            // 
            this.HomeComboBox.FormattingEnabled = true;
            this.HomeComboBox.Location = new System.Drawing.Point(284, 164);
            this.HomeComboBox.Name = "HomeComboBox";
            this.HomeComboBox.Size = new System.Drawing.Size(121, 21);
            this.HomeComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "VS";
            // 
            // TimeCombobox
            // 
            this.TimeCombobox.FormattingEnabled = true;
            this.TimeCombobox.Items.AddRange(new object[] {
            "Weekend/Monday",
            "Other"});
            this.TimeCombobox.Location = new System.Drawing.Point(32, 36);
            this.TimeCombobox.Name = "TimeCombobox";
            this.TimeCombobox.Size = new System.Drawing.Size(121, 21);
            this.TimeCombobox.TabIndex = 10;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Regular Game",
            "Neutral Site"});
            this.LocationComboBox.Location = new System.Drawing.Point(31, 88);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(121, 21);
            this.LocationComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Location";
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLabel.Location = new System.Drawing.Point(107, 223);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(61, 38);
            this.WinnerLabel.TabIndex = 14;
            this.WinnerLabel.Text = "VS";
            this.WinnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinnerLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 356);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.TimeCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HomeComboBox);
            this.Controls.Add(this.AwayComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Choicebutton);
            this.Name = "Form1";
            this.Text = "College Football Wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Choicebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AwayComboBox;
        private System.Windows.Forms.ComboBox HomeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TimeCombobox;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WinnerLabel;
    }
}

