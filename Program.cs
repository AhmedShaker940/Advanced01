using Assignment01Advanced.Question02;
using Assignment01Advanced.Question03;

namespace Assignment01Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Q1: What is a generic class? Why use generics?
            /*
             
            - Generic class is a type of classes that is marked with <> and allow us to use different type parameters which is specified in main 
            - Generics has many benifits such as : 
                      - Type Safety which allow us to find Errors at compile time (before the program runs)
                      - Code Usability which allow us to write the code once then use it in many forms after we specify the type of the parameter
                      - it allow us to Avoid boxing and unboxing (better performance not like Object)
             
             */
            #endregion

            #region Question02

            //Q2: Write a generic class Container<T> with Add and Get methods.

            //container<int> C1 = new container<int>();
            //C1.Add(5);
            //int Value = C1.Get();
            //Console.WriteLine(Value);

            #endregion

            #region Question03

            //Q3:What are multiple type parameters? Write Pair<TKey,TValue >.

            /*
            A class can have more than one parameter type <T1,T2,T3, ... > 
             */

            //Pair<int, string> P1 = new Pair<int, string>(1, "Ahmed");
            //Console.WriteLine($"Key : {P1.Key} - Value : {P1.Value}");

            #endregion



        }
    }
}
