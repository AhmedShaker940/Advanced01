using Assignment01Advanced.Queation10;
using Assignment01Advanced.Question02;
using Assignment01Advanced.Question03;
using Assignment01Advanced.Question04;
using Assignment01Advanced.Question05;
using Assignment01Advanced.Question06;
using Assignment01Advanced.Question07;
using Assignment01Advanced.Question08;
using Assignment01Advanced.Question09;
using Assignment01Advanced.Question14;
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

            #region Question08

            //Q8: What is the 'class' constraint? Write an example.

            /*
              class constraint is a type of generic constraint that allow only Reference types (string class ....)
             */

            //Inventory2<string> I = new Inventory2<string>("Hello");
            //Invetory2<int> I1 = new Invetory2<int>(1); //=> Error (Value Type Not Allowed)


            #endregion

            #region Question09

            //Q9: What is the 'new()' constraint? Write an example.

            /*
             the new() constraint is a type of Generic constraint that Consider that T must have a empty parameterless Ctor
             */

            //Factory<Item> F1 = new Factory<Item>();
            //Item I = F1.Create();
            //Console.WriteLine(I.Id);

            #endregion

            #region Question10

            //Q10: What is the interface constraint? Write an example.

            /*
             Inerface constraint is type of Generic constraints that requires that T Impelement a specifed Interface
             */

            //Printer<Report> P1 = new Printer<Report>();
            //P1.PrintItem(new Report()); // Allowed

            //Printer<Document> P2 = new Printer<Document>();
            //P2.PrintItem(new Document()); // Allowed


            #endregion

            #region Question11

            //Q11: What is the base class constraint? Write an example.

            /*
             base class constraint is a type of Generic constraints that requires that a T must inherit from a base class 

               - public class student<T> Where T : Person{}
             */

            #endregion

            #region Question12

            //Q12: How do you apply multiple constraints? Write an example

            /* 
             we use multible constraints by using "," between the constraints

            Example : where T : Base Class, Interface , new()
             */

            #endregion

            #region Question13

            //Q13: What does the 'default' keyword do in generics?

            /*
             'default' Keyword is used to return the Default Value of T Specially that we don't know the type of T 
            for example default (int) => 0 , default (string) => Null , default (bool) => false
             */

            #endregion

            #region Question14

            //Q14: Write a SafeList<T> that returns default when the index is invalid.

            //SafeList<int> list = new SafeList<int>();
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //Console.WriteLine(list.Get(1));
            //Console.WriteLine(list.Get(10));
            #endregion

        }

    }
}
