using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class StopForm : Form
    {
        private Stop _selected;
        private readonly List<Stop> _stops;

        public StopForm(List<Stop> stops)
        {
            InitializeComponent();
            _stops = stops;
            foreach (var stop in stops)
            {
                listBoxStops.Items.Add(stop.Name);
            }
        }

        private void listBoxStops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStops.SelectedIndex != -1)
            {
                _selected = _stops[listBoxStops.SelectedIndex];
                labelStreet.Text = _selected.Street;
                labelCity.Text = _selected.City;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var newEditStopForm = new EditStopForm(_stops);
            newEditStopForm.Show();
            Close();
        }
        
    }
}

