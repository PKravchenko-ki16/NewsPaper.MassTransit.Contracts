using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Author
{
    public class NoAuthorFound
    {
        public Guid AuthorGuid { get; set; }
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}