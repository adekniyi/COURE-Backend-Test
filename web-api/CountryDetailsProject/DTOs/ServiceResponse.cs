using System;

namespace CountryDetailsProject.DTOs;

public class ServiceResponse
{
    public int StatusCode { get; set; }
    public string Message { get; set; }
    public bool Success { get; set; }
    public dynamic Data { get; set; }
}
