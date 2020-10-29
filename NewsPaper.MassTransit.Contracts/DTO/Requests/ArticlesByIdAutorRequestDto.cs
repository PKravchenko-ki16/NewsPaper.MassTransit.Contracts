using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Requests
{
    public class ArticlesByIdAuthorRequestDto
    {
        public Guid AuthorGuid { get; set; }
    }
}