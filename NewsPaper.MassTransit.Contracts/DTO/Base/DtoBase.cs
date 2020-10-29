using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Base
{
    public class DtoBase : IDto
    {
        public Guid Id { get; set; }
    }
}
