using System.Runtime.Intrinsics.X86;

namespace hw_25._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // номер 1
            
            Console.WriteLine("\nНомер 1\n");

            int[] a = new int[5];
            double[,] b = new double[3, 4];
            Console.Write("Введите 5 чисел от 0 до 100(в одной строке через пробел): ");
            int ind = 0;
            foreach (var el in Console.ReadLine().Split())
            {
                a[ind] = Convert.ToInt32(el);
                ind++;
            }
            Random rand = new Random();
            Random rand_dbl = new Random();
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = Math.Round(rand.Next(100) + rand_dbl.NextDouble(), 3);
                }
            }
            
            double max = 0, min = 1000, sum = 0, multi = 1, sum_chet_A = 0, sum_nechet_column_B = 0;
            
            Console.WriteLine("\nМассив А:\n");
            foreach (int i in a) 
            {
                Console.Write(i + " ");
                if (i > max) max = i;
                if (i < min) min = i;
                sum += i;
                multi *= i;
                if (i % 2 == 0) sum_chet_A += i;
            }

            Console.WriteLine("\n\nМассив B:\n");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + "\t");
                    if (b[i, j] > max) max = b[i, j];
                    if (b[i, j] < min) min = b[i, j];
                    sum += b[i, j];
                    multi *= b[i, j];
                    if (j % 2 == 0) sum_nechet_column_B += b[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nОбщий максимальный элемент: {max}");
            Console.WriteLine($"Общий минимальный элемент: {min}");
            Console.WriteLine($"Общая сумма всех элементов: {sum}");
            Console.WriteLine($"Общее произведение всех элементов: {multi}");
            Console.WriteLine($"Сумма четных элементов массива А: {sum_chet_A}");
            Console.WriteLine($"Сумма нечетных столбцов массива В: {sum_nechet_column_B}");
            
            // номер 2
            
            Console.WriteLine("\nНомер 2\n");

            int[,] arr2 = new int[5, 5];
            int min_i = 0, min_j = 0, max_i = 0, max_j = 0;

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = rand.Next(-100, 100);
                    if (arr2[i, j] < arr2[min_i, min_j])
                    {
                        min_i = i;
                        min_j = j;
                    }
                    if (arr2[i, j] > arr2[max_i, max_j])
                    {
                        max_i = i;
                        max_j = j;
                    }
                }
            }

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            sum = 0;
            int start_i = min_i, start_j = min_j;
            int end_i = max_i, end_j = max_j;
            if (min_i > max_i)
            {
                start_i = max_i;
                start_j = max_j;
                end_i = min_i;
                end_j = min_j;
            }
            else if(min_i == max_i && min_j > max_j)
            {
                start_j = max_j;
                end_j = min_j;
            }

            for (int i = start_i+1; i < end_i; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    sum += arr2[i, j];
                }
            }
            if (min_i == max_i)
            {
                for (int i = start_j; i <= end_j; i++)
                {
                    sum += arr2[start_i, i];
                }
            }
            else
            {
                for (int i = start_j; i < 5; i++)
                {
                    sum += arr2[start_i, i];
                }
                for (int i = 0; i <= end_j; i++)
                {
                    sum += arr2[end_i, i];
                }
            }

            Console.WriteLine($"Cумма элементов массива, расположенных между минимальным({arr2[min_i, min_j]})" +
                $" и максимальным({arr2[max_i, max_j]}) элементами: {sum}");
            
            // номер 3
            Console.WriteLine("\nНомера 3 нет");

            // номер 4
            
            Console.WriteLine("\nНомер 4 без произведения\n");

            int[,] a4 = { { 1, 2, 3 } , { 3, 2, 1 } };
            int[,] b4 = { { 10, 9, 8 }, { 7, 6, 5 } };
            int c = 5;

            Console.WriteLine("a: ");
            for(int i = 0; i < a4.GetLength(0); i++)
            {
                for(int j = 0; j < a4.GetLength(1); j++) Console.Write(a4[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("\nb: ");
            for (int i = 0; i < b4.GetLength(0); i++)
            {
                for (int j = 0; j < b4.GetLength(1); j++) Console.Write(b4[i, j] + " "); 
                Console.WriteLine();
            }
            Console.WriteLine($"\na * {c}: ");
            for (int i = 0; i < a4.GetLength(0); i++)
            {
                for (int j = 0; j < a4.GetLength(1); j++) Console.Write(a4[i, j] * c + " ");
                Console.WriteLine();
            }

            Console.WriteLine("\na + b: ");
            for (int i = 0; i < a4.GetLength(0); i++)
            {
                for (int j = 0; j < a4.GetLength(1); j++) Console.Write((a4[i, j] + b4[i, j]) + " ");
                Console.WriteLine();
            }
            


            // номер 5
            
            Console.WriteLine("\nНомер 5\n");

            Console.WriteLine("Введите арифм. выражение через пробел(пример: 2 + 5): ");
            string[] strs = Console.ReadLine().Split(" ");
            if (strs.Length != 3) Console.WriteLine("Извините, я вас не понимаю");
            else if (strs[1] == "+") Console.WriteLine($"Результат: {int.Parse(strs[0]) + int.Parse(strs[2])}");
            else if (strs[1] == "-") Console.WriteLine($"Результат: {int.Parse(strs[0]) - int.Parse(strs[2])}");
            else Console.WriteLine("Извините, я знаю только + и -");
            
            // номер 6
            
            Console.WriteLine("\nНомер 6\n");

            Console.WriteLine("Введите текст: \n");
            string[] strs6 = Console.ReadLine().Split(". ");
            string text = "";
            char s1;
            string s2;
            foreach (string str in strs6)
            {
                s1 = str.ToUpper()[0];
                s2 = str.ToLower();
                s2 = s2.Substring(1);
                text += s1 + s2 + ". ";
            }
            Console.WriteLine("\nРезультат: \n\n" + text);
            

            // номер 7
            
            Console.WriteLine("\nНомер 7\n");

            Console.WriteLine("Введите текст(для окончания ввода введите пустую строку:\n");
            string text7 = "";
            string s = Console.ReadLine();
            while (s != "")
            {
                text7 += s + "\n";
                s = Console.ReadLine();
            }

            Console.Write("Недопустимое слово: ");
            string word = Console.ReadLine();
            string[] new_text = text7.Split(word);
            string ans_text = "";
            int cnt = 0;
            foreach(var str in new_text)
            {
                ans_text += str;
                for (int i = 0; i < word.Length; i++) ans_text += "*";
                cnt++;
            }

            Console.Write("\nРезультат: \n" + ans_text.Substring(0, ans_text.Length - word.Length) + "\n");
            Console.WriteLine($"Статистика замен слова {word}: {cnt - 1}");
        }
    }
}