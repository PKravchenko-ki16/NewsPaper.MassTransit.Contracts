using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Requests.Operation
{
    public class AccountsForCreateArticleRequestDto
    {
        public Guid AuthorIdentityId { get;set; }
    }
}