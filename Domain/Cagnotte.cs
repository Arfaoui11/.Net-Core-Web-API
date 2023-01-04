using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
    public enum Type { CadeauCommun, DépenseàPlusieurs, ProjetSolidaire, Autres }
    public class Cagnotte
    {

        public int CagnotteId { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime DateLimite { get; set; }



        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string Photo { get; set; }

        [Range(0, int.MaxValue)]
        public int SommeDemandee { get; set; }

        [Required(ErrorMessage = "le titre est obligatoire")]
        public string Title { get; set; }

        public Type Type { get; set; }
        
        public int EntrepriseId { get; set; }
        [JsonIgnore]
        public virtual Entreprise Entreprise { get; set; }
       
        public virtual ICollection<Participation> Participations { get; set; }


        public void GetDetails()
        {
            Console.WriteLine("ProductId: " + CagnotteId + " ; Name : " + Title + "DateProd: " + SommeDemandee + " ; Description: " + Description + " ; Price : " + Type + " ; Quantity:" + DateLimite);
        }
    }
}
