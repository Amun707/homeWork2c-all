using System.Text;

namespace homeWork2c_all
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            //Задача 1.
            //Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B
            //Заполнить одномерный массив
            //А числами, введенными с клавиатуры пользователем, а
            //двумерный массив В случайными числами с помощью
            //циклов.Вывести на экран значения массивов: массива
            //А в одну строку, массива В — в виде матрицы.Найти в
            //данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
            //произведение всех элементов, сумму четных элементов
            //массива А, сумму нечетных столбцов массива В.

            Console.WriteLine("Задача 1.");
            //условие и ввод
            const int size1 = 5;
            int[] A = new int[size1];
            int row = 3, col = 4;
            double[,] B = new double[row, col];
            //заполнение
            Console.WriteLine($"Введите {size1} целых чисел ->");
            for (int i = 0; i < size1; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Random random = new Random();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    B[i, j] = random.NextDouble();
            //вывод в консоль
            Console.Write("Массив А -> ");
            for (int i = 0; i < size1; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Массив В -> ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine("\n\n");
            }
            //max && min
            int minA = A[0];
            int maxA = A[0];
            for (int i = 0; i < size1; i++)
            {
                if (A[i] < minA) minA = A[i];
                if (A[i] > maxA) maxA = A[i];
            }
            Console.WriteLine($"Минимальный элемент массива А -> {minA}.\nМаксимальный элемент массива А -> {maxA}.");

            double minB = B[0, 0];
            double maxB = B[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (B[i, j] < minB) minB = B[i, j];
                    if (B[i, j] > maxB) maxB = B[i, j];
                }
            }
            Console.WriteLine($"Минимальный элемент массива В -> {minB}.\nМаксимальный элемент массива В -> {maxB}.");

            //сумма
            int sumA = 0;
            double sumB = 0;
            foreach (int item in A)
            {
                sumA += item;
            }
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    sumB += B[i, j];
            Console.WriteLine($"Сумма массива А -> {sumA}.\n");
            Console.WriteLine($"Сумма массива В -> {sumB}.\n");
            Console.WriteLine($"Массив А + Массив В = {sumA + sumB}.");

            //произведение
            int prodA = 1;
            double prodB = 1;
            foreach (int item in A)
            {
                prodA *= item;
            }
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    prodB *= B[i, j];
            Console.WriteLine($"Произведение массива А = {prodA}.\n");
            Console.WriteLine($"Произведение массива В = {prodB}.\n");
            Console.WriteLine($"Произведение двух массивов А * В = {prodA * prodB}.\n");
            Console.WriteLine($"Сложение произведений(общее) А + В = {prodA + prodB}.\n");

            //четные + A
            int chetA = 0;
            for (int i = 0; i < size1; i++)
            {
                if (i % 2 == 0)
                    chetA += A[i];
            }
            Console.WriteLine($"Сумма четных элементов массива А = " + chetA);

            //нечетные столбцы массив В
            double nechBcol = 0;
            for (int i = 0; i < row; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < col; j++)
                    {
                        nechBcol += B[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма нечетных столбцов массива В = " + nechBcol);
            Console.WriteLine("\n\n");

            //Задача 2.
            //Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
            //Определить сумму элементов массива, расположенных
            //между минимальным и максимальным элементами.

            Console.WriteLine("Задача 2.\n");
            int[,] Arr2 = new int[5, 5];
            Random random2 = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arr2[i, j] = random2.Next(-100, 100);
                }
            }
            Console.WriteLine("Массив:\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(Arr2[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            //делаем из двумерного одномерный
            Console.WriteLine("Двуодномерный массив: ");
            int[] Arr2_ = new int[25];
            int sum2 = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    Arr2_[sum2] = Arr2[i, j];
                    sum2++;
                }
            foreach (int i in Arr2)
            {
                Console.WriteLine(i + " ");
            }

            //max, min
            int min2 = Arr2_[0];
            int max2 = Arr2_[0];
            for (int i = 0; i < 25; i++)
            {
                if (Arr2_[i] < min2)
                    min2 = Arr2_[i];
                if (Arr2_[i] > max2)
                    max2 = Arr2_[i];
            }
            Console.WriteLine("Минимальное значение = " + min2);
            Console.WriteLine("Максимальное значение = " + max2);

            //индексы min & max

            int index_min2 = 0;
            int index_max2 = 0;
            for (int i = 0; i < Arr2_.Length; i++)
            {
                if (min2 == Arr2_[i])
                {
                    index_min2 = i; break;
                }

            }
            Console.WriteLine("Индекс минимального значения = " + index_min2);

            for (int i = 0; i < Arr2_.Length; i++)
            {
                if (max2 == Arr2_[i])
                {
                    index_max2 = i; break;
                }
            }
            Console.WriteLine("Индекс максимального значения = " + index_max2);

            //Сумма между минимальным и максимальным элементом массива
            int sum2_ = 0;
            if (index_max2 > index_min2)
            {
                for (int i = index_min2; i <= index_max2; i++) ;
                sum2_ = sum2_ + Arr2_[i];  

            }
            else
            {
                for (int i = index_max2; i <= index_min2; i++)
                    sum2_ = sum2_ + Arr2_[i];
            }
            Console.WriteLine("Cумма между минимальным и максимальным значением = " + sum2_);
            Console.WriteLine("\n\n");

            //Задача 3.
            //Пользователь вводит строку с клавиатуры.Необходимо зашифровать данную строку используя шифр Цезаря.
            //Кроме механизма шифровки, реализуйте механизм расшифрования.

            Console.WriteLine("Задача 3.");
            char[] CaesArr = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            Console.Write("Введите фразу: ");
            string text3 = Console.ReadLine();
            char[] CaesArr2 = text3.ToCharArray();
            char[] LastArr = CaesArr2;
            char[] LastArr3 = CaesArr2;
            for (var q = 0; q < CaesArr2.Length; q++)
            {
                var sym3 = CaesArr2[q]; //q = e
                for (int i = 0; i < CaesArr.Length; i++) // i[0] = a ( i - индех)
                {
                    if (sym3 == CaesArr[i])
                    {
                        int n = i + 3;
                        if (n > 33)
                        {
                            n = n % 33;
                        }
                        LastArr[q] = CaesArr[n];
                    }
                    if (sym3 == ' ')
                    {
                        LastArr[q] = ' ';
                    }
                }
            }
            Console.WriteLine("Шифрую:");
            foreach (char item in LastArr)
            {
                Console.Write(item);
            }
            //назад
            for (var q = 0; q < CaesArr2.Length; q++)
            {
                var mys3 = CaesArr2[q];
                for (int r = 0; r < CaesArr.Length; r++)
                {
                    if (mys3 == CaesArr[r])
                    {
                        int m = r - 3;
                        if (m < 0)
                        {
                            m = 33 + m;
                        }

                        LastArr3[q] = CaesArr[m];
                    }
                    if (mys3 == ' ')
                    {
                        LastArr3[q] = ' ';
                    }
                }
            }

            Console.WriteLine("\nРозшифровка:");
            foreach (char item in LastArr3)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n\n");

            //Задача 4.
            //Создайте приложение, которое производит операции над матрицами:
            // Умножение матрицы на число;
            // Сложение матриц;
            // Произведение матриц.

            Console.WriteLine("Задача 4.");
            int[,] Array41 = new int[4, 4];
            int[,] Array42 = new int[4, 4];
            int[,] Array43 = new int[4, 4];
            Random random4 = new Random();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Array41[i, j] = random4.Next(16);

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Array42[i, j] = random4.Next(16);

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Array43[i, j] = random4.Next(16);

            Console.WriteLine("Массив 1:\n ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Array41[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Массив 2: \n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Array42[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Массив 3:\n ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Array43[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Умножение -> ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write((Array41[i, j] * 10) + "\t");
                }
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Сложение матриц -> ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write((Array41[i, j] + Array42[i, j] + Array43[i, j]) + "\t");
                }
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Произведение матриц -> ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Array43[i, j] += Array41[i, k] * Array42[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Array43[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }
            //Задание 5.
            //Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать
            //его результат.Необходимо поддерживать только две
            //операции: +и –.

            Console.WriteLine("Задача 5.");
            string oper;
            double num51, num52;
            Console.Write("Введите оператор + или -: ");
            oper = Console.ReadLine();

            Console.Write("Введите операнды через пробел: ");
            string[] Arr5 = Console.ReadLine().Split();

            num51 = Convert.ToDouble(Arr5[0]);
            num52 = Convert.ToDouble(Arr5[1]);

            switch (oper)
            {
                case "+":
                    Console.WriteLine($"{num51 + num52}");
                    break;
                case "-":
                    Console.WriteLine($"{num51 - num52}");
                    break;
                default:
                    Console.WriteLine("Неверный ввод оператора!");
                    break;
            }
            Console.WriteLine("\n\n");


            //Задание 6.
            //Пользователь с клавиатуры вводит некоторый текст. 
            //Приложение должно изменять регистр первой буквы
            //каждого предложения на букву в верхнем регистре

            Console.WriteLine("Задача 6.");
            Console.WriteLine("Введите текст-> ");
            string enter6 = Console.ReadLine();

            StringBuilder bild6 = new StringBuilder(enter6);
            bild6[0] = Char.ToUpper(bild6[0]);

            bool top = false;

            for (int i = 0; i < bild6.Length; i++)
            {

                if (Char.IsLetter(bild6[i]) && top)
                {
                    bild6[i] = Char.ToUpper(bild6[i]);
                    top = false;
                }
                else
                   if (bild6[i] == '.')
                {
                    top = true;
                }
            }
            enter6 = bild6.ToString();
            Console.WriteLine(enter6);
            Console.WriteLine("\n\n");

            //Задание 7.
            //Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно
            //должно быть заменено на набор символов *.По итогам
            //работы приложения необходимо показать статистику
            //действий.
            Console.WriteLine("Задача 7.");
            string enter7 = "Если всех гонится за вами\r\nСлишком много всех человек,\r\nРасспросите их всех подробно,\r\nЧем они всех огорчены?\r\nПостарайтесь всех утешить.\r\nДайте каждому совет,\r\nНо снижать при этом скорость\r\nСовершенно ни к чему.";
            Console.WriteLine("Исходный текст: \n" + enter7);
            Console.WriteLine("\n");
            string not7 = "всех";
            string star7 = "***";
            enter7 = enter7.ToLower().Replace(not7, star7);
            StringBuilder text7 = new StringBuilder(enter7);
            bool top7 = false;
            text7[0] = Char.ToUpper(text7[0]);
            for (int i = 0; i < text7.Length; i++)
            {

                if (Char.IsLetter(text7[i]) && top7)
                {
                    text7[i] = Char.ToUpper(text7[i]);
                    top7 = false;
                }
                else

                if (text7[i] == '.' || text7[i] == '\r' || text7[i] == '\n')
                {
                    top7 = true;
                }
            }
            enter7 = text7.ToString();
            Console.WriteLine("Красивый текст: \n" + enter7);

            int count7 = 0;
            string[] wordsinText2 = enter7.Split(new char[] { ' ', ',', '\r', '\n', '\t' });
            foreach (var word in wordsinText2)
            {
                if (star7 == word.ToLower())
                {
                    count7++;
                }
            }
            Console.WriteLine("Статистика замены слов -> " + count7);
        }
    }
}
