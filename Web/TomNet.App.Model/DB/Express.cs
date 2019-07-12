
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Model.DB
{
    public class Express : IdentityEntityBase<int>
    {
        public System.String Name { get; set; }
    }
}