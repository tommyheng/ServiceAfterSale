
using System;
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Model.DB
{
    
    public class PurchaseOrder : IdentityEntityBase<int>
    {
        
        public string Order { get; set; }


        public DateTime CreateTime { get; set; }

      
        public int SaleId { get; set; }

       
        public int Guest { get; set; }

       
        public int GuestTel { get; set; }

       
        public int AssistantId { get; set; }

       
        public int AreaId { get; set; }
    }
}