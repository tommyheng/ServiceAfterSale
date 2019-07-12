
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Model.DB
{

    public class Goods : IdentityEntityBase<int>
    {

        public string Name { get; set; }

        public string Type { get; set; }
    }
}