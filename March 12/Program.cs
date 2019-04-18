using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ficaScores = { 300, 400, 450, 847, 662 };
            //returning the avg fica score from averagescore method 
            double avgFica = AverageScores(ficaScores);
            //display it to the user 
            Console.WriteLine($"The avg FICA score is {avgFica:f2}");

            Console.WriteLine($"The max FICA score is {LargestFICA(ficaScores)}"); // the name of method = LargestFICA , the value (parameter) we pulling 

            Console.WriteLine($"The min FICA score is {SmallestFICA(ficaScores)}");

            Console.ReadKey();
        }

        static private double AverageScores (int [] thisFicaArray)

        {
            
            //SUM AND AVG ARE DOUBLES DO WE DON'T DO INTEGER MATH 
            //MUST SET SUM TO ZERO DUE TO RUNNING SUM 
            //Running sum doe the calculation // sum up everything in the arry - eventually 
             double sum = 0 , avg; 
            //START AT INDEX 0 IN THE ARRAY
            //setting equal to zero is really important when you are doing a running sum of somethin
            // index will add the values from 0 to ++
            int index = 0;
            //LOOP AS LONG AS THERE ARE STILL VALUES IN THE ARRY 
            while (index < thisFicaArray.Length)
            {
                //SUM UP EVERYTHING IN THE ARRY - EVENTUALLY 
                sum = sum + thisFicaArray[index];// parameter is indexing into array 
                //GO TO THE NEXT VALUE IN THE ARRARY 
                index = index + 1; //right now the index is 0 in the array . Index++ will also works 
            }
            //CALC AVG BY DIVIDING SUM BY THE NUMBER OF ITEMS IN THE ARRAY 
            avg = sum / (double) thisFicaArray.Length; //sum / the number we have to get the avg . length casted as a double
                                                       //casting can take numeric type and convert it into another numeric type . cannot do it with string 
            //RETURN THE AVG
            return avg; 
            
        }
         static private int LargestFICA (int [] myFICAArray)
        {     //SET A MAX VARIABLE EQUAL TO THE SMALLEST POSSIBLE VALUE 
            //short cut function = return myFICAArray.Max(); - will do the same thing as int with if statement 
            int maxFicaScore = 0;
             //LOOP THROUGH THE ARRAY 
             for (int i=0; i< myFICAArray.Length ; i++ )   //as long as i is less than each items in the arry, keep incrementing 
                //index,true condidtion, what gets done at the bottom of every loop 
                //.length is how you will know when to stop the loop
            {
                if (maxFicaScore < myFICAArray [i])
                {
                    maxFicaScore = myFICAArray[i];
                }
                    

            }

            return maxFicaScore; // return the higest value in the fica score , will return 875 

        }
         static private int SmallestFICA ( int [] myFICAArray )
        { //SET A MAX VARIABLE EQUAL TO THE SMALLEST POSSIBLE VALUE 
            int minFicaScore = 1000; 
            //LOOP THROUGH THE ARRAY 
            for (int i=0; i< myFICAArray.Length; i++)
            {
                if (minFicaScore > myFICAArray[i])
                {
                    minFicaScore = myFICAArray[i];
                }

            }
            return minFicaScore; 
        }




    }
}
