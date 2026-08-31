/// <summary>
/// Задание 1
/// <summary>
// string City = Console.ReadLine();
// string Country = Console.ReadLine();

// Console.WriteLine(City + " - столица " + Country);
// Console.WriteLine("{0} - столица {1}", City, Country);
// Console.WriteLine($"{City} - столица {Country}");

/// <summary>
/// Задание 2
/// <summary>
// string str = Console.ReadLine();
// if (int.TryParse(str, out int intStr)) 
//     Console.WriteLine($"Число {intStr} введено успешно");
// else
//     Console.WriteLine($"Введёная строка {str} не может быть переведена в целое число");

/// <summary>
/// Задание 3
/// <summary>
// int[] num = new int[8] {1, 2, 3, 4, 5, 6, 7, 8};
// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i] % 2 == 0)
//     {
//         Console.WriteLine(num[i]);
//     }
// }

/// <summary>
/// Задание 4
/// <summary>
// using System;
// double a = Double.Parse(Console.ReadLine()!);
// double b = Double.Parse(Console.ReadLine()!);
// double c = Double.Parse(Console.ReadLine()!);

// double[] roots = new double[4];

// double D = Math.Pow(b, 2) - 4 * a * c;

// double x1 = -Math.Pow((-b - Math.Pow(D, 0.5)) / (2 * a), 0.5);
// double x2 = -Math.Pow((-b + Math.Pow(D, 0.5)) / (2 * a), 0.5);
// double x3 = Math.Pow((-b - Math.Pow(D, 0.5)) / (2 * a), 0.5);
// double x4 = Math.Pow((-b + Math.Pow(D, 0.5)) / (2 * a), 0.5);

// roots[0] = x1;
// roots[1] = x2;
// roots[2] = x3;
// roots[3] = x4;

// Bubble(roots);
// printArray(roots);



// //реализация вывода массива
// void printArray(double[] matrix)
// {
//     int n = matrix.Length;
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write(matrix[i] + " ");
//     }
//     Console.WriteLine();
// }

// //Реализация метода Пузырьков
// void Bubble(double[] matrix)
// {   
//     int n = matrix.Length - 1;
//     for(int i = 0; i < n; i++)
//     {
//         for (int q = 0; q < n; q++)
//         {
//             if (matrix[q] > matrix[q + 1])
//             {
//                 double m = matrix[q + 1];
//                 matrix[q + 1] = matrix[q];
//                 matrix[q] = m;
//             }

//         }
//     }
// }
//----------------------

/// <summary>
/// использование пространства имён сокращает код
/// </summary>
// namespace Structures 
// {
//     internal class Program
//     {
//         ...
//     }
// }

// string RefTest = "Значение до вызова функции";
// ParamByVal(RefTest);
// Console.WriteLine("\nВызов функции ParamByVal. Значение переменной: " + RefTest);

// ParamByRef(ref RefTest);
// Console.WriteLine("Вызов функции ParamByRef. Значение переменной:" + RefTest);

// int x = 2, x2, x3;
// ParamOut(x, out x2, out x3);
// Console.WriteLine("Вызов функции ParamOut. X={0}, x^2={1}, x^3={2}", x, x2, x3);


// /// <summary>
// /// Передача параметра по значению
// /// </summary>
// static void ParamByVal(string param)
// {
//     param = "Это значение не будет передано в вызывающую функцию";
// }

// /// <summary>
// /// Передача параметра по ссылке
// /// </summary>
// static void ParamByRef(ref string param)
// {
//     param = "Это значение будет передано в вызывающую функцию";
// }

// static void ParamOut(int x, out int x2, out int x3)
// {
//     x2 = x * x;
//     x3 = x * x * x;
// }

/// <summary>
///конструкция discard
/// <summary>
// void OutFunction(out int x1, out int x2, out int x3) 
// {
//     x1 = 1;
//     x2 = 2;
//     x3 = 3;
// }

// OutFunction(out int x1, out _, out _);
// Console.WriteLine(x1);

/// <summary>
/// передача неопределённого количества параметров используя ключевое слово params
/// <summary>
// static void ParamArray(string str, params int[] ArrayParams)
// {
//     Console.WriteLine(str);
//     foreach (int i in ArrayParams)
//     {
//         Console.Write(" {0} ", i);
//     }
//     Console.WriteLine();
// }

// ParamArray("Переданные параметры:", 1, 4, 567);

/// <summary>
/// оператор сопоставления в С#
/// <summary>
// object[] array1 = { 1, "строка 1", 2, "строка 2", 3};

// foreach (object obj in array1)
// {
//     if (obj is int a)
//     {
//         Console.WriteLine("Число ->" + a.ToString());
//     }
//     else if (obj is string s)
//     {
//         Console.WriteLine("Строка ->" + s);
//     }
// }

/// <summary>
/// тоже самое но для swith кейса
/// <summary>
// foreach (object obj in array1)
// {
//     switch(obj)
//     {
//         case string s1:
//             Console.WriteLine("Строка -> " + s1);
//             break;
//         case int a when a > 2:
//             Console.WriteLine("Число большее 2 ->" + a.ToString());
//             break;
//         case int a:
//             Console.WriteLine("Число ->" + a.ToString());
//             break;
//     }
// }

/// <summary>
/// switch expression
/// <summary>
// string result21 = str switch
// {
//     "строка1" => "строка1",
//     "строка2" or "строка3" => "строка2 или строка3"//логический or
//     _ => "другая строка" // _ = default
// }

/// <summary>
/// более сложный пример
/// <summary>
// int?[] array2 = {2, null, 3, null};
// foreach (int? obj in array2)
// {
//     string description = obj switch
//     {
//         int i => $"Целое число: {i}",
//         null => "Null",
//     };
//     Console.WriteLine(description);
// }

/// <summary>
/// ЗАДАНИЕ 
/// <summary>
// object[] data = {15, "Hello", -5, null, "World", 42, 0, "C#", -10};

// void GetCategory(object[] matrix)
// {
//     foreach (object obj in matrix)
//     {
//         object description = obj switch
//         {
//             int i when i > 0 => $"Положительное число: {obj}",
//             int i when i == 0 => $"Ноль: {obj}",
//             int i when i < 0 => $"Отрицательное число: {obj}",
//             string i => $"Строка: {obj}",
//             null => "Пустое значение",
//             _ => "Неизвестный тип",
//         };
//         Console.WriteLine(description);
//     }
// }
// GetCategory(data);

/// <summary>
/// ЗАДАНИЕ стр 48
/// <summary>
//int[] numbers = {5, -3, 8, 12, - 7, 0, 15, -2, 4, 20};

// void PrintEvenIndices(int[] matrix)
// {
//     for (int i = 0; matrix.Length > i; i += 2)
//     {
//         Console.WriteLine(matrix[i]);
//     }
// }
// PrintEvenIndices(numbers);

// void CalculateSum(int[] matrix, out int sum)
// {
//     sum = 0;
//     foreach (int i in matrix)
//     {
//         sum += i;
//     }
// }

// int summa;
// CalculateSum(numbers, out summa);
// Console.WriteLine(summa);

// static int FindFirstGreaterThan(int[] matrix, int par)
// {
//     int i = 0;
//     while (i < matrix.Length)
//     {
//         if (matrix[i] > par)
//         {
//             return matrix[i];
//         }
//         i++;
//     }
//     return -1;
// }
// Console.WriteLine(FindFirstGreaterThan(numbers, 16));


