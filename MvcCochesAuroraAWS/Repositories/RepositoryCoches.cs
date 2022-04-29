using MvcCochesAuroraAWS.Data;
using MvcCochesAuroraAWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCochesAuroraAWS.Repositories
{
    public class RepositoryCoches
    {
        private CochesContext context;

        public RepositoryCoches(CochesContext context)
        {
            this.context = context;
        }

        public List<Coche> GetCoches()
        {
            return this.context.Coches.ToList();
        }
    }
}
