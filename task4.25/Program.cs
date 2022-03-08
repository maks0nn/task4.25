using System;

namespace Task4._25 {
    internal class Program

{
    public static void Main(string[] args)

{
    string [] name ={"Боинг", "Аэробус", "Антонов", "Туполев", "Суперджет"}

;
Random r = new Random();
for (int i = 0; i < 5; i++) {
    Plaen m = new Plaen(name[r.Next(5)], 1 + r.Next(25), 25 + r.Next(100));
    Console .WriteLine(m.getInfo());
}

for (int i = 0; i < 5; i++) {
    Plaen m = new Country(name[r.Next(5)], 1 + r.Next(25), 25 + r.Next(100), 2 + r.Next(23));
    Console .WriteLine(m.getInfo());
}

Console.ReadKey();
}
}
}
