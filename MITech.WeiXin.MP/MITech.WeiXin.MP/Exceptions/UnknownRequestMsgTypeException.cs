using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MITech.WeiXin.MP.Entities;

namespace MITech.WeiXin.MP
{
    /// <summary>
    /// 未知请求类型。
    /// </summary>
    public class ErrorJsonResultException : WeixinException
    {
        public WxJsonResult JsonResult { get; set; }
        public ErrorJsonResultException(string message, Exception inner, WxJsonResult jsonResult)
            : base(message, inner)
        {
            JsonResult = jsonResult;
        }
    }
}
