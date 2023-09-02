using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class GoodsBLL
    {
        /// <summary>
        /// 查询商品表
        /// </summary>
        /// <returns></returns>
        public static List<Goods> GetGoods()
        {
            return GoodsDAL.GetGoods();
        }
         /// <summary>
        /// 查询商品表显示类型
        /// </summary>
        /// <returns></returns>
        public static DataTable GetGoodsandType()
        {
            return GoodsDAL.GetGoodsandType();
        }
        /// <summary>
        /// 查询商品以及类型根据条形码
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public static DataTable SelectGoodsTypeByBarCode(string BarCode)
        {
            return GoodsDAL.selectgoodstypeBarCode(BarCode);
        }
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static bool InsertGoods(Goods gs)
        {            
            return GoodsDAL.InsertGoods(gs);
        }
        /// <summary>
        /// 根据商品名模糊查询
        /// </summary>
        /// <param name="GoodsName"></param>
        /// <returns></returns>
        public static DataTable GetGoodsLikeName(string GoodsName)
        {
            return GoodsDAL.GetGoodsLikeName(GoodsName);
        }
        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static bool UpdateGoods(Goods gs)
        {
            return GoodsDAL.UpdateGoods(gs);
        }
         /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="GoodsID">商品编号</param>
        /// <returns></returns>
        public static bool DeleteGoods(int GoodsID)
        {
            return GoodsDAL.DeleteGoods(GoodsID);
        }
         /// <summary>
        /// 进货
        /// </summary>
        /// <returns></returns>
        public static bool InsertGoodsByBarCod(int newGoods, int oldGoods, string BarCode)
        {
           return GoodsDAL.InsertGoodsByBarCod(newGoods,oldGoods,BarCode);
        }
         /// <summary>
        /// 根据商品名称查询库存数
        /// </summary>
        /// <param name="goodsName"></param>
        /// <returns></returns>
        public static int GetStockNumByGoodsName(string goodsName)
        {
            return GoodsDAL.GetStockNumByGoodsName(goodsName);
        }
        /// <summary>
        /// 根据编号查询商品返回非断开式查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SqlDataReader GetGoodsReturnDataReaderByID(int id)
        {
            return GoodsDAL.GetGoodsReturnDataReaderByID(id);
        }
         /// <summary>
        /// 销售商品减少库存数
        /// </summary>
        /// <param name="GoodsName"></param>
        /// <param name="GoodsNum"></param>
        /// <returns></returns>
        public static bool UpdateGoodsStockNum(string GoodsName, int GoodsNum)
        {
            return GoodsDAL.UpdateGoodsStockNum(GoodsName,GoodsNum);
        }
        /// <summary>
        /// 根据商品姓名返回商品编号
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int GetGoodsIDbyGoodsName(string name)
        {
            return GoodsDAL.GetGoodsIDbyGoodsName(name);
        }
    }
}
