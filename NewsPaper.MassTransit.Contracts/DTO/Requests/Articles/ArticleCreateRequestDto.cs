using NewsPaper.MassTransit.Contracts.DTO.Models.Articles;

namespace NewsPaper.MassTransit.Contracts.DTO.Requests.Articles
{
    public class ArticleCreateRequestDto
    {
        public ArticleDto Article { get; set; }
    }
}