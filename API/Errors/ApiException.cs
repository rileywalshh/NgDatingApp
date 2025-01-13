using System;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace API.Errors;

public class ApiException(int StatusCode, string message, string? details)
{
    public int StatusCode {get; set;} = StatusCode;
    public string Message {get; set;} = message;
    public string? Details {get; set;} = details;   //optional
}
