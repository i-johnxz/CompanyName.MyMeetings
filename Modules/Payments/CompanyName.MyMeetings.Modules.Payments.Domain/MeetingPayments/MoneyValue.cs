﻿using CompanyName.MyMeetings.BuildingBlocks.Domain;

namespace CompanyName.MyMeetings.Modules.Payments.Domain.MeetingPayments
{
    public class MoneyValue : ValueObject
    {
        public decimal? Value { get; }

        public string Currency { get; }

        public MoneyValue(decimal? value, string currency)
        {
            Value = value;
            Currency = currency;
        }

        public static bool operator > (decimal left, MoneyValue right) => left > right.Value;

        public static bool operator < (decimal left, MoneyValue right) => left < right.Value;

        public static bool operator >=(decimal left, MoneyValue right) => left >= right.Value;
        
        public static bool operator <=(decimal left, MoneyValue right) => left <= right.Value;
        
        public static bool operator > (MoneyValue left, decimal right) => left.Value > right;

        public static bool operator < (MoneyValue left, decimal right) => left.Value < right;
        
        public static bool operator >= (MoneyValue left, decimal right) => left.Value >= right;

        public static bool operator <= (MoneyValue left, decimal right) => left.Value <= right;
    }
}