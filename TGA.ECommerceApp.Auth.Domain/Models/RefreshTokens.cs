﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TGA.ECommerceApp.Auth.Domain.Models;

public class RefreshTokens
{
    public int Id { get; set; }
    public string UserId { get; set; } // Linked to the AspNet Identity User Id
    public string Token { get; set; }
    public string JwtId { get; set; } // Map the token with jwtId
    public bool IsUsed { get; set; } // if its used we dont want generate a new Jwt token with the same refresh token
    public bool IsRevoked { get; set; } // if it has been revoke for security reasons
    public DateTime AddedDate { get; set; }
    public DateTime ExpiryDate { get; set; } // Refresh token is long lived it could last for months.

    [ForeignKey(nameof(UserId))]
    public ApplicationUser User { get; set; }
}
