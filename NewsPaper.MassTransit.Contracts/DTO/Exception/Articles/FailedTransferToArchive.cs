﻿using NewsPaper.MassTransit.Contracts.DTO.Exception.Base;

namespace NewsPaper.MassTransit.Contracts.DTO.Exception.Articles
{
    public class FailedTransferToArchive : IBaseException
    {
        public short CodeException { get; set; }
        public string MassageException { get; set; }
    }
}