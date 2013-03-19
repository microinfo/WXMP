using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MITech.WeiXin.MP.Entities
{
    public class RequestMessageImage : RequestMessageBase, IRequestMessageBase
    {
        public string PicUrl { get; set; }
    }
}
