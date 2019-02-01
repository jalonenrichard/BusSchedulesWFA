using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusScheduleApp.Models;
using BusScheduleApp.Services;

namespace BusScheduleApp.Views
{
    public partial class LongestRides : Form
    {
        private readonly BusService _busService;

        public LongestRides()
        {
            InitializeComponent();
            _busService = new BusService();
            PopulateListView();
        }

        private void PopulateListView()
        {
            List<Bus> longSchedules = _busService.GetLongestBusSchedules();
            if (longSchedules.Any())
            {
                foreach (var bus in longSchedules)
                {
                    ListViewItem row = new ListViewItem(bus.BusNumber) {Tag = bus};
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingStation));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DestinationStation));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingTime.ToString("g")));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.ArrivalTime.ToString("g")));
                    bus_schedules_listview.Items.Add(row);
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}