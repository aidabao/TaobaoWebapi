using System;
using System.Collections.Generic;
using System.Text;

namespace TaoBao.Common
{
    public class RequestInfo
    {
        public string Token { get; set; }
        
    }
    public class DownloadPictureRequest : RequestInfo
    {
        public List<string> Param { get; set; }
    }
}
