using System.ComponentModel;
using System.Windows.Forms;

namespace BusScheduleApp.Views
{
    partial class EditBusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBusForm));
            this.arrival_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departing_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.arrival_time_label = new System.Windows.Forms.Label();
            this.departing_time_label = new System.Windows.Forms.Label();
            this.destination_station_label = new System.Windows.Forms.Label();
            this.departing_station_label = new System.Windows.Forms.Label();
            this.bus_number_label = new System.Windows.Forms.Label();
            this.destination_station_textbox = new System.Windows.Forms.TextBox();
            this.departing_station_textbox = new System.Windows.Forms.TextBox();
            this.bus_number_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arrival_dateTimePicker
            // 
            this.arrival_dateTimePicker.Location = new System.Drawing.Point(108, 116);
            this.arrival_dateTimePicker.Name = "arrival_dateTimePicker";
            this.arrival_dateTimePicker.Size = new System.Drawing.Size(364, 20);
            this.arrival_dateTimePicker.TabIndex = 25;
            // 
            // departing_dateTimePicker
            // 
            this.departing_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.departing_dateTimePicker.Location = new System.Drawing.Point(108, 90);
            this.departing_dateTimePicker.Name = "departing_dateTimePicker";
            this.departing_dateTimePicker.Size = new System.Drawing.Size(364, 20);
            this.departing_dateTimePicker.TabIndex = 24;
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(397, 142);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 23;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(316, 142);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 22;
            this.add_button.Text = "Edit";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // arrival_time_label
            // 
            this.arrival_time_label.AutoSize = true;
            this.arrival_time_label.Location = new System.Drawing.Point(37, 119);
            this.arrival_time_label.Name = "arrival_time_label";
            this.arrival_time_label.Size = new System.Drawing.Size(62, 13);
            this.arrival_time_label.TabIndex = 21;
            this.arrival_time_label.Text = "Arrival Time";
            // 
            // departing_time_label
            // 
            this.departing_time_label.AutoSize = true;
            this.departing_time_label.Location = new System.Drawing.Point(23, 93);
            this.departing_time_label.Name = "departing_time_label";
            this.departing_time_label.Size = new System.Drawing.Size(79, 13);
            this.departing_time_label.TabIndex = 20;
            this.departing_time_label.Text = "Departing Time";
            // 
            // destination_station_label
            // 
            this.destination_station_label.AutoSize = true;
            this.destination_station_label.Location = new System.Drawing.Point(6, 67);
            this.destination_station_label.Name = "destination_station_label";
            this.destination_station_label.Size = new System.Drawing.Size(96, 13);
            this.destination_station_label.TabIndex = 19;
            this.destination_station_label.Text = "Destination Station";
            // 
            // departing_station_label
            // 
            this.departing_station_label.AutoSize = true;
            this.departing_station_label.Location = new System.Drawing.Point(13, 41);
            this.departing_station_label.Name = "departing_station_label";
            this.departing_station_label.Size = new System.Drawing.Size(89, 13);
            this.departing_station_label.TabIndex = 18;
            this.departing_station_label.Text = "Departing Station";
            // 
            // bus_number_label
            // 
            this.bus_number_label.AutoSize = true;
            this.bus_number_label.Location = new System.Drawing.Point(37, 15);
            this.bus_number_label.Name = "bus_number_label";
            this.bus_number_label.Size = new System.Drawing.Size(65, 13);
            this.bus_number_label.TabIndex = 17;
            this.bus_number_label.Text = "Bus Number";
            // 
            // destination_station_textbox
            // 
            this.destination_station_textbox.Location = new System.Drawing.Point(108, 64);
            this.destination_station_textbox.Name = "destination_station_textbox";
            this.destination_station_textbox.Size = new System.Drawing.Size(364, 20);
            this.destination_station_textbox.TabIndex = 16;
            // 
            // departing_station_textbox
            // 
            this.departing_station_textbox.Location = new System.Drawing.Point(108, 38);
            this.departing_station_textbox.Name = "departing_station_textbox";
            this.departing_station_textbox.Size = new System.Drawing.Size(364, 20);
            this.departing_station_textbox.TabIndex = 15;
            // 
            // bus_number_textbox
            // 
            this.bus_number_textbox.Location = new System.Drawing.Point(108, 12);
            this.bus_number_textbox.Name = "bus_number_textbox";
            this.bus_number_textbox.Size = new System.Drawing.Size(364, 20);
            this.bus_number_textbox.TabIndex = 14;
            // 
            // EditBusForm
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
            this.Name = "EditBusForm";
            this.Text = "Edit Bus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker arrival_dateTimePicker;
        private DateTimePicker departing_dateTimePicker;
        private Button cancel_button;
        private Button add_button;
        private Label arrival_time_label;
        private Label departing_time_label;
        private Label destination_station_label;
        private Label departing_station_label;
        private Label bus_number_label;
        private TextBox destination_station_textbox;
        private TextBox departing_station_textbox;
        private TextBox bus_number_textbox;
    }
}