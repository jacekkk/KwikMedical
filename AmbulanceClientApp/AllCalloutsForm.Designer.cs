namespace AmbulanceClientApp
{
    partial class AmbulanceApp
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
            this.list_recent_call_outs = new System.Windows.Forms.ListView();
            this.column_call_out_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_patient_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_hospital_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_reason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_action_taken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_time_spent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_submit_details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_recent_call_outs
            // 
            this.list_recent_call_outs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_call_out_id,
            this.column_patient_id,
            this.column_hospital_id,
            this.column_date,
            this.column_reason,
            this.column_action_taken,
            this.column_time_spent});
            this.list_recent_call_outs.FullRowSelect = true;
            this.list_recent_call_outs.Location = new System.Drawing.Point(12, 12);
            this.list_recent_call_outs.Name = "list_recent_call_outs";
            this.list_recent_call_outs.ShowItemToolTips = true;
            this.list_recent_call_outs.Size = new System.Drawing.Size(1042, 450);
            this.list_recent_call_outs.TabIndex = 1;
            this.list_recent_call_outs.UseCompatibleStateImageBehavior = false;
            this.list_recent_call_outs.View = System.Windows.Forms.View.Details;
            this.list_recent_call_outs.MouseEnter += new System.EventHandler(this.list_recent_call_outs_MouseEnter);
            // 
            // column_call_out_id
            // 
            this.column_call_out_id.Text = "Call-out ID";
            this.column_call_out_id.Width = 65;
            // 
            // column_patient_id
            // 
            this.column_patient_id.Text = "Patient ID";
            this.column_patient_id.Width = 65;
            // 
            // column_hospital_id
            // 
            this.column_hospital_id.Text = "Hospital ID";
            this.column_hospital_id.Width = 65;
            // 
            // column_date
            // 
            this.column_date.Text = "Date";
            this.column_date.Width = 120;
            // 
            // column_reason
            // 
            this.column_reason.Text = "Reason";
            this.column_reason.Width = 130;
            // 
            // column_action_taken
            // 
            this.column_action_taken.Text = "Action Taken";
            this.column_action_taken.Width = 130;
            // 
            // column_time_spent
            // 
            this.column_time_spent.Text = "Time Spent";
            this.column_time_spent.Width = 100;
            // 
            // button_submit_details
            // 
            this.button_submit_details.Location = new System.Drawing.Point(433, 484);
            this.button_submit_details.Name = "button_submit_details";
            this.button_submit_details.Size = new System.Drawing.Size(210, 34);
            this.button_submit_details.TabIndex = 2;
            this.button_submit_details.Text = "Submit call-out details";
            this.button_submit_details.UseVisualStyleBackColor = true;
            this.button_submit_details.Click += new System.EventHandler(this.button_submit_details_Click);
            // 
            // AmbulanceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1068, 530);
            this.Controls.Add(this.button_submit_details);
            this.Controls.Add(this.list_recent_call_outs);
            this.Name = "AmbulanceApp";
            this.Text = "Ambulance Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_recent_call_outs;
        private System.Windows.Forms.ColumnHeader column_call_out_id;
        private System.Windows.Forms.ColumnHeader column_patient_id;
        private System.Windows.Forms.ColumnHeader column_hospital_id;
        private System.Windows.Forms.ColumnHeader column_date;
        private System.Windows.Forms.ColumnHeader column_reason;
        private System.Windows.Forms.Button button_submit_details;
        private System.Windows.Forms.ColumnHeader column_action_taken;
        private System.Windows.Forms.ColumnHeader column_time_spent;
    }
}

