using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oskars.Oscars;

namespace Oskars.Filters
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlDb.Add(new Series
            {
                title = textBox1.Text,
                year = int.Parse(textBox2.Text),
                tvChanal = textBox3.Text,
                completedSeasons = int.Parse(textBox4.Text)
            });
            Close();
        }
    }
}
