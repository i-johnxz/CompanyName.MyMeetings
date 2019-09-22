﻿using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Meetings.Domain.Meetings
{
    public class MeetingAttendeeRole : ValueObject
    {
        public static MeetingAttendeeRole Host => new MeetingAttendeeRole("Host");
        
        public static MeetingAttendeeRole Attendee => new MeetingAttendeeRole("Attendee");
        
        public string Value { get; }

        public MeetingAttendeeRole(string value)
        {
            Value = value;
        }
    }
}