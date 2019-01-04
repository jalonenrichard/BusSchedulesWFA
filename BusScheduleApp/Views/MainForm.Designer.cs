namespace BusScheduleApp.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.last_element_button = new System.Windows.Forms.Button();
            this.up_one_element_button = new System.Windows.Forms.Button();
            this.down_one_element_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.first_element_button = new System.Windows.Forms.Button();
            this.bus_schedules_listview = new System.Windows.Forms.ListView();
            this.BusNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartingStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.special_func_button = new System.Windows.Forms.Button();
            this.delete_all_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // last_element_button
            // 
            this.last_element_button.Image = ((System.Drawing.Image)(resources.GetObject("last_element_button.Image")));
            this.last_element_button.Location = new System.Drawing.Point(947, 357);
            this.last_element_button.Name = "last_element_button";
            this.last_element_button.Size = new System.Drawing.Size(25, 45);
            this.last_element_button.TabIndex = 15;
            this.last_element_button.UseVisualStyleBackColor = true;
            // 
            // up_one_element_button
            // 
            this.up_one_element_button.Image = ((System.Drawing.Image)(resources.GetObject("up_one_element_button.Image")));
            this.up_one_element_button.Location = new System.Drawing.Point(947, 289);
            this.up_one_element_button.Name = "up_one_element_button";
            this.up_one_element_button.Size = new System.Drawing.Size(25, 28);
            this.up_one_element_button.TabIndex = 13;
            this.up_one_element_button.UseVisualStyleBackColor = true;
            // 
            // down_one_element_button
            // 
            this.down_one_element_button.Image = ((System.Drawing.Image)(resources.GetObject("down_one_element_button.Image")));
            this.down_one_element_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.down_one_element_button.Location = new System.Drawing.Point(947, 323);
            this.down_one_element_button.Name = "down_one_element_button";
            this.down_one_element_button.Size = new System.Drawing.Size(25, 28);
            this.down_one_element_button.TabIndex = 12;
            this.down_one_element_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(12, 37);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(101, 23);
            this.edit_button.TabIndex = 10;
            this.edit_button.Text = "Edit Selected";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(178, 8);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 23);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "Delete Selected";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 8);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(101, 23);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add New";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // first_element_button
            // 
            this.first_element_button.Image = ((System.Drawing.Image)(resources.GetObject("first_element_button.Image")));
            this.first_element_button.Location = new System.Drawing.Point(947, 238);
            this.first_element_button.Name = "first_element_button";
            this.first_element_button.Size = new System.Drawing.Size(25, 45);
            this.first_element_button.TabIndex = 16;
            this.first_element_button.UseVisualStyleBackColor = true;
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
            this.bus_schedules_listview.Location = new System.Drawing.Point(12, 66);
            this.bus_schedules_listview.MultiSelect = false;
            this.bus_schedules_listview.Name = "bus_schedules_listview";
            this.bus_schedules_listview.Size = new System.Drawing.Size(929, 483);
            this.bus_schedules_listview.TabIndex = 14;
            this.bus_schedules_listview.UseCompatibleStateImageBehavior = false;
            this.bus_schedules_listview.View = System.Windows.Forms.View.Details;
            // 
            // BusNumber
            // 
            this.BusNumber.Text = "Bus";
            this.BusNumber.Width = 50;
            // 
            // DepartingStation
            // 
            this.DepartingStation.Text = "Departing Station";
            this.DepartingStation.Width = 250;
            // 
            // DestinationStation
            // 
            this.DestinationStation.Text = "Destination Station";
            this.DestinationStation.Width = 250;
            // 
            // DepartingTime
            // 
            this.DepartingTime.Text = "Departing Time";
            this.DepartingTime.Width = 180;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Text = "Arrival Time";
            this.ArrivalTime.Width = 195;
            // 
            // special_func_button
            // 
            this.special_func_button.Location = new System.Drawing.Point(840, 37);
            this.special_func_button.Name = "special_func_button";
            this.special_func_button.Size = new System.Drawing.Size(101, 23);
            this.special_func_button.TabIndex = 17;
            this.special_func_button.Text = "See longest rides";
            this.special_func_button.UseVisualStyleBackColor = true;
            // 
            // delete_all_button
            // 
            this.delete_all_button.Location = new System.Drawing.Point(178, 37);
            this.delete_all_button.Name = "delete_all_button";
            this.delete_all_button.Size = new System.Drawing.Size(101, 23);
            this.delete_all_button.TabIndex = 18;
            this.delete_all_button.Text = "Delete All";
            this.delete_all_button.UseVisualStyleBackColor = true;
            this.delete_all_button.Click += new System.EventHandler(this.delete_all_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.delete_all_button);
            this.Controls.Add(this.special_func_button);
            this.Controls.Add(this.first_element_button);
            this.Controls.Add(this.last_element_button);
            this.Controls.Add(this.bus_schedules_listview);
            this.Controls.Add(this.up_one_element_button);
            this.Controls.Add(this.down_one_element_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Bus Schedules";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button last_element_button;
        private System.Windows.Forms.Button up_one_element_button;
        private System.Windows.Forms.Button down_one_element_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button first_element_button;
        private System.Windows.Forms.ListView bus_schedules_listview;
        private System.Windows.Forms.ColumnHeader BusNumber;
        private System.Windows.Forms.ColumnHeader DepartingStation;
        private System.Windows.Forms.ColumnHeader DestinationStation;
        private System.Windows.Forms.ColumnHeader DepartingTime;
        private System.Windows.Forms.ColumnHeader ArrivalTime;
        private System.Windows.Forms.Button special_func_button;
        private System.Windows.Forms.Button delete_all_button;
    }
}

