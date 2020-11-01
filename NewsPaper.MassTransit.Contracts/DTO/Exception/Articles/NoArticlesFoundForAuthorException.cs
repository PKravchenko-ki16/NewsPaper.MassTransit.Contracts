using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Articles
{
    public class NoArticlesFoundForAuthor
    {
        public Guid AuthorGuid { get; set; }
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}