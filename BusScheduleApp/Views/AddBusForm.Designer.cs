namespace BusScheduleApp.Views
{
    partial class AddBusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBusForm));
            this.bus_number_textbox = new System.Windows.Forms.TextBox();
            this.departing_station_textbox = new System.Windows.Forms.TextBox();
            this.destination_station_textbox = new System.Windows.Forms.TextBox();
            this.bus_number_label = new System.Windows.Forms.Label();
            this.departing_station_label = new System.Windows.Forms.Label();
            this.destination_station_label = new System.Windows.Forms.Label();
            this.departing_time_label = new System.Windows.Forms.Label();
            this.arrival_time_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.departing_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrival_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bus_number_textbox
            // 
            this.bus_number_textbox.Location = new System.Drawing.Point(108, 12);
            this.bus_number_textbox.Name = "bus_number_textbox";
            this.bus_number_textbox.Size = new System.Drawing.Size(364, 20);
            this.bus_number_textbox.TabIndex = 0;
            this.bus_number_textbox.TextChanged += new System.EventHandler(this.bus_number_textbox_TextChanged);
            // 
            // departing_station_textbox
            // 
            this.departing_station_textbox.Location = new System.Drawing.Point(108, 38);
            this.departing_station_textbox.Name = "departing_station_textbox";
            this.departing_station_textbox.Size = new System.Drawing.Size(364, 20);
            this.departing_station_textbox.TabIndex = 1;
            // 
            // destination_station_textbox
            // 
            this.destination_station_textbox.Location = new System.Drawing.Point(108, 64);
            this.destination_station_textbox.Name = "destination_station_textbox";
            this.destination_station_textbox.Size = new System.Drawing.Size(364, 20);
            this.destination_station_textbox.TabIndex = 2;
            // 
            // bus_number_label
            // 
            this.bus_number_label.AutoSize = true;
            this.bus_number_label.Location = new System.Drawing.Point(37, 15);
            this.bus_number_label.Name = "bus_number_label";
            this.bus_number_label.Size = new System.Drawing.Size(65, 13);
            this.bus_number_label.TabIndex = 5;
            this.bus_number_label.Text = "Bus Number";
            // 
            // departing_station_label
            // 
            this.departing_station_label.AutoSize = true;
            this.departing_station_label.Location = new System.Drawing.Point(13, 41);
            this.departing_station_label.Name = "departing_station_label";
            this.departing_station_label.Size = new System.Drawing.Size(89, 13);
            this.departing_station_label.TabIndex = 6;
            this.departing_station_label.Text = "Departing Station";
            // 
            // destination_station_label
            // 
            this.destination_station_label.AutoSize = true;
            this.destination_station_label.Location = new System.Drawing.Point(6, 67);
            this.destination_station_label.Name = "destination_station_label";
            this.destination_station_label.Size = new System.Drawing.Size(96, 13);
            this.destination_station_label.TabIndex = 7;
            this.destination_station_label.Text = "Destination Station";
            // 
            // departing_time_label
            // 
            this.departing_time_label.AutoSize = true;
            this.departing_time_label.Location = new System.Drawing.Point(23, 93);
            this.departing_time_label.Name = "departing_time_label";
            this.departing_time_label.Size = new System.Drawing.Size(79, 13);
            this.departing_time_label.TabIndex = 8;
            this.departing_time_label.Text = "Departing Time";
            // 
            // arrival_time_label
            // 
            this.arrival_time_label.AutoSize = true;
            this.arrival_time_label.Location = new System.Drawing.Point(37, 119);
            this.arrival_time_label.Name = "arrival_time_label";
            this.arrival_time_label.Size = new System.Drawing.Size(62, 13);
            this.arrival_time_label.TabIndex = 9;
            this.arrival_time_label.Text = "Arrival Time";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(316, 142);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(397, 142);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 11;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // departing_dateTimePicker
            // 
            this.departing_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.departing_dateTimePicker.Location = new System.Drawing.Point(108, 90);
            this.departing_dateTimePicker.Name = "departing_dateTimePicker";
            this.departing_dateTimePicker.Size = new System.Drawing.Size(364, 20);
            this.departing_dateTimePicker.TabIndex = 12;
            // 
            // arrival_dateTimePicker
            // 
            this.arrival_dateTimePicker.Location = new System.Drawing.Point(108, 116);
            this.arrival_dateTimePicker.Name = "arrival_dateTimePicker";
            this.arrival_dateTimePicker.Size = new System.Drawing.Size(364, 20);
            this.arrival_dateTimePicker.TabIndex = 13;
            // 
            // AddBusForm
            // 
            this.AcceptButton = this.add_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(484, 176);
            this.Controls.Add(this.arrival_dateTimePicker);
            this.Controls.Add(this.departing_dateTimePicker);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.arrival_time_label);
            this.Controls.Add(this.departing_time_label);
            this.Controls.Add(this.destination_station_label);
            this.Controls.Add(this.departing_station_label);
            this.Controls.Add(this.bus_number_label);
            this.Controls.Add(this.destination_station_textbox);
            this.Controls.Add(this.departing_station_textbox);
            this.Controls.Add(this.bus_number_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBusForm";
            this.Text = "Add New Bus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bus_number_textbox;
        private System.Windows.Forms.TextBox departing_station_textbox;
        private System.Windows.Forms.TextBox destination_station_textbox;
        private System.Windows.Forms.Label bus_number_label;
        private System.Windows.Forms.Label departing_station_label;
        private System.Windows.Forms.Label destination_station_label;
        private System.Windows.Forms.Label departing_time_label;
        private System.Windows.Forms.Label arrival_time_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DateTimePicker departing_dateTimePicker;
        private System.Windows.Forms.DateTimePicker arrival_dateTimePicker;
    }
}