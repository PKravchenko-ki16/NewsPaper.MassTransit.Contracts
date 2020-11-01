using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.User
{
    public class NoUserFound
    {
        public Guid UserGuid { get; set; }
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}