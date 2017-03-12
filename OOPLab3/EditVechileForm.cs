using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class EditVechileForm : Form
    {
        private Vechile _selected;
        private List<Vechile> _vechiles;

        public EditVechileForm(List<Vechile> vechiles)
        {
            InitializeComponent();
            Init(vechiles);
        }

        public void Init(List<Vechile> vechiles)
        {
            listBoxVechiles.Items.Clear();

            textBoxEditType.Enabled = false;
            BtnReplace.Enabled = false;
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = false;
            _vechiles = vechiles;
            if (vechiles.Count < 1)
                textBoxEditType.Enabled = true;
            else if (vechiles[0].VechileType != VechileTypes.NotSelected)
                textBoxEditType.Text = Program.VechileTypeName(vechiles[0].VechileType);
            foreach (var vechile in vechiles)
            {
                listBoxVechiles.Items.Add(vechile.Number);
            }
        }

        private void listBoxVechiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVechiles.SelectedIndex != -1)
            {
                _selected = _vechiles[listBoxVechiles.SelectedIndex];
                BtnReplace.Enabled = true;
                BtnDelete.Enabled = true;

                textBoxEditNumber.Text = _selected.Number;
                textBoxEditType.Text = Program.VechileTypeName(_selected.VechileType);
            }
            if (_vechiles.Count != 0)
            {
                textBoxEditType.Enabled = false;
            }
            else
            {
                textBoxEditType.Enabled = true;
            }
        }
        private void textBoxEditNumber_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxEditNumber.Text))
                BtnAdd.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _vechiles.Remove(_selected);
            Init(_vechiles);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _vechiles.Add(new Vechile(Program.VechileTypeEquals(textBoxEditType.Text), textBoxEditNumber.Text, textBoxEditModel.Text));
            Init(_vechiles);
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            foreach (var vechile in _vechiles.Where(c => c.Number.Equals(_selected.Number)))
            {
                vechile.Number = textBoxEditNumber.Text;
                vechile.Model = textBoxEditModel.Text;
                vechile.VechileType = Program.VechileTypeEquals(textBoxEditType.Text);
            }
            Init(_vechiles);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var newVechileForm = new VechileForm(_vechiles);
            newVechileForm.Show();
            Close();
        }

    }
}
