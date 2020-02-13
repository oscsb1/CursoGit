using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CalculaT
    {

        private int _ai;
        public int A;
        public int MyProperty { get; set; }
        public int B;
        public int CC
        {
            get { return _ai; }
            set { _ai = value; }
        }

        public int ParamV(params int[] p1)
        {
            int j = 0;

            foreach (int obj in p1)
            {
                j += obj;
            }
            for (int i = 0; i < p1.Length; i++)

            {
                j += p1[i];
            }

            return j;

        }

        public CalculaT(int ai, int a, int b)
        {
            this._ai = ai;
            A = a;
            B = b;
        }

        public CalculaT()
        {
        }

        public int CalcArea()
        {


            return A * B + _ai;
        }


        public override bool Equals(object obj)
        {
            return obj is CalculaT t &&
                   _ai == t._ai &&
                   A == t.A &&
                   B == t.B;
        }
    }
}

