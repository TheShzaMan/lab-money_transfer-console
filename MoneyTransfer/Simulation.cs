using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Random rnd;
        public List<Person> people;

        public Simulation()
        {
            rnd = new Random();
        }
        public void RunSimulation()
        {
            InitializeStartingValues();

            Console.WriteLine($"Starting simulation\n" +
                $"...press enter to continue."); Console.ReadLine();

            ContinueSimulation(people);

            DoAnotherTransfer();

            Console.WriteLine($"\nSimulation complete.");
        }

        public List<Person> InitializeStartingValues()
        {
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            Person seamus = new Person("Seamus", rnd.Next(1000));
            Person aideth = new Person("Aideth", rnd.Next(1000));
            Person shea = new Person("Shea", rnd.Next(1000));
            Person elia = new Person("Elia", rnd.Next(1000));
            Person bomba = new Person("Bomba", rnd.Next(1000));

            //Person[] people = { seamus, aideth, elia, shea, bomba };
            List<Person> people = new List<Person> { seamus, aideth, elia, shea, bomba };
            this.people = people;
            return this.people;

        }
        public void ContinueSimulation(List<Person> people)
        {
            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            //People theGroup = new People(people);
            foreach (Person person in people)
            {
                person.DisplayInfo();
            }
            //seamus.DisplayInfo();
            //aideth.DisplayInfo();
            //elia.DisplayInfo();
            //shea.DisplayInfo();
            //bomba.DisplayInfo();
            Console.WriteLine($"\npress enter to initiate a money transfer"); Console.ReadLine();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            Person giver = people[rnd.Next(0, 5)];
            Person receiver = people[rnd.Next(0, 5)];
            while (giver == receiver)
            {
                giver = people[rnd.Next(0, 5)];
                receiver = people[rnd.Next(0, 5)];
            }
            giver.TransferMoney(receiver, rnd.Next(500));
            //people[rnd.Next(0,5)].TransferMoney(people[rnd.Next(0,5)], rnd.Next(500));

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            foreach (Person person in people)
            {
                person.DisplayInfo();
            }
        }
        public void DoAnotherTransfer()
        {
            Console.WriteLine($"\n\nWould you like to do another money transfer? y/n");
            string againInput = Console.ReadLine();

            if (againInput == "y" || againInput == "Y")
            {
                ContinueSimulation(people);
                DoAnotherTransfer();
            }
            else if (againInput == "n" || againInput == "N")
            {
            }
            else
            {
                Console.WriteLine("Invalid response. Enter 'y' for another or enter 'n' to end");
                DoAnotherTransfer();
            }
        }
        
    }
}
