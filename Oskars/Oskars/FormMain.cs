using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oskars.Filters;
using Oskars.Oscars;

namespace Oskars
{
    public partial class FormMain : Form
    {
        BindingList<Nominant> nominants = new BindingList<Nominant>();
        static public BindingList<AllActorsWinners> ListWinnerses = new BindingList<AllActorsWinners>();
        static public BindingList<FilmByYear> ListFilmByYear = new BindingList<FilmByYear>();
        static public BindingList<SerieFiguresReq> ListSerieFiguresReq = new BindingList<SerieFiguresReq>();
        static public BindingList<FiguresToMovies> ListFiguresToMovieses = new BindingList<FiguresToMovies>();
        public int numTabel;

        public FormMain()
        {
            InitializeComponent();
           // nominants = ControlDb.SelectAll();
           // dataGridViewOscars.DataSource = nominants;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           var add = new FormAdd();
            add.ShowDialog();
            nominants = ControlDb.SelectAll();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           // ControlDb.GetAllActorsWinners("Так", 1, "Чол.");
        }

        private void getMoviesWinnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new GetMovieFiguresWinners();
            //dialog.ShowDialog();
            dialog.createAlert();
            dataGridView.DataSource = ListWinnerses;
        }

        private void getMoviesWinnersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dialog = new GetMoviesWinners();
            dialog.ShowDialog();
            dataGridView.DataSource = ListFilmByYear;
        }

        private void getSeriesNominantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new GetSeriesNominants();
            dialog.ShowDialog();
            dataGridView.DataSource = ListSerieFiguresReq;
        }

        private void getSeriesSeasonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new GetSeriesSeasons();
            dialog.ShowDialog();
        }

        private void getFiguresInMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new GetFiguresInMovies();
            dialog.ShowDialog();
            dataGridView.DataSource = ListFiguresToMovieses;
        }

        private void getNominantsInMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new GetNominantsInMovies();
            dialog.ShowDialog();
        }

        private void getNominantsInSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Get_Nominants_in_Series();
            dialog.ShowDialog();
        }

        private void getGGInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new GetGGInfo();
            dialog.ShowDialog();
        }

        private void getNominationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new GetNominationInfo();
            dialog.ShowDialog();
        }

        private void getProfessionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new GetProfessionInfo();
            dialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectTable(object sender, EventArgs e)
        {
            var button = sender as Button;
            numTabel = int.Parse(button.Tag.ToString());
            loadTable();
        }

        public void loadTable()
        {
            switch (numTabel)
            {
                case 0:
                    dataGridView.DataSource = ControlDb.SelectAllFromSeries();
                    break;
                case 1:
                    dataGridView.DataSource = ControlDb.SelectAllFromMovies();
                    break;
                case 2:
                    dataGridView.DataSource = ControlDb.SelectAllFromMovieFigures();
                    break;
                case 3:
                    dataGridView.DataSource = ControlDb.SelectAllFromSerieFigures();
                    break;
                case 4:
                    dataGridView.DataSource = ControlDb.SelectAllFromMovieNominants();
                    break;
                case 5:
                    dataGridView.DataSource = ControlDb.SelectAllFromSerieNominants();
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (numTabel == 0)
            {
                var add = new Add();
                add.ShowDialog();
                loadTable();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numTabel == 0)
            {
                ControlDb.Remove((dataGridView.SelectedRows[0].DataBoundItem as Series).title);
                loadTable();
            }
        }
    }
}
