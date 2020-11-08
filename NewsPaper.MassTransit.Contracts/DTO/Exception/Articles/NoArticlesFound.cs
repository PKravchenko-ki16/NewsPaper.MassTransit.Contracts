using NewsPaper.MassTransit.Contracts.DTO.Exception.Base;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Articles
{
    public class NoArticlesFound : IBaseException
    {
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}