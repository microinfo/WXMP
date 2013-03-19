﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MITech.WeiXin.MP.Entities
{
    public class ResponseMessageMusic : ResponseMessageBase, IResponseMessageBase
    {
        public Music Music { get; set; }

        public ResponseMessageMusic()
        {
            Music = new Music();
        }
    }
}
