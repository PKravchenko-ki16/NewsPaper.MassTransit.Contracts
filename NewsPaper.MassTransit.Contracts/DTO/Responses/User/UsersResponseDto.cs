using System.Collections.Generic;
using NewsPaper.MassTransit.Contracts.DTO.Models.User;

namespace NewsPaper.MassTransit.Contracts.DTO.Responses.User
{
    public class UsersResponseDto
    {
        public IEnumerable<UserDto> UsersDto { get; set; }
    }
}