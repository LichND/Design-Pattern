using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilder
{
    public class IdentificationPersonBuilder : IIdentificationPersonBuilder
    {
        private string name = "";  // request
        private string ethic = ""; // request
        private string otherName = "";
        private DateTime date = new DateTime(1950, 1, 1);
        private string address = "";
        private EnumType.Gender gender = EnumType.Gender.Other;
        private MailAddress mail = null;

        public IdentificationPerson Build()
        {
            this.ValidateIdentificationPersonObject();
            return new IdentificationPerson(this.name, this.otherName, this.date, this.address, this.ethic, this.gender, this.mail);
        }

        public IIdentificationPersonBuilder SetAddress(string address)
        {
            this.address = address;
            return this;
        }

        public IIdentificationPersonBuilder SetDayOfBirth(DateTime date)
        {
            this.date = date;
            return this;
        }

        public IIdentificationPersonBuilder SetEthnic(string ethic)
        {
            this.ethic = ethic;
            return this;
        }

        public IIdentificationPersonBuilder SetGender(EnumType.Gender gender)
        {
            this.gender = gender;
            return this;
        }

        public IIdentificationPersonBuilder SetMail(MailAddress mail)
        {
            this.mail = mail;
            return this;
        }

        public IIdentificationPersonBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public IIdentificationPersonBuilder SetOtherName(string otherName)
        {
            this.otherName = name;
            return this;
        }

        private void ValidateIdentificationPersonObject()
        {
            if (this.name.Length == 0)
            {
                throw new MissingFieldException("IdentificationPerson", "name");
            }
            if (this.ethic.Length == 0)
            {
                throw new MissingFieldException("IdentificationPerson", "ethic");
            }
        }
    }
}
