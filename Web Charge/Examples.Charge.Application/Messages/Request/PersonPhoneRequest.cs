namespace Examples.Charge.Application.Messages.Request
{
    public class PersonPhoneRequest
    {
        public string PhoneNumber { get; set; }
        public int PersonId { get; set; }
        public int PhoneNumberTypeId { get; set; }
    }
}
