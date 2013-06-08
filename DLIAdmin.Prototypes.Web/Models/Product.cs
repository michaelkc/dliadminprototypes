using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Product
    {
        public Product()
        {
            this.Subscriptions = new List<Subscription>();
            this.ProductRequirements = new List<ProductRequirement>();
            this.ProductRequirements1 = new List<ProductRequirement>();
        }

        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ADGroupname { get; set; }
        public string Productno { get; set; }
        public string Accountingid { get; set; }
        public int Payer { get; set; }
        public int NoDaysAccess { get; set; }
        public int CannotResubscribeWithinNoDays { get; set; }
        public int ReuseSubscriptionWithinNoDays { get; set; }
        public int StartPrice { get; set; }
        public int SubscriptionPrice { get; set; }
        public int SubscriptionPeriod { get; set; }
        public string Ajourini { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<ProductRequirement> ProductRequirements { get; set; }
        public virtual ICollection<ProductRequirement> ProductRequirements1 { get; set; }
    }
}
