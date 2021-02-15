using System;

namespace Widget {
    class Program {
        static void Main(string[] args) {

            var w1 = new Widget("LARGE", "RED");
            Console.WriteLine($"A {w1.Size}, {w1.Color} widget costs {w1.Price()}");
            var wsw = new Widget("SMALL", "WHITE");
            Console.WriteLine($"A {wsw.Size}, {wsw.Color} widget costs {wsw.Price()}");
        }
    }
}
