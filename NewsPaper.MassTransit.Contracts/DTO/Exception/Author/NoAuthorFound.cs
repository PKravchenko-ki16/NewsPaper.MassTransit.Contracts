using NewsPaper.MassTransit.Contracts.DTO.Exception.Base;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Author
{
    public class NoAuthorFound : IBaseException
    {
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}