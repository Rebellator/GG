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

namespace Oskars
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Nominant nominant = new Nominant
            {
                name = textBoxName.Text,
                nominations = int.Parse(textBoxNominations.Text),
                oscars = int.Parse(textBoxOscars.Text)
            };
            ControlDb.Add(nominant);
            Thread.Sleep(500);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
