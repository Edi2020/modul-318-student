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
            textBoxZeit.Text = DateTime.Now.ToString("HH:mm");
            dtpDatum.Text = DateTime.Now.ToString();
        }

        //Code für den Verbindungen suchen Button.
        private void VerbindungSuchenButton_Click(object sender, EventArgs e)
        { 
            string Date = dtpDatum.Value.Year + "-" + dtpDatum.Value.Month + "-" + dtpDatum.Value.Day;
            Connections connections = transport.GetConnections(comboBoxVon.Text, comboBoxNach.Text);
            listBoxVerbindungen.Items.Clear();
            foreach (Connection connection in connections.ConnectionList)
            {
                var departure = Convert.ToDateTime(connection.From.Departure);
                var arrival = Convert.ToDateTime(connection.To.Arrival);
                listBoxVerbindungen.Items.Add(comboBoxVon.Text + " " + comboBoxNach.Text + " " + "Abfahrt:" + " " + connection.From.Departure + " " + "Ankunft:" + " " + connection.To.Arrival);
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
            List<StationBoard> StationBoardList = transport.GetStationBoard(comboBoxStation.Text, string.Empty).Entries;

            listBoxAbfahrtsplan.Items.Clear();

            foreach (var s in StationBoardList)
            {
                if (s.Name != null)
                {
                    listBoxAbfahrtsplan.Items.Add("Von: " + comboBoxStation.Text + "        Nach: " + s.To);
                    listBoxAbfahrtsplan.Items.Add("");
                }
            }
        }

        private void StationsortAnzeigenButton_Click(object sender, EventArgs e)
        {
            /*Wenn Suche nicht nichts drin ist dann soll Programm ausführen
             wenn das nicht so ist dann MessageBox anzeigen*/
            if (comboBoxStation.Text != "")
            {
                double xcoordinate;
                //xcoordinate = station.Coordinate.XCoordinate;
                double ycoordinate;
                //ycoordinate = station.Coordinate.YCoordinate;
                string url;
                url = "https://www.google.ch/maps/place/" + comboBoxStation.Text;
                webBrowser1.Navigate(url);
            }
            else
            {
                MessageBox.Show("Kein Stationsort angegeben!");
            }
        }

        private void MSDNButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/de-de/?view=netframework-4.8");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:edi.kocuvan24@hotmail.com");
        }
    }
}
