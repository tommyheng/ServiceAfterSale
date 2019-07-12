
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Model.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class GoodsType : IdentityEntityBase<int>
    {
       
        public int GId { get; set; }


        public string Name { get; set; }
    }
}