﻿namespace Shared.DTOs;
public class AuthDto
{
    public string? Message { get; set; }
    public string? Token { get; set; }
    public string? Email { get; set; }
    public bool IsAuthenticated { get; set; } 
    public DateTime ExpiresOn { get; set; }
    public List<string> Roles { get; set; } = new();
}
