using System;

namespace IIDimensionalLibrary
{
    public class IIDArray
    {
        int[,] a;
        int x = 2;
        int y = 2;
        int z;
        int max_i = 0;
        int max_j = 0;

        public IIDArray (int n, int el)
        {
            a = new int[ n, n ];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[ i, j ] = el;
        }
        public IIDArray (int n, int min, int max)
        {
            a = new int[ n, n ];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[ i, j ] = rnd.Next(min, max);
        }
        public int Min
        {
            get
            {
                int min = a[ 0, 0 ];
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        if (a[ i, j ] < min)
                            min = a[ i, j ];
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = a[ 0, 0 ];
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        if (a[ i, j ] > max)
                            max = a[ i, j ];
                return max;
            }
        }
        public int Sum
        {
            get
            {
                int s = 0;
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        if (a[ i, j ] > z)
                            s = s + a[ i, j ];
                return s;
            }
        }
        public int Sum2
        {
            get
            {
                z = Convert.ToInt32(Console.ReadLine());
                int s = 0;
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        if (a[ i, j ] > z)
                            s = s + a[ i, j ];
                return s;
            }
        }
        //public int c(ref int[,] a)/*, int maxNum, int max_i, int max_j)*/
        //{
        //    int maxNum = a[0,0];
        //        for (int i = 0; i < x; i++)
        //            for (int j = 0; j < y; j++)
        //                if (a[i,j] > maxNum)
        //                {
        //                    maxNum = a[i, j];
        //                    max_i = i;
        //                    max_j = j;
        //                }
        //        Console.WriteLine($"Максимальный элемент имеет координаты {max_i + 1} {max_j + 1}");

        //}

        public new string ToString ()
        {
            string s = "";
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                    s += a[ i, j ] + " ";
                s += "\n";
            }
            return s;
        }
    }
}