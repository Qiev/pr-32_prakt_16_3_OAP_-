using System;
namespace pr_32_prakt_16_3_OAP_Давыдова
{
    class Vector
    {
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double X;
        public double Y;
        public double Z;
        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public static Vector operator +(Vector l, Vector r)
        {
            return new Vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }
        public static Vector operator -(Vector l, Vector r)
        {
            return new Vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }
        public static double operator *(Vector l, Vector r)
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }
        public static double Cos(Vector l, Vector r)
        {
            return (l * r) / (l.GetLength() * r.GetLength());
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Vector vector = new Vector(2, 4, 6);
            Vector vector1 = new Vector(10, 12, 14);
            Vector vector2 = vector + vector1;
            Vector vector3 = vector - vector1;
            double doubl = vector1 * vector2;
            double doubl1 = Vector.Cos(vector, vector1);

            Console.WriteLine(vector);
            Console.WriteLine(vector1);
            Console.WriteLine(vector2);
            Console.WriteLine(vector3);
            Console.WriteLine(doubl);
            Console.WriteLine(doubl1);
            Console.ReadKey();
        }
    }
}
