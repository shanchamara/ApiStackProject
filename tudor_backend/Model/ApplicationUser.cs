﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace tudor_backend.Model
{


    public class AuthenticationModel
    {
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
    public class JWT
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationInMinutes { get; set; }
    }

    public class Setting
    {
        public string DefaultUploadPath { get; set; }
    }

    public class AddRoleModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }

    [Owned]
    public class RefreshToken
    {
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime Created { get; set; }
        public DateTime? Revoked { get; set; }
        public bool IsActive => Revoked == null && !IsExpired;
    }

    public class InsertAccount : Account
    {

    }

    public class Account
    {

        public virtual string Code { get; set; }

        public virtual string FirstName { get; set; } = "";

        public virtual string LastName { get; set; } = "";

        public virtual string Email { get; set; } = "";

        public virtual string Role { get; set; } = CommonResources.default_role.ToString();

        public string PhoneNumber { get; set; } = String.Empty;
        public virtual bool LockoutEnabled { get; set; } = false;
        public virtual string Password { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }

    }

    public class EditAccount : Account
    {
        [Required]
        public override string Code { get; set; }

        [Required]
        public override bool LockoutEnabled { get; set; }


    }

    public class TokenRequestModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class RevokeTokenRequest
    {
        public string Token { get; set; }
    }
}
