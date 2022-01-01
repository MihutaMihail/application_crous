using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Model;

namespace View
{
    public partial class FGestionColocataire : Form
    {
        public FGestionColocataire()
        {
            InitializeComponent();
            this.Text = "Gestion Colocataires";
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            this.load(new DaoColocataire().GetAll());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbColocataires.SelectedIndex == -1) return;
            int position = lbColocataires.SelectedIndex;
            ((Colocataire)lbColocataires.Items[position]).Remove();
            lbColocataires.Items[position] = lbColocataires.Items[position];

            saveDatabase();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbColocataires.SelectedIndex == -1) return;
            int position = lbColocataires.SelectedIndex;
            FeditColocataire fEdit = new FeditColocataire(State.modified, lbColocataires.Items, position);
            fEdit.ShowDialog();

            saveDatabase();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            FeditColocataire fEdit = new FeditColocataire(State.added, lbColocataires.Items, 0);
            fEdit.ShowDialog();

            FCreationCompteColoc ccc = new FCreationCompteColoc();
            ccc.ShowDialog();

            saveDatabase();
        }

        private void saveDatabase()
        {
            Colocataires lesColocataires = new Colocataires();
            foreach (object o in lbColocataires.Items)
            {
                lesColocataires.AjouterColocataire((Colocataire)o);
            }
            new DaoColocataire().SaveChanges(lesColocataires);
            this.load(lesColocataires);
        }

        private void load(Colocataires lesColocataires)
        {
            lbColocataires.Items.Clear();
            for (int i = 0; i < lesColocataires.Count(); i++) {
                lbColocataires.Items.Add(lesColocataires[i]);
            }
        }
    }
}
