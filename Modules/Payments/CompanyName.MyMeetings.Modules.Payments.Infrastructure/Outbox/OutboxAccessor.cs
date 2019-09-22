using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Outbox;

namespace CompanyName.MyMeetings.Modules.Payments.Infrastructure.Outbox
{
    public class OutboxAccessor : IOutbox
    {
        private readonly PaymentsContext _paymentsContext;

        public OutboxAccessor(PaymentsContext paymentsContext)
        {
            _paymentsContext = paymentsContext;
        }

        public void Add(OutboxMessage message)
        {
            _paymentsContext.OutboxMessages.Add(message);
        }
    }
}