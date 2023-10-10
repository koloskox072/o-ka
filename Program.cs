namespace ośka
{
    class liczbaZ
    {
        private double re;
        private double im;

        public liczbaZ(double re=0 , double im = 0)
        {
            this.re = re;
            this.im = im;
        }
        public override string ToString()
        {
            if (im < 0) return $"{re}{im}i";
            if (re == 0) return $"{im}i";
            else if (im == 0) return $"{re}";
            return $"{re}+{im}i";
        }
        public static liczbaZ operator +(liczbaZ a, liczbaZ b)
        {
            return new liczbaZ(a.re + b.re, a.im + b.im);
        }
        public static liczbaZ operator -(liczbaZ a, liczbaZ b)
        {
            return new liczbaZ(a.re - b.re, a.im - b.im);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            liczbaZ z1 = new liczbaZ(3,6);
            Console.WriteLine(z1);
            liczbaZ z2 = new liczbaZ(3, -1);
            Console.WriteLine(z2);
            liczbaZ z3 = new liczbaZ(0,3);
            Console.WriteLine(z3);
            Console.WriteLine(z1 + z2) ;
        }
    }
}