using System;
using System.Linq;

namespace Napilnik1
{
    public class Logger : ILogger
    {
        private readonly ILogger[] subloggers;

        public Logger(params ILogger[] loggers)
        {
            if (loggers.Any(logger => logger == null))
                throw new InvalidOperationException(nameof(loggers));

            subloggers = loggers;
        }

        public void Log(string message)
        {
            Console.WriteLine("\n");
            foreach (var logger in subloggers)
                logger.Log(message);
        }
    }

    abstract class SubLogger : ILogger
    {
        protected readonly ILogStrategy strategy;

        public SubLogger(ILogStrategy strategy) => this.strategy = strategy ?? throw new InvalidOperationException(nameof(strategy));

        public SubLogger() => strategy = new NormalLogStrategy();

        public abstract void Log(string message);
    }

    class ConsoleSubLogger : SubLogger
    {
        public ConsoleSubLogger(ILogStrategy strategy) : base(strategy) { }
        public ConsoleSubLogger() : base() { }

        public override void Log(string message)
        {
            if (strategy.ShouldILog)
                Console.WriteLine("I Log on console");
            //Console.WriteLine(message);
        }
    }

    class FileSubLogger : SubLogger
    {
        public FileSubLogger(ILogStrategy strategy) : base(strategy) { }
        public FileSubLogger() : base() { }

        public override void Log(string message)
        {
            if (strategy.ShouldILog)
                Console.WriteLine("I Log on file");
            //File.WriteAllText("log.txt", message);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }
}