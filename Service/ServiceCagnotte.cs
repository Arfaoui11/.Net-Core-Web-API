using Data.Infrastructure;
using Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ServiceCagnotte : Service<Cagnotte>, IServiceCagnotte
    {

        public ServiceCagnotte(IUnitOfWork utwk) : base(utwk)
        {

        }
        IEnumerable<Cagnotte> IServiceCagnotte.EnCours()
        {
            return GetMany().Where(c => c.DateLimite.CompareTo(DateTime.Now) > 0 ).ToList();
        }

        int IServiceCagnotte.Montant(int id)
        {
            IDataBaseFactory factory = new DataBaseFactory();
            IUnitOfWork utwk = new UnitOfWork(factory);
            var req = utwk.getRepository<Participation>().GetMany().Where(p => p.CagnotteFK == id);
            int montant = 0;

            foreach(var item in req)
            {
                montant += item.Montant;
            }

            return montant;
        }

        int IServiceCagnotte.NbrCagnottes(int id)
        {
            IDataBaseFactory factory = new DataBaseFactory();
            IUnitOfWork utwk = new UnitOfWork(factory);

            return utwk.getRepository<Participant>().GetMany().Where(p => p.ParticipantId == id).Select(p => p.Participantions).Count();
        }

        IEnumerable<Entreprise> IServiceCagnotte.Top2Entreprise(string Type)
        {
            IDataBaseFactory factory = new DataBaseFactory();
            IUnitOfWork utwk = new UnitOfWork(factory);

            var linq = (from i in utwk.getRepository<Entreprise>().GetMany()
                        join c in GetMany() on i.EntrepriseId equals c.Entreprise.EntrepriseId
                        where c.Type.ToString() == Type
                        select i).Take(2);
            return linq;
        }
    }
}
