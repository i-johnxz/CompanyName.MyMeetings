using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Meetings.Domain.MeetingGroupProposals
{
    public class MeetingGroupProposalStatus : ValueObject
    {
        internal static MeetingGroupProposalStatus InVerification => new MeetingGroupProposalStatus(nameof(InVerification));
        
        internal static MeetingGroupProposalStatus Accepted => new MeetingGroupProposalStatus(nameof(Accepted));

        public string Value { get; set; }

        public MeetingGroupProposalStatus(string value)
        {
            Value = value;
        }
    }
}