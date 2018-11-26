namespace HeadOfficeClientApplication
{
    partial class PatientDetailsPopoup
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_patient_first_name = new System.Windows.Forms.Label();
            this.label_patient_last_name = new System.Windows.Forms.Label();
            this.label_patient_insurance_number = new System.Windows.Forms.Label();
            this.label_hospital_name = new System.Windows.Forms.Label();
            this.label_patient_details = new System.Windows.Forms.Label();
            this.button_send_ambulance_request = new System.Windows.Forms.Button();
            this.button_get_hospital_details = new System.Windows.Forms.Button();
            this.label_hospital_details = new System.Windows.Forms.Label();
            this.label_hospital_address = new System.Windows.Forms.Label();
            this.label_hospital_email = new System.Windows.Forms.Label();
            this.label_hospital_phone = new System.Windows.Forms.Label();
            this.text_patient_insurance_number = new System.Windows.Forms.Label();
            this.text_patient_last_name = new System.Windows.Forms.Label();
            this.text_patient_first_name = new System.Windows.Forms.Label();
            this.text_hospital_phone = new System.Windows.Forms.Label();
            this.text_hospital_email = new System.Windows.Forms.Label();
            this.text_hospital_address = new System.Windows.Forms.Label();
            this.text_hospital_name = new System.Windows.Forms.Label();
            this.text_patient_address = new System.Windows.Forms.Label();
            this.label_patient_address = new System.Windows.Forms.Label();
            this.text_medical_conditions = new System.Windows.Forms.Label();
            this.label_medical_conditions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_patient_first_name
            // 
            this.label_patient_first_name.AutoSize = true;
            this.label_patient_first_name.Location = new System.Drawing.Point(35, 69);
            this.label_patient_first_name.Name = "label_patient_first_name";
            this.label_patient_first_name.Size = new System.Drawing.Size(88, 20);
            this.label_patient_first_name.TabIndex = 4;
            this.label_patient_first_name.Text = "First name:";
            // 
            // label_patient_last_name
            // 
            this.label_patient_last_name.AutoSize = true;
            this.label_patient_last_name.Location = new System.Drawing.Point(35, 98);
            this.label_patient_last_name.Name = "label_patient_last_name";
            this.label_patient_last_name.Size = new System.Drawing.Size(88, 20);
            this.label_patient_last_name.TabIndex = 5;
            this.label_patient_last_name.Text = "Last name:";
            // 
            // label_patient_insurance_number
            // 
            this.label_patient_insurance_number.AutoSize = true;
            this.label_patient_insurance_number.Location = new System.Drawing.Point(35, 158);
            this.label_patient_insurance_number.Name = "label_patient_insurance_number";
            this.label_patient_insurance_number.Size = new System.Drawing.Size(142, 20);
            this.label_patient_insurance_number.TabIndex = 6;
            this.label_patient_insurance_number.Text = "Insurance number:";
            // 
            // label_hospital_name
            // 
            this.label_hospital_name.AutoSize = true;
            this.label_hospital_name.Location = new System.Drawing.Point(35, 275);
            this.label_hospital_name.Name = "label_hospital_name";
            this.label_hospital_name.Size = new System.Drawing.Size(55, 20);
            this.label_hospital_name.TabIndex = 7;
            this.label_hospital_name.Text = "Name:";
            // 
            // label_patient_details
            // 
            this.label_patient_details.AutoSize = true;
            this.label_patient_details.BackColor = System.Drawing.SystemColors.Window;
            this.label_patient_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_patient_details.Location = new System.Drawing.Point(35, 36);
            this.label_patient_details.Name = "label_patient_details";
            this.label_patient_details.Size = new System.Drawing.Size(124, 20);
            this.label_patient_details.TabIndex = 8;
            this.label_patient_details.Text = "Patient details";
            // 
            // button_send_ambulance_request
            // 
            this.button_send_ambulance_request.Location = new System.Drawing.Point(261, 425);
            this.button_send_ambulance_request.Name = "button_send_ambulance_request";
            this.button_send_ambulance_request.Size = new System.Drawing.Size(195, 32);
            this.button_send_ambulance_request.TabIndex = 10;
            this.button_send_ambulance_request.Text = "Send ambulance request";
            this.button_send_ambulance_request.UseVisualStyleBackColor = true;
            this.button_send_ambulance_request.Click += new System.EventHandler(this.button_send_ambulance_request_Click);
            // 
            // button_get_hospital_details
            // 
            this.button_get_hospital_details.Location = new System.Drawing.Point(37, 425);
            this.button_get_hospital_details.Name = "button_get_hospital_details";
            this.button_get_hospital_details.Size = new System.Drawing.Size(195, 32);
            this.button_get_hospital_details.TabIndex = 11;
            this.button_get_hospital_details.Text = "Get hospital details";
            this.button_get_hospital_details.UseVisualStyleBackColor = true;
            this.button_get_hospital_details.Click += new System.EventHandler(this.button_get_hospital_details_Click);
            // 
            // label_hospital_details
            // 
            this.label_hospital_details.AutoSize = true;
            this.label_hospital_details.BackColor = System.Drawing.SystemColors.Window;
            this.label_hospital_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hospital_details.Location = new System.Drawing.Point(35, 245);
            this.label_hospital_details.Name = "label_hospital_details";
            this.label_hospital_details.Size = new System.Drawing.Size(133, 20);
            this.label_hospital_details.TabIndex = 12;
            this.label_hospital_details.Text = "Hospital details";
            // 
            // label_hospital_address
            // 
            this.label_hospital_address.AutoSize = true;
            this.label_hospital_address.Location = new System.Drawing.Point(35, 304);
            this.label_hospital_address.Name = "label_hospital_address";
            this.label_hospital_address.Size = new System.Drawing.Size(72, 20);
            this.label_hospital_address.TabIndex = 13;
            this.label_hospital_address.Text = "Address:";
            // 
            // label_hospital_email
            // 
            this.label_hospital_email.AutoSize = true;
            this.label_hospital_email.Location = new System.Drawing.Point(35, 334);
            this.label_hospital_email.Name = "label_hospital_email";
            this.label_hospital_email.Size = new System.Drawing.Size(52, 20);
            this.label_hospital_email.TabIndex = 14;
            this.label_hospital_email.Text = "Email:";
            // 
            // label_hospital_phone
            // 
            this.label_hospital_phone.AutoSize = true;
            this.label_hospital_phone.Location = new System.Drawing.Point(35, 363);
            this.label_hospital_phone.Name = "label_hospital_phone";
            this.label_hospital_phone.Size = new System.Drawing.Size(117, 20);
            this.label_hospital_phone.TabIndex = 15;
            this.label_hospital_phone.Text = "Phone number:";
            // 
            // text_patient_insurance_number
            // 
            this.text_patient_insurance_number.AutoSize = true;
            this.text_patient_insurance_number.Location = new System.Drawing.Point(175, 158);
            this.text_patient_insurance_number.Name = "text_patient_insurance_number";
            this.text_patient_insurance_number.Size = new System.Drawing.Size(0, 20);
            this.text_patient_insurance_number.TabIndex = 18;
            // 
            // text_patient_last_name
            // 
            this.text_patient_last_name.AutoSize = true;
            this.text_patient_last_name.Location = new System.Drawing.Point(175, 98);
            this.text_patient_last_name.Name = "text_patient_last_name";
            this.text_patient_last_name.Size = new System.Drawing.Size(0, 20);
            this.text_patient_last_name.TabIndex = 17;
            // 
            // text_patient_first_name
            // 
            this.text_patient_first_name.AutoSize = true;
            this.text_patient_first_name.Location = new System.Drawing.Point(175, 69);
            this.text_patient_first_name.Name = "text_patient_first_name";
            this.text_patient_first_name.Size = new System.Drawing.Size(0, 20);
            this.text_patient_first_name.TabIndex = 16;
            // 
            // text_hospital_phone
            // 
            this.text_hospital_phone.AutoSize = true;
            this.text_hospital_phone.Location = new System.Drawing.Point(157, 363);
            this.text_hospital_phone.Name = "text_hospital_phone";
            this.text_hospital_phone.Size = new System.Drawing.Size(0, 20);
            this.text_hospital_phone.TabIndex = 22;
            // 
            // text_hospital_email
            // 
            this.text_hospital_email.AutoSize = true;
            this.text_hospital_email.Location = new System.Drawing.Point(157, 334);
            this.text_hospital_email.Name = "text_hospital_email";
            this.text_hospital_email.Size = new System.Drawing.Size(0, 20);
            this.text_hospital_email.TabIndex = 21;
            // 
            // text_hospital_address
            // 
            this.text_hospital_address.AutoSize = true;
            this.text_hospital_address.Location = new System.Drawing.Point(157, 304);
            this.text_hospital_address.Name = "text_hospital_address";
            this.text_hospital_address.Size = new System.Drawing.Size(0, 20);
            this.text_hospital_address.TabIndex = 20;
            // 
            // text_hospital_name
            // 
            this.text_hospital_name.AutoSize = true;
            this.text_hospital_name.Location = new System.Drawing.Point(157, 275);
            this.text_hospital_name.Name = "text_hospital_name";
            this.text_hospital_name.Size = new System.Drawing.Size(0, 20);
            this.text_hospital_name.TabIndex = 19;
            // 
            // text_patient_address
            // 
            this.text_patient_address.AutoSize = true;
            this.text_patient_address.Location = new System.Drawing.Point(177, 128);
            this.text_patient_address.Name = "text_patient_address";
            this.text_patient_address.Size = new System.Drawing.Size(0, 20);
            this.text_patient_address.TabIndex = 24;
            // 
            // label_patient_address
            // 
            this.label_patient_address.AutoSize = true;
            this.label_patient_address.Location = new System.Drawing.Point(35, 128);
            this.label_patient_address.Name = "label_patient_address";
            this.label_patient_address.Size = new System.Drawing.Size(72, 20);
            this.label_patient_address.TabIndex = 23;
            this.label_patient_address.Text = "Address:";
            // 
            // text_medical_conditions
            // 
            this.text_medical_conditions.AutoSize = true;
            this.text_medical_conditions.Location = new System.Drawing.Point(177, 188);
            this.text_medical_conditions.Name = "text_medical_conditions";
            this.text_medical_conditions.Size = new System.Drawing.Size(0, 20);
            this.text_medical_conditions.TabIndex = 26;
            // 
            // label_medical_conditions
            // 
            this.label_medical_conditions.AutoSize = true;
            this.label_medical_conditions.Location = new System.Drawing.Point(35, 188);
            this.label_medical_conditions.Name = "label_medical_conditions";
            this.label_medical_conditions.Size = new System.Drawing.Size(143, 20);
            this.label_medical_conditions.TabIndex = 25;
            this.label_medical_conditions.Text = "Medical conditions:";
            // 
            // PatientDetailsPopoup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(515, 498);
            this.Controls.Add(this.text_medical_conditions);
            this.Controls.Add(this.label_medical_conditions);
            this.Controls.Add(this.text_patient_address);
            this.Controls.Add(this.label_patient_address);
            this.Controls.Add(this.text_hospital_phone);
            this.Controls.Add(this.text_hospital_email);
            this.Controls.Add(this.text_hospital_address);
            this.Controls.Add(this.text_hospital_name);
            this.Controls.Add(this.text_patient_insurance_number);
            this.Controls.Add(this.text_patient_last_name);
            this.Controls.Add(this.text_patient_first_name);
            this.Controls.Add(this.label_hospital_phone);
            this.Controls.Add(this.label_hospital_email);
            this.Controls.Add(this.label_hospital_address);
            this.Controls.Add(this.label_hospital_details);
            this.Controls.Add(this.button_get_hospital_details);
            this.Controls.Add(this.button_send_ambulance_request);
            this.Controls.Add(this.label_patient_details);
            this.Controls.Add(this.label_hospital_name);
            this.Controls.Add(this.label_patient_insurance_number);
            this.Controls.Add(this.label_patient_last_name);
            this.Controls.Add(this.label_patient_first_name);
            this.Name = "PatientDetailsPopoup";
            this.Text = "PatientDetailsPopoup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_patient_first_name;
        private System.Windows.Forms.Label label_patient_last_name;
        private System.Windows.Forms.Label label_patient_insurance_number;
        private System.Windows.Forms.Label label_hospital_name;
        private System.Windows.Forms.Label label_patient_details;
        private System.Windows.Forms.Button button_send_ambulance_request;
        private System.Windows.Forms.Button button_get_hospital_details;
        private System.Windows.Forms.Label label_hospital_details;
        private System.Windows.Forms.Label label_hospital_address;
        private System.Windows.Forms.Label label_hospital_email;
        private System.Windows.Forms.Label label_hospital_phone;
        private System.Windows.Forms.Label text_patient_insurance_number;
        private System.Windows.Forms.Label text_patient_last_name;
        private System.Windows.Forms.Label text_patient_first_name;
        private System.Windows.Forms.Label text_hospital_phone;
        private System.Windows.Forms.Label text_hospital_email;
        private System.Windows.Forms.Label text_hospital_address;
        private System.Windows.Forms.Label text_hospital_name;
        private System.Windows.Forms.Label text_patient_address;
        private System.Windows.Forms.Label label_patient_address;
        private System.Windows.Forms.Label text_medical_conditions;
        private System.Windows.Forms.Label label_medical_conditions;
    }
}