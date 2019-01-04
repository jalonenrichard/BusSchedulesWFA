using System.Windows.Forms;
using BusScheduleApp.Services;
using BusScheduleApp.Views;

namespace BusScheduleApp
{
    public partial class MainForm : Form
    {
        private BusService busService;

        public MainForm()
        {
            InitializeComponent();
            busService = new BusService();
            PopulateListView();
        }

        public void PopulateListView()
        {
            foreach (var bus in busService.GetAllBusSchedules())
            {
                ListViewItem row = new ListViewItem(bus.BusNumber);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingStation));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DestinationStation));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.DepartingTime.ToString()));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, bus.ArrivalTime.ToString()));
                bus_schedules_listview.Items.Add(row);
            }
        }

        private void add_button_Click(object sender, System.EventArgs e)
        {
            AddBusForm addBusForm = new AddBusForm(bus_schedules_listview);
            addBusForm.Show();
        }

        private void delete_all_button_Click(object sender, System.EventArgs e)
        {
            busService.DeleteAllBuses();
            bus_schedules_listview.Items.Clear();
        }
    }
}