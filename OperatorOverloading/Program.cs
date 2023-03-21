namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD();
            Console.Write("Координаты точки а: ");
            a.show();
            Console.WriteLine();
            Console.Write("Координаты точки b: ");
            b.show();
            Console.WriteLine();
            a = b++;
            Console.Write("Результат инкрементирования b++: ");
            a.show();
            Console.WriteLine();
            b.show();
            c = a + b;
            Console.Write("Результат сложения а + b: ");
            c.show();
            Console.WriteLine();
            c = a + b + c;
            Console.Write("Результат сложения а + b + с: ");
            c.show();
            Console.WriteLine();
            c = c - a;
            Console.Write("Результат вычитания с - а: ");
            c.show();
            Console.WriteLine();
            c = c - b;
            Console.Write("Результат вычитания с - Ь: ");
            c.show();
            Console.WriteLine();
            c = -a;
            Console.Write("Результат присваивания -а: ");
            c.show();
            Console.WriteLine();
            b = a + 10;
            Console.Write("Результат сложения a + 10: ");
            b.show();
            b = 10 + b;
            Console.Write("Результат сложения 10 + b: ");
            b.show();
            if (a > c) Console.WriteLine("a > с - ИСТИНА");
            if (a < c) Console.WriteLine("a < с - ИСТИНА");
            if (a > b) Console.WriteLine("a > b - ИСТИНА");
            if (a < b) Console.WriteLine("a < b - ИСТИНА");
            a = c;
            if (a == c) Console.WriteLine("a == с - ИСТИНА");
            if (a != b) Console.WriteLine("a != b - ИСТИНА");
            int i;
            ThreeD d = new ThreeD(1, 2, 3);
            i = d;
            Console.WriteLine("Результат присваивания i = d: " + i);
            Console.WriteLine();
            i = d * 2;
            Console.WriteLine("Результат вычисления выражения d * 2: " + i);
            i = d;
            Console.WriteLine("Результат присваивания i = d: " + i);
            Console.WriteLine();
            i = (int)d * 2;
            Console.WriteLine("Результат вычисления выражения d * 2: " + i);
            d = 100;
            Console.WriteLine("Результат неявного преобразования int в ThreeD");
            d.show();
        }
    }

    class ThreeD
    {
        int x, y, z; // 3-х-мерные координаты.
        public ThreeD() { x = y = z = 0; }
        public ThreeD(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        // Перегрузка бинарного оператора "+"
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            return result;
        }

        // Перегрузка бинарного оператора "-"
        public static ThreeD operator -(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x - op2.x;
            result.y = op1.y - op2.y;
            result.z = op1.z - op2.z;
            return result;
        }

        // Перегрузка унарного оператора "-"
        public static ThreeD operator -(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = -op.x;
            result.y = -op.y;
            result.z = -op.z;
            return result;
        }

        // Перегрузка унарного оператора "++"
        public static ThreeD operator ++(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = op.x + 1;
            result.y = op.y + 1;
            result.z = op.z + 1;
            return result;
        }

        // Перегрузка бинарного оператора "+" для суммирования объекта и int-значения.
        public static ThreeD operator +(ThreeD opl, int op2)
        {
            ThreeD result = new ThreeD();
            result.x = opl.x + op2;
            result.y = opl.y + op2;
            result.z = opl.z + op2;
            return result;
        }

        // Перегрузка бинарного оператора "+" для варианта int-значение + объект".
        public static ThreeD operator +(int opl, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op2.x + opl;
            result.y = op2.y + opl;
            result.z = op2.z + opl;
            return result;
        }

        // Операторы отношения перегружаются парами 1) < > 2)== != 3)>= <=
        // Перегрузка оператора "<".
        public static bool operator <(ThreeD op1, ThreeD op2)
        {
            if ((op1.x < op2.x) && (op1.y < op2.y) && (op1.z < op2.z))
                return true;
            else
                return false;
        }

        // Перегрузка оператора ">".
        public static bool operator >(ThreeD op1, ThreeD op2)
        {
            if ((op1.x > op2.x) && (op1.y > op2.y) && (op1.z > op2.z))
                return true;
            else
                return false;
        }

        public static bool operator ==(ThreeD op1, ThreeD op2)
        {
            if ((op1.x == op2.x) && (op1.y == op2.y) && (op1.z == op2.z))
                return true;
            else
                return false;
        }

        public static bool operator !=(ThreeD op1, ThreeD op2)
        {
            if ((op1.x != op2.x) || (op1.y != op2.y) || (op1.z != op2.z))
                return true;
            else
                return false;
        }

        //public override bool Equals(object? obj)
        //{
        //    return this.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return this.GetHashCode();
        //}

        // Неявное преобразование из объекта класса в стандартный тип
        public static implicit operator int(ThreeD op1)
        {
            return op1.x * op1.y * op1.z;
        }


        // Неявное преобразование из стандартного типа в объект класса
        public static implicit operator ThreeD(int n)
        {
            ThreeD result = new ThreeD(n, n, n);
            return result;
        }

        /*
         Внутри класса не может одновременно быть, и explicit, и implicit преобразования.
         Если в классе есть  implicit,  он будет срабатывать и при явном преобразовании.
         При  explicit, утверждение не является верным.
         */

        // Явное преобразование
        //public static explicit operator int(ThreeD op1)
        //{
        //    return op1.x * op1.y * op1.z;
        //}

        // Отображаем координаты X, Y, Z.
        public void show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }

        // Нельзя перегружать .  []  ()  new  is  as  sizeof  typeof  ?:  =
    }

}