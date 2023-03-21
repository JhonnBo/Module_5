namespace OperatorsOver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoDim p1 = new(2, 1);
            TwoDim p2 = new(3, 3);
           
            TwoDim p3 = p1 + p2;
            TwoDim p4 = p1 - p2;
            TwoDim p5 = p1++;
            TwoDim p6 = p2 + 3;

            Console.WriteLine(p3.ToString());
            Console.WriteLine(p4.ToString());
            Console.WriteLine(p5.ToString());
            Console.WriteLine(p6.ToString());
            Console.WriteLine($"p1({p1.X}, {p1.Y}) > p2({p2.X}, {p2.Y}) = {p1 > p2}");
            Console.WriteLine($"p1({p1.X}, {p1.Y}) < p2({p2.X}, {p2.Y}) = {p1 < p2}");


            Console.WriteLine($"Convert p1({p1.X}, {p1.Y}) into type int = {(int)p1}");
            TwoDim p7 = (TwoDim)5; 
            Console.WriteLine($"Convert int 5 into type TwoDim  p7({p7.X}, {p7.Y})" );
            Console.WriteLine(p1 != p2);
         
        }
    }

    class TwoDim
    {
        public int X { get; set; }
        public int Y { get; set; }

        public TwoDim(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static TwoDim operator +(TwoDim x, TwoDim y)
        {
            return new TwoDim(x.X + y.X, x.Y + y.Y);
        }

        public static TwoDim operator -(TwoDim x, TwoDim y)
        {
            return new TwoDim(x.X - y.X, x.Y - y.Y);

        }

        public static TwoDim operator ++(TwoDim x)
        {
            return new TwoDim(x.X++, x.Y++);
        }

        public static TwoDim operator +(TwoDim x, int y)
        {
            return new TwoDim(x.X * y, x.Y * y);
        }

        public static bool operator <(TwoDim x, TwoDim y)
        {
            if (x.X < y.X && x.Y < y.Y) 
            {
                return true;
            }
            else { return false; }
        }

        public static bool operator >(TwoDim x, TwoDim y)
        {
            if (x.X > y.X && x.Y > y.Y)
            {
                return true;
            }
            else { return false; }
        }

        public static explicit operator int(TwoDim x)
        {
            return x.X * x.Y;
        }

        public static explicit operator TwoDim(int x)
        {
            return new TwoDim(x, x);
        }

        //public static implicit operator int(TwoDim x)
        //{
        //    return x.X * x.Y;
        //}

        //public static implicit operator TwoDim(int x)
        //{
        //    return new TwoDim(x, x);
        //}

        public static bool operator ==(TwoDim x, TwoDim y)
        {
            if (x.X > y.X && x.Y > y.Y) return true;
            else return false;
        }
        public static bool operator !=(TwoDim x, TwoDim y)
        {
            if (x.X < y.X && x.Y < y.Y) return true;
            else return false;
        }

        public override string ToString()
        {
            return string.Format($"X: {this.X}, Y: {this.Y}");
        }

    }
}