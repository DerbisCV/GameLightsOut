using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Solvtio.Data;
using Solvtio.Data.Contracts;
using Solvtio.Data.Implementations;
using Solvtio.Data.Models.Dtos;
using Solvtio.Models;
using Solvtio.Services.Contracts;
using Solvtio.Services.Implementations;

namespace Solvtio.API.Start
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddTransient<IConfiguracionService, ConfiguracionService>()
                .AddTransient<IConfiguracionRepository, ConfiguracionRepository>()
                .AddTransient<ICaracteristicaBaseRepository, CaracteristicaBaseRepository>()
                .AddTransient<IExpedienteRepository, ExpedienteRepository>()
                .AddTransient<IAlquilerRepository, AlquilerRepository>()
                .AddTransient<IClienteRepository, ClienteRepository>()
                .AddTransient<IClienteOficinaRepository, ClienteOficinaRepository>()
                .AddTransient<ITipoAreaRepository, TipoAreaRepository>()
                .AddTransient<IAbogadoRepository, AbogadoRepository>()
                .AddTransient<IProcuradorRepository, ProcuradorRepository>()
                .AddTransient<INomencladorReadOnlyRepository, NomencladorReadOnlyRepository>()
                ; //INomencladorReadOnlyRepository

            return services;
        }

        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SolvtioDbContext>(options =>
                options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"])
            );

            return services;
        }

        public static void UpgradeDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SolvtioDbContext>();
                if (context != null && context.Database != null)
                {
                    //context.Database.Migrate();
                    context.SeedDataInitial();
                    var caract = context.CaracteristicaBaseSet.Find(1);
                }
            }
        }
    }

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<Expediente, ModelExpedienteEdit>().ReverseMap();

            CreateMap<ExpedienteEstado, ExpedienteEstadoDto>();
            CreateMap<ExpedienteNota, ExpedienteNotaDto>();

            CreateMap<Gnr_Cliente, ModelDtoNombre>();
            CreateMap<Gnr_ClienteOficina, ModelDtoNombre>();
            CreateMap<Gnr_TipoArea, ModelDtoNombre>();
            CreateMap<Gnr_Abogado, ModelDtoNombre>();
            CreateMap<Gnr_Procurador, ModelDtoNombre>();            
            CreateMap<Gnr_TipoEstado, ModelDtoNombre>();

            //public async Task<ExpedienteEstadoDto> GetEstadoActual(int idExpediente) 
            //{
            //    var idEstadoLast = _solvtioDbContext.ExpedienteSet.First(x => x.IdExpediente == idExpediente)?.IdEstadoLast;
            //    if (!idEstadoLast.HasValue) throw new System.Exception("No se encontró el expediente o este no tiene estado");

            //    var result = await _solvtioDbContext.ExpedienteEstadoes
            //        .Include(x => x.Gnr_TipoEstado)
            //        .FindAsync(idEstadoLast.Value);

            //    return _mapper.Map<ExpedienteEstadoDto>(result);


            AutoMapperCustom();
        }

        private void AutoMapperCustom()
        {
            CreateMap<Expediente, ModelExpedienteEdit>()
               .ForMember(dest => dest.TipoExpediente, opt => opt.MapFrom(src => new DtoIdNombre(src.Gnr_TipoExpediente)))
               .ForMember(dest => dest.Deudor, opt => opt.MapFrom(src => new DtoIdNombre(src.Gnr_Persona)))
               .ForMember(dest => dest.Abogado, opt => opt.MapFrom(src => new DtoIdNombre(src.Gnr_Abogado)))
               .ForMember(dest => dest.Oficina, opt => opt.MapFrom(src => new DtoIdNombre(src.Gnr_ClienteOficina)))
               .ForMember(dest => dest.Juzgado, opt => opt.MapFrom(src => new DtoIdNombre(src.Juzgado)))
               ;
            //   .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))

            //   .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
            //   .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
            //   .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate))
            //   .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy))
            //   .ForMember(dest => dest.ProfileFileName, opt => opt.MapFrom(src => src.ProfileFileName))
            //   .ForMember(dest => dest.InternalNotes, opt => opt.MapFrom(src => src.InternalNotes))
            //   .ForMember(dest => dest.User, opt => opt.MapFrom(src => new UserGraph() { Id = src.UserId }))
            //   .ForMember(dest => dest.Caas, opt => opt.MapFrom(src => src.ClientsContentAsService.Select(c => c.Caas)));

            //CreateMap<Client, ClientSQL>()
            //   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //   .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))

            //   .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
            //   .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
            //   .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate))
            //   .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy))
            //   .ForMember(dest => dest.ProfileFileName, opt => opt.MapFrom(src => src.ProfileFileName))
            //   .ForMember(dest => dest.InternalNotes, opt => opt.MapFrom(src => src.InternalNotes))
            //   .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id));

            //CreateMap<ContentAsAServiceSQL, ContentAsAService>()
            //    .ForMember(dest => dest.HasCampaigns, opt => opt.MapFrom(src => src.Campaigns.Any(c => c.IsActive)))
            //    .ForMember(dest => dest.Users, opt => opt.MapFrom(src => src.ClientsContentAsService.Select(c => c.Client)))
            //    .ReverseMap();
        }

    }
    
}
