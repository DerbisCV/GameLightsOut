using Solvtio.Data.Contracts;
using Solvtio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solvtio.Data.Models.Dtos;
using System.Linq;

//using Microsoft.EntityFrameworkCore;
//using Solvtio.Data.Contracts;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;


namespace Solvtio.Data.Implementations
{
    public class ExpedienteDeudorRepository : GenericRepository<ExpedienteDeudor>, IExpedienteDeudorRepository
    {
        public ExpedienteDeudorRepository(SolvtioDbContext solvtioDbContext) : base(solvtioDbContext) { }

        public override IEnumerable<ExpedienteDeudor> GetAll()
        {
            return _context.ExpedienteDeudors
                .Include(x => x.Gnr_TipoDeudor)
                .Include(x => x.Provincia)
                .Include(x => x.Gnr_Persona);
        }

        public override async Task<ExpedienteDeudor> Get(int id)
        {
            return await _context.ExpedienteDeudors
                .Include(x => x.Gnr_TipoDeudor)
                .Include(x => x.Provincia)
                .Include(x => x.Gnr_Persona)
                .FirstOrDefaultAsync(x => x.IdExpedienteDeudor == id);
        }

        public void Update(ExpedienteDeudorDto model)
        {
            if (model.Persona.IdPersona <= 0)
                model.Persona.IdPersona = PersonaInsert(model);

            Update(new ExpedienteDeudor(model));
        }

        private int PersonaInsert(ExpedienteDeudorDto model)
        {
            if (model.Persona.IdPersona > 0) return model.Persona.IdPersona;

            var persona = _context.Gnr_Persona.FirstOrDefault(x => x.NoDocumento == model.personaNoDocumento);
            if (persona == null)
            {
                persona = new Gnr_Persona()
                {
                    NoDocumento = model.personaNoDocumento,
                    IdTipoIdentidad = model.personaIdTipoIdentidad ?? 1,
                    Nombre = model.personaNombre,
                    Apellidos = model.personaApellidos,
                    Email = model.personaEmail,
                    Telefono = model.personaTelefono
                };

                _context.Gnr_Persona.Add(persona);
                _context.SaveChanges();
            } 

            return persona.IdPersona;
        }
    }

}
