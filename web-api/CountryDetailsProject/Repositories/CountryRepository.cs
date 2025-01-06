using System;
using CountryDetailsProject.Data;
using CountryDetailsProject.DTOs;
using CountryDetailsProject.Interfaces;

namespace CountryDetailsProject.Repositories;

public class CountryRepository : ICountryRepository
{
    private readonly DBContext _dbContext;

    public CountryRepository(DBContext dbContext)
    {
        _dbContext = dbContext;
    }
    public ServiceResponse GetCountryByCode(string phoneNumber)
    {
        var response = new ServiceResponse();

        try
        {
            if(!string.IsNullOrEmpty(phoneNumber))
            {
                var countryCode = phoneNumber.Substring(0,3);

                var country = _dbContext.Countries.Where(x=>x.CountryCode == countryCode)
                                                .Select(country => new CountryDTO
                                                {
                                                    Name = country.Name,
                                                    CountryCode = country.CountryCode,
                                                    CountryIso = country.CountryIso,
                                                    CountryDetails = country.CountryDetails.Select(countryDetails => new CountryDetailDTO
                                                    {
                                                        Operator = countryDetails.Operator,
                                                        OperatorCode = countryDetails.OperatorCode
                                                    }).ToList()
                                                }).FirstOrDefault();

                if(country != null)
                {
                    response.Data = new 
                    {
                        Number = phoneNumber,
                        Country = country
                    };
                    response.Success = true;
                    response.StatusCode = 200;
                }else{
                    response.StatusCode = 404;
                    response.Message = "Country not found";
                }
            }else{
                response.StatusCode = 400;
                response.Message = "Enter a phone number";
            }
        }
        catch (System.Exception ex)
        {
            response.StatusCode = 500;
            response.Message = $"An error occured: {ex.Message}";
        }

        return response;
    }
}
