using System.ComponentModel;
using System.Windows.Forms;

namespace BusScheduleApp.Views
{
    partial class LongestRides
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongestRides));
            this.bus_schedules_listview = new System.Windows.Forms.ListView();
            this.BusNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartingStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bus_schedules_listview
            // 
            this.bus_schedules_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BusNumber,
            this.DepartingStation,
            this.DestinationStation,
            this.DepartingTime,
            this.ArrivalTime});
            this.bus_schedules_listview.FullRowSelect = true;
            this.bus_schedules_listview.Location = new System.Drawing.Point(12, 41);
            this.bus_schedules_listview.MultiSelect = false;
            this.bus_schedules_listview.Name = "bus_schedules_listview";
            this.bus_schedules_listview.Size = new System.Drawing.Size(460, 208);
            this.bus_schedules_listview.TabIndex = 15;
            this.bus_schedules_listview.UseCompatibleStateImageBehavior = false;
            this.bus_schedules_listview.View = System.Windows.Forms.View.Details;
            // 
            // BusNumber
            // 
            this.BusNumber.Text = "Bus";
            this.BusNumber.Width = 30;
            // 
            // DepartingStation
            // 
            this.DepartingStation.Text = "Departing Station";
            this.DepartingStation.Width = 94;
            // 
            // DestinationStation
            // 
            this.DestinationStation.Text = "Destination Station";
            this.DestinationStation.Width = 101;
            // 
            // DepartingTime
            // 
            this.DepartingTime.Text = "Departing Time";
            this.DepartingTime.Width = 110;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Text = "Arrival Time";
            this.ArrivalTime.Width = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "All buses with >= 2h20min travel time";
            // 
            // close_button
            // 
            this.close_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_button.Location = new System.Drawing.Point(397, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 17;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // LongestRides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close_button;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bus_schedules_listview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LongestRides";
            this.Text = "LongestRides";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView bus_schedules_listview;
        private ColumnHeader BusNumber;
        private ColumnHeader DepartingStation;
        private ColumnHeader DestinationStation;
        private ColumnHeader DepartingTime;
        private ColumnHeader ArrivalTime;
        private Label label1;
        private Button close_button;
    }
}