// static int PrintUntilSumExceeds(int[] matrix, int par)
// {
//     int i = 0;
//     int sum = 0;
//     do 
//     {
//         sum += matrix[i];
//         Console.WriteLine($"Элемент массива: {matrix[i]}, сумма элементов: {sum}");
//         i++;
//     } 
//     while (par > sum && i < matrix.Length);
//     return sum;
// }
// PrintUntilSumExceeds(numbers, 15);

// void PrintPositiveOnly(int[] matrix)
// {
//     foreach (int num in matrix)
//     {
//         if (num <= 0)
//         {
//             continue;
//         }
//         Console.Write($" {num} ");
//     }
//     Console.WriteLine();
// }
// PrintPositiveOnly(numbers);

///<summary> Основы работы с файлами </summary>

// string catalogName = @"/Users/a1/С#/лекции/лекции по методичке";
// if (Directory.Exists(catalogName))
// {
//     Console.WriteLine("Каталог существует: " + catalogName);
// }
// else 
// {
//     Console.WriteLine("Каьалог не найден: " + catalogName);
// }

///<summary> Создвние каталога </summary>
// string output = @"/Users/a1/С#/лекции/семён";
// if (!Directory.Exists(output))
// {
//     Directory.CreateDirectory(output);
//     Console.WriteLine($"Каталог {output} создан");
// }


// Console.WriteLine("\nСписок файлов каталога " + catalogName);
// string[] files = Directory.GetFiles(@"/Users/a1/С#/лекции/семён");
// foreach (string file in files)
// {
//     Console.WriteLine(file);
// }

// Console.WriteLine("\nСписок подкаталогов каталога " + catalogName);
// string[] dirs = Directory.GetDirectories(catalogName);
// foreach (string dir in dirs)
// {
//     Console.WriteLine(dir);
// }

// string[] reportFiles = Directory.GetFiles(catalogName, "report*.*.txt");

// string[] txtFile = Directory.GetFiles(catalogName, "*.txt");
// foreach (string file in txtFile)
// {
//     Console.WriteLine(file);
// }

// string[] files = Directory.GetFiles(catalogName, "*.txt", SearchOption.TopDirectoryOnly);
// foreach (string file in files)
// {
//     Console.WriteLine(file);
// }

// string[] files = Directory.GetFiles(catalogName, "*.txt", SearchOption.AllDirectories);
// foreach (string file in files)
// {
//     Console.WriteLine(file);
// }


// string[] allFiles = Directory.GetFiles(catalogName);
// Console.WriteLine(allFiles.GetType().FullName, allFiles.Length);
// Console.WriteLine(allFiles.Length);
// foreach (string file in allFiles)
// {
//     Console.WriteLine(file);
// }

/// <summary>
/// "ленивое четние" необходимо для того чтобы экономить память, то есть понадобилось взяли, а не тратить память лишний раз
/// <summary>
// var lazyFile = Directory.EnumerateFiles(catalogName, "*.txt"); //лучше для большого количества файлов потому что не нужно хранить большое количество файлов
// Console.WriteLine(lazyFile.GetType().FullName);
// int i = 0;
// foreach (string file in lazyFile)
// {
//     Console.WriteLine(file);
//     i++;
//     if (i >= 5) break;
// }


// if (File.Exists(FileName))
// {
//     Console.WriteLine("Файл найден: " + FileName);

//     DateTime created = File.GetCreationTime(FileName);
//     DateTime modified = File.GetLastWriteTime(FileName);
//     DateTime accessed = File.GetLastAccessTime(FileName);

//     Console.WriteLine($"Создан: {created:dd.MM.yyyy HH:mm}");
//     Console.WriteLine($"Изменён: {modified:dd.MM.yyyy HH:mm}");
//     Console.WriteLine($"Открывался: {accessed:dd.MM.yyyy HH:mm}");

// }

// Console.WriteLine(Path.GetFileName(FileName)); //имя файла с расширением
// Console.WriteLine(Path.GetFileNameWithoutExtension(FileName)); //без расширения файл
// Console.WriteLine(Path.GetExtension(FileName)); //только расширение файла
// Console.WriteLine(Path.GetDirectoryName(FileName));

// string csvFile = Path.ChangeExtension(FileName, ".csv");
// Console.WriteLine(csvFile);

// string absPath = Path.GetFullPath("семён/er.txt");
// Console.WriteLine(absPath);

// string FileName = @"/Users/a1/С#/лекции/семён/er.txt"; 

// string path3 = Path.Combine(@"c:\docs", "report.txt");
// Console.WriteLine(path3);

// string path4 = Path.Combine(@"c:\docs", "2024", "report.txt");
// Console.WriteLine(path4);

// string appDir = AppContext.BaseDirectory;
// Console.WriteLine(appDir);

/// <summary>
/// ЗАДАНИЕ стр 68
/// <summary>

// Console.WriteLine("Введите путь к каталогу: ");
// string catalogName = Console.ReadLine();

// //для теста путь: /Users/a1/С#/лекции/семён
// if (Directory.Exists(catalogName))
// {
//     string[] files = Directory.GetFiles(catalogName, "*.txt", SearchOption.AllDirectories);
//     foreach (string file in files)
//     {
//         Console.WriteLine($"Путь к файлу: {file}");
//         string fileName = Path.GetFileName(file);
//         Console.WriteLine($"Имя файла: {fileName}");
//         DateTime created = File.GetLastWriteTime(file);
//         Console.WriteLine($"Последнее изменение файла: {created:dd.MM.yyyy HH:mm}");
//         Console.WriteLine();
//     }

// }
// else
// {
//     Console.WriteLine($"Каталога: {catalogName} не существует");
// }

/// <summary>
/// ГЛАВА О ЗАПИСИ ФАЙЛОВ
/// <summary>

// string currentPath = AppContext.BaseDirectory;
// // Console.WriteLine(currentPath);
// Console.WriteLine("Введите текст для записи в файл: ");
// string fileContent = Console.ReadLine();

// string fileName = Path.Combine(currentPath, "file1.txt");
// File.WriteAllText(fileName, fileContent);
// if (File.Exists(fileName))
// {
//     Console.WriteLine("Файл существует.");
//     string readContentFileb = File.ReadAllText(fileName);
//     Console.WriteLine($"Текст из файла: {readContentFileb}");
// }

// Console.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm}");

/// <summary>
/// Пример введения текстового журнала событий
/// <summary>

// string logFile = Path.Combine(AppContext.BaseDirectory, "log.txt");
// File.WriteAllText(logFile, $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] Запуск программы\n");

// File.AppendAllText(logFile, $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] Шаг 1 выполнен\n");
// File.AppendAllText(logFile, $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] Шаг 2 выполнен\n");

// string[] newEvents = 
// {
//     $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] шаг 3 выполнен\n", 
//     $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] завершение программы"
// };

// File.AppendAllLines(logFile, newEvents);
// Console.WriteLine("Содержимое журнала: ");
// Console.WriteLine(File.ReadAllText(logFile));

// Console.WriteLine("Введите строки для записи в файл (пустая строка - окончание ввода):");
// string tempStrTrim = "";

