using System.ComponentModel.Design;

namespace CSharp_Lab2_Bogdanov_Shumila
{

    internal class Program
    {

        static void Main(string[] args)
        {
            //double a = 10;
            //double b = 3;
            //double c = a / b;
            //Console.WriteLine($"Переменная с = {c}");
            //double x = 10 / 3;
            //Console.WriteLine($"Переменная х = {x}");

            //int x1 = 4;
            //int y1 = ++x1;
            //Console.WriteLine($"x1 = {x1}, y1 = {y1}");
            //int x2 = 4;
            //int y2 = x2++;
            //Console.WriteLine($"x2 = {x2}, y2 = {y2}");

            //int x = 10 / 5 * 2; //Сначала деление , потом умножение
            //Console.WriteLine($"{x}");

            //double a = 0.1;
            //double b = 0.2;
            //double c = a + b;
            //double d = 0.3;
            //Console.WriteLine(c == d);
            //decimal x = 0.1m;
            //decimal y = 0.2m;
            //decimal z = x + y;
            //decimal e = 0.3m;
            //Console.WriteLine(z == e);

            //int a = 25;
            //int b = 25;
            //Console.WriteLine(a == b);
            //int c = 25;
            //int d = 17;
            //Console.WriteLine(c == d);
            //int a = 45;
            //int b = 13;
            //Console.WriteLine(a != b);
            //Console.WriteLine(a != 45);

            //bool x1 = (5 > 6) | (4 < 6);
            //bool x2 = (5 > 6) | (4 > 6);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            //bool x1 = (5 > 6) || (4 < 6);
            //bool x2 = (5 > 6) || (4 > 6);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            //int a = 250;
            //int b = 10;
            //byte c = (byte)(a + b); 

            //Console.Write("Введите целое число: ");
            //string? input = Console.ReadLine();
            //int number = Convert.ToInt32(input);

            //if (number > 0)
            //{
            //    Console.WriteLine("Число положительное.");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("Число отрицательное. ");
            //}
            //else
            //{
            //    Console.WriteLine("Это ноль.");
            //}

            //int x = 3;
            //int y = 2;
            //int z = x < y ? (x + y) : (x - y);
            //Console.WriteLine(z);

            //string game = Console.ReadLine().ToLower();

            //switch (game)
            //{
            //    case "Dota 2":
            //        Console.WriteLine("Ваша игра - Dota 2");
            //        break;
            //    case "CS":
            //        Console.WriteLine("Ваша игра - Counter-Strike");
            //        break;
            //    case "Minecraft":
            //        Console.WriteLine("Ваша игра - Minecraft");
            //        goto case "Dota 2";
            //    default:
            //        Console.WriteLine("Игра не найдена");
            //        break;
            //}

            //Задание 1
            //Console.WriteLine("Введите число: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Число четное");
            //}
            //else
            //{
            //    Console.WriteLine("Число нечетное");
            //}

            //Задание 2        
            //Console.WriteLine("Введите ваш пароль: ");
            //string pr = Console.ReadLine();
            //switch (pr)
            //{
            //    case "310179":
            //        Console.WriteLine("пароль принят");
            //        break;
            //    default:
            //        Console.WriteLine("пароль не принят");
            //        break;
            //}

            //Задание 3
            //Console.Write("Напишите число: ");
            //int a = int.Parse(Console.ReadLine());
            //if (((a / 1000) + (a % 10)) == (((a / 100) % 10) - ((a / 10) % 10)))
            //{
            //    Console.WriteLine("ДА");
            //}
            //else
            //{
            //    Console.WriteLine("Нет");
            //}

            //Задание 4
            //Console.WriteLine("Введите ваш возраст: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age > 17)
            //{
            //    Console.WriteLine("Доступ разрешен");
            //}
            //else
            //{
            //    Console.WriteLine("Доступ запрещен");
            //}

            //Задание 5
            //Console.WriteLine("Напишите два различных целых числа: ");
            //int num = int.Parse(Console.ReadLine());
            //int num1= int.Parse(Console.ReadLine());
            //if (num > num1)
            //{
            //    Console.WriteLine($"{num1}");
            //}
            //else if(num < num1)
            //{
            //    Console.WriteLine($"{num}");
            //}

            //Задание 6
            //Console.WriteLine("Введите два числа: ");
            //int num = int.Parse(Console.ReadLine());
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите тип операции например(+ - * /):");
            //string operazia = Console.ReadLine();
            //if (operazia == "+")
            //{
            //    Console.WriteLine($"{num + num1}");
            //}
            //if (operazia == "-")
            //{
            //    Console.WriteLine($"{num - num1}");
            //}
            //if (operazia == "*")
            //{
            //    Console.WriteLine($"{num * num1}");
            //}
            //if (operazia == "/")
            //{
            //    Console.WriteLine($"{num / num1}");
            //}



            //Задание 7
            //Console.WriteLine("Введите порядковый номер дня недели: ");
            //string number = Console.ReadLine();
            //switch (number)
            //{
            //    case "1":
            //        Console.WriteLine("Понедельник");
            //        break;
            //    case "2":
            //            Console.WriteLine("Вторник");
            //        break;
            //    case "3":
            //        Console.WriteLine("Среда");
            //        break;
            //    case "4":
            //        Console.WriteLine("Четверг");
            //        break;
            //    case "5":
            //        Console.WriteLine("Пятница");
            //        break;
            //    case "6":
            //        Console.WriteLine("Суббота");
            //        break;
            //    case "7":
            //        Console.WriteLine("Воскресеье");
            //        break;

            //Задание 8
            //Console.WriteLine("Введите два числа: ");
            //int num = int.Parse(Console.ReadLine());
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите тип операции например(+ - * /): ");
            //string znak = Console.ReadLine();
            //switch (znak)
            //{
            //    case "+":
            //        Console.WriteLine($"{num + num1}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{num - num1}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{num * num1}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"{num / num1}");
            //        break;
            //}


            //Задание 9
            //Console.WriteLine("Введите уровень сложности (цифру от 1 до 3): ");
            //string number = Console.ReadLine();
            //switch (number)
            //{
            //    case "1":
            //        Console.WriteLine("легкий");
            //        break;
            //    case "2":
            //        Console.WriteLine("средний");
            //        break;
            //    case "3":
            //        Console.WriteLine("сложный");
            //        break;
            //}

            //Задание 10
            //   namespace Program 
            //    {
            //internal class Program
            //        {
            //            static int health = 100;//вводим значение сколько здоровья у персонажа 
            //static void Main(string[] args)/*вводим метод мэйн*/
            //            {
            //                Console.WriteLine($"Здоровье персонажа: {health}");/*выводим на консоль здоровье персонажа*/
            //                TakeDamage(30);
            //            }
            //static void TakeDamage(int damage)
            //            {
            //                health -= damage;//тут считаем сколько останется здоровья после полученго урона а ниже через консолврайи выводим все
            //                Console.WriteLine($"Персонаж получил {damage} урона.Текущее здоровье: { health}.");
            //}


            //Задание 11
            //Console.WriteLine("Введите класс персонажа: ");
            //string klass = Console.ReadLine();
            //if (klass == "воин")
            //{
            //    Console.WriteLine("ближний боец");
            //}
            //else if (klass == "маг")
            //{
            //    Console.WriteLine("дальнобойщик");
            //}
            //else if (klass == "разбойник")
            //{
            //    Console.WriteLine("ближний боец");
            //}
            //else if (klass == "паладин")
            //{
            //    Console.WriteLine("ближний боец");
            //}
            //else if (klass == "варвар")
            //{
            //    Console.WriteLine("ближний боец");
            //}
            //else if (klass == "охотник")
            //{
            //    Console.WriteLine("дальнобойщик");
            //}
            //else if (klass == "друид")
            //{
            //    Console.WriteLine("дальнобойщик");
            //}
            //else if (klass == "жрец")
            //{
            //    Console.WriteLine("дальнобойщик");
            //}
            //else
            //{
            //    Console.WriteLine("Неизвестный класс");
            //}

            //Задание 12
            //Console.WriteLine("Введите три числа: ");
            //int num = int.Parse(Console.ReadLine());
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //if (num  > 0||num1 > 0||num2 > 0) 
            //{
            //    Console.WriteLine($"{num+num1+num2}");
            //}

            //Задание 13
          //  Console.Write("Вы — отважный искатель приключений, отправившийся в Темный Лабиринт,\r\nчтобы найти легендарного Dungeon Master’а. Вам предстоит пройти через несколько\r\nкомнат, каждая из которых может иметь свои опасности и сокровища.");
          //  Console.WriteLine(" ");
          //  Console.WriteLine(" ");
          //  Console.WriteLine(" Вы стоите перед первой дверью. Перед вами два пути: ");
          //  Console.WriteLine(" ");
          //  Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
          //  Console.WriteLine("Путь B: Пойти по темному коридору.");
          //  string komnata = Console.ReadLine();
            
          //  if (komnata == "A")
          //  {
          //      Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
          //  }
          //  else if (komnata == "B")
          //  {
          //      Console.WriteLine("Путь B: Пойти по темному коридору.");
          //  }
          //  if (komnata == "A")
          //  {
          //      Console.WriteLine("Дракон говорит:");
          //      Console.WriteLine("Кто не дышит, но живет; хоть не нужно — много пьет; и в жизни, и в смерти тело как лед.");
          //  }
          //  string otvet = Console.ReadLine();
          //  if (otvet == "рыба")
          //  {
          //      Console.WriteLine("Дракон открыл вам дверь в следующую комнату!");
          //  }
          //  else
          //  {
          //      Console.WriteLine("Дракон вас съел!");
          //  }
          //  Console.WriteLine("Выбери дверь:Дверь1 или Дверь2 ");
          //  if (komnata == "B")
          //  {
          //      Console.WriteLine("Выбери дверь: ");
          //      Console.WriteLine("Дверь1");
          //      Console.WriteLine("Дверь2");
          //  }
          //  string otvet1 = Console.ReadLine();
          //if (otvet1 == "Дверь1")
          //  {
          //      Console.WriteLine("сокровища Dungeon Master’а.");
          //  }
          //  else
          //  {
          //      Console.WriteLine("ловушка с ядовитыми шипами.");
          //  }


        }
    }
}    


