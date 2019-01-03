using System.Windows.Forms;
using BusScheduleApp.Services;

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

        private void PopulateListView()
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
    }
}