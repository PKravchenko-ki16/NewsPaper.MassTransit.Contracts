using NewsPaper.MassTransit.Contracts.DTO.Exception.Base;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Operation
{
    public class FailedGetAccountsToCreateArticle : IBaseException
    {
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}