using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Editor
{
    public class NoEditorFound
    {
        public Guid EditorGuid { get; set; }
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}