// List<string> list = new List<string>();

// do
// {
//     string tempStr = Console.ReadLine();
//     tempStrTrim = tempStr.Trim();

//     if (tempStrTrim != "")
//     {
//         list.Add(tempStrTrim);
//     }
// }
// while(tempStrTrim != "");

// string file2Name = Path.Combine(AppContext.BaseDirectory, "file2.txt");

// File.WriteAllLines(file2Name, list.ToArray());

// //четние строк
// string[] file2ContentRead = File.ReadAllLines(file2Name);
// Console.WriteLine("Чтение строк из файла: ");
// foreach (string str in file2ContentRead)
// {
//     Console.WriteLine(str);
// }

/// <summary>
/// Разбор текстового файла на подстроки
/// <summary>
// string fileName = Path.Combine(AppContext.BaseDirectory, "poem.txt");
// string fileContent = File.ReadAllText(fileName);

// //разбиваем текст на строки:
// string[] lines = fileContent.Split('\n');
// Console.WriteLine($"Строк в файле: {lines.Length}");

// //разбиваем текст на слова:
// string[] words = fileName.Split(' ');
// Console.WriteLine($"Слов в файле: {words.Length}");

// // Разбивка по нескольим определителям
// char[] separators = {' ', '\n', '\r', '\t'};
// string[] tokens = fileName.Split(separators, StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine($"В файле {tokens.Length} токенов");

// foreach (string line in lines)
// {
//     string[] lineWords = line.Trim().Split(' ');
//     foreach (var item in lineWords)
//     {
//         Console.WriteLine(item.Trim());
//         Console.WriteLine('|');
//     }
//     Console.WriteLine();
// }

//Пример работы с бинарными файлами:
// string sourceFile = Path.Combine(AppContext.BaseDirectory, "image.jpg");
// string destFile = Path.Combine(AppContext.BaseDirectory, "image_copy.jpg");
// //Чтение файла как последовательность байтов
// byte[] fileBytes = File.ReadAllBytes(sourceFile);
// Console.WriteLine($"Размер файлов: {fileBytes.Length} байт");

// File.WriteAllBytes(destFile, fileBytes);
// Console.WriteLine($"Файл {destFile} скопирован");

/// <summary>
/// Задание с 78 страницы
/// <summary>

// string pathNotes = Path.Combine(AppContext.BaseDirectory, "notes.txt");

// if (File.Exists(pathNotes))
// {
//     Console.WriteLine($"Файл заметок {pathNotes} найден");
// }
// else if (!File.Exists(pathNotes))
// {
//     Console.WriteLine($"Файл заметок {pathNotes} не найден, будет создан новый");
//     File.WriteAllText(pathNotes, "");
// }

// int strInt;
// string text;

// do 
// {
//     Console.WriteLine("Выберите действие: ");
//     Console.WriteLine("1 - добавить заметку");
//     Console.WriteLine("2 - показать все заметки");
//     Console.WriteLine("3 - найти заметки по слову");
//     Console.WriteLine("4 - очистить все заметки");
//     Console.WriteLine("0 - завершить программу ");
//     string str = Console.ReadLine();
//     strInt = Convert.ToInt32(str);
//     switch (strInt)
//     {
//         case 1:
//             Console.WriteLine("Пришлите текст заметки: ");
            

//             List<string> textFile = new List<string>();

//             do
//             {
//                 text = Console.ReadLine();

//                 if (text != "")
//                 {
//                     textFile.Add(text);
//                 }

//             } while (text != "");

//             File.WriteAllLines(pathNotes, textFile.ToArray());
//             break;
//         case 2:
//             string[] lines = File.ReadAllLines(pathNotes);
//             int k = 1;
//             foreach (string line in lines)
//             {
//                 Console.WriteLine($"{k}. {line}");
//                 k++;
//             }
//             break;
//         case 3:
//             Console.WriteLine("Пришлите слово для поиска: ");
//             string wordFile = Console.ReadLine();
//             string[] words = File.ReadAllLines(pathNotes);
//             foreach(string word in words)
//             {
//                 if (word.Contains(wordFile))
//                 {
//                     Console.WriteLine(word);
//                 }
//             }
//             break;
//         case 4:
//             File.WriteAllText(pathNotes, "");
//             Console.WriteLine($"Файл {pathNotes} очищен");
//             break;
//         default:
//             Console.WriteLine("Введите другое число");
//             break;
//     }   


// } while (strInt != 0);

/// <summary>
/// Освобождение ресурсов
/// <summary>
// using System;
// using System.Diagnostics;

// using (var file = File.OpenRead("data.txt"))
// {
//     Process(file);
// }

/// <summary>
/// Формирование отчёта
/// <summary>

// using System;
// using System.IO;
// using System.Text;

// // Формирование отчёта
// string[] subjects = {"Математика", "Физика", "Информатика", "История", "Химия", "Английский"};
// int[] scores = { 82, 92, 98, 76, 81, 88};
// string reportFile = Path.Combine(AppContext.BaseDirectory, "report.txt");

// BuildAndSaveReport(subjects, scores, reportFile);
// Console.WriteLine(new string('=', 40));
// foreach (string line in File.ReadLines(reportFile))
// {
//     Console.WriteLine(line);
// }



// ================= ФУНКЦИИ =================
/// <param name="subjects">Массив названий предметов</param>
/// <param name="scores">Массив оценок</param>
/// <param name="filePath">Путь к файлу для сохранения
// static void BuildAndSaveReport(string[] subjects, int[] scores, string filePath)
// {
//     StringBuilder sb = new StringBuilder();
//     sb.AppendLine("========================================");
//     sb.AppendLine(" ОТЧЁТ ОБ УСПЕВАЕМОСТИ ");
//     sb.AppendLine("========================================");
//     sb.AppendFormat("Дата формирования: {0:dd.MM.yyyy HH:mm}\n", DateTime.Now);
//     sb.AppendLine("----------------------------------------");
//     int totalScore = 0;

//     for (int i = 0; i < subjects.Length; i++)
//     {
//         string grade = GetGrade(scores[i]);
//         sb.AppendFormat("{0,-15} {1,3} балла {2}\n", subjects[i], scores[i], grade);
//         totalScore += scores[i];
//     }

//     double average = (double)totalScore / scores.Length;
//     sb.AppendLine("----------------------------------------");
//     sb.AppendFormat("Средний балл: {0:F1}\n", average);
//     sb.AppendFormat("Всего предметов: {0}\n", subjects.Length);
//     sb.AppendLine("========================================");

//     string reportText = sb.ToString(); //достаём из sb строку которая получилась на данный момент и работать дальше с ней можно
//     File.WriteAllText(filePath, reportText);
//     Console.WriteLine($"Отчёт сохранён в {filePath}");
//     Console.WriteLine($"Рзамер отчёта: {reportText.Length}");
//     Console.WriteLine();
// }

// static string GetGrade(int score)
// {
//     return score switch
//     {
//         >= 90 => "Отлично",
//         >= 75 => "Хорошо",
//         >= 60 => "Удовлетварительно",
//         _ => "Неудовлетворительно" 
//     };
// }

/// <summary>
/// задание с 90 стр
/// <summary>

// using System;
// using System.IO;
// using System.Text;
// string pathFile = Path.Combine(AppContext.BaseDirectory, "list.txt");

