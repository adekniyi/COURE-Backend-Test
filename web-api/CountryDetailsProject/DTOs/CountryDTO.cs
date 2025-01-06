using System;

namespace CountryDetailsProject.DTOs;

public class CountryDTO
{
    public string CountryCode { get; set; }
    public string Name { get; set; }
    public string CountryIso { get; set; }
    public List<CountryDetailDTO> CountryDetails { get; set; }
}
