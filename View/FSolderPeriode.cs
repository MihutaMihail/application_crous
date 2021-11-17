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
            this.Text = "Solder une période";
            this.load(new DaoColocataire().GetAll(), new DaoDepense().GetAll());
        }
        private void load(Colocataires lesColocataires, Depenses lesDepenses)
        {
            for(int i = 0; i< lesDepenses.Count(); i++) {
                lesDepenses[i].Reparti = true;
                lesDepenses[i].State = State.solderModified;
            }
            new DaoDepense().SaveChanges(lesDepenses);

            tbAPayeColoc1.Text = "0 €";
            tbAuraitPayerColoc1.Text = "0 €";
            tbSolderReglerColoc1.Text = "0 €";

            tbAPayeColoc2.Text = "0 €";
            tbAuraitPayerColoc2.Text = "0 €";
            tbSolderReglerColoc2.Text = "0 €";

            tbAPayeColoc3.Text = "0 €";
            tbAuraitPayerColoc3.Text = "0 €";
            tbSolderReglerColoc3.Text = "0 €";

        }
    }
}
