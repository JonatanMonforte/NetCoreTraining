using AT.Model.Common;
using AT.Model.Dtos;
using AutoMapper;

namespace AT.Model.MapperProfiles
{
    public class UserUserList : Profile
    {
        public UserUserList()
        {
            CreateMap<User, UserList>().ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                                       .ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName));
        }
    }
}