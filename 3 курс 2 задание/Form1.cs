using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_курс_2_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddField_B_Click(object sender, EventArgs e)
        {
            Element E = new Element(Convert.ToString(FieldOne_TB.Text), 
                                   Convert.ToString(FieldTwo_TB.Text));
            ListBox_LB.Items.Add(E);
        }

        private void Del_B_Click(object sender, EventArgs e)
        {
            if (ListBox_LB.SelectedIndex >= 0)
                ListBox_LB.Items.RemoveAt(ListBox_LB.SelectedIndex);
            else
                MessageBox.Show("Не выбран элемент", "Информация", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
        }

        private void SubtracOperator_B_Click(object sender, EventArgs e)
        {
            if (ListBox_LB.SelectedIndex >= 0)
            {
                Element E = new Element(Convert.ToString(SubtracOperatorOne_TB.Text),
                                        Convert.ToString(SubtracOperatorTwo_TB.Text));
                Element Result = (ListBox_LB.SelectedItem as Element) - E;
                Result_TB.Text = "\"" + ListBox_LB.SelectedItem + "\" - \"" + E + "\" = \"" + Result + "\"";
            }
            else
                MessageBox.Show("Не выбран элемент", "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void ResultingOperator_B_Click(object sender, EventArgs e)
        {
            if (ListBox_LB.SelectedIndex >= 0)
            {
                Element Result = (ListBox_LB.SelectedItem as Element) * Convert.ToInt32(ResultingOperatorTwo_NUD.Value);
                Result_TB.Text = "\"" + ListBox_LB.SelectedItem + "\" * \"" + Convert.ToInt32(ResultingOperatorTwo_NUD.Value) + "\" = \"" + Result + "\"";
            }
            else
                MessageBox.Show("Не выбран элемент", "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void EqualsOperator_B_Click(object sender, EventArgs e)
        {
            if (ListBox_LB.SelectedIndex >= 0)
            {
                Element E = new Element(Convert.ToString(EqualsOperatorOne_TB.Text),
                                        Convert.ToString(EqualsOperatorTwo_TB.Text));
                bool Result = (ListBox_LB.SelectedItem as Element) == E;
                Result_TB.Text = "\"" + ListBox_LB.SelectedItem + "\" == \"" + E + "\" = \"" + Result + "\"";
            }
            else
                MessageBox.Show("Не выбран элемент", "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void LessOperator_B_Click(object sender, EventArgs e)
        {
            if (ListBox_LB.SelectedIndex >= 0)
            {
                Element E = new Element(Convert.ToString(LessOperatorOne_TB.Text),
                                        Convert.ToString(LessOperatorTwo_TB.Text));
                bool Result = (ListBox_LB.SelectedItem as Element) < E;
                Result_TB.Text = "\"" + ListBox_LB.SelectedItem + "\" < \"" + E + "\" = \"" + Result + "\"";
            }
            else
                MessageBox.Show("Не выбран элемент", "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
