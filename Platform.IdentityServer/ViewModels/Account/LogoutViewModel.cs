using Platform.IdentityServer.Models;

namespace Platform.IdentityServer.ViewModels
{
    public class LogoutViewModel : LogoutInputModel
    {
        public bool ShowLogoutPrompt { get; set; } = true;
    }
}