// StringBuilder sd = new StringBuilder();
// Console.WriteLine($"Введите заметку для файла: {pathFile}");

// int i = 1;
// string str;
// do 
// {
//     str = Console.ReadLine();
//     string strTrim = str.Trim();
//     if (str != "")
//     {
//         sd.AppendLine($"{i}. [{DateTime.Now:dd.MM.yyyy HH:mm}] {strTrim}");
//     }

//     i++;

// } while (str != "");

// string sdStr = sd.ToString(); //доставание введённыё данных из объекта 
// File.WriteAllText(pathFile, sdStr); //добавление введённых колонок в файл и при этом происходит перезапись
// Console.WriteLine("Данные из файла: ");


// foreach (string line in File.ReadLines(pathFile))
// {
//     Console.WriteLine(line);
// }

// using System.Text;

// Console.OutputEncoding = Encoding.UTF8;
// Console.InputEncoding = Encoding.UTF8;

// if (args.Length == 0)
// {
//     Console.Error.WriteLine(" Использлвание:");
//     Console.Error.WriteLine(" produce_consume produce — вывод данных");
//     Console.Error.WriteLine(" produce_consume consume — обработка данных");
//     Console.Error.WriteLine(" produce_consume produce > data.csv — вывод в файл");
//     Console.Error.WriteLine(" produce_consume consume < data.csv — ввод из файла");
//     Console.Error.WriteLine(" produce_consume produce | tool consume — конвейер");
//     return;
// }

// switch (args[0].ToLower())
// {
//     case "produce":
//         Produce();
//         break;
//     case "consume":
//         Consume();
//         break;
//     default:
//         Console.Error.WriteLine($"Неизвестная команда: {args[0]}");
//         break;
// }

// void Produce()
// {
//     string[] cities = { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Казань" };
//     Random rng = new Random(42);
//     for (int i = 0; i < 10; i++)
//     {
//         string city = cities[rng.Next(cities.Length)];
//         int temperature = rng.Next(-25, 36);
//         Console.WriteLine($"{city}:{temperature}");
//     }
//     Console.WriteLine("[produce] сгенерировано 10 измерений");
// }

// void Consume()
// {
//     Dictionary<string, List<int>> data = new();
//     int lineCount = 0;

//     string? line;
//     while ((line = Console.ReadLine()) is not null)
//     {
//         lineCount++;
//         string[] parts = line.Split(";");
//         if (parts.Length != 2 || !int.TryParse(parts[1], out int temp))
//         {
//             Console.Error.WriteLine($"[consume] Пропущена строка: {line}");
//             continue;
//         }
//         string city = parts[0];
//         if (!data.ContainsKey(city))
//             data[city] = new List<int>();
//         data[city].Add(temp);
//     }
//     Console.WriteLine($"Обработано строк: {lineCount}");
//     Console.WriteLine(new string('-', 40));
//     foreach (var pair in data.OrderBy(p => p.Key))
//     {
//         double avg = pair.Value.Average(); //берётся среднее значение из листа соотвествующего ключа
//         int min = pair.Value.Min();
//         int max = pair.Value.Max();
//         Console.WriteLine($"{pair.Key}: среднее={avg}, мин={min}, макс={max}");
//     }
//     Console.Error.WriteLine($"[consume] Обработано {lineCount} строк");
// }

/// <summary>
/// Задание со стр 101
/// <summary>


// string[] surname = {"Попов", "Иванов", "Следнев", "Пуговкин", "Воробъёв"};
// string[] subject = {"Математика", "Русский", "Физика"};

// if (args.Length == 0)
// {
//     Console.Error.WriteLine("[generate] - генерация данных");
//     Console.Error.WriteLine("[filter] - генерация данных");
//     return;
// }

// string param = args[0].ToLower();
// switch(param)
// {
//     case "generate":
//         Generate();
//         break;
//     case "filter":
//         Filter();
//         break;
//     default:
//         Console.Error.WriteLine($"Вы передали неверный параметр: {param}");
//         break;
// }

// void Generate()
// {
//     Random box = new Random(32);
//     for (int i = 0; i < 20; i++)
//     {
//         string surnameRan = surname[box.Next(surname.Length)];
//         string subjectRan = subject[box.Next(subject.Length)];
//         int grade = box.Next(2, 6);
//         Console.WriteLine($"{surnameRan};{subjectRan};{grade}");
//     }
// }

// void Filter()
// {
//     int countLine = 0;
//     string? line;
//     List<string> lines = new();
//     while((line = Console.ReadLine()) is not null)
//     {
//         countLine++;
        
//         string[] lineSplit = line.Split(";");
//         int.TryParse(args[1], out int minGrade);
//         if (int.TryParse(lineSplit[2], out int gr))
//         {
//             if (gr >= minGrade)
//             {
//                 lines.Add(line);     
//             }
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine("Отсортированные строки: ");
//     foreach (string i in lines)
//     {
//         Console.WriteLine(i);
//     }
//     Console.WriteLine($"Всего прочитано {countLine} строк");
// }

/// <summary>
/// Работа со стандартными коллекциями
/// <summary>
// List<int> li = new List<int>();
// li.Add(1);
// li.Add(2);
// li.Add(3);

// List<int> li = new List<int>()
// {
//     1, 2, 3
// };
// List<string> li1_str = new List<string>()
// {
//     "Строка1",
//     "Строка2",
//     "Строка3"
// };
// foreach (string l in li1_str)
// {
//     Console.WriteLine(l);
// }

// List<int> first = [1, 2, 3];
// List<int> second = [4, 5, 6];
// List<int> metod = [.. first, .. second];
// foreach (int i in metod)
// {
//     Console.WriteLine(i);
// }
//Необобщённый список:
// using System.Collections;
// ArrayList al = new ArrayList();
// al.Add(1);
// al.Add("Str");
// al.Add(12.12);
// foreach (object o in al)
// {
//     string type = o.GetType().Name;
//     if (type == "Int32")
//     {
//         Console.WriteLine($"Целое число: {o}");
//     }
//     else if (type == "String")
//     {
//         Console.WriteLine($"Строка: {o}")
//     }
//     else
//     {
//         Console.WriteLine("Другой тип");
//     }
// }

/// <summary>
/// создание стэка
/// <summary/>   

// Stack<int> st = new Stack<int>();
// st.Push(1);
// st.Push(2);
// st.Push(3);
// while (st.Count > 0)
// {
//     int i = st.Pop();
//     Console.WriteLine(i);
// }

/// <summary>
/// Работа с очередью
/// <summary>

// Queue<int> q = new Queue<int>();
// q.Enqueue(11);
// q.Enqueue(22);
// q.Enqueue(33);
// foreach(int i in q)
// {
//     Console.WriteLine(i);
// }

/// <summary>
/// Обобщённый словарь
/// <summary>
// d.Add(1, "строка 1");
// d.Add(2, "строка 2");
// d.Add(3, "строка 3");
//более удобный способ:
// Dictionary<int, string> d = new Dictionary<int, string>
// {
//     [1] = "строка 1", 
//     [2] = "строка 2",
//     [3] = "строка 3"
// };
// foreach (KeyValuePair<int, string> v in d)
// {
//     Console.WriteLine($"{v.Key} - {v.Value}");
// }
// Dictionary<int, string> d = new Dictionary<int, string>()
// {
//     [1] = "строка 1",
//     [2] = "строка 2",
//     [3] = "строка 3"
// };
// int key = 3;
// string val = d[key];
// Console.WriteLine($"Для ключа {key} значение: {val}");

