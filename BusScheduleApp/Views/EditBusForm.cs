﻿using System;
using System.Drawing;
using System.Windows.Forms;
using BusScheduleApp.Models;
using BusScheduleApp.Services;

namespace BusScheduleApp.Views
{
    public partial class EditBusForm : Form
    {
        private readonly Bus _bus;
        private readonly BusService _busService;
        private readonly MainForm _mainForm;

        public EditBusForm(MainForm mainForm, Bus bus)
        {
            InitializeComponent();
            _busService = new BusService();
            _mainForm = mainForm;
            _bus = bus;
            departing_dateTimePicker.Format = DateTimePickerFormat.Custom;
            departing_dateTimePicker.CustomFormat = @"dd.MM.yyy HH:mm";
            arrival_dateTimePicker.Format = DateTimePickerFormat.Custom;
            arrival_dateTimePicker.CustomFormat = @"dd.MM.yyyy HH:mm";
            FillBusData();
        }

        private void FillBusData()
        {
            bus_number_textbox.Text = _bus.BusNumber;
            departing_station_textbox.Text = _bus.DepartingStation;
            destination_station_textbox.Text = _bus.DestinationStation;
            departing_dateTimePicker.Value = _bus.DepartingTime;
            arrival_dateTimePicker.Value = _bus.ArrivalTime;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (!FieldsFilledCorrectly())
                return;
            if (!ValuesChanged())
            {
                Close();
                return;
            }

            _busService.DeleteBus(_bus);
            _busService.AddNewBus(new Bus
            {
                BusNumber = bus_number_textbox.Text,
                DepartingStation = departing_station_textbox.Text,
                DestinationStation = destination_station_textbox.Text,
                DepartingTime = departing_dateTimePicker.Value,
                ArrivalTime = arrival_dateTimePicker.Value
            });
            _mainForm.RefreshBusListView();
            Close();
        }

        private bool FieldsFilledCorrectly()
        {
            bool numberFieldFilled = true;
            bool departingFieldFilled = true;
            bool destinationFieldFilled = true;
            bool datesCorrect = true;

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

            if (DateTime.Compare(departing_dateTimePicker.Value, arrival_dateTimePicker.Value) >= 0)
            {
                arrival_time_label.ForeColor = Color.Crimson;
                datesCorrect = false;
            }

            if (numberFieldFilled)
                bus_number_label.ResetForeColor();
            if (departingFieldFilled)
                departing_station_label.ResetForeColor();
            if (destinationFieldFilled)
                destination_station_label.ResetForeColor();
            if (datesCorrect)
                arrival_time_label.ResetForeColor();

            if (numberFieldFilled && departingFieldFilled && destinationFieldFilled && datesCorrect)
                return true;

            return false;
        }

        private bool ValuesChanged()
        {
            return bus_number_textbox.Text != _bus.BusNumber ||
                   departing_station_textbox.Text != _bus.DepartingStation ||
                   destination_station_textbox.Text != _bus.DestinationStation ||
                   departing_dateTimePicker.Value != _bus.DepartingTime ||
                   arrival_dateTimePicker.Value != _bus.ArrivalTime;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}