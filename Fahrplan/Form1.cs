using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrplan
{
    public partial class Form1 : Form
    {
        private Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();

        public Form1()
        {
            InitializeComponent();
        }
        //Code für den Verbindungen suchen Button.
        private void VerbindungSuchenButton_Click(object sender, EventArgs e)
        {
            Connections connections = transport.GetConnections(comboBoxVon.Text, comboBoxNach.Text);
            listBoxVerbindungen.Items.Clear();
            foreach (Connection connection in connections.ConnectionList)
            {
                listBoxVerbindungen.Items.Add(comboBoxVon.Text + "\t" + comboBoxNach.Text + "\t Abfahrt" +
                                              connection.From.Departure + "\t Ankunft" + connection.To.Arrival);
            }
        }
        //Die vorschläge werden im comboBoxVon angezeigt.
        private void comboBoxVon_DropDown(object sender, EventArgs e)
        {
            var von = Convert.ToString(comboBoxVon.Text);
            Stations stations = transport.GetStations(von);
            comboBoxVon.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                comboBoxVon.Items.Add(station.Name);
            }
        }
        //Die vorschläge werden im comboBoxNach angezeigt.
        private void comboBoxNach_DropDown(object sender, EventArgs e)
        {
            var nach = Convert.ToString(comboBoxNach.Text);
            Stations stations = transport.GetStations(nach);
            comboBoxNach.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                comboBoxNach.Items.Add(station.Name);
            }
        }
        //Die vorschläge werden im comboBoxStation angezeigt
        private void comboBoxStation_DropDown(object sender, EventArgs e)
        {
            var von = Convert.ToString(comboBoxStation.Text);
            Stations stations = transport.GetStations(von);
            comboBoxStation.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                comboBoxStation.Items.Add(station.Name);
            }
        }

        private void AbfahrtsplanAnzeigenButton_Click(object sender, EventArgs e)
        {

        }
    }
}
