using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oskars.Filters
{
    public partial class GetFiguresInMovies : Form
    {
        public GetFiguresInMovies()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormMain.ListFiguresToMovieses = ControlDb.getMovieFigures(textBox1.Text, decimal.Parse(textBox2.Text));
            Close();
        }
    }
}
