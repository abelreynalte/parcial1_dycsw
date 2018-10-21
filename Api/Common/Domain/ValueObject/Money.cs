﻿using DyCswParcial1.Api.Common.Application.Enum;

namespace DyCswParcial1.Api.Common.Domain.ValueObject
{
    public class Money
    {
        public decimal Amount { get; }
        public Currency Currency { get; }

        public Money()
        {
        }

        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money dollars(decimal amount)
        {
            return new Money(amount, Currency.USD);
        }

        public static Money soles(decimal amount)
        {
            return new Money(amount, Currency.PEN);
        }

        public static Money euros(decimal amount)
        {
            return new Money(amount, Currency.EUR);
        }
    }
}
