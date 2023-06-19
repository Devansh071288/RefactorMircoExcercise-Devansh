using System;
namespace TDDMicroExercises.TurnTicketDispenser.SomeDependencies
{
    public class TicketDispenserClient
    {
        // A class with the only goal of simulating a dependency on TicketDispenser
        // that has impact on the refactoring.

        private readonly TicketDispenser _ticketDispenser;
        public TicketDispenserClient(TicketDispenser ticketDispenser)
        // An IOC container will be responsible for providing this dependency via constructor injection
        {
            _ticketDispenser = ticketDispenser;
            GetTickets();
        }

        private void GetTickets()
        {
            _ticketDispenser.GetTurnTicket();
            _ticketDispenser.GetTurnTicket();
            _ticketDispenser.GetTurnTicket();
        }
    }
}