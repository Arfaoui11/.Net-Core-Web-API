using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiView.Data
{
    public interface IServiceE
    {

        List<Entreprise> Entreprises { get; set; }

        Task<List<Entreprise>> GetEntreprise();
    }
}
