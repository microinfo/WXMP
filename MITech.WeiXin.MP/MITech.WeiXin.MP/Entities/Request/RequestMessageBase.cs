﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MITech.WeiXin.MP.Entities
{
    public interface IRequestMessageBase : IMessageBase
    {
        RequestMsgType MsgType { get; set; }
        long MsgId { get; set; }
    }

    /// <summary>
    /// 接收到请求的消息
    /// </summary>
    public class RequestMessageBase : MessageBase, IRequestMessageBase
    {
        public RequestMsgType MsgType { get; set; }
        public long MsgId { get; set; }
    }
}
