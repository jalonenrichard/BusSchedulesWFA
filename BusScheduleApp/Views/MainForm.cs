using System.Windows.Forms;
using BusScheduleApp.Models;
using BusScheduleApp.Services;

namespace BusScheduleApp.Views
{
    public partial class MainForm : Form
    {
        private readonly BusService _busService;

        public MainForm()
        {
            InitializeComponent();
            _busService = new BusService();
            PopulateListView();
        }

        public void PopulateListView()
        {
            foreach (var bus in _busService.GetAllBusSchedules())
            {
                ListViewItem row = new ListViewItem(bus.BusNumber) {Tag = bus};
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingStation));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DestinationStation));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingTime));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.ArrivalTime));
                bus_schedules_listview.Items.Add(row);
            }
        }

        public void AddBusToListView()
        {
            bus_schedules_listview.Items.Clear();
            PopulateListView();
        }

        private void add_button_Click(object sender, System.EventArgs e)
        {
            AddBusForm addBusForm = new AddBusForm(this);
            addBusForm.Show();
        }

        private void delete_all_button_Click(object sender, System.EventArgs e)
        {
            DialogResult userChoice = MessageBox.Show(@"Delete all entries?", @"Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (userChoice == DialogResult.Yes)
            {
                _busService.DeleteAllBuses();
                bus_schedules_listview.Items.Clear();
            }
        }

        private void delete_button_Click(object sender, System.EventArgs e)
        {
            if (bus_schedules_listview.SelectedItems.Count > 0)
            {
                Bus bus = (Bus) bus_schedules_listview.SelectedItems[0].Tag;
                _busService.DeleteBus(bus);
                bus_schedules_listview.SelectedItems[0].Remove();
                bus_schedules_listview.Update();
            }
        }

        private void edit_button_Click(object sender, System.EventArgs e)
        {
            if (bus_schedules_listview.SelectedItems.Count > 0)
            {
                Bus bus = (Bus) bus_schedules_listview.SelectedItems[0].Tag;
                EditBusForm editBusForm = new EditBusForm(this, bus);
                editBusForm.Show();
            }
        }
    }
}