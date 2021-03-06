﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using TaskTimeTracker.Entities;
using TaskTimeTracker.IServices;

namespace TaskTimeTracker.Helpers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IUserService _userService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IUserService userService
            ) : base(options, logger, encoder, clock)
        {

            _userService = userService;

        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            User user = null;
            try
            {
                AuthenticationHeaderValue authHeader =
                    AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);

                if (authHeader.Scheme.ToLower().Equals("basic"))
                {
                    byte[] credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                    string[] credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                    user = await _userService.Authenticate(credentials[0], credentials[1]);
                }
                else
                    return AuthenticateResult.Fail("Invalid Authorization Header");
            }
            catch(Exception ex)
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (user == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, user.Level.ToString())
            };

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return AuthenticateResult.Success(ticket);

        }
    }
}
