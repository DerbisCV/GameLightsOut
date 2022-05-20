using AutoMapper;
using Solvtio.Data.Models.Dtos;
using Solvtio.Models;

namespace Solvtio.API.Start
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Hip_Expediente, ExpedienteHipDto>().ReverseMap();
            CreateMap<ExpedienteNota, ExpedienteNotaDto>().ReverseMap();
            //CreateMap<ExpedienteDeudor, ExpedienteDeudorDto>().ReverseMap();
            CreateMap<ExpedienteDeudor, ExpedienteDeudorDto>()
                .ForMember(dest => dest.Persona, opt => opt.MapFrom(src => src.Gnr_Persona));
            CreateMap<Gnr_Persona, PersonaDto>().ReverseMap();
            //      CreateMap<Gnr_Persona, PersonaDto>()
            //

            CreateMap<ExpedienteEstado, ExpedienteEstadoDto>()
                .ForMember(dest => dest.TipoEstado, opt => opt.MapFrom(src => src.Gnr_TipoEstado));
            CreateMap<ExpedienteNota, ExpedienteNotaDto>();

            CreateMap<Gnr_Cliente, ModelDtoNombre>();
            CreateMap<Gnr_ClienteOficina, ModelDtoNombre>();
            CreateMap<Gnr_TipoArea, ModelDtoNombre>();
            CreateMap<Gnr_Abogado, ModelDtoNombre>();
            CreateMap<Gnr_Procurador, ModelDtoNombre>();
            CreateMap<Gnr_TipoEstado, ModelDtoNombre>();
            CreateMap<Gnr_TipoEstado, DtoIdNombre>();
            CreateMap<Gnr_TipoDeudor, ModelDtoNombre>();
            CreateMap<Provincia, ModelDtoNombre>();
            CreateMap<Gnr_TipoExpediente, ModelDtoNombre>();
            CreateMap<Gnr_TipoArea, ModelDtoNombre>();

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

            CreateMap<Gnr_TipoEstado, DtoIdNombre>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdTipoEstado))
               .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Descripcion));

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
