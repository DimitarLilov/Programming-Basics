using System;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        string[] elements = Console.ReadLine().Split();

        int numberEqualElements = 1;
        int[] arrayRepeatElements = new int[elements.Length];
        int[] startPositionRepeatElement = new int[elements.Length];
        string refrenceElement = elements[0];
        int l = 0;
        startPositionRepeatElement[l] = 0;
        for (int i = 1, k = 0; i < elements.Length; i++)
        {
            if (refrenceElement == elements[i])
            {
                l++;
                numberEqualElements++;
                startPositionRepeatElement[l] = k;
            }
            else
            {
                if (l > k)
                {
                    k = l;
                }
                l++;
                k++;
                arrayRepeatElements[i] = numberEqualElements;
                refrenceElement = elements[i];
                numberEqualElements = 1;
                startPositionRepeatElement[l] = k;
            }
        }
        for (int i = 0; i < elements.Length; i++)
        {
            if (numberEqualElements > arrayRepeatElements[i] ||
                numberEqualElements == elements.Length)
            {
                if (i == elements.Length - 1)
                {
                    Console.WriteLine(numberEqualElements);
                    for (int j = startPositionRepeatElement[i]; j < elements.Length; j++)
                    {
                        Console.WriteLine("{0}", elements[j]);
                    }
                    break;
                }
            }
            else if (numberEqualElements == arrayRepeatElements[i] && numberEqualElements == 1)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if (refrenceElement.Length > elements[j].Length)
                    {
                        continue;
                    }
                    else
                    {
                        refrenceElement = elements[j];
                    }
                }
                Console.WriteLine(numberEqualElements);
                Console.WriteLine(refrenceElement);
                break;
            }
            else if (numberEqualElements == arrayRepeatElements[i] && numberEqualElements > 1)
            {
                Console.WriteLine(arrayRepeatElements[i]);
                refrenceElement = elements[0];
                int m = 1;
                for (; m < elements.Length; m++)
                {
                    if (refrenceElement == elements[m])
                    {
                        break;
                    }
                    else
                    {
                        refrenceElement = elements[m];
                    }
                }
                for (int j = startPositionRepeatElement[m]; j < i; j++)
                {
                    Console.WriteLine("{0}", elements[j]);
                }
                break;
            }
        }
    }
}

