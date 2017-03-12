using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class EditRouteForm : Form
    {
        private Route _selected;
        private List<Route> _routes;

        public EditRouteForm(List<Route> routes)
        {
            InitializeComponent();
            Init(routes);
        }

        public void Init(List<Route> routes)
        {
            listBoxRoutes.Items.Clear();
            BtnReplace.Enabled = false;
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = false;
            _routes = routes;
            foreach (var route in routes)
            {
                listBoxRoutes.Items.Add(route.Number);
            }
        }

        private void listBoxRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {

            _selected = _routes[listBoxRoutes.SelectedIndex];
            if (_selected != null)
            {
                BtnReplace.Enabled = true;
                BtnDelete.Enabled = true;

                textBoxEditNumber.Text = _selected.Number;
                textBoxEditType.Text = Program.VechileTypeName(_selected.VechileType);
            }
            if (_selected.Vechiles.Count != 0)
            {
                textBoxEditType.Enabled = false;
            }
            else
            {
                textBoxEditType.Enabled = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Program.DataRoutes.Remove(_selected);
            Init(_routes);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Program.DataRoutes.Add(new Route(textBoxEditNumber.Text, new List<Stop>(), new List<Vechile>()));
            Init(_routes);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var newRouteForm = new RouteForm(_routes);
            newRouteForm.Show();
            Close();
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            foreach (var route in Program.DataRoutes.Where(c => c.Number.Equals(_selected.Number)))
            {
                route.Number = textBoxEditNumber.Text;
                route.VechileType = Program.VechileTypeEquals(textBoxEditType.Text);
            }
            Init(_routes);
        }

        private void textBoxEditType_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(textBoxEditType.Text)) && (!String.IsNullOrWhiteSpace(textBoxEditNumber.Text)))
                BtnAdd.Enabled = true;
        }

        private void textBoxEditNumber_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxEditNumber.Text))
                BtnAdd.Enabled = true;
        }
    }
}

