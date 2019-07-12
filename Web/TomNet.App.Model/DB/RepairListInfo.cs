
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Model.DB
{

    public class RepairListInfo : IdentityEntityBase<int>
    {
       
        public int RlId { get; set; }


        public int GId { get; set; }


        public int GtId { get; set; }


        public int Count { get; set; }


        public string Remark { get; set; }
    }
}