// string val2 = "";
// bool res = d.TryGetValue(key, out val2);
// if (res)
// {
//     Console.WriteLine($"\nДля ключа {key} значение: {val2}");
// }

// Dictionary<int, string> d2 = new() {[1] = "один"};
// bool added1 = d2.TryAdd(2, "Два"); //true
// bool added2 = d2.TryAdd(1, "1 - один"); //false

// foreach(var (k, v) in d2)
// {
//     Console.WriteLine($"Ключ: {k}, значение: {v}")
// }

/// <summary>
/// Задание со стр 116
/// <summary> 
// using System.Collections.Generic;
// List<string> students = new()
// {
//     "Даня",
//     "Иван", 
//     "Слава",
//     "Коля",
//     "Миша"
// };
// foreach(string item in students)
// {
//     Console.WriteLine(item);
// }
// string str = "Глеб";
// students.Add(str);
// if (students.Contains(str))
// {
//     Console.WriteLine($"Студент {str} есть в листе");
// }
// students.Remove("Иван");
// Console.WriteLine("Итоговый список студентов: ");
// int num = 1;
// foreach(string eitem in students)
// {
//     Console.WriteLine($"{num}. {eitem}");
//     num++;
// }

// Stack<string> stud = new();
// stud.Push("Егор");
// stud.Push("Матвей");
// stud.Push("Никита");
// string ver = stud.Peek();
// Console.WriteLine($"Вершина стэка: {ver}");
// Console.WriteLine("Извлечение всех студентов методом pop");
// while (stud.Count > 0)
// {
//     Console.WriteLine(stud.Pop());
// }
// Queue<string> st = new();
// st.Enqueue("Даня");
// st.Enqueue("Саня");
// st.Enqueue("Коля");
// Console.WriteLine($"Первый в очереди: {st.Peek()}");
// Console.WriteLine($"Полная очередь принятия лабораторной работы: ");
// Console.WriteLine(st.Dequeue());
// Console.WriteLine(st.Dequeue());
// Console.WriteLine(st.Dequeue());

// Dictionary<string, int> studentsGrade = new()
// {
//     ["Даня"] = 5,
//     ["Мира"] = 4,
//     ["Ваня"] = 3,
//     ["Паша"] = 4,
//     ["Кирилл"] = 2
// };
// foreach (var (k, v) in studentsGrade)
// {
//     Console.WriteLine($"Пара ключ: {k}, значение: {v}");
// }

// if (studentsGrade.TryGetValue("Мира", out int mira))
// {
//     Console.WriteLine($"Успешно! оценка найдена: {mira}");
// }

// double countGrade = 0;
// int n = 0;
// foreach (var (k, v) in studentsGrade)
// {
//     countGrade += v;
//     n++;
// }
// Console.WriteLine(countGrade/n);

//кортежи
// Tuple<int, string, string> group = new Tuple<int, string, string>(1, "ИУ", "ИУ-5");
// (string strParam, int intParam) tuple1 = ("Строка", 111);
// Console.WriteLine(tuple1.strParam);
// Console.WriteLine(tuple1.intParam);

//иная форма записи кортежа
// var tuple2 = (strParam: "строка", intParam: 111);
// Console.WriteLine(tuple2.strParam);
// Console.WriteLine(tuple2.intParam);
// tuple2.intParam = 12;
// Console.WriteLine(tuple2.intParam);
// static (string strParam, int intParam) OutputTuple()
// {
//     return ("строка", 333);
// }
// var tuple3 = OutputTuple();
// Console.WriteLine(tuple3);


// (string name, int age, _) = GetPerson();
// Console.WriteLine($"{name} {age}");
// static (string name, int age, string city) GetPerson() =>    ("Иван", 18, "Москва");
// static string GetDirection(int dx, int dy) =>
//     (dx, dy) switch
//     {
//         (0, 1) => "Север",
//         (0, -1) => "Юг",
//         (1, 0) => "Восток",
//         (-1, 0) => "Запад",
//         (0, 0) => "Стоп",
//         _ => "Диагональ"
//     };
// Console.WriteLine(GetDirection(0, 1)); // Север
// Console.WriteLine(GetDirection(1, 0)); // Восток
// Console.WriteLine(GetDirection(1, 1)); // Диагональ

/// <summary>
/// Задание со стр 124
/// <summary/>

// Tuple<string, string, int> bibl1 = new Tuple<string, string, int>("Занимательная физика", "Перельман", 1913);
// Console.WriteLine(bibl1.Item1);
// Console.WriteLine(bibl1.Item2);
// Console.WriteLine(bibl1.Item3);

// Console.WriteLine();

// (string title, string author, int year) bibl2 = ("Занимательная физика", "Перельман", 1913);
// Console.WriteLine(bibl2.title);
// Console.WriteLine(bibl2.author);
// Console.WriteLine(bibl2.year);

// List<(string Title, string Author, int Year)> library = new()
// {
//     ("Война и мир", "Толстой", 1869),
//     ("Преступление и наказание", "Достоевский", 1866),
//     ("Мастер и Маргарита", "Булгаков", 1967),
//     ("1984", "Оруэлл", 1949),
//     ("Гарри Поттер", "Роулинг", 1997)
// };

// static (string Oldest, string Newest, double AvgYear) GetBookStats(List<(string Title, string Author, int Year)> books)
// {
//     string oldest = books[0].Title;
//     string newest = books[0].Title;
//     double avgYear = 0;
//     int minYear = books[0].Year;
//     int maxYear = books[0].Year;
//     int countBooks = 0;
//     foreach (var (t, a, y) in books)
//     {
//         if (y > maxYear)
//         {
//             maxYear = y;
//             newest = t;
//         }
//         else if (y < minYear)
//         {
//             minYear = y;
//             oldest = t;
//         }
//         avgYear += y;
//         countBooks++;
//     }
//     return (oldest, newest, avgYear/countBooks);
// }
// var st = GetBookStats(library);
// Console.WriteLine(st.Oldest);
// Console.WriteLine(st.Newest);
// Console.WriteLine(st.AvgYear);
// // Console.WriteLine(st.GetType().Name);

// static string ClassifyBook(string genre, int year) =>
//     (genre, year) switch
//     {
//         ("Роман", < 1900) => "Классический роман XIX века",
//         ("Роман", >= 1900 and < 2000) => "Роман XX века",
//         ("Роман", >=2000) => "Современный роман",
//         ("Фантастика", >= 1990) => "Современная фантастика"
//     }

//записи records


// Book b1 = new Book("Евгений Онегин", "Пушкин", 1833);
// Book b2 = new Book("Евгений Онегин", "Пушкин", 1833);

// Console.WriteLine(b1);
// Console.WriteLine(b1 == b2);

// Book b3 = b1 with {Year = 1837};
// Console.WriteLine(b3.Year);

// record Book(string Title, string Author, int Year);

/// <summary>
/// Задание со стр 129
/// <summary> 

// Person Lev1 = new Person("Лев", 18);
// Person Lev2 = new Person("Лев", 18);

