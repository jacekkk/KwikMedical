namespace HeadOfficeClientApplication
{
    partial class HeadOfficeApp
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
            this.button_find_patient = new System.Windows.Forms.Button();
            this.text_box_first_name = new System.Windows.Forms.TextBox();
            this.text_box_last_name = new System.Windows.Forms.TextBox();
            this.text_box_insurance_number = new System.Windows.Forms.TextBox();
            this.text_box_address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_find_patient
            // 
            this.button_find_patient.Location = new System.Drawing.Point(189, 223);
            this.button_find_patient.Name = "button_find_patient";
            this.button_find_patient.Size = new System.Drawing.Size(156, 41);
            this.button_find_patient.TabIndex = 1;
            this.button_find_patient.Text = "Find patient";
            this.button_find_patient.UseVisualStyleBackColor = true;
            this.button_find_patient.Click += new System.EventHandler(this.button_find_patient_Click);
            // 
            // text_box_first_name
            // 
            this.text_box_first_name.BackColor = System.Drawing.SystemColors.Window;
            this.text_box_first_name.Location = new System.Drawing.Point(45, 39);
            this.text_box_first_name.Multiline = true;
            this.text_box_first_name.Name = "text_box_first_name";
            this.text_box_first_name.Size = new System.Drawing.Size(438, 26);
            this.text_box_first_name.TabIndex = 2;
            this.text_box_first_name.Text = "First name";
            this.text_box_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_box_last_name
            // 
            this.text_box_last_name.BackColor = System.Drawing.SystemColors.Window;
            this.text_box_last_name.Location = new System.Drawing.Point(45, 80);
            this.text_box_last_name.Multiline = true;
            this.text_box_last_name.Name = "text_box_last_name";
            this.text_box_last_name.Size = new System.Drawing.Size(438, 26);
            this.text_box_last_name.TabIndex = 3;
            this.text_box_last_name.Text = "Last name";
            this.text_box_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_box_insurance_number
            // 
            this.text_box_insurance_number.Location = new System.Drawing.Point(45, 169);
            this.text_box_insurance_number.Multiline = true;
            this.text_box_insurance_number.Name = "text_box_insurance_number";
            this.text_box_insurance_number.Size = new System.Drawing.Size(438, 26);
            this.text_box_insurance_number.TabIndex = 5;
            this.text_box_insurance_number.Text = "Insurance number";
            this.text_box_insurance_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_box_address
            // 
            this.text_box_address.Location = new System.Drawing.Point(45, 124);
            this.text_box_address.Multiline = true;
            this.text_box_address.Name = "text_box_address";
            this.text_box_address.Size = new System.Drawing.Size(438, 26);
            this.text_box_address.TabIndex = 6;
            this.text_box_address.Text = "Address";
            this.text_box_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeadOfficeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(529, 298);
            this.Controls.Add(this.text_box_address);
            this.Controls.Add(this.text_box_insurance_number);
            this.Controls.Add(this.text_box_last_name);
            this.Controls.Add(this.text_box_first_name);
            this.Controls.Add(this.button_find_patient);
            this.Name = "HeadOfficeApp";
            this.Text = "Head Office Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_find_patient;
        private System.Windows.Forms.TextBox text_box_first_name;
        private System.Windows.Forms.TextBox text_box_last_name;
        private System.Windows.Forms.TextBox text_box_insurance_number;
        private System.Windows.Forms.TextBox text_box_address;
    }
}

