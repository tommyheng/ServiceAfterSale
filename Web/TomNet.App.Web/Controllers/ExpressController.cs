using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SqlSugar;
using TomNet.App.Core.Contracts;
using TomNet.App.Core.Contracts.Identity;
using TomNet.App.Core.Contracts.Security;
using TomNet.App.Model.DB;
using TomNet.App.Model.DB.Identity;
using TomNet.App.Model.DB.Security;
using TomNet.App.Model.DTO;
using TomNet.AspNetCore.Data;
using TomNet.Collections;
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Web.Controllers
{
    //[Authorize]
    [Description("快递公司")]
    public class ExpressController : Controller
    {
        private readonly IExpressContract _roleContract;

        //[Description("快递公司列表")]
        //[HttpGet]

        //public IActionResult ExpressList()
        //{
        //    return View();
        //}
        
        #region 快递公司列表

        [Description("快递公司列表")]
        [HttpPost]
        public IActionResult ExpressList(int page = 1, int limit = 20, string name = "")
        {
            var query = _roleContract.Entities;
            query.WhereIF(!string.IsNullOrEmpty(name), m => m.Name.Contains(name));
            query.OrderBy(m => m.Id, OrderByType.Desc);
            int total = 0;
            var list = query.ToPageList(page, limit, ref total);
            var result = new LayuiPageResult<Express>
            {
                Code = 0,
                Msg = "Success",
                Count = total,
                Data = list.ToArray()
            };
            return Json(result);
        }
        #endregion
    }
}