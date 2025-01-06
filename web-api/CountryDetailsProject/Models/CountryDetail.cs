using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryDetailsProject.Models;

public class CountryDetail
{
    public int Id { get; set; }

    [ForeignKey("Country")]
    public int CountryId { get; set; }
    public string Operator { get; set; }
    public string OperatorCode { get; set; }

    public Country Country { get; set; }
}