// Console.WriteLine(Lev1 == Lev2);

// Person Lev3 = Lev2 with {Name = "Даня"};
// Console.WriteLine(Lev3.Name);

// Point p = new Point(2.0, 1.4);
// var p2 = p;
// p2 = p2 with {X = 99};
// Console.WriteLine(p2);

// record Person(string Name, int age);
// record struct Point(double X, double Y);

/// <summary>
/// 8 Лекция
/// <summary> 
// class DefaultClass {} //класс виден только в текущей сборке по умолчанию
// public class PublicClass {} //класс виден из любой сборки
// //файл part1.cs
// partial class LargeClass
// {
//     public void Method1() {}
// }
// //файл part2.cs
// partial class LargeClass
// {
//     public void Method2() {}
// }

// using System;
// using System.Collections.Generic;
// using System.Text;

// namespace Classes
// {
//     internal class BaseClass
//     {
//         private int i;

//         //конструктор
//         public BaseClass(int param) {i = param;}

//         //методы с различными сигнатурами
//         public int MethodReturn(int a) {return i;}
//         public string MethodReturn(string a) {return i.ToString();}

//         //Свойство
//         //private значение которое хранит данные для свойства
//         private int _property1 = 0;
//         //объявление свойства
//         public int Property1
//         {
//             get 
//             { 
//                 return _property1;
//             }
//             set
//             {
//                 _property1 = value;
//             }
//         }
//         /// <summary>
//         /// Вычисляемое свойство
//         /// </summary>
//         public int Property1mul2
//         {
//             get 
//             {
//                 return property1*2;
//             }
//         }

//         public string Property2 {get; set;} = "Строка";
//         public float Property3 {get; private set;}

//     }
// }

// Book book1 = new Book();
// book1.SetData("Война и мир", "Толстой");
// Console.WriteLine(book1.GetInfo());

// Book book2 = new Book();
// book2.SetData("kocnw", "nlv", 12, 12);
// Console.WriteLine(book2.GetInfo());

// BaseClass bc1 = new(333);
// Console.WriteLine(bc1.i);

// Book book1 = new Book("Война и мир", "Толстой", 1, 2);
// Console.WriteLine(book1.GetInfo());

// Book book2 = new Book("Война и мир", "Толстой");
// Console.WriteLine(book2.GetInfo());

// Book book3 = new Book();
// Console.WriteLine(book3.GetInfo());

// PrintMessage("Hello");
// PrintMessage("Hello", 3);
// PrintMessage("Hello", 3," | ");
// PrintMessage(count: 50, text: "Hello");
// static void PrintMessage(string text, int count = 1, string separator = ", ")
// {
//     for (int j = 0; j < count; j++)
//     {
//         if (j > 0) 
//             Console.Write(separator);
//         Console.Write(text);
//     }
//     Console.WriteLine();
// }
// int[] data = {1, 2, 3};
// ProcessData(data);
// foreach (var i in data)
// {
//     Console.WriteLine(i);
// }
    

// static void ProcessData(int[] data)
// {
//     int k = 10;
//     //локальные функции
//     int Square(int x) => x*x + k;

//     for (int j = 0; j < data.Length; j++)
//     {
//         data[j] = Square(data[j]) + Square(data[j]);
//     }
//     // static int Square(int x) => x*x;
// }
// switch

// Book book1 = new Book("Война и мир", "Толстой", 1, 2);

// Console .WriteLine(book1.GetInfo());
// Console .WriteLine(book1.GetInfo(showPages: false ));
// // Параметр по умолчанию
// Console .WriteLine($"Старше 50 лет: {book1.IsOlderThan()}");
// Console .WriteLine($"Старше 200 лет: {book1.IsOlderThan(years: 200)}");
// // Локальная функция
// Console .WriteLine(book1.GetFormattedInfo());
// Console .WriteLine(book1.GetFormattedInfo(format: "full" ));

//пример объявления простого свойства
// MyPrim pr = new MyPrim();
// pr.Property1 = 111;
// Console.WriteLine(pr.Property1);
// Console.WriteLine(pr.Property1mul2);

// public class MyPrim()
// {
//     private int property1 = 11;

//     public int Property1
//     {
//         get { return this.property1; }
//         set { property1 = value; }
//     }
//     //вычисляемое свойство
//     public int Property1mul2
//     {
//         get { return property1 * 2; }
//     }

//     public string String1 { get; set; } = "Строка1";
// }
//использование
// var person = new Person
// {
//     FirstName = "Тамара",
//     LastName = "Следнева"
// };
// Console.WriteLine(person.FirstName);
// Console.WriteLine(person.LastName);

// public class Person
// {
//     public string? FirstName { get; init; }
//     public string? LastName { get; init; }
// }
// public class Comparison
// {
//     public string A { get; set; }
//     public string B { get; private set; }
//     public string C { get; }
//     public string D { get; init; }
// }

/// <summary>
/// required свойства:
/// <summary>
// Book1 book0 = new Book1()
// {
//     Title = "Война и семён"
// };
// Console.WriteLine(book0.Title);

// public class Book1
// {
//     public required string Title { get; set; }
//     public int Year { get; set; }
// }

// Book bk = new Book()
// {
//     Title = "Война и мир",
//     Author = "Толстoй",
//     Genre = "роман-эпопея"
// };
// bk.Year = 1600;
// bk.pageCount = 1000;

// Console.WriteLine(bk.AgeInYears);
// Console.WriteLine(bk.ShortDescription);

// class BaseClass
// {
//     private int i;

//     public BaseClass(int param) { i = param;}
//     //финализатор
//     ~BaseClass()
//     {
//         Console.WriteLine($"Финализатор BaseClass вызван дляобъекта с i={i}")
//     }
// }

// CreateBook();

// GC.Collect();
// GC.WaitForPendingFinalizers();

// Console.WriteLine("Конец программы");

// static void CreateBook()
// {
//     Book bk = new Book()
//     {
//         Title = "Война и мир",
//         Author = "Толстой",
//         Genre = "роман-эпопея"
//     };

//     Console.WriteLine(bk.GetInfo());
// }

// Book bk1 = new Book()
// {
//     Title = "Война и мир",
//     Author = "Толстой",
//     Genre = "роман-эпопея"
// };

// Book bk2 = new Book()
// {
//     Title = "Война и мир",
//     Author = "Толстой",
//     Genre = "роман-эпопея"
// };

// Book bk3 = new Book()
// {
//     Title = "Война и мир",
//     Author = "Толстой",
//     Genre = "роман-эпопея"
// };
// Book.PrintStatistics();

// double area = MathHelper.CircleArea(5.0);


// Console.WriteLine(area);

// static class MathHelper
// {
//     //статистическое свойство
//     public static double Pi { get; } = 3.14159265;
//     //статистические методы
//     public static double Square(double x) => x * x;
//     public static double CircleArea(double radius) => Pi * Square(radius);
// }


// Book[] books =
// {
//     new Book("Война и мир", "Толстой", 1869, 1225) { Genre = "Роман" },
//     new Book("1984", "Оруэлл", 1949, 328) { Genre = "Антиутопия" },
//     new Book("Мастер и Маргарита", "Булгаков", 1967, 480) { Genre = "Роман" }
// };
// LibraryUtils.PrintSeparator('=', 40);
// Console.WriteLine(LibraryUtils.FormatBookList(books));
// Console.WriteLine(LibraryUtils.FindOldest(books));
// LibraryUtils.PrintSeparator('=', 40);

