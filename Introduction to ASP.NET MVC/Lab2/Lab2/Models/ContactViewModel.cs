// Lab #2, Step #1
using System;

namespace Lab2.Models
{
    public class ContactViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void Save()
        {
            // Could save to DB, send emails, etc.
            // But for demos, doesn't really do anything
        }
    }
}
