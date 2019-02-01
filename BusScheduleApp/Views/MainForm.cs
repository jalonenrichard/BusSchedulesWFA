using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using BusScheduleApp.Models;
using BusScheduleApp.Services;
using Microsoft.Win32;

namespace BusScheduleApp.Views
{
    public partial class MainForm : Form
    {
        private readonly BusService _busService;
        private List<Bus> _deletedBuses;
        private bool _deletedAll = false;

        public MainForm()
        {
            InitializeComponent();
            _busService = new BusService();
            PopulateListView();
            edit_button.Enabled = false;
            delete_button.Enabled = false;
            _deletedBuses = new List<Bus>();
        }

        public void PopulateListView()
        {
            foreach (var bus in _busService.GetAllBusSchedules())
            {
                ListViewItem row = new ListViewItem(bus.BusNumber) {Tag = bus};
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingStation));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DestinationStation));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingTime.ToString("g")));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.ArrivalTime.ToString("g")));
                bus_schedules_listview.Items.Add(row);
            }
        }

        public void RefreshBusListView()
        {
            bus_schedules_listview.Items.Clear();
            PopulateListView();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddBusForm addBusForm = new AddBusForm(this);
            addBusForm.Show();
        }

        private void delete_all_button_Click(object sender, EventArgs e)
        {
            DialogResult userChoice = MessageBox.Show(@"Delete all entries?", @"Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (userChoice == DialogResult.Yes)
            {
                _deletedAll = true;
                _deletedBuses.AddRange(_busService.GetAllBusSchedules());
                _busService.DeleteAllBuses();
                bus_schedules_listview.Items.Clear();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (bus_schedules_listview.SelectedItems.Count > 0)
            {
                Bus bus = (Bus) bus_schedules_listview.SelectedItems[0].Tag;
                _deletedBuses.Add(bus);
                _busService.DeleteBus(bus);
                RefreshBusListView();
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (bus_schedules_listview.SelectedItems.Count > 0)
            {
                Bus bus = (Bus) bus_schedules_listview.SelectedItems[0].Tag;
                EditBusForm editBusForm = new EditBusForm(this, bus);
                editBusForm.Show();
            }
        }

        private void bus_schedules_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bus_schedules_listview.SelectedItems.Count > 0)
            {
                edit_button.Enabled = true;
                delete_button.Enabled = true;
            }
            else
            {
                edit_button.Enabled = false;
                delete_button.Enabled = false;
            }
        }

        private void special_func_button_Click(object sender, EventArgs e)
        {
            LongestRides longestRides = new LongestRides();
            longestRides.Show();
        }

        private void up_one_element_button_Click(object sender, EventArgs e)
        {
            if (bus_schedules_listview.SelectedItems.Count > 0)
            {
                var selectedItem = bus_schedules_listview.SelectedItems[0];
                int selectedItemIndex = bus_schedules_listview.Items.IndexOf(selectedItem);
                if (selectedItemIndex > 0)
                    selectedItemIndex--;
                bus_schedules_listview.Focus();
                bus_schedules_listview.Items[selectedItemIndex].Selected = true;
            }
        }

        private void down_one_element_button_Click(object sender, EventArgs e)
        {
            if (bus_schedules_listview.SelectedItems.Count > 0)
            {
                var selectedItem = bus_schedules_listview.SelectedItems[0];
                int selectedItemIndex = bus_schedules_listview.Items.IndexOf(selectedItem);
                if (selectedItemIndex < bus_schedules_listview.Items.Count - 1)
                    selectedItemIndex++;
                bus_schedules_listview.Focus();
                bus_schedules_listview.Items[selectedItemIndex].Selected = true;
            }
        }

        private void first_element_button_Click(object sender, EventArgs e)
        {
            if (bus_schedules_listview.Items.Count > 0)
            {
                bus_schedules_listview.Focus();
                bus_schedules_listview.Items[0].Selected = true;
            }
        }

        private void last_element_button_Click(object sender, EventArgs e)
        {
            if (bus_schedules_listview.Items.Count > 0)
            {
                bus_schedules_listview.Focus();
                bus_schedules_listview.Items[bus_schedules_listview.Items.Count - 1].Selected = true;
            }
        }

        private void undo_button_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine(_deletedAll);
                Debug.WriteLine(string.Join(",", _deletedBuses));
                if (!_deletedBuses.Any()) return;
                if (_deletedAll)
                {
                    foreach (var bus in _deletedBuses)
                    {
                        _busService.AddNewBus(bus);
                        //_deletedBuses.Remove(bus);
                        RefreshBusListView();
                        _deletedAll = false;
                    }

                    _deletedBuses.Clear();
                }
                else
                {
                    var deletedBus = _deletedBuses.ElementAt(_deletedBuses.Count - 1);
                    var matches = _busService.GetAllBusSchedules().Where(p => p.BusNumber == deletedBus.BusNumber);
                    if (!matches.Any())
                    {
                        _busService.AddNewBus(deletedBus);
                        RefreshBusListView();
                        _deletedBuses.RemoveAt(_deletedBuses.Count - 1);
                    }
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Undo error (nothing was deleted or bus already exists: " + exception.Message);
            }
        }
    }
}