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
    public partial class FSolderUnePeriode : Form
    {
        public FSolderUnePeriode()
        {
            InitializeComponent();
            this.load(new DaoColocataire().GetAll(), new DaoDepense().GetAll());
            this.dataGridView1.Columns["Nom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["APaye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["AuraitDuPayer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["SoldesARegler"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
        private void load(Colocataires lesColocataires, Depenses lesDepenses)
        {
            for (int i = 0; i < lesDepenses.Count(); i++)
            {
                lesDepenses[i].Reparti = true;
                lesDepenses[i].State = State.solderModified;
            }
            new DaoDepense().SaveChanges(lesDepenses);

            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[i].Cells[0].Value = lesColocataires[i].Nom;
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = "0";
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = "0";
            }
            for (int i = 0; i < lesColocataires.Count(); i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = "0";
            }
        }
    }
}
