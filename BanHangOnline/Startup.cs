using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
using System.Configuration;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

[assembly: OwinStartupAttribute(typeof(BanHangOnline.Startup))]
namespace BanHangOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        /*    // Cấu hình cookie middleware
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                LogoutPath = new PathString("/Account/Logout"),
                ExpireTimeSpan = TimeSpan.FromMinutes(30)
            });

            // Cấu hình đăng nhập Google
            var googleOptions = new GoogleOAuth2AuthenticationOptions
            {
                ClientId = ConfigurationManager.AppSettings["googleplus.clientId"],
                ClientSecret = ConfigurationManager.AppSettings["googleplus.clientSecret"],
                CallbackPath = new PathString("/signin-google"),
                Provider = new GoogleOAuth2AuthenticationProvider
                {
                    OnAuthenticated = context =>
                    {
                        context.Identity.AddClaim(new Claim("urn:google:access_token", context.AccessToken));
                        foreach (var claim in context.User)
                        {
                            var claimType = $"urn:google:{claim.Key}";
                            var claimValue = claim.Value.ToString();
                            if (!context.Identity.HasClaim(claimType, claimValue))
                                context.Identity.AddClaim(new Claim(claimType, claimValue, "XmlSchemaString", "Google"));
                        }
                        return Task.FromResult(0);
                    }
                }
            };
            app.UseGoogleAuthentication(googleOptions);*/
        }
    }
}
