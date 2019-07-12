
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using TomNet.App.Core.Contracts;
using TomNet.App.Model.DB;
using TomNet.App.Model.DTO;
using TomNet.AspNetCore.Data;
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Web.Controllers
{
    public class AreaManagerController : Controller
    {
        private readonly IAreaContract _areaContract;
        private readonly IUnitOfWork _unitOfWork;

        public AreaManagerController(IAreaContract _areaContracts,
          IUnitOfWork unitOfWork
         )
        {
            _areaContract = _areaContracts;
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddArea()
        {
            return View();
        }


        [Description("获取所有的维修站点")]
        [HttpPost]
        public IActionResult GetAreaLists(int page = 1, int limit = 20, string name = "")
        {
            var query = _areaContract.Entities;
            query.WhereIF(!string.IsNullOrEmpty(name), m => m.Name.Contains(name));
            query.OrderBy(m => m.Id, OrderByType.Desc);
            int total = 0;
            var list = query.ToPageList(page, limit, ref total);
            var result = new LayuiPageResult<Area>
            {
                Code = 0,
                Msg = "Success",
                Count = total,
                Data = list.ToArray()
            };
            return Json(result);
        }

        [Description("添加维修站点")]
        [HttpPost]
        public IActionResult IntertArea(Area area)
        {
            AjaxResult result = new AjaxResult { Type = Data.AjaxResultType.Error, Content = "未知异常", Data = null };

            var count = _areaContract.Entities.Where(m => m.Name == area.Name).Count();
            if (count > 0)
            {
                result.Content = "此维修站点已经存在";
            }
            else
            {
                result.Content = "操作成功";
                result.Type = Data.AjaxResultType.Success;
                _areaContract.Insert(area);
            }

            return Json(result);
        }

        [Description("删除维修站点")]
        [HttpPost]
        public IActionResult AreaDelete(int id)
        {
            AjaxResult result = new AjaxResult { Type = Data.AjaxResultType.Error, Content = "未知异常", Data = null };
            int count = _areaContract.Delete(id);
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

        [Description("通过id获取维修站点的名称")]
        [HttpGet]
        public IActionResult UpdateArea(int id)
        { 
            var area = _areaContract.Entities.Where(m => m.Id == id).First();

            return View(area);
        }


        [Description("修改维修站点的名称")]
        [HttpPost]
        public IActionResult UpdateArea(Area area)
        {
            AjaxResult result = new AjaxResult { Type = Data.AjaxResultType.Error, Content = "未知异常", Data = null };

            var count = _areaContract.Entities.Where(m => m.Name == area.Name).Count();
            if (count > 0)
            {
                result.Content = "有相同的维修站点";
            }
            else
            {
                result.Content = "操作成功";
                result.Type = Data.AjaxResultType.Success;
                _areaContract.Update(area);
            }

            return Json(result);
        }
    }
}