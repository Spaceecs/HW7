﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV321_CSharp
{
    public interface ICalc
    {
        public int Less(int valueToCompare);
        public int Greater(int valueToCompare);
        public int CountDistinct();
        public int EqualToValue(int valueToCompare);
    }
    public interface IOutput
    {
        public void ShowEven();
        public void ShowOdd();
    }
    internal class Matrix:ICalc, IOutput
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
                    array[i,j] = r.Next(0, 10);
                }
            }
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            for (int i=0;i<Rows;++i)
            {
                for (int j= 0; j < Cols; ++j)
                {
                    if (array[i, j] <= valueToCompare)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Cols; ++j)
                {
                    if (array[i, j] >= valueToCompare)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public void ShowEven()
        {
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Cols; ++j)
                {
                    if (array[i, j] %2== 0)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                }
            }
            Console.WriteLine();
        }
        public void ShowOdd()
        {
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Cols; ++j)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                }
            }
            Console.WriteLine();
        }
        public int CountDistinct()
        {
            int distinctCount = 0;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (IsDistinct(array, i, j))
                    {
                        distinctCount++;
                    }
                }
            }

            return distinctCount;
        }

        private bool IsDistinct(int[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == matrix[row, col])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Cols; ++j)
                {
                    if (array[i, j] == valueToCompare)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
