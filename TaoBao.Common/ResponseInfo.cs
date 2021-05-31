using System;

namespace TaoBao.Common
{
    public class ResponseInfo<T>
    {
        public bool IsSuccess { get; set; }
        public string Msg { get; set; }
        public T Data { get; set; }
    }
}
