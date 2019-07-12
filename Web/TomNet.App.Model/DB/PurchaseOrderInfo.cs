
using System;
using TomNet.SqlSugarCore.Entity;

namespace TomNet.App.Model.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class PurchaseOrderInfo : IdentityEntityBase<int>
    {
       
        public int PoId { get; set; }


        public int GId { get; set; }


        public int GtId { get; set; }

        public int Count { get; set; }


        public string Remark { get; set; }


        public decimal Cost { get; set; }


        public bool Test { get; set; }


        public int Rework { get; set; }


        public DateTime Guarantee { get; set; }


        public bool IsBack { get; set; }


        public DateTime BackTime { get; set; }


        public int EId { get; set; }


        public string Enumber { get; set; }


        public int SendId { get; set; }


        public int RepairType { get; set; }
    }
}