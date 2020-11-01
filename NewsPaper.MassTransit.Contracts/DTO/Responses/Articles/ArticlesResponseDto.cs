using System.Collections.Generic;
using NewsPaper.MassTransit.Contracts.DTO.Models.Articles;

namespace NewsPaper.MassTransit.Contracts.DTO.Responses.Articles
{
    public class ArticlesResponseDto
    {
        public IEnumerable<ArticlesDto> ArticlesDto { get; set; }
    }
}