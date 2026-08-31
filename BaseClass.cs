// public class BaseClass
// {
//     private int i;
//     public BaseClass() {}
//     public BaseClass(int param) { this.i = param; }
// }

// Class MyClass
// {
//     private static int counter;
//     //Статистический конструктор
//     static MyClass()
//     {
//         //Выполняется один раз при первом обращении к классу
//         counter = 0;
//         Console.WriteLine("Статистический конструктор вызван");
//     }
//     //обычный конструктор
//     public MyClass()
//     {
//         counter++;
//     }
// }

//первичный конструктор:
// class BaseClass(int param)
// {
//     private int param;
//     public int GetValue() => i;
//     public void PrintValue()
//     {
//         Console.WriteLine($"Параметр: {param}");
//     }
//     public BaseClass() : this(0) {}
// }

//полна форма:
// public int MethodReturn(int i) {return i;}
// public string MethodReturn(string i) {return i.ToString();}

// //сокращённая форма с#6
// public int MethodReturn(int i) => i;
// public string MethodReturn(string i) => i.ToString();