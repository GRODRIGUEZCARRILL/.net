using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller
{
    [HttpPost("Add")]
    public User CreateUser(int id, string name, string email, int phone)
    {
        userId = id;
        userName = name;
        userEmail = email;
        userPhone = phone;

    };
    return user;
}

[HttpGet("Id")]
