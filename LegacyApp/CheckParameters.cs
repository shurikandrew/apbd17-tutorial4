using System;

namespace LegacyApp;

public class CheckParameters
{
    public bool CheckName(string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            return false;
        }
        return true;
    }
    
    public bool CheckEmail(string email)
    {
        if (!email.Contains("@") && !email.Contains("."))
        {
            return false;
        }
        return true;
    }

    public bool CheckAge(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        int age = now.Year - dateOfBirth.Year;
        if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

        if (age < 21)
        {
            return false;
        }

        return true;
    }

    public bool CheckCreditLimit(User user)
    {
        if (user.HasCreditLimit && user.CreditLimit < 500)
        {
            return false;
        }

        return true;
    }
}