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
    public partial class FSolderPeriode : Form
    {
        public FSolderPeriode()
        {
            InitializeComponent();
            this.load(new DaoColocataire().GetAll(), new DaoDepense().GetAll());
        }
        private void load(Colocataires lesColocataires, Depenses lesDepenses)
        {
            for(int i = 0; i< lesDepenses.Count(); i++) {
                lesDepenses[i].Reparti = true;
                lesDepenses[i].State = State.solderModified;
            }
            new DaoDepense().SaveChanges(lesDepenses);

            int index1 = lesColocataires.GetIndex("Vincent");
            tbAPayeVincent.Text = lesDepenses.APayer(index1).ToString() + " €";
            tbAuraitPayerVincent.Text = lesDepenses.AuraitDuPayer().ToString() + " €";
            tbSolderReglerVincent.Text = (lesDepenses.AuraitDuPayer() - lesDepenses.APayer(index1)) + " €";

            int index2 = lesColocataires.GetIndex("Lassina");
            tbAPayeLassina.Text = lesDepenses.APayer(index2).ToString() + " €";
            tbAuraitPayerLassina.Text = lesDepenses.AuraitDuPayer().ToString() + " €";
            tbSolderReglerLassina.Text = (lesDepenses.AuraitDuPayer() - lesDepenses.APayer(index2)) + " €";

            int index3 = lesColocataires.GetIndex("Mihail");
            tbAPayeMihail.Text = lesDepenses.APayer(index3).ToString() + " €";
            tbAuraitPayerMihail.Text = lesDepenses.AuraitDuPayer().ToString() + " €";
            tbSolderReglerMihail.Text = (lesDepenses.AuraitDuPayer() - lesDepenses.APayer(index3)) + " €";

        }
    }
}
