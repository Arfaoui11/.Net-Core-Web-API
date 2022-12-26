using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
    public class Entreprise
    {
        public string AdresseEntreprise { get; set; }

        public int EntrepriseId { get; set; }

        public string MailEntreprise { get; set; }

        public string NomEntreprise { get; set; }

        [JsonIgnore]
        public virtual ICollection<Cagnotte> Cagnotte { get; set; }
    }
}
