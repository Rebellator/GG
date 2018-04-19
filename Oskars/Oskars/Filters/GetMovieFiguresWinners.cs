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
    public partial class GetMovieFiguresWinners : Form
    {
        public BindingList<AllActorsWinners> win = new BindingList<AllActorsWinners>();

        public GetMovieFiguresWinners()
        {
            InitializeComponent();
        }

        public void createAlert()
        {
            this.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormMain.ListWinnerses = ControlDb.GetAllActorsWinners(comboBox1.Text,int.Parse(comboBox2.Text), comboBox3.Text);

            Close();
        }
    }
}
