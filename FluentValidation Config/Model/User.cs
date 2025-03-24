using FluentValidation;
using FluentValidation.Results;
using System;
namespace FluentValidation_Config.Model
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
