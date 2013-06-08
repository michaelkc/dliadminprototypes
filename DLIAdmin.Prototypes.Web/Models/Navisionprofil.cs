using System;
using System.Collections.Generic;

namespace DLIAdmin.Prototypes.Web.Models
{
    public partial class Navisionprofil
    {
        public System.Guid ID { get; set; }
        public string Regnskabsident { get; set; }
        public Nullable<int> Navisionident { get; set; }
        public string Debitornummer { get; set; }
        public string Samlever { get; set; }
        public string Telefon { get; set; }
        public string Mobiltelefon { get; set; }
        public string EMail { get; set; }
        public Nullable<System.DateTime> Indmeldt { get; set; }
        public Nullable<System.DateTime> Udmeldt { get; set; }
        public Nullable<byte> Slettet { get; set; }
        public string Foreningsnummer { get; set; }
        public Nullable<byte> ErEllerHarVaeretMedlem { get; set; }
        public short Medlemsstatus { get; set; }
        public Nullable<byte> Blad { get; set; }
        public string Abonnentnr { get; set; }
        public string Kreds { get; set; }
        public string O90Nummer { get; set; }
        public string CVRNummer { get; set; }
        public string SENummer { get; set; }
        public string Ekstra2 { get; set; }
        public string Ekstra3 { get; set; }
        public string Ekstra4 { get; set; }
        public Nullable<System.Guid> BrugerID { get; set; }
        public Nullable<System.Guid> AdresseID { get; set; }
        public Nullable<System.Guid> LeveringsadresseID { get; set; }
        public System.DateTime Ajourtid { get; set; }
        public System.DateTime Navisiontid { get; set; }
        public string Ajourini { get; set; }
        public Nullable<System.DateTime> IndmelddatoDL { get; set; }
        public Nullable<System.DateTime> UdmelddatoDL { get; set; }
        public Nullable<int> Gruppeliv { get; set; }
        public Nullable<int> GruppelivAegtefaelle { get; set; }
        public Nullable<System.DateTime> Foedselsdato { get; set; }
        public Nullable<System.DateTime> FoedselsdatoAegtefaelle { get; set; }
        public string CPR { get; set; }
        public int ReferenceNavisionident { get; set; }
        public virtual Adresse Adresse { get; set; }
        public virtual Adresse Adresse1 { get; set; }
        public virtual Bruger Bruger { get; set; }
    }
}
