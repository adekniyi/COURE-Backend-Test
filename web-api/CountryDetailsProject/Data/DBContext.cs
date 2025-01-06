using System;
using CountryDetailsProject.Models;

namespace CountryDetailsProject.Data;

public class DBContext
{
    public List<Country> Countries { get; } = DataStorage.Data();
}