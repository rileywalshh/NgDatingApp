using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController(DataContext context) : BaseApiController
{
    [Authorize]
    [HttpGet("auth")]
    public ActionResult<string> GetAuth()
    {
        return "secret text";
    }

    [HttpGet("not-found")]
    public ActionResult<AppUser> GetNotFound()
    {
        var thing = context.Users.Find(-1);
        if (thing == null) return NotFound();

        return thing;
    }

    [HttpGet("Server-error")]
    public ActionResult<AppUser> GetServerError()
    {
        try
        {
            var thing = context.Users.Find(-1) ?? throw new Exception("A bad thing happened");
            return thing;
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Computer says nuh uh!");
        }

    }

    [HttpGet("bad-request")]
    public ActionResult<string> GetBadRequest()
    {
        return BadRequest("not a good request");
    }
}