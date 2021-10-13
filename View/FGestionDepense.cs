using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Dao;

namespace View
{
    public partial class FGestionDepense : Form
    {
        public FGestionDepense()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            this.load(new DaoDepense().GetAll());
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            List<Depense> lesDepenses = new List<Depense>();
            foreach (object o in lbDepenses.Items)
            {
                lesDepenses.Add((Depense)o);
            }
            new DaoDepense().SaveChanges(lesDepenses);
            this.load(lesDepenses);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbDepenses.SelectedIndex == -1) return;
            int position = lbDepenses.SelectedIndex;
            ((Depense)lbDepenses.Items[position]).Remove();
            lbDepenses.Items[position] = lbDepenses.Items[position];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbDepenses.SelectedIndex == -1) return;
            int position = lbDepenses.SelectedIndex;
            FeditDepense fEdit = new FeditDepense(State.modified, lbDepenses.Items, position);
            fEdit.Show();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            FeditDepense fEdit = new FeditDepense(State.added, lbDepenses.Items, 0);
            fEdit.Show();
        }

        private void load(List<Depense> lesDepenses)
        {
            lbDepenses.Items.Clear();
            foreach (Depense d in lesDepenses)
            {
                lbDepenses.Items.Add(d);
            }
        }
    }
}
