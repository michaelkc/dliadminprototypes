using System;

namespace DLIAdmin.Prototypes.Web.Prototype
{
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class PortalServices
    {
        [System.Xml.Serialization.XmlElementAttribute("PortalService")]
        public PortalServicesPortalService[] PortalService  { get; set; }
    }
}