using AutoMapper;
using Solvtio.Data.Models.Dtos;
using Solvtio.Models;

namespace Solvtio.Data
{
    //public class AutoMapperProfile : Profile
    //{
    //    public AutoMapperProfile()
    //    {
    //        CreateMap<Expediente, ModelExpedienteEdit>().ReverseMap();
    //        CreateMap<Gnr_Cliente, ModelDtoNombre>();
    //        CreateMap<Gnr_ClienteOficina, ModelDtoNombre>();

    //        AutoMapperCustom();
    //    }

    //    private void AutoMapperCustom()
    //    {
    //        //CreateMap<ClientSQL, Client>()
    //        //   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
    //        //   .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))

    //        //   .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
    //        //   .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
    //        //   .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate))
    //        //   .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy))
    //        //   .ForMember(dest => dest.ProfileFileName, opt => opt.MapFrom(src => src.ProfileFileName))
    //        //   .ForMember(dest => dest.InternalNotes, opt => opt.MapFrom(src => src.InternalNotes))
    //        //   .ForMember(dest => dest.User, opt => opt.MapFrom(src => new UserGraph() { Id = src.UserId }))
    //        //   .ForMember(dest => dest.Caas, opt => opt.MapFrom(src => src.ClientsContentAsService.Select(c => c.Caas)));

    //        //CreateMap<Client, ClientSQL>()
    //        //   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
    //        //   .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))

    //        //   .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
    //        //   .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
    //        //   .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate))
    //        //   .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy))
    //        //   .ForMember(dest => dest.ProfileFileName, opt => opt.MapFrom(src => src.ProfileFileName))
    //        //   .ForMember(dest => dest.InternalNotes, opt => opt.MapFrom(src => src.InternalNotes))
    //        //   .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id));

    //        //CreateMap<ContentAsAServiceSQL, ContentAsAService>()
    //        //    .ForMember(dest => dest.HasCampaigns, opt => opt.MapFrom(src => src.Campaigns.Any(c => c.IsActive)))
    //        //    .ForMember(dest => dest.Users, opt => opt.MapFrom(src => src.ClientsContentAsService.Select(c => c.Client)))
    //        //    .ReverseMap();
    //    }

    //}
}
