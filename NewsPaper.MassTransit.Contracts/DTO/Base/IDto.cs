using System;

namespace NewsPaper.MassTransit.Contracts.DTO.Base
{
    public interface IDto
    {
        public Guid Id { get; set; }
    }
}