using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MITech.WeiXin.MP.Entities
{
    public class ResponseMessageText : ResponseMessageBase, IResponseMessageBase
    {
        public string Content { get; set; }
    }
}
