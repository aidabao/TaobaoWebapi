using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Nancy.Json;
using System;
using System.Collections.Generic;
using TaoBao.Common;

namespace TaoBaoWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        [HttpPost]
        public ResponseInfo<bool> DownloadPhoto(DownloadPictureRequest request)
        {
            ResponseInfo<bool> result = new ResponseInfo<bool>()
            {
                IsSuccess = true,
                Msg = "",
                Data = true
            };
            try
            {                
                if (request.Param.Count>0)
                {
                    string basePath = ConfigurationHelper.GetSingle("PicturePath");
                    PhotoHelper.DownloadPicture(request.Param, basePath);
                }
            }
            catch(Exception ex)
            {
                result.IsSuccess = false;
                result.Msg = ex.Message;
                result.Data = false;
            }
            return result;
        }
    }
}
