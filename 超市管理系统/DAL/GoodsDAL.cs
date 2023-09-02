using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class GoodsDAL
    {
        /// <summary>
        /// 根据条形码查询商品
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public static DataTable selectgoodstypeBarCode(string BarCode)
        {
            string sql = string.Format("select * from goods a,type b where a.typeid=b.typeid  and BarCode='{0}'", BarCode);
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 查询商品表
        /// </summary>
        /// <returns></returns>
        public static List<Goods> GetGoods()
        {
            string sql = "select * from Goods";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Goods> list = new List<Goods>();
            Goods goods = new Goods();
            foreach (DataRow rows in dt.Rows)
            {
                goods.GoodsID = int.Parse(rows["GoodsID"].ToString());
                goods.GoodsName = rows["GoodsName"].ToString();
                goods.SalePrice = decimal.Parse(rows["SalePrice"].ToString());
                goods.StorePrice = decimal.Parse(rows["StorePrice"].ToString());
                goods.StockDate = DateTime.Parse(rows["StockDate"].ToString());
                goods.StockNum = int.Parse(rows["StockNum"].ToString());
                goods.TypeID = int.Parse(rows["TypeID"].ToString());
                list.Add(goods);
            }
            return list;

        }
        /// <summary>
        /// 查询商品表显示类型
        /// </summary>
        /// <returns></returns>
        public static DataTable GetGoodsandType()
        {
            string sql = "select * from [dbo].[Goods] a,type b  where a.typeID=b.typeID ";
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 查询商品以及类型根据条形码
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public static DataTable SelectGoodsTypeByBarCode(string BarCode)
        {
            string sql = string.Format("select * from [dbo].[Goods] a,type b  where a.typeID=b.typeID and BarCode='{0}'", BarCode);
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static bool InsertGoods(Goods gs)
        {
            string sql = string.Format("insert Goods values ('{0}',{1},'{2}',{3},{4},{5},{6},'{7}')", gs.GoodsName, gs.TypeID, gs.BarCode, gs.StorePrice, gs.SalePrice, gs.Discount, gs.StockNum, gs.StockDate);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 根据商品名模糊查询
        /// </summary>
        /// <param name="GoodsName"></param>
        /// <returns></returns>
        public static DataTable GetGoodsLikeName(string GoodsName)
        {
            string sql = string.Format("select * from Goods a, type b  where a.typeID=b.typeID and GoodsName like '%{0}%'", GoodsName);
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static bool UpdateGoods(Goods gs)
        {
            string sql = string.Format("update goods set goodsname='{0}',typeid={1},BarCode='{2}',StorePrice={3}, SalePrice={4},Discount={5},StockNum={6},StockDate='{7}' where goodsid={8}"
            ,gs.GoodsName, gs.TypeID, gs.BarCode,gs.StorePrice,gs.SalePrice, gs.Discount, gs.StockNum, gs.StockDate, gs.GoodsID);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="GoodsID"></param>
        /// <returns></returns>
        public static bool DeleteGoods(int GoodsID)
        {
            string sql = string.Format("delete from goods where Goodsid={0}", GoodsID);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 检索条形码是否存在
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public static bool GetGoodsByBarCode(string BarCode)
        {
            string sql = string.Format("select * from goods a,type b where a.typeid=b.typeid  and BarCode='{0}'", BarCode);
            return int.Parse(DBHelper.GetDataTable(sql).Rows.Count.ToString())>0;

        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <returns></returns>
        public static bool InsertGoodsByBarCod(int newGoods,int oldGoods, string BarCode)
        {
            string sql = string.Format("UPDATE Goods set stockNum='{0}' where barcode='{1}'", newGoods + oldGoods, BarCode);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据商品名称查询库存数
        /// </summary>
        /// <param name="goodsName"></param>
        /// <returns></returns>
        public static int GetStockNumByGoodsName(string goodsName)
        {
            string sql = string.Format("select stockNum from goods where goodsname='{0}'", goodsName);
            return int.Parse(DBHelper.GetDataTable(sql).Rows[0][0].ToString());
        }
        /// <summary>
        /// 根据编号查询商品返回非断开式查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SqlDataReader GetGoodsReturnDataReaderByID(int id)
        {
            string sql1 = string.Format("select * from goods where goodsid={0}", id);
            return DBHelper.GetDataReader(sql1);
        }
        /// <summary>
        /// 销售商品减少库存数
        /// </summary>
        /// <param name="GoodsName"></param>
        /// <param name="GoodsNum"></param>
        /// <returns></returns>
        public static bool UpdateGoodsStockNum(string GoodsName,int GoodsNum)
        {
            string sql= string.Format("update goods set stocknum-={0} where GoodsName='{1}'", GoodsNum, GoodsName);
            return DBHelper.ExecuteNonQuery(sql);
         }
        /// <summary>
        /// 根据商品姓名返回商品编号
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int GetGoodsIDbyGoodsName(string name)
        {
            string sql = "select GoodsID from Goods where GoodsName='" + name + "'";
            return int.Parse(DBHelper.GetDataTable(sql).Rows[0][0].ToString());
        }
    }
}

