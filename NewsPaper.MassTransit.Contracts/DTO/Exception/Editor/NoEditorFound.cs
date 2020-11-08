using NewsPaper.MassTransit.Contracts.DTO.Exception.Base;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Editor
{
    public class NoEditorFound : IBaseException
    {
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}