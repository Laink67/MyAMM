using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAMM
{
    class AmmINT
    {
        AMMimp Aimp = new AMMimp();
        public int[,] rA, rB, rC;
        public static int i, j, N;

        public void Init(string _N, DataGridView dgA, DataGridView dgB, DataGridView dgC, DataGridView dgD)
        {
            if (Int32.TryParse(_N, out N))
            {
                dgA.RowCount = N;
                dgB.RowCount = N;
                dgC.RowCount = N;
                dgD.RowCount = N;
                dgA.ColumnCount = N;
                dgB.ColumnCount = N;
                dgC.ColumnCount = N;
                dgD.ColumnCount = N;
                rA = new int[N, N];
                rB = new int[N, N];
                rC = new int[N, N];


                for (i = 0; i < N; i++)
                {
                    dgA.Columns[i].Width = dgA.Width / (N + 1);
                    dgB.Columns[i].Width = dgB.Width / (N + 1);
                    dgC.Columns[i].Width = dgC.Width / (N + 1);
                    dgD.Columns[i].Width = dgD.Width / (N + 1);
                }
                Random Aval = new Random();

                for (i = 0; i < N; i++)
                    for (j = 0; j < N; j++)
                    {
                        rA[i, j] = Aval.Next(3);
                        rB[i, j] = Aval.Next(3);
                        dgA[j, i].Value = rA[i,j];
                        dgB[j, i].Value = rB[i,j];
                    }
            }
            else
                MessageBox.Show("Error");
        }

        public void AddI()
        {
            Aimp.FAdd(N, AddE);
        }

        public void AddE()
        {
            rC[Aimp.i, Aimp.j] = rA[Aimp.i, Aimp.j] + rB[Aimp.i, Aimp.j];
        }
        public void MultM()
        {
            Aimp.MMult(N, ZeroE, MultE);
        }
        public void MultE()
        {
            rC[Aimp.i, Aimp.k] = rC[Aimp.i, Aimp.k] + rA[Aimp.i, Aimp.k] * rB[Aimp.i, Aimp.k];
        }
        public void ZeroE()
        {
            rC[Aimp.i ,Aimp.k] = 0;
        }
        public void Show(DataGridView dgC)
        {
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                    dgC[j,i].Value = rC[i, j];
        }
    }

}

