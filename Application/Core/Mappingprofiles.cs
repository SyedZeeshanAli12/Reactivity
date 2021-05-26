using AutoMapper;
using Domain;

namespace Application.Core
{
    public class Mappingprofiles : Profile //using automapper quickfix and generating a constructor for mapping profiles
    {
        public Mappingprofiles()
        {
            CreateMap<Activity, Activity>();//using domain quickfix
        }
    }
}