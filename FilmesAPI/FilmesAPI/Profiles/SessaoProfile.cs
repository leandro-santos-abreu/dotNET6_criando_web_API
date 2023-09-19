using AutoMapper;
using FilmesAPI.Data.Dtos.Filme;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class SessaoProfile: Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, CreateSessaoDto>();
        }
    }
}
