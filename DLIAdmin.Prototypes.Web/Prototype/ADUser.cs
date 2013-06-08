namespace DLIAdmin.Prototypes.Web.Prototype
{
    public class AdUser
    {
        public string AdLogonName { get; set; }
        public string Name { get; set; }

        public AdUser(string adLogonName)
        {
            AdLogonName = adLogonName;
        }
    }
}