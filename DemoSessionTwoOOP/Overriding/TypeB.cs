namespace DemoSessionTwoOOP.Overriding
{
    internal class TypeB : TypeA
    {
        public int B{ get; set; }
        public TypeB(int a , int b) : base(a)
        {
            B=b;
        }

        public override string ToString()
        {
            return base.ToString() + $"B = {B}";
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB, A ==> {A} , B ==>{B}");
        }

        //Masking or hidding 
        public new void MyFun01() {

            Console.WriteLine($"Hello from child - TypeB");
        }

    }
}
