using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tumakov4
{
    internal class Program
    {
        static void Main()
        {
            dz62();
            Console.ReadKey();
        }
        public static void up61()
        {
            string sr = "C:\\Users\\Семья\\Desktop\\11\\данные для массива.txt";
            StreamReader SR = new StreamReader(sr);
            string rg = "аеёиоуюяыэ";
            string rs = "йцкнгшщзхъфвпрлджчсмтьб";
            string es = "qwrtpsdfghjklzxcvbnm";
            string eg = "eyuoai";
            string s = "";
            int gl = 0;
            int sog = 0;
            while (!SR.EndOfStream)
            {
                s = s + SR.ReadLine().ToLower().Trim();
            }
            SR.Close();
            char[] Array = s.ToCharArray();
            foreach (char i in Array)
            {
                if (rg.Contains(i) || eg.Contains(i))
                {
                    gl++;
                }
                if (rs.Contains(i) || es.Contains(i))
                {
                    sog++;
                }
            }
            Console.WriteLine("кол-во гласны" + gl);
            Console.WriteLine("кол-во согласных" + sog);
        }
        public static void dz61()
        {
            string sr = "C:\\Users\\Семья\\Desktop\\11\\данные для массива.txt";
            StreamReader SR = new StreamReader(sr);
            string rg = "аеёиоуюяыэ";
            string rs = "йцкнгшщзхъфвпрлджчсмтьб";
            string es = "qwrtpsdfghjklzxcvbnm";
            string eg = "eyuoai";
            string s = "";
            var list = new List<char>();
            while (!SR.EndOfStream)
            {
                s = s + SR.ReadLine().ToLower().Trim();
            }
            for (int i = 0; i < s.Length; i++)
            {
                list.Add(s[i]);
            }
            int gl = 0;
            int sog = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (rg.Contains(list[i]) || eg.Contains(list[i]))
                {
                    gl++;
                }
                else if (rs.Contains(list[i]) || es.Contains(list[i]))
                {
                    sog++;
                }
            }
            Console.WriteLine("Кол-во гласных в файле = " + gl);
            Console.WriteLine("Кол-во согласных в файле = " + sog);
        }
        public static void up62()
        {
            Console.WriteLine("Введите размерность первой матрицы: ");
            int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите размерность второй матрицы: ");
            int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМатрица A:");
            Print(A);
            Console.WriteLine("\nМатрица B:");
            Print(B);
            Console.WriteLine("\nМатрица C = A * B:");
            int[,] C = Operation(A, B);
            Print(C);
        }
        static int[,] Operation(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] res = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        res[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return res;
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static double[] TemperatureValue(Dictionary<string, double[]> array)
        {
            string[] mounth = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            double[] result = new double[array.Keys.Count];
            for (int i = 0; i < array.Keys.Count; i++)
            {
                double sum = 0;
                for (int j = 0; j < array.Values.Count; j++)
                {
                    sum += array[mounth[i]][j];
                }
                result[i] = sum / array.Keys.Count;
            }
            return result;
        }
        static void Print1(LinkedList<LinkedList<int>> Mtrx)
        {
            foreach (LinkedList<int> subline in Mtrx)
            {
                Console.WriteLine(string.Join(" ", subline.ToArray()));
            }
        }
        static LinkedList<LinkedList<int>> Multiply(LinkedList<LinkedList<int>> a, LinkedList<LinkedList<int>> b)
        {
            LinkedList<LinkedList<int>> r = new LinkedList<LinkedList<int>>();
            return r;
        }
        public static void dz62()
        {
            LinkedList < LinkedList < int>> A1m = new LinkedList<LinkedList<int>>();
            Console.WriteLine("Введите размерность первой матрицы: ");
            int xA = Convert.ToInt32(Console.ReadLine());
            int yA = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < xA; i++)
            {
                A1m.AddLast(new LinkedList<int>());
            }
            Console.WriteLine("Введите значения матрицы");
            foreach (LinkedList<int> sublist in A1m)
            {
                for (int j = 0; j < yA; j++)
                {
                    Console.Write("A[{0},{0}] = ", j);
                    sublist.AddLast(Convert.ToInt32(Console.ReadLine()));
                }
            }

            LinkedList < LinkedList < int>> B1m = new LinkedList<LinkedList<int>>();
            Console.WriteLine("Введите размерность второй матрицы: ");
            int xB = Convert.ToInt32(Console.ReadLine());
            int yB = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < xB; i++)
            {
                B1m.AddLast(new LinkedList<int>());
            }
            Console.WriteLine("Введите значения матрицы");
            foreach (LinkedList<int> sublist in B1m)
            {
                for (int j = 0; j < yB; j++)
                {
                    Console.Write("A[{0},{0}] = ", j);
                    sublist.AddLast(Convert.ToInt32(Console.ReadLine()));
                }
            }
            Print1(A1m);
            Print1(B1m);
            Multiply(A1m, B1m);
        }
        public static void up63()
        {
            int countMonths = 12;
            int countDaysInMonths = 30;
            double summ = 0;
            Random value = new Random();
            double[,] temperature = new double[countMonths, countDaysInMonths];
            var avgTempInMonth = new double[countMonths];
            for (int i = 0; i < countMonths; i++)
            {
                summ = 0;
                for (int j = 0; j < countDaysInMonths; j++)
                {
                    temperature[i, j] = value.Next(-45, 45);
                    summ += temperature[i, j];

                }
                avgTempInMonth[i] = summ / countDaysInMonths;
            }
            summ = 0;
            byte temp = 1;
            foreach (var item in avgTempInMonth)
            {
                Console.WriteLine($"Средние температуры за месяц {(Months)temp} составила : {item}");
                summ += item;
                temp++;
            }
            Console.WriteLine($"Средняя температура за весь год = {summ / countMonths}");
        }

        public static void dz63()
        {
            Dictionary<string, double[]> temperature1 = new Dictionary<string, double[]>();
            int count = 12;
            int maxTemp = 30;
            int minTemp = -30;
            Random value = new Random();
            for (int i = 0; i < count; i++)
            {
                double[] temperatureOfDay = new double[30];
                for (int j = 0; j < temperatureOfDay.Length; j++)
                {
                    temperatureOfDay[j] = value.NextDouble() * (maxTemp - minTemp) + minTemp;
                }
                switch (i)
                {
                    case 0:
                        temperature1.Add("Январь", temperatureOfDay);
                        break;
                    case 1:
                        temperature1.Add("Февраль", temperatureOfDay);
                        break;
                    case 2:
                        temperature1.Add("Март", temperatureOfDay);
                        break;
                    case 3:
                        temperature1.Add("Апрель", temperatureOfDay);
                        break;
                    case 4:
                        temperature1.Add("Май", temperatureOfDay);
                        break;
                    case 5:
                        temperature1.Add("Июнь", temperatureOfDay);
                        break;
                    case 6:
                        temperature1.Add("Июль", temperatureOfDay);
                        break;
                    case 7:
                        temperature1.Add("Август", temperatureOfDay);
                        break;
                    case 8:
                        temperature1.Add("Сентябрь", temperatureOfDay);
                        break;
                    case 9:
                        temperature1.Add("Октябрь", temperatureOfDay);
                        break;
                    case 10:
                        temperature1.Add("Ноябрь", temperatureOfDay);
                        break;
                    case 11:
                        temperature1.Add("Декабрь", temperatureOfDay);
                        break;
                }
            }
            double[] avarageTemperature = TemperatureValue(temperature1);
            Array.Sort(avarageTemperature);
            Console.WriteLine("Средние значения температуры: ");
            for (int i = 0; i < avarageTemperature.Length; i++)
            {
                Console.WriteLine(avarageTemperature[i]);
            }
            Console.ReadKey();
        }
    }


    //public static void up61(string filename{ @"C:\Users\Семья\Семья\1\данные для массива.txt"});





    //public static void up62()



}

