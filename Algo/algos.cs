using System;
using System.Collections.Generic;

namespace Puzzles.Algo
{
    public class algos
    {
        // Create a function called RandomArray() that returns an integer array
        public static int[] RandomArray() {
            // Place 10 random integer values between 5-25 into the array
            int[] result = new int[10];
            for (int i = 0; i < result.Length; i++) {
                Random rand = new Random();
                result[i] = rand.Next(5, 25);
            }
            // Print the min and max values of the array
            int min = result[0];
            int max = result[0];
            for (int i = 0; i < result.Length; i++) {
                if (result[i] < min) {
                    min = result[i];
                }
                if (result[i] > max) {
                    max = result[i];
                }
            }
            Console.WriteLine($"Minimum: {min}. Maximum: {max}.");
            // Print the sum of all the values
            int sum = 0;
            for (int i = 0; i < result.Length; i++) {
                sum += result[i];
            }
            Console.WriteLine($"Sum: {sum}.");
            return result;
        }

        // Create a function called TossCoin() that returns a string
        public static string TossCoin() {
            // Have the function print "Tossing a Coin!"
            Console.WriteLine("Tossing a Coin!");
            // Randomize a coin toss with a result signaling either side of the coin 
            Random rand = new Random();
            int toss = rand.Next(1, 10);
            // Have the function print either "Heads" or "Tails"
            string result = "";
            if (toss <= 5) {
                result = "Tails!";
                Console.WriteLine(result);
            }
            if (toss > 5) {
                result = "Heads!";
                Console.WriteLine(result);
            }
            // Finally, return the result
            return result;
        }

        // Create another function called TossMultipleCoins(int num) that returns a Double
        public static double TossMultipleCoins(int num) {
            // Have the function call the tossCoin function multiple times based on num value
            int heads = 0;
            for (int i = 0; i < num; i++) {
                string result = TossCoin();
                if (result != "Tails!") {
                    heads++;
                    Console.WriteLine("# of Heads: " + heads);
                }
            }
            // Have the function return a Double that reflects the ratio of head toss to total toss
            double final = (double)heads / (double)num;
            Console.WriteLine("Heads to Tosses Ratio: " + final);
            return final;
        }

        // Build a function Names that returns a list of strings.  In this function:
        public static List<string> Names() {
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> myList = new List<string>() {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            // Shuffle the list and print the values in the new order
            for (int i = 0; i < myList.Count; i++) {
                if (myList[i].Length <= 5) {
                    myList.Remove(myList[i]);
                }
                Random rand = new Random();
                int num = rand.Next(0, myList.Count);
                string temp = myList[i];
                myList[i] = myList[num];
                myList[num] = temp;
            }
            foreach (var item in myList) {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            // Return a list that only includes names longer than 5 characters
            return myList;
        }
    }
}