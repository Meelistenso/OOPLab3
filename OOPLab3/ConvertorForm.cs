using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace OOPLab3
{
    public partial class ConvertorForm : Form
    {
        static string[] types = new string[4] { "Явное преобразование", "Неявное преобразование", "Преобразование с помощью Convert( )", "Преобразование с помощью Parse( )" };
        static Type[] explicitType = new Type[2] { typeof(ulong), typeof(float) };
        static Type[] notExplicitTypes = new Type[2] { typeof(float), typeof(sbyte) };
        static Type[] parseTypes = new Type[2] { typeof(int), typeof(char) };
        static Type[,] convertTypes = new Type[5,2] { {typeof(float), typeof(sbyte)}, {typeof(long), typeof(byte)}, {typeof(uint),typeof(short)}, {typeof(char),typeof(sbyte)}, {typeof(float),typeof(double)} };
        
        public ConvertorForm()
        {
            InitializeComponent();
            foreach (var type in types)
            {
            comboBoxType.Items.Add(type);
            }
        }

        private void ConvertorForm_Load(object sender, EventArgs e)
        {
          
           // var asda = explicitType[0].GetConstructor(new[]{typeof(float)}).Invoke(new object[] { 10.0f});
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxValues.Items.Clear();
            switch (comboBoxType.Text)
            {
                case "Явное преобразование":
                    comboBoxValues.Items.Add
                    (explicitType[0].ToString().Replace("System.", "").Replace("Single", "Float")
                    + " < " +
                     explicitType[1].ToString().Replace("System.", "").Replace("Single", "Float"));
                    break;
                case "Неявное преобразование":
                    comboBoxValues.Items.Add
                    (notExplicitTypes[0].ToString().Replace("System.", "").Replace("Single", "Float")
                    + " < " +
                     notExplicitTypes[1].ToString().Replace("System.", "").Replace("Single", "Float"));
                    break;
                case "Преобразование с помощью Parse( )":
                    foreach (var type in parseTypes)
                    {
                        comboBoxValues.Items.Add("String < "+type.ToString().Replace("System.", "").Replace("Single", "Float"));
                    }
                    break;
                case "Преобразование с помощью Convert( )":
                    for(int i=0; i<5;i++)
                    {
                        comboBoxValues.Items.Add(
                        convertTypes[i,0].ToString().Replace("System.","").Replace("Single", "Float")
                        +" < "+
                        convertTypes[i,1].ToString().Replace("System.", "").Replace("Single", "Float")
                        );
                    }
                    break;
                default:
                    return;
            }
        }

        private void comboBoxValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] t = comboBoxValues.SelectedItem.ToString().Split('<');
            if (t!=null)
            {
                Typelabel1.Text = t[0];
                typelabel2.Text = t[1];
            }
        }

        private void textBoxValue1_TextChanged(object sender, EventArgs e)
        {
            textBoxValue2.Text=
        }

        private void textBoxValue2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
