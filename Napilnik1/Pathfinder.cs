namespace Napilnik1
{
    class Pathfinder
    {
        private readonly ILogger logger;

        public Pathfinder(ILogger logger) => this.logger = logger;

        public void Find() => logger.Log("error");
    }
}