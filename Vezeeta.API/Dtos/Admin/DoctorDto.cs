﻿using Vezeeta.Core.Domain.Enums;

namespace Vezeeta.API.Dtos.Admin
{
    public class DoctorDto
    {
        public string? ImageUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? SpecializationId { get; set; }
        public Gender Gender { get; set; }
        public string DateOfBirth { get; set; }
    }
}
