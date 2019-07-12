using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Model.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class Area : IdentityEntityBase<int>
    {
        public string Name { get; set; }
    }
}