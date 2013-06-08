using System;

namespace DLIAdmin.Prototypes.Web.Prototype
{
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class PortalServicesPortalService
    {
        public string Name { get; set; }
        public string Description  { get; set; }
        public string PortalID  { get; set; }
    }

}