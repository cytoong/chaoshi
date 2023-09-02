using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
  public   class SalesDetail
    {
        public int SDID { get; set; }//销售详情编号
        public int SalesID { get; set; }//销售编号
        public int GoodsID { get; set; }//商品编号
        public int Quantity { get; set; }//数目
        public decimal  AloneAmount { get; set; }//商品金额
    }
}
