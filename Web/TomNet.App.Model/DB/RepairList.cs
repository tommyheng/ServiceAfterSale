
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Model.DB
{

    public class RepairList : IdentityEntityBase<int>
    {
     

        public int PoId { get; set; }

        public int PoiId { get; set; }


        public string GoodsNumber { get; set; }


        public string RepairId { get; set; }
    }
}