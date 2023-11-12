﻿using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class UsersController  : BaseApiController
{
    // context of the user table
    private readonly DataContext _context;


    // controller we use to get users out of the DataContext
    public UsersController(DataContext context)
    {
        _context = context;
    }

    [AllowAnonymous]
    [HttpGet] // api/users returns every user
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }

    [Authorize]
    [HttpGet("{id}")] // api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
       return await _context.Users.FindAsync(id);
    }
}
