using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackLight.Recruitment.UnitTests
{
    class Algorithms
    {
        public static string ReverseWordsInString(string input)
        {
            string output = "";
            var tmpArray = input.Split().Reverse();

            foreach (var word in tmpArray)
            {
                output += word + " ";
            }

            return output.Trim();
        }

        public static string ReverseWordsInStringWithoutUsingAnyLinqMethods(string input)
        {
            string output = "";
            var stringArray = input.Split();
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                output += stringArray[i] + " ";
            }
            return output.Trim();
        }

        internal static int[] SortWithoutUsingBuiltInSortMethods(int[] input)
        {
            Quicksort(input, 0, input.Length - 1);
            return input;
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {

                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
