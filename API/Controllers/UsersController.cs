﻿using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] // /api/users
public class UsersController  : ControllerBase
{
    // context of the user table
    private readonly DataContext _context;


    // controller we use to get users out of the DataContext
    public UsersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet] // api/users returns every user
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }

    [HttpGet("{id}")] // api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
       return await _context.Users.FindAsync(id);
    }
}
