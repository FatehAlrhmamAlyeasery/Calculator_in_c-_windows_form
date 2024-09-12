using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect2_fateh_motaher_abdoh_saleh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtb1.TextChanged += txtb2_TextChanged;
            sum.Enabled = sub.Enabled = mult.Enabled = divsion.Enabled = false;
            this.Text = "الة حاسبة بسيطة";
            result.ReadOnly = true;

        }

        private void txtb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 || e.KeyChar == 46)
                e.Handled = false;
            else if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            { e.Handled = true; }
        }

        private void txtb2_KeyPress(object sender, KeyPressEventArgs e)
        {
                 if (e.KeyChar == 45 || e.KeyChar == 46)
                e.Handled = false;
            else if ((e.KeyChar < 48 || e.KeyChar > 57 ) && (e.KeyChar != 8))
            { e.Handled = true; }

        }

        private void txtb1_TextChanged(object sender, EventArgs e)
        {
            if(txtb1.Text.Trim()!=null&&txtb2.Text.Trim()!=null)
            { sum.Enabled = sub.Enabled = mult.Enabled = divsion.Enabled = true; }
            else
            {
                sum.Enabled = sub.Enabled = mult.Enabled = divsion.Enabled = (txtb1.Text.Trim()!=null&&txtb2.Text.Trim()!=null);
            }
        }

        private void txtb2_TextChanged(object sender, EventArgs e)
        {
            if (txtb1.Text.Trim() != null && txtb2.Text.Trim() != null)
            { sum.Enabled = sub.Enabled = mult.Enabled = divsion.Enabled = (txtb1.Text.Trim() != null && txtb2.Text.Trim() != null); }
            else
            {
                sum.Enabled = sub.Enabled = mult.Enabled = divsion.Enabled = (txtb1.Text.Trim() != null && txtb2.Text.Trim() != null);
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            result.Text = (Convert.ToDouble(txtb1.Text) + Convert.ToDouble(txtb2.Text)).ToString();

        }

        private void sub_Click(object sender, EventArgs e)
        {
            result.Text = (Convert.ToDouble(txtb1.Text) - Convert.ToDouble(txtb2.Text)).ToString();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            result.Text = (Convert.ToDouble(txtb1.Text) * Convert.ToDouble(txtb2.Text)).ToString();

        }

        private void divsion_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = Convert.ToDouble(txtb1.Text);
            y = Convert.ToDouble(txtb2.Text);
            if(y!=0)
            { z = x / y;
                result.Text = z.ToString();
            }
            else
            { MessageBox.Show("لا يمكن القسمة على صفر ");
                txtb2.Focus();
                txtb2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            txtb1.Clear();
            txtb2.Clear();
            result.Clear();
        }
    }
}
