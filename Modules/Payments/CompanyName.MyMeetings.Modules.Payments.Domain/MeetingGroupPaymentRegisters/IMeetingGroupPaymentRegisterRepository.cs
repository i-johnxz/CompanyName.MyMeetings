using System.Threading.Tasks;

namespace CompanyName.MyMeetings.Modules.Payments.Domain.MeetingGroupPaymentRegisters
{
    public interface IMeetingGroupPaymentRegisterRepository
    {
        Task AddAsync(MeetingGroupPaymentRegister groupPaymentRegister);

        Task<MeetingGroupPaymentRegister> GetByIdAsync(MeetingGroupPaymentRegisterId paymentRegisterId);
    }
}