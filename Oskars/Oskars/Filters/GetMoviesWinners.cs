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
    public partial class GetMoviesWinners : Form
    {
        DataGridView dataGrid = new DataGridView();

        public GetMoviesWinners()
        {
            InitializeComponent();
        }

        public void getMovie(DataGridView dataGrid)
        {
            this.dataGrid = dataGrid;
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           FormMain.ListFilmByYear = ControlDb.getFilmByYear(int.Parse(textBox1.Text), decimal.Parse(textBox2.Text));
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
