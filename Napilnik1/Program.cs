using System;

namespace Napilnik1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fridayLogStrategy = new ExactDayLogStrategy(DayOfWeek.Friday);

            Logger firstLogger = new Logger(new FileSubLogger());
            Logger secondLogger = new Logger(new ConsoleSubLogger());
            Logger thirdLogger = new Logger(new FileSubLogger(fridayLogStrategy));
            Logger fourthLogger = new Logger(new ConsoleSubLogger(fridayLogStrategy));
            Logger fifthLogger = new Logger(new ConsoleSubLogger(), new FileSubLogger(fridayLogStrategy));

            Pathfinder first = new Pathfinder(firstLogger);
            Pathfinder second = new Pathfinder(secondLogger);
            Pathfinder third = new Pathfinder(thirdLogger);
            Pathfinder fourth = new Pathfinder(fourthLogger);
            Pathfinder fifth = new Pathfinder(fifthLogger);

            first.Find();
            second.Find();
            third.Find();
            fourth.Find();
            fifth.Find();
            Console.ReadKey();
        }
    }
}