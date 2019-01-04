using System;
using System.Drawing;
using System.Windows.Forms;
using BusScheduleApp.Models;
using BusScheduleApp.Services;

namespace BusScheduleApp.Views
{
    public partial class AddBusForm : Form
    {
        private BusService busService;
        private ListView _list;

        public AddBusForm(ListView listView)
        {
            busService = new BusService();
            InitializeComponent();
            departing_dateTimePicker.Format = DateTimePickerFormat.Custom;
            departing_dateTimePicker.CustomFormat = @"dd.MM.yyy HH:mm";
            arrival_dateTimePicker.Format = DateTimePickerFormat.Custom;
            arrival_dateTimePicker.CustomFormat = @"dd.MM.yyyy HH:mm";
            _list = listView;
        }

        private void cancel_button_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void add_button_Click(object sender, System.EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                return;
            }

            Bus bus = new Bus();
            bus.BusNumber = bus_number_textbox.Text;
            bus.DepartingStation = departing_station_textbox.Text;
            bus.DestinationStation = destination_station_textbox.Text;
            bus.DepartingTime = departing_dateTimePicker.Value.ToString("g");
            bus.ArrivalTime = arrival_dateTimePicker.Value.ToString("g");
            busService.AddNewBus(bus);
            AddBusToListView(bus);
            Close();
        }

        private bool AreAllFieldsFilled()
        {
            bool numberFieldFilled = true;
            bool departingFieldFilled = true;
            bool destinationFieldFilled = true;

            if (String.IsNullOrEmpty(bus_number_textbox.Text))
            {
                bus_number_label.ForeColor = Color.Crimson;
                numberFieldFilled = false;
            }

            if (String.IsNullOrEmpty(departing_station_textbox.Text))
            {
                departing_station_label.ForeColor = Color.Crimson;
                departingFieldFilled = false;
            }

            if (String.IsNullOrEmpty(destination_station_textbox.Text))
            {
                destination_station_label.ForeColor = Color.Crimson;
                destinationFieldFilled = false;
            }

            if (numberFieldFilled)
                bus_number_label.ResetForeColor();
            if (departingFieldFilled)
                departing_station_label.ResetForeColor();
            if (destinationFieldFilled)
                destination_station_label.ResetForeColor();

            if (numberFieldFilled && departingFieldFilled && destinationFieldFilled)
                return true;

            return false;
        }

        private void AddBusToListView(Bus bus)
        {
            ListViewItem row = new ListViewItem(bus.BusNumber);
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingStation));
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DestinationStation));
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingTime));
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.ArrivalTime));
            _list.Items.Add(row);
            _list.Update();
        }

        private void bus_number_textbox_TextChanged(object sender, System.EventArgs e)
        {
        }
    }
}