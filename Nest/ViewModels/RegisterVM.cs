﻿using System.ComponentModel.DataAnnotations;

namespace Nest.ViewModels
{
    public class RegisterVM
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Username { get; set; } = null!;
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
        public bool IsVendor { get; set; }
        public bool Policy { get; set; }
    }
}
