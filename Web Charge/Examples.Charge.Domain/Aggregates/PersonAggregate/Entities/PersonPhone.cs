using Abp.Events.Bus;
using System;
using System.Collections.Generic;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Entities
{
    public class PersonPhone
    {
        public PersonPhone() { }

        public PersonPhone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public int BusinessEntityID { get; set; }

        public string PhoneNumber { get; set; }

        public int PhoneNumberTypeID { get; set; }

        public Person Person { get; set; }

        public PhoneNumberType PhoneNumberType { get; set; }

        public ICollection<IEventData> DomainEvents => throw new NotImplementedException();
    }
}
