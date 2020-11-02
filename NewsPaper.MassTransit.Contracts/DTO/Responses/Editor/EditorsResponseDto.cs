using System.Collections.Generic;
using NewsPaper.MassTransit.Contracts.DTO.Models.Editor;

namespace NewsPaper.MassTransit.Contracts.DTO.Responses.Editor
{
    public class EditorsResponseDto
    {
        public IEnumerable<EditorDto> EditorsDto { get; set; }
    }
}