// AppSettings fd = new AppSettings();
// Console.WriteLine(AppSettings.mn);
// Console.WriteLine(AppSettings.StartTime);


// class AppSettings
// {
//     public static readonly DateTime StartTime = DateTime.Now;
//     public static readonly string mn;
//     static AppSettings()
//     {
//         mn = c.MachineName;
//     }
// }

// class ExtendedClass : BaseClass //класс ExtendedClass наследуется от BaseClass
// {
//     private int i2;
//     private int i3;
//     public ExtendedClass1(int pi, int pi2) : base(pi)
//     {
//         i2 = pi2;
//     }
//     public ExtendedClass1(int pi, int pi2, pi3) : this(pi, pi2)
//     {
//         i3 = pi3;
//     }

//     public override string ToString()
//     {
//         // return ...
//     }
// }

// sealed class FinalClass : BaseClass
// {
//     public FinalClass(int param) : base(param)
//     { }
// }
// public ExtendedClass(int pi, int pi2) : base(pi) //base - базовый класс, через него происходит инициализация переменных с модификатором доступа private
// {
//     i2 = pi2;
// }
// DerivedClass d = new DerivedClass();
// d.Print();


// class BaseClass
// {
//     public void Print()
//     {
//         Console.WriteLine("Метод из BaseClass");
//     }
// }

// class DerivedClass : BaseClass
// {
//     public new void Print()
//     {
//         base.Print();
//         Console.WriteLine("Метод из DerivedClass");
//     }
// }
// class BaseClass
// {
//     public int Value { get; set; } = 10;

//     public void Print()
//     {
//         Console.WriteLine($"BaseClass: Value = {Value}");
//     }
// }
// BaseClass obj = new ExtendedClass1(1, 2);
// //оператор is проверка типа
// if (obj is ExtendedClass1)
// {
//     Consol.WriteLine("obj является ExtendedClass1");
// }

// if (obj is ExtendedClass1 ext)
// {
//     Console.WriteLine(ext.ToString());
// }

/// <summary>
/// задание с 167
/// </summary>
// LibraryItem[] items = 
// {
//     new Book("Война и мир", "Толстой", 1869, 1225) { Genre = "роман-эпопея"},
//     new Magazine("Правда", 1912, 1, "Правда так же"),
//     new Book("Капитанская дочка", "Пушкин", 1836, 200) { Genre = "Исторический роман"},
//     new Magazine("Русское слово", 1900, 8, "Сытин")
// };
// Console.WriteLine($"всего объектов: {Book.TotalCount}");

// foreach (var item in items)
// {
//     if (item is Book book)
//     {
//         Console.WriteLine($"Книга, автор: {book.Author}, жанр: {book.Genre}");
//     }
//     else if (item is Magazine mag)
//     {
//         Console.WriteLine ( $"Журнал, выпуск # { mag.IssueNumber } , изд-во: { mag.Publisher }" );
//     }
// }
// class ExtendedClass2 : BaseClass
// {
//     private string name;

//     public ExtendedClass2(int pi, string pName) : base(pi)
//     {
//         name = pName;
//     }

//     public override string GetInfo()
//     {
//         return base.GetInfo() + $", name = {name}";
//     }
// }

// BaseClass[] items = new BaseClass[]
// {
//     new BaseClass(1),
//     new ExtendedClass1(2, 20),
//     new ExtendedClass2(3, "объект")
// };

// foreach (BaseClass item in items)
// {
//     Console.WriteLine(item.GetInfo());
// }
// Base obj1 = new DerivedOverride();
// Base obj2 = new DerivedNew();

// Console.WriteLine(obj1.Method());
// Console.WriteLine(obj2.Method());


// class Base
// {
//     public virtual string Method() => "Base";
// }

// class DerivedOverride : Base
// {
//     public override string Method() => "DerivedOverride";
// }

// class DerivedNew : Base
// {
//     public new string Method() => "DerivedNew";
// }

// Shape circle = new Circle(5.0);
// Shape rect = new Rectangle(3.0, 4.0);

// circle.PrintInfo();
// rect.PrintInfo();

// Shape[] shapes = { circle, rect };
// double TotalArea = 0;
// foreach (var s in shapes)
// {
//     TotalArea += s.Area();
// }

// Console.WriteLine(TotalArea);




// abstract class Shape
// {
//     public string Name { get; }

//     public Shape(string name) { Name = name; }

//     public abstract double Area();

//     public void PrintInfo()
//     {
//         Console.WriteLine($"{Name}: площадь = {Area():F2}");
//     }
// }

// class Circle : Shape
// {
//     public double Radius { get; }

//     public Circle(double radius) : base("круг")
//     {
//         Radius = radius;
//     }
//     public override double Area() => Math.PI * Radius * Radius;
// }

// class Rectangle : Shape
// {
//     public double Width { get; }
//     public double Height { get; }
//     public Rectangle(double width, double height) : base("Прямоугольник")
//     {
//         Width = width;
//         Height = height;
//     }
    
//     public override double Area() => Width * Height;
// }

// LibraryItem[] catalog =
// {
//     new Book ( "Война и мир", "Толстой" , 1869, 1225) { Genre = "Роман" },
//     new Magazine ( "Наука и жизнь" , 2025, 3, "Пресса" ),
//     new Book ( "1984" , "Оруэлл" , 1949, 328) { Genre = "Антиутопия" },
//     new Magazine ( "National Geographic" , 2024, 12, "NatGeo" )
// };

// // Полиморфизм — один цикл, разное поведение
// Console.WriteLine( "=== Каталожные карточки ===" );

// foreach ( LibraryItem item in catalog)
// {
//     Console.WriteLine(item.GetCardInfo());
// }

// Console.WriteLine( "\n=== Описания ===" );

// foreach ( LibraryItem item in catalog)
// {
//     Console . WriteLine ( item .Description);
// }

// static class ExtendedClass2Extension
// {
//     public static int ExtendedClass2NewMethod(this ExtendedClass2 ec2, int i)
//     {
//         return i + 1;
//     }
// }

// ExtendedClass2 obj = new ExtendedClass2(1, "test");

// int result = obj.ExtendedClass2NewMethod(2)

// Book book1 = new("Война и мир", "Толстый", 1869, 1225) 
// {
//     Genre = "Роман-эпопея"
// };

// Magazine mag = new("Наука и жизнь" , 2025, 3, "Пресса");
// Console.WriteLine($"<{book1.Title}> новинка? {book1.IsNew}");

// try
// {
//     Book book1 = new("Война и мир", "", 100, 1225) { Genre = "Жанр"};
// }
// catch (InvalidBookDataException e)
// {
//     Console.WriteLine("Ошибка данных книги");
//     Console.WriteLine(e.Message);
// }
// catch (LibraryException e)
// {
//     Console.WriteLine("Ошибка библиотеки:");
//     Console.WriteLine(e.Message);
// }
// catch (Exception e)
// {
//     Console.WriteLine("Другая ошибка:");
//     Console.WriteLine(e.Message);
// }
// finally
// {
//     Console.WriteLine("Проверка завершена.");
// }

