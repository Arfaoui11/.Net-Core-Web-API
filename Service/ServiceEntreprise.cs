using Data.Infrastructure;
using Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ServiceEntreprise : Service<Entreprise>, IServiceEntreprise
    {
        public ServiceEntreprise(IUnitOfWork utwk) : base(utwk)
        {

        }

        Entreprise IServiceEntreprise.PlusParticipations()
        {
            IDataBaseFactory factory = new DataBaseFactory();
            IUnitOfWork utwk = new UnitOfWork(factory);
            var e = utwk.getRepository<Cagnotte>().GetMany().OrderBy(e => e.Participations.Count).ToList();
            
            return e.First().Entreprise;
           
        }
    }
}
