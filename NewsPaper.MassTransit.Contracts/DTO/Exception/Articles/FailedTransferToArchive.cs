namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Articles
{
    public class FailedTransferToArchive
    {
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}