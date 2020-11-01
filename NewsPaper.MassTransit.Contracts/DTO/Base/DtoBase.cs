using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Base
{
    public abstract class DtoBase : IDto
    {
        public abstract Guid Id { get; set; }
    }
}
