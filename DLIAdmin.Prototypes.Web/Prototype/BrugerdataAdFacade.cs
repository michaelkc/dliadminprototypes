using System;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using StackExchange.Profiling;

namespace DLIAdmin.Prototypes.Web.Prototype
{
    public class BrugerdataAdFacade
    {
        private const string AdDomainName = "prod.dli";

        public AdUser LoadUser(string adLogonName)
        {
            var profiler = MiniProfiler.Current;
            using (profiler.Step("BrugerdataAdFacade.LoadUser"))
            {
                string[] adDomainParts = AdDomainName.Split('.');
                string adContainer = "dc=" + adDomainParts[0] + ",dc=" + adDomainParts[1];

                using (var userPrincipalContext = new PrincipalContext(ContextType.Domain, AdDomainName, adContainer))
                {
                    using (
                        var userPrincipal = UserPrincipal.FindByIdentity(userPrincipalContext,
                                                                         IdentityType.SamAccountName, adLogonName))
                    {

                        if (userPrincipal == null)
                        {
                            throw new InvalidOperationException("Could not find user");
                        }
                        var userEntry = (DirectoryEntry) userPrincipal.GetUnderlyingObject();

                        return new AdUser(adLogonName) {Name = userEntry.Name};
                    }
                }
            }
        }

    }
}