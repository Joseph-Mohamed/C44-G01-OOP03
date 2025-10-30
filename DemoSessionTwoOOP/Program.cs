using DemoSessionTwoOOP.overloading;
using DemoSessionTwoOOP.Overriding;

namespace DemoSessionTwoOOP
{
    internal class Program
    {
        #region method overloading
        //public static int SumTwoNumbers(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int SumThreeNumbers(int x, int y , int z) { 
        //return x + y + z;
        //}
        //// method overloading
        //public static double SumTwoNumbers(double a, double b)
        //{
        //    return a+b;
        //}

        //public static double SumThreeNumbers(double x, double y, double z)
        //{
        //    return x + y + z;
        //}


        //public static int SumNumbers(int x , int y)
        //{
        //    return x + y;
        //}
        //public static double SumNumbers(int x, double y)
        //{
        //    return x + y;
        //}
        //public static double SumNumbers(double x, double y)
        //{
        //    return x + y;
        //}
        //public static int SumNumbers(int x, int y ,int z)
        //{
        //    return x + y + z ;
        //}

        //public static double SumNumbers(double x, double y , double z)
        //{
        //    return x + y + z;
        //}

        #endregion
        static void Main(string[] args)
        {

            #region Poly. -method overloading [sumNumbers]
            // overloading types
            //1} ctor overloaing
            //2} indexer
            //3} method oveloading
            // 4} operator overloading
            //5} casting operator overloading

            //int x = 10, y = 20, z = 30;
            //double a = 1.5, b = 2.5, c = 3.4;
            //Console.WriteLine(SumNumbers(10,20));
            //Console.WriteLine(SumNumbers(10, 20,30));
            //Console.WriteLine(SumNumbers(10.5, 20.5, 30.5));
            //Console.WriteLine(SumNumbers(10.5, 20.5));
            //// pasing by name
            //Console.WriteLine(SumNumbers(y:10.5,x: 20.5));


            //Console.WriteLine(SumTwoNumbers(x,y));
            //Console.WriteLine(SumThreeNumbers(x, y,z));
            ////console.writeline(sumtwonumbers(a, b)); //invalid
            //Console.WriteLine(SumTwoNumbers(a,b));
            //Console.WriteLine(SumThreeNumbers(a,b,c));
            #endregion

            #region poly. - operator overloading [binary operator] 
            //int x = 5, y = 6;
            //Console.WriteLine(x+y);

            //4+5i
            //user define data type
            // class complex ==> real , img
            //Complex c1; // refrance refer to null
            //c1 = new Complex();
            //Console.WriteLine(c1);
            //c1.real = 4;
            //c1.imaginary = 5;


            //Complex c1 = new Complex() { real = 4 , imaginary = 5};
            //Complex c2 = new Complex { real = 6, imaginary = 7 }; /*default;*/
            //Complex? c3 = default;
            //c3 = c1 + c2; // operator overloading +
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine();
            //Console.WriteLine(c3);

            //c3 = c1 - c2;
            //Console.WriteLine(c3);

            //c3 += c1;
            //c3 -= c1;
            #endregion

            #region poly. operator overloading [unary operators]
            // prefix , postfix
            // ++x, x++

            //Complex c1 = new Complex() { real = 4, imaginary = 5 };

            ////Complex? c1 = default;
            //Console.WriteLine(c1);
            //++c1;
            //Console.WriteLine(c1);
            //--c1;//prefix
            //Console.WriteLine(c1);

            #endregion


            #region poly. operator overloading [relational operators]
            // > < <= >=

            //Complex c1 = new Complex() { real = 10 , imaginary = 20};
            //Complex c2 = new Complex() { real = 15, imaginary = 25 };

            //if(c1>c2)
            //    Console.WriteLine("c1>c2");
            //else if(c2>c1)
            //    Console.WriteLine("c2>c1");
            //else
            //    Console.WriteLine("C1=c2");


            #endregion

            #region poly. casting operator overloading 
            //int x = 10;
            //float y = (float)x;//implecite

            //float z = 1.5f;
            //int num =(int)z; // explicite , unsave casting


            //Complex c1 = new Complex() { real = 1 , imaginary = 2 };
            ////int x = (int)c1;
            ////Console.WriteLine(x);

            //string str = c1; // cast from c1 to string implicite
            //Console.WriteLine(str);

            //***Note:
            // if i cating implecite i can use both
            // the best use is explicite
            #endregion



            #region poly - user define casting operators overloading
            //User user = new User() { Id = 10,
            //    Email = "youssef@gmail.com",
            //    FullName = "youssef Mohamed",
            //    SecurityStamp = Guid.NewGuid(),
            //    Password = "p@ssword" };

            //UserViewModel viewModel = (UserViewModel)user;
            //Console.WriteLine(viewModel);
            #endregion



            #region poly - overriding [TypeA - TypeB]

            TypeA typeA;
            // refrence
            typeA = new TypeA(1);
            typeA.A = 10;

            Console.WriteLine(typeA);
            typeA.MyFun01();
            typeA.MyFun02();


            TypeB typeB;
            typeB = new TypeB(10 ,20);
            typeB.A = 1;
            typeB.B = 2;
            Console.WriteLine(typeB);
            typeB.MyFun01();
            typeB.MyFun02();
            #endregion

        }
    }
}
