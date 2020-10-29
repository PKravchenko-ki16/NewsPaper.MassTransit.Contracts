using System.Collections.Generic;
using NewsPaper.MassTransit.Contracts.DTO.Models;

namespace NewsPaper.MassTransit.Contracts.DTO.Responses
{
    public class ArticlesResponseDto
    {
        public IEnumerable<ArticlesDto> ArticlesDto { get; set; }
    }
}