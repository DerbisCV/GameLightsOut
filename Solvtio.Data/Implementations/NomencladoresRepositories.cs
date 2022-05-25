using Solvtio.Data.Contracts;
using Solvtio.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

//using Microsoft.EntityFrameworkCore;
//using Solvtio.Data.Contracts;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;


namespace Solvtio.Data.Implementations
{

    public class ClienteRepository : GenericRepository<Gnr_Cliente>, IClienteRepository
    {
        public ClienteRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }
    public class ClienteOficinaRepository : GenericRepository<Gnr_ClienteOficina>, IClienteOficinaRepository
    {
        public ClienteOficinaRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }
    public class TipoAreaRepository : GenericRepository<Gnr_TipoArea>, ITipoAreaRepository
    {
        public TipoAreaRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }
    public class TipoExpedienteRepository : GenericRepository<Gnr_TipoExpediente>, ITipoExpedienteRepository
    {
        public TipoExpedienteRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }

    public class AbogadoRepository : GenericRepository<Gnr_Abogado>, IAbogadoRepository
    {
        public AbogadoRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }

        public override IEnumerable<Gnr_Abogado> GetAll()
        {
            return _context.Gnr_Abogado.Include(x => x.Persona);
        }
    }
    public class ProcuradorRepository : GenericRepository<Gnr_Procurador>, IProcuradorRepository
    {
        public ProcuradorRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }

        public override IEnumerable<Gnr_Procurador> GetAll()
        {
            return _context.Gnr_Procurador.Include(x => x.Gnr_Persona);
        }
    }


    public class ExpedienteNotaRepository : GenericRepository<ExpedienteNota>, IExpedienteNotaRepository
    {
        public ExpedienteNotaRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }
    }



}