/// <summary>
/// ИСПОЛЬЗОВАНИЕ УСЛОВИЙ
/// </summary>
// catch (DivideByZeroException) when (attempt < 3)
// {
//     Console.WriteLine("Предупреждение 1");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Предупреждение 2");
// }

// try
// {
//     Book book1 = new(title: "Война и мир", author: null, year: 1000, pageCount: 100) { Genre = "Жанр"};
// }
// catch (InvalidBookDataException e) when (e.Message == "Количество страниц должно быть больше нуля")
// {
//     Console.WriteLine(e.Message);
// }
// catch (InvalidBookDataException e) when (e.Message == "Автор книги не может быть пустым.")
// {
//     Console.WriteLine(e.Message);
// }

// catch (LibraryException e)
// {
//     Console.WriteLine("Ошибка библиотеки:");
//     Console.WriteLine(e.Message);
// }
// catch (Exception e)
// {
//     Console.WriteLine("Другая ошибка:");
//     Console.WriteLine(e.Message);
// }
// finally
// {
//     Console.WriteLine("Проверка завершена.");
// }

// IEquatable<Number>
/// <summary>
/// 
// Catalog<Book> bookCatalog = new();
// Catalog<Magazine> magazineCatalog = new();

// bookCatalog.Add(new Book("Война и мир", "Лев Толстой", 1869, 1225)
// {
//     Genre = BookGenre.Novel
// });

// bookCatalog.Add(new Book("1984", "Джордж Оруэлл", 1949, 328)
// {
//     Genre = BookGenre.SciFi
// });

// bookCatalog.Add(new Book("Краткая история времени", "Стивен Хокинг", 1988, 256)
// {
//     Genre = BookGenre.Science
// });

// magazineCatalog.Add(new Magazine("Наука и жизнь", 2024, 5, "Наука"));
// magazineCatalog.Add(new Magazine("Вокруг света", 1999, 12, "Вокруг света"));
// magazineCatalog.Add(new Magazine("Популярная механика", 2010, 3, "Hearst"));

// Console.WriteLine("=== Каталог книг ===");
// bookCatalog.PrintAll();

// Console.WriteLine();

// Console.WriteLine("=== Каталог журналов ===");
// magazineCatalog.PrintAll();

// Console.WriteLine();

// Console.WriteLine("=== Старые книги старше 50 лет ===");
// List<Book> oldBooks = bookCatalog.FindOlderThan<Book>(50);

// foreach (Book book in oldBooks)
// {
//     Console.WriteLine(book.GetInfo());
// }

// Console.WriteLine();

// Console.WriteLine("=== CatalogUtils.PrintInfo ===");

// Book exampleBook = new Book("Мастер и Маргарита", "Михаил Булгаков", 1967, 480)
// {
//     Genre = BookGenre.Novel
// };

// Magazine exampleMagazine = new Magazine("Forbes", 2020, 7, "Forbes Media");

// CatalogUtils.PrintInfo(exampleBook);
// CatalogUtils.PrintInfo(exampleMagazine);

/// <summary>
/// Делегалы 
/// </summary>

//создание делегала и создание анонимного метода
// PlusOrMinus p3 = delegate(int p1, int p2)
// {
//     return p1 + p2;
// };

// // int p0 = p3(5, 2);
// // Console.WriteLine(p0);
// PlusOrMinus ang = new PlusOrMinus(ProgramG.Plus);
// Console.WriteLine(ang(1, 4));




// /// <summary>
// /// Лямбда-выражения
// /// </summary>

// PlusOrMinus pm = (int p1, int p2) =>
// {
//     return p1 + p2;
// };
// delegate int PlusOrMinus(int p1, int p2);

// class ProgramG
// {
//     public static int Plus(int p1, int p2)
//     {
//         return p1 + p2;
//     }

//     public static int Minus(int p1, int p2)
//     {
//         return p1 - p2;
//     }
// }

/// <summary>
/// LINQ 
/// </summary>

//если например стоит задача в получении списка сотрудников, то решение без LINQ:
//это 1 шаг: нахождение ID среды работы
//2 шаг: потом используя ID находим всех рабочих
//дальше 3 шагом сортируем любым методом и 4 шагом вывод

//с LINQ
using System.Linq;
// var result = from emp in employees 
//              join dep in departments on emp.DepartmentId equals dep.Id 
//              where dep.Name == "Разработка" 
//              orderby emp.Salary descending
//              select new {emp.Name, emp.Salary };
            
// foreach (var item in result)
// {
//     Console.WriteLine($"Имя: {item.Name} - {item.Salary}");
// }
// //выборка и проекция select
// var q1 = from emp in employees select emp;
// foreach (var emp in q1)
//     Console.WriteLine(emp);
//проекция - это выбор отдельных полей или создание новых объектов на основании существующих
//проекция выбор только имён
// var q2 = from emp in employees select emp.Name;
// foreach(var emp in q2)
//     Console.WriteLine(emp);
// //для получении только имени и зарплаты:
// var q3 = from emp in employees select new { emp.Name, emp.Salary };
// foreach (var emp in q3)
//     Console.WriteLine(emp);

// var q4 = from emp in employees
//          where emp.Salary > 140000 && emp.DepartmentId == 1
//          select emp;
// foreach (var emp in q4)
//     Console.ReadLine($"имя {emp.Name} зп {emp.Salary}");

//для фильтрации по типу объекта используется OfType<T>
// object[] item = {"строка", true, 3.13, "строоокаа", 7};
// var strings = item.OfType<string>();
// foreach(var i in strings)
//     Console.WriteLine(i);

// var q5 = from emp in employees
//          orderby emp.DepartmentId, emp.Salary descending
//          select emp;

// var q6 = from emp in employees
//          join dep in departments on emp.DepartmentId equals dep.Id
//          select new { emp.Name, Department = dep.Name, }
var departments = new List<Department>
{
    new Department { Id = 1, Name = "Разработка" },
    new Department { Id = 2, Name = "Тестирование" },
    new Department { Id = 3, Name = "Аналитика" }
};

var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Иванов", DepartmentId = 1, Salary = 150000 },
    new Employee { Id = 2, Name = "Петрова", DepartmentId = 1, Salary = 180000 },
    new Employee { Id = 3, Name = "Сидоров", DepartmentId = 2, Salary = 120000 },
    new Employee { Id = 4, Name = "Козлова", DepartmentId = 1, Salary = 160000 },
    new Employee { Id = 5, Name = "Николаев", DepartmentId = 3, Salary = 140000 },
    new Employee { Id = 6, Name = "Морозова", DepartmentId = 2, Salary = 130000 }
};

var projects = new List<Project>
{
new Project { Id = 101, Title = "Сайт", Budget = 500000 },
new Project { Id = 102, Title = "Мобильное приложение", Budget = 800000 },
new Project { Id = 103, Title = "Аналитическая платформа", Budget = 1200000 }
};

var q7 = from dep in departments
    join emp in employees 
    on dep.Id equals emp.DepartmentId
    into deptEmployees
    select new { dep.Name, Employees = deptEmployees};

foreach (var item in q7)
{
    Console.WriteLine($" {item.Name}:");
    foreach(var emp in item.Employees)
    {
        Console.WriteLine($"{emp.Name} --- {emp.Salary}" );
    }
}
