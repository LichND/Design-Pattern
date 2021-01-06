using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    public class IdentificationPerson
    {
        private string name;
        private string otherName;
        private DateTime dateOfBirth;
        private string address;
        private string ethic;
        private EnumType.Gender gender;
        private MailAddress mail;

        public IdentificationPerson(string name, string otherName, DateTime dateOfBirth, string address, string ethic, EnumType.Gender gender, MailAddress mail)
        {
            this.name = name;
            this.otherName = otherName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.ethic = ethic;
            this.gender = gender;
            this.mail = mail;
        }

        public override string ToString()
        {
            return $"name: {name}, gender: {gender.ToString()}, other name: {otherName}, dateOfBirth: {dateOfBirth.ToShortDateString()}, address {address}, ethic: {ethic}, mail: {mail?.Address}";
        }
    }
}
