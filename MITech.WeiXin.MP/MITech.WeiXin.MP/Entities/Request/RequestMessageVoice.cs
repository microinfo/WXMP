﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MITech.WeiXin.MP.Entities
{
    public class RequestMessageVoice : RequestMessageBase,IRequestMessageBase
    {
        public string MediaId { get; set; }
        public string Format { get; set; }
    }
}
