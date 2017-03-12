using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class EditStopForm : Form
    {
        private Stop _selected;
        private List<Stop> _stops;

        public EditStopForm(List<Stop> stops)
        {
            InitializeComponent();
            Init(stops);
        }

        public void Init(List<Stop> stops)
        {
            listBoxStops.Items.Clear();
            BtnReplace.Enabled = false;
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = false;
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
                BtnReplace.Enabled = true;
                BtnDelete.Enabled = true;
                _selected = _stops[listBoxStops.SelectedIndex];
                textBoxEditStopName.Text = _selected.Name;
                textBoxEditCity.Text = _selected.City;
                textBoxEditStreet.Text = _selected.Street;
            }
        }

        private void textBoxEditCity_TextChanged(object sender, EventArgs e)
        {
            BtnAdd.Enabled = true;
        }

        private void textBoxEditStreet_TextChanged(object sender, EventArgs e)
        {

            BtnAdd.Enabled = true;
        }

        private void textBoxEditStopName_TextChanged(object sender, EventArgs e)
        {
            BtnAdd.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _stops.Remove(_selected);
            Init(_stops);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_selected != null)
                _stops.Insert(_stops.IndexOf(_selected), new Stop(textBoxEditStreet.Text, textBoxEditCity.Text, textBoxEditStopName.Text));
            else
                _stops.Add(new Stop(textBoxEditStreet.Text, textBoxEditCity.Text, textBoxEditStopName.Text));
            Init(_stops);
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            foreach (var stop in _stops.Where(c => c.Name.Equals(_selected.Name)))
            {
                stop.Name = textBoxEditStopName.Text;
                stop.City = textBoxEditCity.Text;
                stop.Street = textBoxEditStreet.Text;
            }
            Init(_stops);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Init(_stops);
            Close();
        }
    }
}
