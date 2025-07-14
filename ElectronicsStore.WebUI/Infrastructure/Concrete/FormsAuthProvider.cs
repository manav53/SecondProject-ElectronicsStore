using System.Web.Security;
using ElectronicsStore.WebUI.Infrastructure.Abstract;

namespace ElectronicsStore.WebUI.Infrastructure.Concrete {

    public class FormsAuthProvider : IAuthProvider {

        public bool Authenticate(string username, string password) {

            bool result = Membership.ValidateUser(username, password);
            if (result) {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}
