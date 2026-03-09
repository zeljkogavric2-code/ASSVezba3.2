
using System;

namespace LegacyOrderSystem.Services
{
    public class EmailService
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}
