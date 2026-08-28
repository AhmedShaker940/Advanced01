using Assignment01Advanced.Question02;
using Assignment01Advanced.Question03;
using Assignment01Advanced.Question04;
using Assignment01Advanced.Question05;
using Assignment01Advanced.Question06;
using Assignment01Advanced.Question07;
using System.ComponentModel.Design;

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

            #region Questoin04

            //Q4: What is a generic method? Write Swap<T> method.

            /*
              A method also can be a Generic where each call can use a different type
             */

            //int a = 1;
            //int b = 2;
            //Helper.Swap<int>(ref a , ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            #region Question05

            //Q5: Write a generic method FindMax<T> that finds maximum value

            //Console.WriteLine(Max.FindMax(10, 100)); 

            #endregion

            #region Queation06

            //Q6: What is a generic interface? Write IRepository<T>.

            /*
             Generic Interface is a type of interfaces that can be implmented with different types of classes or structs (user defined)
             */

            //IRepository<Product> repo = new ProductRepository();
            //repo.Add(new Product(1, "Phone", 5000m));



            #endregion

            #region Question07

            //Q7: What is the 'struct' constraint? Write an example.

            /*
            struct constraint is a type of generic constraint that allow only value types (int double struct ....)
             */

            //Invetory<int> I1 = new Invetory<int>(1);
            //Invetory<string> I1 = new Invetory<string>("Hello"); => Error (Reference Type Not Allowed)


            #endregion
        }

    }
}
