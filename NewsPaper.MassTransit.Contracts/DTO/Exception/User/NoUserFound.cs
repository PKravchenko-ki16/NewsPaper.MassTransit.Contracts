using NewsPaper.MassTransit.Contracts.DTO.Exception.Base;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.User
{
    public class NoUserFound : IBaseException
    {
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}