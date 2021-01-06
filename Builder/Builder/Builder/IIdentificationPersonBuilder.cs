using Builder.Product;
using System;
using System.Net.Mail;

namespace Builder.Builder
{
    public interface IIdentificationPersonBuilder
    {
        IIdentificationPersonBuilder SetName(string name);
        IIdentificationPersonBuilder SetOtherName(string otherName);
        IIdentificationPersonBuilder SetDayOfBirth(DateTime date);
        IIdentificationPersonBuilder SetGender(EnumType.Gender gender);
        IIdentificationPersonBuilder SetEthnic(string ethic);
        IIdentificationPersonBuilder SetAddress(string address);
        IIdentificationPersonBuilder SetMail(MailAddress mail);
        IdentificationPerson Build();
    }
}
