namespace HeadOfficeClientApplication
{
    partial class SendAmbulanceForm
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
            this.text_box_request_reason = new System.Windows.Forms.TextBox();
            this.text_box_request_action = new System.Windows.Forms.TextBox();
            this.label_callout_details = new System.Windows.Forms.Label();
            this.button_generate_ambulance_request = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_box_request_reason
            // 
            this.text_box_request_reason.Location = new System.Drawing.Point(43, 58);
            this.text_box_request_reason.Name = "text_box_request_reason";
            this.text_box_request_reason.Size = new System.Drawing.Size(427, 26);
            this.text_box_request_reason.TabIndex = 0;
            this.text_box_request_reason.Text = "Reason";
            // 
            // text_box_request_action
            // 
            this.text_box_request_action.Location = new System.Drawing.Point(43, 101);
            this.text_box_request_action.Name = "text_box_request_action";
            this.text_box_request_action.Size = new System.Drawing.Size(427, 26);
            this.text_box_request_action.TabIndex = 1;
            this.text_box_request_action.Text = "Action to take";
            // 
            // label_callout_details
            // 
            this.label_callout_details.AutoSize = true;
            this.label_callout_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_callout_details.Location = new System.Drawing.Point(39, 26);
            this.label_callout_details.Name = "label_callout_details";
            this.label_callout_details.Size = new System.Drawing.Size(332, 20);
            this.label_callout_details.TabIndex = 2;
            this.label_callout_details.Text = "Call-out details to be send to ambulance";
            // 
            // button_generate_ambulance_request
            // 
            this.button_generate_ambulance_request.Location = new System.Drawing.Point(179, 158);
            this.button_generate_ambulance_request.Name = "button_generate_ambulance_request";
            this.button_generate_ambulance_request.Size = new System.Drawing.Size(152, 40);
            this.button_generate_ambulance_request.TabIndex = 3;
            this.button_generate_ambulance_request.Text = "Generate request";
            this.button_generate_ambulance_request.UseVisualStyleBackColor = true;
            this.button_generate_ambulance_request.Click += new System.EventHandler(this.button_generate_ambulance_request_Click);
            // 
            // SendAmbulanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(502, 239);
            this.Controls.Add(this.button_generate_ambulance_request);
            this.Controls.Add(this.label_callout_details);
            this.Controls.Add(this.text_box_request_action);
            this.Controls.Add(this.text_box_request_reason);
            this.Name = "SendAmbulanceForm";
            this.Text = "Send Ambulance Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box_request_reason;
        private System.Windows.Forms.TextBox text_box_request_action;
        private System.Windows.Forms.Label label_callout_details;
        private System.Windows.Forms.Button button_generate_ambulance_request;
    }
}