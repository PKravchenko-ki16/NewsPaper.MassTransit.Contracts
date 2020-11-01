using System;
using NewsPaper.MassTransit.Contracts.DTO.Base;

namespace NewsPaper.MassTransit.Contracts.DTO.Models.Editor
{
    public class EditorDto : DtoBase
    {
        public override Guid Id { get; set; }

        public Guid IdentityGuid { get; set; }

        public string NikeName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public int CountСompletedArticles { get; set; }

        public int CountUnderRevisionArticles { get; set; }
    }
}