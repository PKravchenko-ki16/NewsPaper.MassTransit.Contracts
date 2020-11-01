using System;
using NewsPaper.MassTransit.Contracts.DTO.Base;

namespace NewsPaper.MassTransit.Contracts.DTO.Models.User
{
    public class UserDto : DtoBase
    {
        public override Guid Id { get; set; }

        public Guid IdentityGuid { get; set; }

        public string NikeName { get; set; }
    }
}