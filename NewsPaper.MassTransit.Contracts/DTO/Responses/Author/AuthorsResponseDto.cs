using System.Collections.Generic;
using NewsPaper.MassTransit.Contracts.DTO.Models.Author;

namespace NewsPaper.MassTransit.Contracts.DTO.Responses.Author
{
    public class AuthorsResponseDto
    {
        public IEnumerable<AuthorDto> AuthorsDto { get; set; }
    }
}