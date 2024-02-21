namespace Matrix
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(new int[,] { { 4, 3, 9 }, { 43, 7, 8 }, { 8, 0, 1 } });
            Matrix matrix2 = new Matrix(new int[,] { { 6, 10, 21 }, { 24, 13, 19 }, { 26, 22, 31 } });

            Matrix sumMatrix = matrix1 + matrix2;
            Matrix subtractMatrix = matrix1 - matrix2;
        }

        public class Matrix
        {
            public int[,] Array { get; private set; }

            public Matrix(int[,] matrix)
            {
                Array = matrix;
            }

            public static Matrix operator +(Matrix a, Matrix b)
            {
                int[,] sumMatrix = new int[a.Array.GetLength(0), a.Array.GetLength(1)];
                if (a.Array.Length == b.Array.Length)
                {
                    for (int i = 0; i < a.Array.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.Array.GetLength(1); j++)
                        {
                            sumMatrix[i, j] = a.Array[i, j] + b.Array[i, j]; 
                        }
                    }
                }
                else
                {
                    throw new Exception("Not valid matrix length!");
                }
                return new Matrix(sumMatrix);
            }

            public static Matrix operator -(Matrix a, Matrix b)
            {
                int[,] subtractMatrix = new int[a.Array.GetLength(0), a.Array.GetLength(1)];
                if (a.Array.Length == b.Array.Length)
                {
                    for (int i = 0; i < a.Array.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.Array.GetLength(1); j++)
                        {
                            subtractMatrix[i, j] = a.Array[i, j] - b.Array[i, j];
                        }
                    }
                }
                else
                {
                    throw new Exception("Not valid matrix length!");
                }
                return new Matrix(subtractMatrix);
            }
        }
    }*/

    /*public class AdditionalTask1
    {
        static void Main()
        {
            Object player = new Object(1, 1, 1);
            Object enemy = new Object(2, 2, 3);

            if (player == enemy)
            {
                Console.WriteLine("Одна из точек объекта совпадает с точкой другого объекта.");
            }
        }

        public class Object
        {
            public Object(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public static bool operator ==(Object a, Object b)
            {
                if (a.X == b.X || a.Y == b.Y || a.Z == b.Z)
                {
                    return true;
                }
                return false;
            }

            public static bool operator !=(Object a, Object b)
            {
                if (a.X == b.X || a.Y == b.Y || a.Z == b.Z)
                {
                    return false;
                }
                return true;
            }
        }
    }*/

    /*public class AdditionalTask3
    {
        static void Main()
        {
            User user = new User(null, 1, "Ukraine");

            User user2 = null;

            if (user)
            {
                Console.WriteLine("Все поля пользователя заполнены.");
            }
            else
            {
                Console.WriteLine("Имеется пустое поле.");
            }
        }

        public class User
        {
            public User(string name, int age, string country)
            {
                Name = name;
                Age = age;
                Country = country;
            }

            public string Name { get; set; }
            public int Age { get; set; }
            public string Country { get; set; }

            public static bool operator true(User user)
            {
                if (user == null || user.Name == null || user.Country == null || user.Name == "" || user.Country == "" || user.Age == 0) {
                    return false;
                }
                return true;
            }

            public static bool operator false(User user)
            {
                if (user == null || user.Name == null || user.Country == null || user.Name == "" || user.Country == "" || user.Age == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }*/

    /*public class AdditionalTask4
    {
        static void Main()
        {
            Point3D point = new Point3D(10, 5, 6);

            Console.WriteLine(point.Info());
            
        }

        public readonly struct Point3D
        {
            public readonly int X;
            public readonly int Y;
            public readonly int Z;

            public Point3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public string Info()
            {
                return $"Точка: ({X}, {Y}, {Z})";
            }
        }
    }*/

    /*public class AdditionalTask7
    {
        static void Main()
        {
            Random random = new Random();
            Doubler number = new Doubler(random.Next(2, 100));
            int steps = 0;
            int userChoice = 0;

            while (number.Current < number.Finish) {
                Console.Clear();
                Console.WriteLine($"Текущее число - {number.Current}\nНужное число - {number.Finish}\nКоличество шагов - {steps}");
                Console.Write("Выберите действие:\n1. Увеличить на 1\n2. Умножить на 2\n3. Сбросить до 1\n-> ");
                userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        number.IncreaseBy1();
                        break;
                    case 2:
                        number.MultiplyBy2();
                        break;
                    case 3:
                        number.Reset();
                        break;
                    default:
                        continue;
                }
                steps++;

                Console.Clear();

                if (number.Current == number.Finish)
                {
                    Console.WriteLine($"\n\tВы выиграли!\n\nПолученное число - {number.Current}\nНужное число - {number.Finish}\nСделано {steps} шагов");
                    return;
                }
            }
            Console.WriteLine($"\n\tВы проиграли!\n\nПолученное число - {number.Current}\nНужное число - {number.Finish}\nСделано {steps} шагов");

        }

        public class Doubler
        {
            private int current = 1;
            public int Current { get => current; }


            private int finish;

            public Doubler(int finish)
            {
                this.finish = finish;
            }

            public int Finish { get => finish; }

            public void IncreaseBy1()
            {
                current++;
            }

            public void MultiplyBy2()
            {
                current *= 2;
            }

            public void Reset()
            {
                current = 1;
            }
        }
    }*/
}
