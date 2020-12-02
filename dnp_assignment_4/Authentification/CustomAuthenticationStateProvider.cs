using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using dnp_assignment_4.Data;
using dnp_assignment_4.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace dnp_assignment_4.Authentification
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IUserService _userService;

        private User _cachedUser;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService)
        {
            _jsRuntime = jsRuntime;
            _userService = userService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (_cachedUser == null)
            {
                string userAsJson = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    _cachedUser = JsonSerializer.Deserialize<User>(userAsJson);
                    identity = SetupClaimsForUser(_cachedUser);
                }
            }
            else
            {
                identity = SetupClaimsForUser(_cachedUser);
            }
            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }
        public async Task ValidateRegistration(User user)
        {
            Console.WriteLine("Validating registration");
            if(string.IsNullOrEmpty(user.Email)) throw new Exception("Enter username");
            if(string.IsNullOrEmpty(user.Password)) throw new Exception("Enter password");

            try
            {
                await _userService.RegisterUser(user);
                NotifyAboutChange(user);
            }
            catch (Exception e)
            {
                throw new Exception("Cannot create a user");
            }
        }
        
        public async Task ValidateLogin(string email, string password)
        {
            Console.WriteLine("Validating log in");
            if(string.IsNullOrEmpty(email)) throw new Exception("Enter username");
            if(string.IsNullOrEmpty(password)) throw new Exception("Enter password");
            
            try
            {
                User user  = await _userService.LoginUser(email, password);
                NotifyAboutChange(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void NotifyAboutChange(User user)
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            identity = SetupClaimsForUser(user);
            string serialisedData = JsonSerializer.Serialize(user);
            _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
            _cachedUser = user;
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }

        public void Logout()
        {
            _cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

       

        private ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            claims.Add(new Claim("Id", user.Id.ToString()));

            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}
