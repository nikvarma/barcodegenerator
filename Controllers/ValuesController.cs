using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using BarCodeGenerator.BarCodeGenerator;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace BarCodeGenerator.Controllers
{
    [Route("api/barcode")]
    public class ValuesController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Index([FromBody] JObject jObject)
        {
            ResponseBody responseBody;
            BarCodeSettings barCodeSettings = (jObject != null) ? JsonConvert.DeserializeObject<BarCodeSettings>(jObject.ToString()) : null;
            try
            {
                responseBody = new ResponseBody()
                {
                    Message = "Barcode generated successfully",
                    Status = 200,
                    BarCodeInformation = await new GenerateBarCode().GetBarCode<BarCodeInformation>(barCodeSettings)
                };
            }
            catch (Exception Ex)
            {
                responseBody = new ResponseBody()
                {
                    Message = Ex.Message,
                    Status = 500,
                    BarCodeInformation = null
                };
            }
            return Ok(responseBody);
        }
    }
}
