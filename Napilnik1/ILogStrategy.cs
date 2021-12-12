using System;

namespace Napilnik1
{
    interface ILogStrategy
    {
        bool ShouldILog { get; }
    }

    class NormalLogStrategy : ILogStrategy
    {
        public bool ShouldILog => true;
    }

    class ExactDayLogStrategy : ILogStrategy
    {
        private readonly DayOfWeek dayOfWeek;

        public ExactDayLogStrategy(DayOfWeek dayOfWeek) => this.dayOfWeek = dayOfWeek;

        public bool ShouldILog => DateTime.Now.DayOfWeek == dayOfWeek;
    }
}