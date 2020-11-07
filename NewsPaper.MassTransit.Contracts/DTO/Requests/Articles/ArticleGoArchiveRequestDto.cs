using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Requests.Articles
{
    public class ArticleGoArchiveRequestDto
    {
        public Guid ArticleGuid { get; set; }
    }
}