using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
;            Dictionary<string, string[]> graph = new Dictionary<string, string[]>()
            {
                {"A" , new string[]{"B","F"}},
                {"B",new string[] { "D","A" }},
                {"C", new string[] { "A" }},
                {"D",new string[]{"C"}},
                {"F" ,new string[]{ } }
            };
            //Ex4(graph, "A", "C");
            Console.ReadKey();
        }
        public struct Student
        {
            public string name;
            public string surname;
            public byte age;
            public string exam;
            public int pointsOfExam;
            public Student(string Name, string Surname, byte Age, string Exam,  int PointsOfExam)
            {
                name = Name;
                surname = Surname;
                age = Age;
                exam = Exam;
                pointsOfExam = PointsOfExam;
            }
        }
        static void ShowCommands()//для вывода меню на консоль
        {
            Console.WriteLine("Доступные команды(писать строкой):");
            Console.WriteLine("{0} добавить",1);
            Console.WriteLine("{0} удалить",2);
            Console.WriteLine("{0} сортировка",3);
            Console.WriteLine("{0} показать",4);
            Console.WriteLine("{0} выйти",5);
        }
        static public void Ex1()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student("Арайан ","Тимурхан",18, "Инфоматика",259) },
                {2, new Student("Вальярова","Алина",28,"Английский",252) },
                {3, new Student("Воронко","Диана",17,"Информатика",235) },
                {4, new Student("Заречный","Максим",18,"Английский",246) },
                {5, new Student("Муракаева","Дания",18,"Английский",267) },
                {6, new Student("Полетаев","Никита",18,"Информатика",249) },
                {7, new Student("Салимов","Радмир",18,"Информатика",243) },
                {8, new Student("Сархандеева","Аделина",18,"Физика",248) },
                {9, new Student("Чернова","Маргарита",25,"Физика",242) },
                {10, new Student("Шпак","Виталий",18,"Информатика",205) }

            };

            bool flag = true;
            string inputValue;
            while (flag)
            {
                ShowCommands();
                inputValue = Console.ReadLine().ToLower();
                switch (inputValue)
                {
                    case "добавить":
                        AddStudent(students);
                        break;
                    case "удалить":
                        RemoveStudent(students);
                        break;
                    case "сортировка":
                        students = SortStudents(students);
                        break;
                    case "показать":
                        WriteAllStudents(students);
                        break;
                    case "выйти":
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Я вас не понимаю");
                        break;
                }
                Console.Clear();
            }

        }

        private static void RemoveStudent(Dictionary<int, Student> students)
        {
            Console.WriteLine("Какой id у студента?");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                if (students.ContainsKey(id))
                {
                    Console.WriteLine("Стерт с лица земли -_-");
                    students.Remove(id);
                }
                else
                {
                    Console.WriteLine("Студент не нашелся");
                }
            }
            else
            {
                Console.WriteLine("Неккоректное значение!");
            }
            Console.ReadKey();
        }

        private static void AddStudent(Dictionary<int, Student> students)
        {
            Console.Clear();
            Console.WriteLine("Введите его имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите его фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Какой у него возраст??");

            byte age;
            while (!byte.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Не знаю таких чисел для возраста!");
            }
            Console.WriteLine("С каким экзаменом поступал?");
            string exam = Console.ReadLine();
            Console.WriteLine("А баллов сколько?");
            int points;
            while (!int.TryParse(Console.ReadLine(), out points) || points < 0)
            {
                Console.WriteLine("Не может быть! Введите еще раз.");
            }
            Random random = new Random();
            int valueId = random.Next(0, 100);
            while (students.ContainsKey(valueId))
            {
                valueId = random.Next();
            }
            students.Add(valueId, new Student(name,  surname,age, exam,  points));
            Console.Clear();
            Console.WriteLine("Студент был успешно добавлен!");
        }

        private static Dictionary<int, Student> SortStudents(Dictionary<int, Student> students)
        {

            var sort = students.OrderByDescending(x => x.Value.pointsOfExam).ToDictionary(x => x.Key, x => x.Value);
            //OrderBy - метод сортирующий в порядке убывания ключа (возвращает не словарь)
            //ToDiсtionary переводит в словарь
            //В лямбда-выражениях лямбда-оператор => используется для отделения входных параметров с левой стороны от тела лямбда-выражения с правой стороны
            return sort;
        }
        private static void WriteAllStudents(Dictionary<int, Student> students)
        {
            Console.WriteLine("Вот все студенты:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} {student.Value.name} {student.Value.surname} {student.Value.age} лет " +
                    $"{student.Value.exam} {student.Value.pointsOfExam}");
            }
            Console.ReadKey();
        }
        static void Ex2()
        {
            Random r = new Random();
            int countOfFirstTeam = 5;
            int countOfSecondTeam = 17;
            int[] firstTeam = new int[countOfFirstTeam];
            int[] secondTeam = new int[countOfSecondTeam];
            for (int i = 0; i < countOfFirstTeam; i++)
            {
                firstTeam[i] = r.Next(0, 10);
            }
            for (int i = 0; i < countOfSecondTeam; i++)
            {
                secondTeam[i] = r.Next(0, 10);
            }
            GetWinners(firstTeam, secondTeam);

        }
        static void GetWinners(int[] first, int[] second)
        {
            int firstFivesCount = 0;
            int secondFivesCount = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == 5)
                {
                    firstFivesCount++;
                }
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (second[i] == 5)
                {
                    secondFivesCount++;
                }
            }
            if (secondFivesCount == firstFivesCount)
            {
                Console.WriteLine("All Round! Free Beers! URAAA");
            }
            else
            {
                Console.WriteLine("ОЙ, Бьорг!Ни для кого пива!");
            }
        }
        internal struct Citizen
        {
            public string name;
            public string problem;
            public int keyOfProblem;
            public string descriptionOfProblem;
            public int id;
            public int temperament;
            public bool isStupid;
            public Citizen(string Name, string Problem, int KeyProblem, string Description, int Id, int Temperament, bool IsStupid)
            {
                name = Name;
                problem = Problem;
                keyOfProblem = KeyProblem;
                descriptionOfProblem = Description;
                id = Id;
                temperament = Temperament;
                isStupid = IsStupid;
            }
        }
        public static void Ex3()
        {
            Random r = new Random();
            List<Citizen> citizens = new List<Citizen>()
            {
                {new Citizen("Павел","подключение",1,"труба отпала",1223,7,false) },//3
                {new Citizen("Васz","другое",2,"хочет узнать номер телефона",122,2,true) },
                {new Citizen("Аня","оплата",3,"хочу оплатить услуги",12223,8,false) },//6
                {new Citizen("Саша","подключение",4,"труба отпала",1223,6,true) },//1
                {new Citizen("Женя","оплата",5,"хочу оплатить",125,1,false) },
                {new Citizen("Катя","другое",6,"хочу жалобу накатать",123,10,true) },//3
                {new Citizen("Витя","оплата",7,"купить трубу",23,10,true) },//2
                {new Citizen("Маша","подключение",8,"провести трубу",455,3,false) },
                {new Citizen("Миша","другое",9,"хочет поспать в очереди",12445,1,true )},
            };
            Stack<Citizen> zina = new Stack<Citizen>();
            List<Queue<Citizen>> gloabalQueue = new List<Queue<Citizen>>();
            Queue<Citizen> paymeentQueue = new Queue<Citizen>();
            Queue<Citizen> connectionQueue = new Queue<Citizen>();
            Queue<Citizen> otherQueue = new Queue<Citizen>();
            gloabalQueue.Add(paymeentQueue);
            gloabalQueue.Add(connectionQueue);
            gloabalQueue.Add(otherQueue);
            //проходим через зину
            foreach (var citizen in citizens)
            {
                zina.Push(citizen);
            }
            citizens.Clear();
            int zinaSize = zina.Count;
            for (int i = 0; i < zinaSize; i++)
            {
                citizens.Add(zina.Pop());
            }

            Dictionary<int, Citizen> howManyPeopleShouldOverRun = new Dictionary<int, Citizen>();
            //выбираем по темпераменту
            foreach (var citizen in citizens)
            {
                if (citizen.temperament > 5)
                {
                    Console.WriteLine($"Сколько людей обогнать мне? Я - {citizen.name} и я достаточно буйный-(ая)!");
                    int count;
                    while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
                    {
                        Console.WriteLine("Кажется я не могу так!Попробуй ввести еще раз!");
                    }
                    if (!howManyPeopleShouldOverRun.ContainsKey(count))
                    {
                        howManyPeopleShouldOverRun.Add(count, citizen);
                    }
                }
            }
            howManyPeopleShouldOverRun = howManyPeopleShouldOverRun.OrderByDescending
                (x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            //запихиваем самых скандальных
            foreach (var citizen in howManyPeopleShouldOverRun)
            {
                if (citizen.Value.isStupid)
                {
                    gloabalQueue[r.Next(0, 3)].Enqueue(citizen.Value);
                }
                else
                {

                    SetToQueue(gloabalQueue, citizen.Value);
                }
            }
            //запихиваем оставшихся
            foreach (var citizen in citizens)
            {
                if (!howManyPeopleShouldOverRun.ContainsValue(citizen))
                {
                    if (citizen.isStupid)
                    {
                        gloabalQueue[r.Next(0, 3)].Enqueue(citizen);
                    }
                    else
                    {
                        SetToQueue(gloabalQueue, citizen);
                    }
                }
            }
            ShowAllQueues(gloabalQueue);


        }
        static void ShowAllQueues(List<Queue<Citizen>> gloabalQueue)
        {
            int tmp = 0;
            foreach (var queue in gloabalQueue)
            {
                int queueSize = queue.Count;
                Console.WriteLine(GetNameOfQueue(tmp));
                for (int i = 0; i < queueSize; i++)
                {
                    Console.WriteLine(queue.Dequeue().name);
                }
                tmp++;
            }
        }
        static string GetNameOfQueue(int i)
        {
            switch (i)
            {
                case 0:
                    return "оплата";
                case 1:
                    return "подключение";
                default:
                    return "другое";
            }
        }
        static void SetToQueue(List<Queue<Citizen>> gloabalQueue, Citizen citizen)
        {
            //
            switch (citizen.problem)
            {
                case "оплата":
                    gloabalQueue[0].Enqueue(citizen);
                    break;
                case "подключение":
                    gloabalQueue[1].Enqueue(citizen);
                    break;
                default:
                    gloabalQueue[2].Enqueue(citizen);
                    break;
            }
        }
        static void Ex4(Dictionary<string, string[]> graph, string startValue, string endValue)
        {

            List<string> usedValues = new List<string>();//в это лист записываются посещенные вершины
            Queue<string> queue = new Queue<string>(); //путь обхода, Queue - коллекция(очередь) объектов на принципе первым поступил - первым обслужили
            queue.Enqueue(startValue); //добавляет в конец очереди
            while (queue.Count != 0)
            {
                string node = queue.Dequeue(); //текущая вершина графа
                Console.WriteLine($"Посетили {node}");
                string[] vertexs = graph[node];
                if (node == endValue)
                {
                    return;
                }

                foreach (string vertex in vertexs)
                {
                    if (!usedValues.Contains(vertex))
                    {
                        Console.WriteLine($"Посетили {vertex} из {node}");
                        if (vertex == endValue)
                        {
                            Console.WriteLine("Закончили поиски");
                            return;
                        }
                        queue.Enqueue(vertex);
                    }

                }
                usedValues.Add(node);//добавляем в лист использованных, чтобы к ним не возвращаться
            }

        }


    }
}

