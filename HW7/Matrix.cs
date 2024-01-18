using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV321_CSharp
{


    internal class Matrix
    {

        int[,] array;
        public int Rows { get; } = 5;
        public int Cols { get; }

        public Matrix(int row, int col)
        {
            Rows = row;
            Cols = col;
            array = new int[row, col];
        }

        public void SetRandom()
        {
            Random r = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    array[i,j] = r.Next(0, 255);
                }
            }
        }

        public int this[int r, int c]
        {
            get { return array[r,c];  }
            set { array[r,c] = value; }
        }

        public int Method()
        {

        }

    }
}
