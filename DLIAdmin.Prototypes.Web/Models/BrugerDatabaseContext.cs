using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.EntityClient;
using DLIAdmin.Prototypes.Web.Models.Mapping;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class BrugerDatabaseContext : DbContext
    {
        static BrugerDatabaseContext()
        {
            Database.SetInitializer<BrugerDatabaseContext>(null);
        }

        public BrugerDatabaseContext()
            : base("Name=BrugerDatabaseContext")
        {
        }


        //protected BrugerDatabaseContext(EntityConnection createEntityConnectionWithWrappers) : base(createEntityConnectionWithWrappers.ConnectionString)
        //{
            
        //}

        public DbSet<Abonnement> Abonnements { get; set; }
        public DbSet<AbonnementHist> AbonnementHists { get; set; }
        public DbSet<ADIdent> ADIdents { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<AdresseHist> AdresseHists { get; set; }
        public DbSet<Arbejdsomraade> Arbejdsomraades { get; set; }
        public DbSet<ArbejdsomraadeHist> ArbejdsomraadeHists { get; set; }
        public DbSet<BedriftID> BedriftIDs { get; set; }
        public DbSet<BedriftIDHist> BedriftIDHists { get; set; }
        public DbSet<BedriftIDRettighedLokalcenter> BedriftIDRettighedLokalcenters { get; set; }
        public DbSet<BedriftIDRettighedLokalcenterHist> BedriftIDRettighedLokalcenterHists { get; set; }
        public DbSet<BedriftIDRettighedPerson> BedriftIDRettighedPersons { get; set; }
        public DbSet<BedriftIDRettighedPersonHist> BedriftIDRettighedPersonHists { get; set; }
        public DbSet<Bedrifttype> Bedrifttypes { get; set; }
        public DbSet<BedrifttypeHist> BedrifttypeHists { get; set; }
        public DbSet<BortkonsolideretBruger> BortkonsolideretBrugers { get; set; }
        public DbSet<Bruger> Brugers { get; set; }
        public DbSet<BrugerHist> BrugerHists { get; set; }
        public DbSet<BrugerIBruger> BrugerIBrugers { get; set; }
        public DbSet<BrugerIBrugerHist> BrugerIBrugerHists { get; set; }
        public DbSet<BrugerMax> BrugerMaxes { get; set; }
        public DbSet<BrugerMaxHist> BrugerMaxHists { get; set; }
        public DbSet<BrugerRelation> BrugerRelations { get; set; }
        public DbSet<BrugerRelationHist> BrugerRelationHists { get; set; }
        public DbSet<BrugerTilBrugerRelation> BrugerTilBrugerRelations { get; set; }
        public DbSet<BrugerTilBrugerRelationHist> BrugerTilBrugerRelationHists { get; set; }
        public DbSet<Butik> Butiks { get; set; }
        public DbSet<ButikHist> ButikHists { get; set; }
        public DbSet<ClaimRelation> ClaimRelations { get; set; }
        public DbSet<ClaimRelationHist> ClaimRelationHists { get; set; }
        public DbSet<Constant> Constants { get; set; }
        public DbSet<ConstantHist> ConstantHists { get; set; }
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<CultureHist> CultureHists { get; set; }
        public DbSet<CVRNummer> CVRNummers { get; set; }
        public DbSet<CVRNummerHist> CVRNummerHists { get; set; }
        public DbSet<CVRValideringer> CVRValideringers { get; set; }
        public DbSet<CVRValideringerHist> CVRValideringerHists { get; set; }
        public DbSet<DataIdent> DataIdents { get; set; }
        public DbSet<DataIdentEjer> DataIdentEjers { get; set; }
        public DbSet<DataIdentEjerHist> DataIdentEjerHists { get; set; }
        public DbSet<DataIdentHist> DataIdentHists { get; set; }
        public DbSet<DQS_Ekstern> DQS_Ekstern { get; set; }
        public DbSet<DQS_Output> DQS_Output { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<EmailSkabelon> EmailSkabelons { get; set; }
        public DbSet<Forening> Forenings { get; set; }
        public DbSet<ForeningHist> ForeningHists { get; set; }
        public DbSet<Gruppeudmelding> Gruppeudmeldings { get; set; }
        public DbSet<GruppeudmeldingHist> GruppeudmeldingHists { get; set; }
        public DbSet<ImageBLOB> ImageBLOBs { get; set; }
        public DbSet<ImageBlobHist> ImageBlobHists { get; set; }
        public DbSet<inserted> inserteds { get; set; }
        public DbSet<insertedx> insertedxes { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<LogHist> LogHists { get; set; }
        public DbSet<Lokalcenter> Lokalcenters { get; set; }
        public DbSet<LokalcenterHist> LokalcenterHists { get; set; }
        public DbSet<Navisionprofil> Navisionprofils { get; set; }
        public DbSet<NavisionprofilHist> NavisionprofilHists { get; set; }
        public DbSet<NulstilletPassword> NulstilletPasswords { get; set; }
        public DbSet<NulstilletPasswordHist> NulstilletPasswordHists { get; set; }
        public DbSet<PortalRegel> PortalRegels { get; set; }
        public DbSet<PortalRegelHist> PortalRegelHists { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductRequirement> ProductRequirements { get; set; }
        public DbSet<Regnskabsident> Regnskabsidents { get; set; }
        public DbSet<RegnskabsidentHist> RegnskabsidentHists { get; set; }
        public DbSet<RequiredProduct> RequiredProducts { get; set; }
        public DbSet<SENummer> SENummers { get; set; }
        public DbSet<SENummerHist> SENummerHists { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<SystemRelation> SystemRelations { get; set; }
        public DbSet<SystemRelationHist> SystemRelationHists { get; set; }
        public DbSet<Vare> Vares { get; set; }
        public DbSet<VareHist> VareHists { get; set; }
        public DbSet<VareKoeb> VareKoebs { get; set; }
        public DbSet<VareKoebHist> VareKoebHists { get; set; }
        public DbSet<C_hypmv_3> C_hypmv_3 { get; set; }
        public DbSet<AdBruger_LiBruger_Relation> AdBruger_LiBruger_Relation { get; set; }
        public DbSet<Bruger_med_Navisionprofil> Bruger_med_Navisionprofils { get; set; }
        public DbSet<BrugerMaxView> BrugerMaxViews { get; set; }
        public DbSet<DQS_Master> DQS_Master { get; set; }
        public DbSet<DQS_Navision> DQS_Navision { get; set; }
        public DbSet<Mapning_je_landbrugsinfo> Mapning_je_landbrugsinfoes { get; set; }
        public DbSet<RegnskabsnrMedLokalcenter> RegnskabsnrMedLokalcenters { get; set; }
        public DbSet<SSOBruger> SSOBrugers { get; set; }
        public DbSet<SSOBrugerCprValidatedApplicationKey> SSOBrugerCprValidatedApplicationKeys { get; set; }
        public DbSet<SSOBrugerCvrValidatedApplicationKey> SSOBrugerCvrValidatedApplicationKeys { get; set; }
        public DbSet<SSOBrugerIBruger> SSOBrugerIBrugers { get; set; }
        public DbSet<SSOBrugerMax> SSOBrugerMaxes { get; set; }
        public DbSet<SSOBrugerNonValidatedApplicationKey> SSOBrugerNonValidatedApplicationKeys { get; set; }
        public DbSet<SSOPortalRegel> SSOPortalRegels { get; set; }
        public DbSet<SSOUserRelationKey> SSOUserRelationKeys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AbonnementMap());
            modelBuilder.Configurations.Add(new AbonnementHistMap());
            modelBuilder.Configurations.Add(new ADIdentMap());
            modelBuilder.Configurations.Add(new AdresseMap());
            modelBuilder.Configurations.Add(new AdresseHistMap());
            modelBuilder.Configurations.Add(new ArbejdsomraadeMap());
            modelBuilder.Configurations.Add(new ArbejdsomraadeHistMap());
            modelBuilder.Configurations.Add(new BedriftIDMap());
            modelBuilder.Configurations.Add(new BedriftIDHistMap());
            modelBuilder.Configurations.Add(new BedriftIDRettighedLokalcenterMap());
            modelBuilder.Configurations.Add(new BedriftIDRettighedLokalcenterHistMap());
            modelBuilder.Configurations.Add(new BedriftIDRettighedPersonMap());
            modelBuilder.Configurations.Add(new BedriftIDRettighedPersonHistMap());
            modelBuilder.Configurations.Add(new BedrifttypeMap());
            modelBuilder.Configurations.Add(new BedrifttypeHistMap());
            modelBuilder.Configurations.Add(new BortkonsolideretBrugerMap());
            modelBuilder.Configurations.Add(new BrugerMap());
            modelBuilder.Configurations.Add(new BrugerHistMap());
            modelBuilder.Configurations.Add(new BrugerIBrugerMap());
            modelBuilder.Configurations.Add(new BrugerIBrugerHistMap());
            modelBuilder.Configurations.Add(new BrugerMaxMap());
            modelBuilder.Configurations.Add(new BrugerMaxHistMap());
            modelBuilder.Configurations.Add(new BrugerRelationMap());
            modelBuilder.Configurations.Add(new BrugerRelationHistMap());
            modelBuilder.Configurations.Add(new BrugerTilBrugerRelationMap());
            modelBuilder.Configurations.Add(new BrugerTilBrugerRelationHistMap());
            modelBuilder.Configurations.Add(new ButikMap());
            modelBuilder.Configurations.Add(new ButikHistMap());
            modelBuilder.Configurations.Add(new ClaimRelationMap());
            modelBuilder.Configurations.Add(new ClaimRelationHistMap());
            modelBuilder.Configurations.Add(new ConstantMap());
            modelBuilder.Configurations.Add(new ConstantHistMap());
            modelBuilder.Configurations.Add(new CultureMap());
            modelBuilder.Configurations.Add(new CultureHistMap());
            modelBuilder.Configurations.Add(new CVRNummerMap());
            modelBuilder.Configurations.Add(new CVRNummerHistMap());
            modelBuilder.Configurations.Add(new CVRValideringerMap());
            modelBuilder.Configurations.Add(new CVRValideringerHistMap());
            modelBuilder.Configurations.Add(new DataIdentMap());
            modelBuilder.Configurations.Add(new DataIdentEjerMap());
            modelBuilder.Configurations.Add(new DataIdentEjerHistMap());
            modelBuilder.Configurations.Add(new DataIdentHistMap());
            modelBuilder.Configurations.Add(new DQS_EksternMap());
            modelBuilder.Configurations.Add(new DQS_OutputMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new EmailSkabelonMap());
            modelBuilder.Configurations.Add(new ForeningMap());
            modelBuilder.Configurations.Add(new ForeningHistMap());
            modelBuilder.Configurations.Add(new GruppeudmeldingMap());
            modelBuilder.Configurations.Add(new GruppeudmeldingHistMap());
            modelBuilder.Configurations.Add(new ImageBLOBMap());
            modelBuilder.Configurations.Add(new ImageBlobHistMap());
            modelBuilder.Configurations.Add(new insertedMap());
            modelBuilder.Configurations.Add(new insertedxMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new LogHistMap());
            modelBuilder.Configurations.Add(new LokalcenterMap());
            modelBuilder.Configurations.Add(new LokalcenterHistMap());
            modelBuilder.Configurations.Add(new NavisionprofilMap());
            modelBuilder.Configurations.Add(new NavisionprofilHistMap());
            modelBuilder.Configurations.Add(new NulstilletPasswordMap());
            modelBuilder.Configurations.Add(new NulstilletPasswordHistMap());
            modelBuilder.Configurations.Add(new PortalRegelMap());
            modelBuilder.Configurations.Add(new PortalRegelHistMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductRequirementMap());
            modelBuilder.Configurations.Add(new RegnskabsidentMap());
            modelBuilder.Configurations.Add(new RegnskabsidentHistMap());
            modelBuilder.Configurations.Add(new RequiredProductMap());
            modelBuilder.Configurations.Add(new SENummerMap());
            modelBuilder.Configurations.Add(new SENummerHistMap());
            modelBuilder.Configurations.Add(new SubscriptionMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new SystemRelationMap());
            modelBuilder.Configurations.Add(new SystemRelationHistMap());
            modelBuilder.Configurations.Add(new VareMap());
            modelBuilder.Configurations.Add(new VareHistMap());
            modelBuilder.Configurations.Add(new VareKoebMap());
            modelBuilder.Configurations.Add(new VareKoebHistMap());
            modelBuilder.Configurations.Add(new C_hypmv_3Map());
            modelBuilder.Configurations.Add(new AdBruger_LiBruger_RelationMap());
            modelBuilder.Configurations.Add(new Bruger_med_NavisionprofilMap());
            modelBuilder.Configurations.Add(new BrugerMaxViewMap());
            modelBuilder.Configurations.Add(new DQS_MasterMap());
            modelBuilder.Configurations.Add(new DQS_NavisionMap());
            modelBuilder.Configurations.Add(new Mapning_je_landbrugsinfoMap());
            modelBuilder.Configurations.Add(new RegnskabsnrMedLokalcenterMap());
            modelBuilder.Configurations.Add(new SSOBrugerMap());
            modelBuilder.Configurations.Add(new SSOBrugerCprValidatedApplicationKeyMap());
            modelBuilder.Configurations.Add(new SSOBrugerCvrValidatedApplicationKeyMap());
            modelBuilder.Configurations.Add(new SSOBrugerIBrugerMap());
            modelBuilder.Configurations.Add(new SSOBrugerMaxMap());
            modelBuilder.Configurations.Add(new SSOBrugerNonValidatedApplicationKeyMap());
            modelBuilder.Configurations.Add(new SSOPortalRegelMap());
            modelBuilder.Configurations.Add(new SSOUserRelationKeyMap());
        }
    }
}
