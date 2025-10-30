namespace DemoSessionTwoOOP.overloading
{
    internal class Complex
    {

        //public int real { get; set; }
        //public int imaginary { get; set; }

        //public override string ToString()
        //{
        //    return $"{real} + {imaginary}i";
        //}


        #region binary oprator overloading
        //public static complex operator +(complex c1, complex c2)
        //{
        //    //complex result = new complex()
        //    //{
        //    //    real = c1.real + c2.real,
        //    //    imaginary = c1.imaginary + c2.imaginary
        //    //};
        //    //return result;


        //    // logical error
        //    // + will be evaluated before ??
        //    return new complex() // address of instance in the heap
        //    {
        //        real = (c1?.real??0) + (c2?.real??0),
        //        imaginary = (c1?.imaginary??0) + (c2?.imaginary??0)
        //    };


        //}


        //public static complex operator -(complex c1, complex c2)
        //{
        //    return new complex() // address of instance in the heap
        //    {
        //        real = (c1?.real ?? 0) - (c2?.real ?? 0),
        //        imaginary = (c1?.imaginary ?? 0) - (c2?.imaginary ?? 0)
        //    };

        //}
        #endregion


        #region Unary operator overloading
        //public static Complex operator ++(Complex c)
        //{
        //    //// ++ ==> real +1
        //    //Complex res = new Complex()
        //    //{
        //    //    real = c.real + 1,
        //    //    imaginary= c.imaginary
        //    //};
        //    //return res;

        //    return new Complex()
        //    {
        //        real = (c?.real ?? 0) + 1,
        //        imaginary = c?.imaginary??0
        //    };
        //}

        //public static Complex operator --(Complex c)
        //{
        //    return new Complex()
        //    {
        //        real = (c?.real ?? 0) + 1,
        //        imaginary = c?.imaginary ?? 0
        //    };
        //}



        #endregion



        #region relational operator

        //public static bool operator >(Complex left, Complex right)
        //{
        //    if (left is null || right is null) return false;
        //    else
        //    {
        //        //left.real > right.real ==>true
        //        //left.real < right.real ==>false
        //        //left.real = right.real / left.imagenige >right.imagenige ==> true/left.imagenige <right.imagenige  ==>false
        //        if (left.real == right.real)
        //            return left.imaginary > right.imaginary;
        //        //if(left.imaginary > right.imaginary)
        //        else
        //            return left.real > right.real;
        //    }
        //}

        //public static bool operator <(Complex left, Complex right)
        //{
        //    if (left is null || right is null) return false;
        //            else {
        //        //left.real < right.real ==>true
        //        //left.real > right.real ==>false
        //        //left.real = right.real / left.imagenige <right.imagenige ==> true/left.imagenige >right.imagenige  ==>false
        //        if (left.real == right.real)
        //            return left.imaginary < right.imaginary;
        //        //if(left.imaginary > right.imaginary)
        //        else
        //            return left.real < right.real;
        //    } }
        #endregion

        #region casting
        //public static explicit operator int(Complex c)
        //{
        //    return c?.real??0;// 4 + 5i ==> x = 4
        //}

        //public static implicit operator string(Complex c)
        //{
        //    return c.ToString();
        //    //return $"{c.real} + {c.imaginary}";
        //}
        #endregion
    }
}
