using System;
using CountryDetailsProject.DTOs;

namespace CountryDetailsProject.Interfaces;

public interface ICountryRepository
{
    ServiceResponse GetCountryByCode(string phoneNumber);
}
