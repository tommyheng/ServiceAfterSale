using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using TomNet.App.Core.Contracts;
using TomNet.App.Model.DB;
using TomNet.App.Model.DTO;
using TomNet.AspNetCore.Data;

namespace TomNet.App.Web.Controllers
{
    [Description("快递公司")]
    public class ExpressController : Controller
    {
        private readonly IExpressContract _expressContract;

        public ExpressController(IExpressContract expressContract)
        {
            _expressContract = expressContract;
        }

        #region 快递公司列表
        [Description("快递公司列表")] 
        [HttpGet]

        public IActionResult ExpressList() // 网页
        {
            return View();
        }

        [Description("快递公司列表")]
        [HttpPost]
        public IActionResult ExpressList(int page = 1, int limit = 20, string name = "")
        {
            var query = _expressContract.Entities;
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

        #region 添加快递公司
        [Description("添加快递公司")]
        [HttpGet]
        public IActionResult ExpressInsert()
        {
            return View();
        }

        [Description("添加快递公司")]
        [HttpPost]
        public IActionResult ExpressInsert(Express express)
        {
            AjaxResult result = new AjaxResult { Type = Data.AjaxResultType.Error, Content = "未知异常", Data = null };

            var count = _expressContract.Entities.Where(m => m.Name == express.Name).Count();
            if (count > 0)
            {
                result.Content = "已添加过相同的快递公司";
            }
            else
            {
                result.Content = "操作成功";
                result.Type = Data.AjaxResultType.Success;
                _expressContract.Insert(express);
            }

            return Json(result);
        }

        #endregion

        #region 修改快递公司
        [Description("修改快递公司")]
        [HttpGet]
        public IActionResult ExpressEdit(int id)
        {
            var role = _expressContract.Entities.Where(m => m.Id == id).First();

            return View(role);
        }

        [Description("修改角色")]
        [HttpPost]
        public IActionResult ExpressEdit(Express express)
        {
            AjaxResult result = new AjaxResult { Type = Data.AjaxResultType.Error, Content = "未知异常", Data = null };

            var count = _expressContract.Entities.Where(m => m.Name == express.Name).Count();
            if (count > 0)
            {
                result.Content = "有相同账号";
            }
            else
            {
                result.Content = "操作成功";
                result.Type = Data.AjaxResultType.Success;
                _expressContract.Update(express);
            }

            return Json(result);
        }
        #endregion

        #region 删除快递公司
        [Description("删除快递公司")]
        [HttpPost]
        public IActionResult ExpressDelete(int id)
        {
            AjaxResult result = new AjaxResult { Type = Data.AjaxResultType.Error, Content = "未知异常", Data = null };
            int count = _expressContract.Delete(id);
            if (count > 0)
            {
                result.Content = "操作成功";
                result.Type = Data.AjaxResultType.Success;
            }
            else
            {
                result.Content = "操作失败";
                result.Type = Data.AjaxResultType.Error;
            }

            return Json(result);
        }
        #endregion
    }
}