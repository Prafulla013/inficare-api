﻿using Inficare.Domain.Interfaces;

namespace Inficare.Domain.Entities
{
    public class UserProfile : BaseEntity<int>
    {
        public string Suffix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }

        public virtual IUser UserRef { get; set; }
        public virtual Balance Balance { get; set; }
    }
}
