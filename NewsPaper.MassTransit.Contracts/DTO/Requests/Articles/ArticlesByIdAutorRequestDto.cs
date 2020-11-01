using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Requests.Articles
{
    public class ArticlesByIdAuthorRequestDto
    {
        public Guid AuthorGuid { get; set; }
    }
}