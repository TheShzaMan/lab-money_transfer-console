using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class SimulationSP
    {
        public Random rnd;
        public SimulationSP()
        {
            rnd = new Random();
        }
        // á, é, í, ó, ú, ü, ñ, ¿, and ¡ on your keyboard? ¡No
        public void RunSimulation()
        {
            Console.WriteLine($"Iniciando la simulación \n" +
                $"...presiona 'ENTER' para continuar."); Console.ReadLine();
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            Person seamus = new Person("Seamus", rnd.Next(1000));
            Person aideth = new Person("Aideth", rnd.Next(1000));
            Person shea = new Person("Shea", rnd.Next(1000));
            Person elia = new Person("Elia", rnd.Next(1000));
            Person bomba = new Person("Bomba", rnd.Next(1000));

            Person[] people = { seamus, aideth, elia, shea, bomba };

            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            foreach (Person person in people)
            {
                person.DisplayInfo();
            }
            //seamus.DisplayInfo();
            //aideth.DisplayInfo();
            //elia.DisplayInfo();
            //shea.DisplayInfo();
            //bomba.DisplayInfo();
            Console.WriteLine($"\nimpresa 'ENTER' para iniciar la simulación"); Console.ReadLine();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            people[rnd.Next(0, 5)].TransferMoney(people[rnd.Next(0, 5)], rnd.Next(500));


            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            foreach (Person person in people)
            {
                person.DisplayInfo();
            }
            //seamus.DisplayInfo();
            //aideth.DisplayInfo();
            //elia.DisplayInfo();
            //shea.DisplayInfo();
            //bomba.DisplayInfo();

            Console.WriteLine($"\nSimulación finalizada.");
        }
        
    }
}
