using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAMM
{
    class AmmTransitive
    {
        AMMimp Aimp = new AMMimp();
        public bool[,] rA, rB, rC,rD;
        int i, j, N;

        public void InitTR(string _N, DataGridView dgA, DataGridView dgB, DataGridView dgC, DataGridView dgD)
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
                rA = new bool[N, N];
                rB = new bool[N, N];
                rC = new bool[N, N];
                rD = new bool[N, N];

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
                        if (j > i)
                        {
                            rA[i, j] = Convert.ToBoolean(Aval.Next(3));
                            rB[i, j] = rA[i, j];
                            rD[i, j] = rA[i, j];
                    }
                        else
                        {
                    rA[i, j] = false;
                    rB[i, j] = false;
                    rC[i, j] = false;
                }
                dgA[j, i].Value = rA[i, j];
                    }
            }
            else
                MessageBox.Show("Error");
        }

        public bool Null(bool[,] arr)
        {
            bool tmp = true;
            for (i = 0; i < Math.Sqrt(arr.Length); i++)
                for (j = 0; j < Math.Sqrt(arr.Length); j++)
                    tmp = tmp && (arr[i, j] == false);
            return tmp;
        }
        public void AddI()
        {
            Aimp.FAdd(N, AddE);
        }

        public void AddE()
        {
            rD[Aimp.i, Aimp.j] = rC[Aimp.i, Aimp.j] || rD[Aimp.i, Aimp.j];
        }

        public void MultM()
        {
            Aimp.MMult(N, ZeroE, MultE);
        }

        public virtual void MultE()
        {
            rC[Aimp.i, Aimp.k] = rC[Aimp.i, Aimp.k] || rA[Aimp.i, Aimp.j] && rB[Aimp.j, Aimp.k];
        }

        public void ZeroE()
        {
            rC[Aimp.i, Aimp.k] = false;
        }

        public void AlgB( bool[,] arr)
        {
            int ch=0;
            while (!Null(arr))
            {
                MultM();
                AddI();
                ch++;
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < N; j++)
                        rA[i, j] = rC[i, j];
            }
            MessageBox.Show(ch.ToString());
        }

        public void Show(DataGridView dgC)
        {
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                    dgC[j, i].Value = rD[i, j];
        }

    }
}
