using System ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAMM
{
    public partial class AmmForm : Form
    {
        AmmINT AmmIn = new AmmINT();
        AmmBool AmmBool = new AmmBool();
        AmmTransitive AmmTr = new AmmTransitive();
        
        public AmmForm()
        {
            InitializeComponent();
            tbN.Text = "4";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            AmmIn.Init(tbN.Text, dgA, dgB, dgC,dgD);
        }

        private void btnClearInt_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < dgA.RowCount; i++)
                for (j = 0; j < dgA.ColumnCount; j++)
                {
                    dgA[j,i].Value = null;
                    dgB[j,i].Value = null;
                    dgC[j,i].Value = null;
                    dgD[j, i].Value = null;
                }
        }

        private void btnInitBool_Click(object sender, EventArgs e)
        {
            AmmBool.Init(tbN.Text,dgA,dgB,dgC,dgD);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AmmIn.AddI();
            AmmIn.Show(dgC);
        }

        private void btnAddBool_Click(object sender, EventArgs e)
        {
            AmmBool.AddI();
            AmmBool.Show(dgC);
        }

        private void btnMultInt_Click(object sender, EventArgs e)
        {
            AmmIn.MultM();
            AmmIn.Show(dgC);
        }

        private void btnMultBool_Click(object sender, EventArgs e)
        {
            AmmBool.MultM();
            AmmBool.Show(dgC);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btTransitive_Click(object sender, EventArgs e)
        {
                AmmTr.AlgB(AmmTr.rA);
                AmmTr.Show(dgD);
        }

        private void btInitTrans_Click(object sender, EventArgs e)
        {
            AmmTr.InitTR(tbN.Text, dgA, dgB, dgC, dgD);
        }
    }
}
