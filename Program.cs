using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace MethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Assignment 1
            Console.Write("Enter how many values you want to be in your array: ");
            int input = int.Parse(Console.ReadLine());

            int[] arr = new int[input];

            Console.WriteLine($"You will now choose {input} values.\n");
            for (int i = 0; i < input; i++)
            {
                Console.Write("Enter a value: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Call the methods
            Console.WriteLine("\nBiggest value: " + BiggestNum(arr));
            Console.WriteLine("Smallest value: " + SmallestNum(arr));
            Console.WriteLine("Mean value: " + MeanValue(arr));
            SortArrayLowToHigh(arr);
            SortArrayHighToLow(arr);

            // Returns biggest number in an array
            static int BiggestNum(int[] arr)
            {
                // Initialize var as first value in array that will keep track of the highest found value
                int highestValue = arr[0];

                // Loops through the array, if the current value we're checking is higher than highestValue
                // change highestValue to that number
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > highestValue)
                    {
                        highestValue = arr[i];
                    }
                }

                return highestValue;
            }

            // Returns smallest number in an array
            static int SmallestNum(int[] arr)
            {
                // Initialize the variable as first value in array to keep track of the smallest found value
                int smallestValue = arr[0];

                // Loops through array, if the current value is smaller than smallestValue change smallestValue to that 
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < smallestValue)
                    {
                        smallestValue = arr[i];
                    }
                }

                return smallestValue;
            }

            // Calculates the mean value of an array
            static int MeanValue(int[] arr)
            {
                // Initialize variable that will keep the total value
                int totalValue = 0;

                // loop through array, add the value at each positon to totalValue
                for (int i = 0; i < arr.Length; i++)
                {
                    totalValue += arr[i];
                }

                // return totalValue divided by the number of values in the array. Which will be the mean value.
                return totalValue / arr.Length;
            }


            // Assignment 2
             
            // Sorts an array in order from lowest to highest 
            static void SortArrayLowToHigh(int[] arr)
            {
                int temp;
                bool sorted = false;

                while (!sorted)
                {
                    // Assume array is sorted in the beginning of each loop
                    // If no changes are made, array must be sorted
                    sorted = true;

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        // Checks if the current number in the array is bigger than the next number
                        // if it is, save number on temp variable and change so current number becomes next number
                        // then set the next number to temp which is the bigger number
                        // sorted will also switch to false since array wasn't sorted
                        // Essentially switch place on the numbers 
                        if (arr[i] > arr[i + 1])
                        {   
                            temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            sorted = false;
                        }
                        
                    }
                    
                }

                // Print out array after it has been sorted
                Console.Write("Array sorted: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + ", ");
                }
            }

            // Sorts an array in order from lowest to highest 
            static void SortArrayHighToLow(int[] arr)
            {
                int temp;
                bool sorted = false;

                while (!sorted)
                {
                    // Assume array is sorted in the beginning of each loop
                    // If no changes are made, array must be sorted
                    sorted = true;

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        // Checks if the current number in the array is smaller than the next number
                        // if it is, save number on temp variable and change so current number becomes next number
                        // then set the next number to temp which is the smaller number
                        // sorted will also switch to false since array wasn't sorted
                        // Essentially switch place on the numbers 
                        if (arr[i] < arr[i + 1])
                        {
                            temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            sorted = false;
                        }

                    }

                }

                // Print out array after it has been sorted
                Console.Write("Array sorted: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + ", ");
                }
            }

        }
    }
}