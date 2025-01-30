using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Bubble Sort enhancement

            //int[] Arr = { 56, 32, 1, 777, 1313 };
            //Helper.BubbleSort(Arr);
            //foreach (int i in Arr)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q2 create a generic Range<T> class

            //Range<int> range = new Range<int>(40, 10);
            //Console.WriteLine(range.IsInRange(1));
            //Console.WriteLine(range.Length());

            #endregion


        }
    }
    #region Q1 Bubble Sort enhancement
    /// <summary>
    /// 1-  I added a flag that indicates that if the last itteriation in the second loop no Numbers swapped that indicates 
    ///     Numbers sorted successfully.
    /// 2-  I added a two variables that indicates the last swapped element that we can end with it next itteriation
    ///     that makes we can skip 2 itteration the case of the last 2 elements are sorted.
    /// </summary>
    internal static class Helper
    {
        internal static void BubbleSort(int[] Arr)
        {
            int lastIndex = Arr.Length - 1;
            bool flag = false;
            for (int i = 0; i < Arr.Length; i++)
            {
                flag = false;

                int CurrentIndex = 0;
                for (int j = 0; j < lastIndex; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        Helper.Swap(ref Arr[j], ref Arr[j + 1]);
                        flag = true;
                        CurrentIndex = j;
                    }
                }
                if (flag != true)
                {
                    break;
                }

                lastIndex = CurrentIndex;
            }
        }

        internal static void Swap(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
    }

    #endregion

    #region Q2 create a generic Range<T> class
    public class Range<T> where T : IComparable<T>, ISubtractionOperators<T, T, T>
    {
        public T Maximum { get; set; }
        public T Minimum { get; set; }

        public Range(T Max, T Min)
        {
            Maximum = Max;
            Minimum = Min;
        }

        public bool IsInRange(T obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.Maximum.CompareTo(obj) >= 0 && this.Minimum.CompareTo(obj) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Length()
        {
            T Diff = this.Maximum - this.Minimum; // not avaliable substraction without implementing "ISubtractionOperators"
            return Diff;
        }

    }
    #endregion

}
