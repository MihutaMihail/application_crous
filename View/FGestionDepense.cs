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
            this.Text = "Gestion Dépenses";
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            this.load(new DaoDepense().GetAll());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbDepenses.SelectedIndex == -1) return;
            int position = lbDepenses.SelectedIndex;
            ((Depense)lbDepenses.Items[position]).Remove();
            lbDepenses.Items[position] = lbDepenses.Items[position];

            saveDatabase();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbDepenses.SelectedIndex == -1) return;
            int position = lbDepenses.SelectedIndex;
            FeditDepense fEdit = new FeditDepense(State.modified, lbDepenses.Items, position);
            fEdit.ShowDialog();

            saveDatabase();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            FeditDepense fEdit = new FeditDepense(State.added, lbDepenses.Items, 0);
            fEdit.ShowDialog();

            saveDatabase();
        }

        private void saveDatabase()
        {
            Depenses lesDepenses = new Depenses();
            foreach (object o in lbDepenses.Items)
            {
                lesDepenses.AjouterDepense((Depense)o);
            }
            new DaoDepense().SaveChanges(lesDepenses);
            this.load(lesDepenses);
        }

        private void load(Depenses lesDepenses)
        {
            lbDepenses.Items.Clear();
            for (int i = 0; i < lesDepenses.Count(); i++)
            {
                lbDepenses.Items.Add(lesDepenses[i]);
            }
        }
    }
}
