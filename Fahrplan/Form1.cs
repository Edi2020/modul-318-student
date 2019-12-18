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
        public Form1()
        {
            InitializeComponent();
        }

        private void VerbindungSuchenButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxVon_DropDown(object sender, EventArgs e)
        {
            var Von = Convert.ToString(comboBoxVon.Text);
            transport.GetStations(Von);
            Stations stations = transport.GetStations(Von);
            foreach (Station station in stations.StationList)
            {
                comboBoxNach.Text = Convert.ToString(Von);
            }
        }
    }
}
