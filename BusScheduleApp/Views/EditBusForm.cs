using System;
using System.Drawing;
using System.Windows.Forms;
using BusScheduleApp.Models;
using BusScheduleApp.Services;

namespace BusScheduleApp.Views
{
    public partial class EditBusForm : Form
    {
        private Bus _bus;
        private BusService _busService;
        private MainForm _mainForm;

        public EditBusForm(MainForm mainForm, Bus bus)
        {
            _busService = new BusService();
            _mainForm = mainForm;
            _bus = bus;
            InitializeComponent();
            FillBusData();
        }

        private void FillBusData()
        {
            bus_number_textbox.Text = _bus.BusNumber;
            departing_station_textbox.Text = _bus.DepartingStation;
            destination_station_textbox.Text = _bus.DestinationStation;
            departing_dateTimePicker.Value = DateTime.Parse(_bus.DepartingTime);
            arrival_dateTimePicker.Value = DateTime.Parse(_bus.ArrivalTime);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled() || !ValuesChanged())
                return;

            _busService.UpdateBus(_bus);
        }

        private bool ValuesChanged()
        {
            throw new NotImplementedException();
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
    }
}