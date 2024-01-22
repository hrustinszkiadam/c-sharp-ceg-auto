using System;
using System.Collections.Generic;
using System.Linq;

namespace ceg_auto;

class Program {
    static void Main(string[] args) {
        Ceg ceg = new("Cég", new Benzinkut(500, 600, 75000), [
            new Auto("Audi", "Jacob", 15000, 6, 50, 24),
            new Auto("BMW", "John", 20000, 5, 60, 12),
            new Auto("Mercedes", "Peter", 10000, 7, 55, 35),
            new Auto("Opel", "Mark", 25000, 8, 65, 40),
            new Auto("Volkswagen", "Paul", 5000, 10, 70, 60)
        ]);

        ceg.AutokElkuldese();

        Console.WriteLine("A szimuláció véget ért.");

        Console.ReadKey();
    }
}
