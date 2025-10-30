
namespace DemoSessionTwoOOP.Overriding
{

    internal class TypeA
    {
public int A { get; set; }
         public TypeA( int a)
        {
            A = a;
        }

        // virtual and non private
        public  void MyFun01()
        {
            Console.WriteLine($"I am base - [TypeA]");
        }

        public virtual void MyFun02() {

            Console.WriteLine($"I am in the type A ==> {A}");
        }


        public override string ToString()
        {
            return $"A = {A}";
        }
    }
}
