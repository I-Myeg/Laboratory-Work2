using System;

namespace Laboratory_Work_2
{
    class Program
    {
        
        static void Main()
        {
            int[] inputData = new int[] { -2, 45, 5, -12, 10 };
            OutputData(inputData);

            SquaresAndSort(inputData, 0, inputData.Length - 1);

            OutputData(inputData);
        }
        
        static void OutputData(int[] temp)
        {
            Console.WriteLine(string.Join(",", temp));
        }

        static void Squares(int[] inputData)
        {
            for (int k = 0; k < inputData.Length; k++)
            {
                inputData[k] = inputData[k] * inputData[k];
            }
        }

        static void Sort(int[] temp, int first, int last)
        {
            if (first < last)
            {
                int left = first;
                int right = last;
                int middle = temp[(left + right) / 2];
                do
                {
                    while (temp[left] < middle) left++;
                    while (temp[right] > middle) right--;
                    if (left <= right)
                    {
                        (temp[left], temp[right]) = (temp[right], temp[left]);
                        left++;
                        right--;
                    }
                } while (left < right);

                Sort(temp, first, right);
                Sort(temp, left, last);
            }

            return;
        }

        static void SquaresAndSort(int[] temp, int first, int last)
        {
            Squares(temp);
            Sort(temp, first, last);
        }
    }
}
