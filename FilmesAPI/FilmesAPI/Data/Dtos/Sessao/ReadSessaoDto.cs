using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Filme
{
    public class ReadSessaoDto
    {
        public int FilmeId { get; set; }
        public int CinemaId { get; set; }
    }
}
