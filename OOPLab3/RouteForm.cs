using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class RouteForm : Form
    {
        private Route _selected;
        private readonly List<Route> _routes;

        public RouteForm(List<Route> routes)
        {
            InitializeComponent();
            _routes = routes;
            foreach (var route in routes)
            {
                listBoxRoutes.Items.Add(route.Number);
            }
        }

        private void listBoxRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRoutes.SelectedIndex != -1)
            {
                _selected = _routes[listBoxRoutes.SelectedIndex];

                if ((_selected.VechileType == VechileTypes.NotSelected) && (_selected.Vechiles.Count > 0) && (_selected.Vechiles[_selected.Vechiles.Count - 1].VechileType != VechileTypes.NotSelected))
                {
                    _selected.VechileType = _selected.Vechiles[_selected.Vechiles.Count - 1].VechileType;
                }

                BtnStops.Enabled = true;
                BtnVechiles.Enabled = true;

                labelNumber.Text = _selected.Number;
                labelTransportType.Text = Program.VechileTypeName(_selected.VechileType);
            }
        }

        private void BtnStops_Click(object sender, EventArgs e)
        {
            var stopsForm = new StopForm(_selected.Stops);
            stopsForm.Show();
        }

        private void BtnVechiles_Click(object sender, EventArgs e)
        {
            var vechileForm = new VechileForm(_selected.Vechiles);
            vechileForm.Show();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var newEditRouteForm = new EditRouteForm(_routes);
            newEditRouteForm.Show();
            Close();
        }
    }
}

