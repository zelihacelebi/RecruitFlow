using RecruitFlow.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitFlow.Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

        private Candidate() { } // EF Core

        public Candidate(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
