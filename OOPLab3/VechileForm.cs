using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPLab3
{
    public partial class VechileForm : Form
    {
        private Vechile _selected;
        private readonly List<Vechile> _vechiles;

        public VechileForm(List<Vechile> vechiles)
        {
            InitializeComponent();
            _vechiles = vechiles;
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
                labelModel.Text = _selected.Model;
                labelTransportType.Text = Program.VechileTypeName(_selected.VechileType);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var newEditVechileForm = new EditVechileForm(_vechiles);
            newEditVechileForm.Show();
            Close();
        }
        
    }
}

