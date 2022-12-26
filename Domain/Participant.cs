using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
    public class Participant
    {
        public string MailParticipant { get; set; }

        public string Nom { get; set; }

        [JsonIgnore]
        public int ParticipantId { get; set; }

        public string Prenom { get; set; }

        [JsonIgnore]
        public virtual ICollection<Participation> Participantions { get; set; }
    }
}
