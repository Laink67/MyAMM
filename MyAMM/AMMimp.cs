using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAMM
{
    class AMMimp
    {
        public int i, j, k;
        public delegate void DelZero();
        public delegate void DelAdd();
        public delegate void DelMult();

        public void FAdd(int N,DelAdd _Ad)
        {
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                    _Ad();
        }

        public void MMult(int _N, DelZero _EZero, DelMult _EMult)
        {
            for (i = 0; i < _N; i++)
                for (k = 0; k < _N;k++)
                {
                    _EZero();
                    for (j = 0; j < _N; j++)
                        _EMult();
                }
        }
    }
}
