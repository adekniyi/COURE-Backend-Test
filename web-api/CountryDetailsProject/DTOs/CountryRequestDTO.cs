using System;
using System.ComponentModel.DataAnnotations;

namespace CountryDetailsProject.DTOs;

public class CountryRequestDTO
{
    [Required]
    [MinLength(10)]
    [MaxLength(14)]
    public string phoneNumber { get; set; }
}
