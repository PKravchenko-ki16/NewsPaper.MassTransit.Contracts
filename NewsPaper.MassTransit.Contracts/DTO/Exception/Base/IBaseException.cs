namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Base
{
    public interface IBaseException
    {
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}