using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {

            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var bufferResult = new List<Route>();
            List<Route> searchResult;

            if (!String.IsNullOrWhiteSpace(textBoxNumber.Text))
            {
                foreach (var route in Program.DataRoutes)
                {
                    if (route.Number.Contains(textBoxNumber.Text))
                    {
                        bufferResult.Add(route);
                    }
                }
                if (!String.IsNullOrWhiteSpace(comboBoxTransportType.Text))
                {

                    searchResult = bufferResult;
                    bufferResult = new List<Route>();

                    foreach (var route in searchResult)
                    {
                        if (Program.VechileTypeEquals(comboBoxTransportType.Text) == route.VechileType)
                        {
                            bufferResult.Add(route);
                        }
                    }
                }
                if (!String.IsNullOrWhiteSpace(textBoxStreet.Text))
                {
                    searchResult = bufferResult;
                    bufferResult = new List<Route>();

                    foreach (
                        var route in
                        searchResult.Where(c => c.Stops.Any(d => d.Street == textBoxStreet.Text)))
                    {
                        bufferResult.Add(route);
                    }
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(comboBoxTransportType.Text))
                {
                    foreach (var route in Program.DataRoutes)
                    {

                        if (Program.VechileTypeEquals(comboBoxTransportType.Text) == route.VechileType)
                        {
                            bufferResult.Add(route);
                        }
                    }
                }
                else
                {
                    bufferResult = Program.DataRoutes;
                }
                if (!String.IsNullOrWhiteSpace(textBoxStreet.Text))
                {
                    searchResult = bufferResult;
                    bufferResult = new List<Route>();

                    foreach (
                        var route in
                        searchResult.Where(c => c.Stops.Any(d => d.Street == textBoxStreet.Text)))
                    {
                        bufferResult.Add(route);
                    }
                }
            }

            var routesForm = new RouteForm(bufferResult);
            routesForm.Show();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            var about = new ProgramInfoForm();
            about.Show();
        }
        
        private void DestroyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var randomSetter = new RandomSetter();
            randomSetter.DestroyModel();
        }

        private void FillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var randomSetter = new RandomSetter();
            randomSetter.SetModel();
        }

        private void ConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newConvertorForm = new ConvertorForm();
            newConvertorForm.Show();
        }
    }
}
