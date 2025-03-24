using FluentValidation_Config.Model;
using FluentValidation.Results;
using System;
using System.Xml.Linq;
public class Program
{
    static void Main(string[] args)
    {
        var user = new User { Name = "Jo", Age = 16, Email = "invalid-email" };

        var validator = new UserValidator();
        ValidationResult result = validator.Validate(user);

        Console.WriteLine(result);
        //Output
        //Error: Name - Name must be at least 3 characters long.
        //Error: Age - Age must be greater than 18.
        //Error: Email - Invalid email format.

    }
}