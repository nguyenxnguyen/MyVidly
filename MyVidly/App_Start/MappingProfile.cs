using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MyVidly.Dtos;
using MyVidly.Models;

namespace MyVidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(x => x.Id, y => y.Ignore());
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(x => x.Id, y => y.Ignore());
        }
    }
}