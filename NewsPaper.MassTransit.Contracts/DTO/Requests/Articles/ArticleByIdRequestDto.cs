using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Requests.Articles
{
    public class ArticleByIdRequestDto
    {
        public Guid ArticleGuid { get; set; }
    }
}