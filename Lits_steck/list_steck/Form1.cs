using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_steck
{
    public partial class Form1 : Form
    {
        List<Zavdannya> zd = new List<Zavdannya>();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                zd.Add(new Zavdannya(i.ToString(), false));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zd.Add(new Zavdannya(textBox1.Text, checkBox1.Checked));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = zd;

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            for(int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
            {
                if (zd.Index[dataGridView1.SelectedRows[i]]. == true)
                    zd.RemoveAt(i);
            }

            dataGridView1.DataSource = null;
                dataGridView1.DataSource = zd;
        }

      
    }
}
