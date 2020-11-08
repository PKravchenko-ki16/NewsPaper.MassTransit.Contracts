using NewsPaper.MassTransit.Contracts.DTO.Models.Author;
using NewsPaper.MassTransit.Contracts.DTO.Models.Editor;

namespace NewsPaper.MassTransit.Contracts.DTO.Responses.Operation
{
    public class AccountsForCreateArticleResponseDto
    {
        public AuthorDto Author { get; set; }
        public EditorDto Editor { get; set; }
    }
}