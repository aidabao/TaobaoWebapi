using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TaoBao.Common
{
    public class ConfigurationHelper
    {
        public static string GetSingle(string name)
        {
            string result = "";
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();//创建ConfigurationBuilder对象
            //给configurationBuilder对象设置appsettings的路径
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();
            //获取单独字段
            result = configuration[name];
            return result;
        }
    }
}
