
using System.Text;

namespace C_Sharp_P58            // простори імен групують класи
{
    internal class Program       // весь код групується у класах (методах)   
    {                            // поза класами код не створюється
        static void Main(string[] args)   // першим запускається даний метод
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding  = Encoding.UTF8;

            Console.WriteLine("Платформа Microsoft .NET та мова програмування C#");
            
            new Intro.VarsTypes().Run();  // видаляти об'єкти немає потреби,
            // за це відповідає окремий модуль платформи - GC Garbage Collector
        }
    }
}
/* 
Платформа Microsoft .NET та мова програмування C#
C# (C-Sharp) - мова 4 покоління (4GL), що базується на платформі .NET
Загальна ідея:
програма мовою C# компілюється (транслюється) до проміжної мови
 MSIL (Microsoft Intermediate Language), схожою на Асемблер.
Цей файл з проміжним байт-кодом є виконавчим (.ехе) і опрацьовується
платформою, яка "на льоту" (just in time, JIT) докомпільовує його
до процесорного коду, який реально виконується.

JScript----\          |    |
VisualBasic-\         |.NET|
C# (text) --> MSIL -->| JIT| ---> CPU
F# ---------/         |CLR |
C++.NET----/          |    |
                     Managed   Unmanaged

Така схема виконання дозволяє зробити мову програмування придатною
для різних операційних платформ (Windows, Linux, Mac, Android тощо)
для яких випускаються різні збірки .NET, які приймають однакові програми.

IDE (Integrated Development Equipment - устаткування розробника)
 Microsoft Visual Studio
 Jetbrains Rider
 Mono
 VS Code

CLR - Common Language Runtime - середовище виконання (спільне для різних мов)
JIT - Just In Time Compiller - компілятор виконання (перетворювач IL коду
      до процесороного)
FCL - Framework Class Library - набір бібліотек класів для використання
      у програмах .NET
 */