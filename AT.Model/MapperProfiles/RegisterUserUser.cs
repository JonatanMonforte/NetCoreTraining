using AT.Model.Common;
using AT.Model.Dtos;
using AutoMapper;

namespace AT.Model.MapperProfiles
{
    public class RegisterUserUser : Profile
    {
        public RegisterUserUser()
        {
            CreateMap<RegisterUser, User>().ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                                           .ForMember(d => d.Password, o => o.MapFrom(s => s.Password));
        }

    }
}