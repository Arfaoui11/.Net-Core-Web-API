using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
    public class Participation
    {
        public int CagnotteFK { get; set; }
        public int ParticipantFK { get; set; }
        public int Montant { get; set; }


        [JsonIgnore]
        [ForeignKey("ParticipantFK")]
        public virtual Participant Participant { get; set; }
        [JsonIgnore]
        [ForeignKey("CagnotteFK")]
        public virtual Cagnotte Cagnotte { get; set; }
    }
}
