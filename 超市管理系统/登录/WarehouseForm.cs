using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//导入命名空间
using model;
using BLL;
using System.Text.RegularExpressions;

namespace 超市管理系统
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }
        int id;       //保存选取项的ID
        int goodtype;  //保存当前商品类型
        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            //显示所有商品                      
            //不允许自动创建列
            this.dgv_goods.AutoGenerateColumns = false;
            //绑定数据源
            this.dgv_goods.DataSource = GoodsBLL.GetGoodsandType();
            //初始最大化
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //设置为可编辑状态
            // dgv_goods.BeginEdit(false);
            //查询类型
            DataTable dt = TypeBLL.selecttype();
            //遍历出所有类型
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.cbo_type.Items.Add(dt.Rows[i][1]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        bool error = true;//判断是否
        bool flag = false;
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {


            //获取类型ID  
            try
            {
               
                goodtype = TypeBLL.GetTypeIDByTypeName(this.cbo_type.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请先去添加商品类型", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                //添加商品
                if (this.txt_goodname.Text == "" || this.txt_jinjia.Text == "" || this.txt_kucun.Text == "" || this.txt_shoujia.Text == "" || this.txt_tiaoxingma.Text == "" || this.txt_zhekou.Text == "")
                {
                    MessageBox.Show("带*号不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (TextBoxBll.Intextnull(this.txt_kucun.Text, 2))
                {
                    MessageBox.Show("库存必须为正整数", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (TextBoxBll.Intextnull(this.txt_zhekou.Text, 4))
                {
                    MessageBox.Show("折扣请输入0~1的数字", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (GoodsBLL.SelectGoodsTypeByBarCode(this.txt_tiaoxingma.Text).Rows.Count > 0)
                {
                    MessageBox.Show("该条形码已存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (TextBoxBll.Intextnull(this.txt_tiaoxingma.Text, 1))
                {
                    MessageBox.Show("条形码长度过长", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {

                    Goods gs = new Goods();
                    gs.GoodsName = this.txt_goodname.Text;
                    gs.TypeID = goodtype;
                    gs.BarCode = this.txt_tiaoxingma.Text;
                    gs.StorePrice = decimal.Parse(this.txt_jinjia.Text.ToString());
                    gs.SalePrice = decimal.Parse(this.txt_shoujia.Text.ToString());
                    gs.Discount = decimal.Parse(this.txt_zhekou.Text.ToString());
                    gs.StockNum = int.Parse(this.txt_kucun.Text);
                    gs.StockDate = DateTime.Parse(this.dtp_riqi.Text.ToString());
                    if (GoodsBLL.InsertGoods(gs))
                    {
                        MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //绑定数据源
                        this.dgv_goods.DataSource = GoodsBLL.GetGoodsandType();
                        //初始化文本框数据                        
                        this.txt_goodsname.Text = null;
                        this.txt_jinjia.Text = null;
                        this.txt_kucun.Text = null;
                        this.txt_shoujia.Text = null;
                        this.txt_tiaoxingma.Text = null;
                        this.txt_zhekou.Text = null;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("请正确填写信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 模糊查询商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chaxun_Click(object sender, EventArgs e)
        {
            this.dgv_goods.DataSource = GoodsBLL.GetGoodsLikeName(txt_goodsname.Text);
        }


        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                return;
            }
            //获取类型ID
            goodtype = TypeBLL.GetTypeIDByTypeName(this.cbo_type.Text);
            if (goodtype==0)
            {
                MessageBox.Show("请选择商品类型","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }                        
            try
            {
                if (error)
                {
                    //修改商品
                    string pattern = @"^[0]+(\.[0-9]{1,3})?$";
                    Match m = Regex.Match(this.txt_zhekou.Text, pattern);   // 匹配正则表达式

                    if (this.txt_goodname.Text == "" || this.txt_jinjia.Text == "" || this.txt_kucun.Text == "" || this.txt_shoujia.Text == "" || this.txt_tiaoxingma.Text == "" || this.txt_zhekou.Text == "")
                    {
                        MessageBox.Show("带*号不能为空", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else if (float.Parse(txt_zhekou.Text) > 1 || float.Parse(txt_zhekou.Text) < 0)
                    {
                        MessageBox.Show("折扣必须输入0~1的数", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else if (this.txt_tiaoxingma.Text.Length >= 50)
                    {
                        MessageBox.Show("条形码长度过长", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else if (!m.Success && this.txt_zhekou.Text != "1" && this.txt_zhekou.Text != "1.0")
                    {
                        MessageBox.Show("折扣请输入0~1的数字", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        return;
                    }
                    else
                    {
                        if (int.Parse(this.txt_kucun.Text) >= 0)
                        {
                            Goods gs = new Goods();
                            gs.GoodsName = this.txt_goodname.Text;
                            gs.TypeID = goodtype;
                            gs.BarCode = this.txt_tiaoxingma.Text;
                            gs.StorePrice = decimal.Parse(this.txt_jinjia.Text.ToString());
                            gs.SalePrice = decimal.Parse(this.txt_shoujia.Text.ToString());
                            gs.Discount = decimal.Parse(this.txt_zhekou.Text.ToString());
                            gs.StockNum = int.Parse(this.txt_kucun.Text);
                            gs.StockDate = DateTime.Parse(this.dtp_riqi.Text.ToString());
                            gs.GoodsID = id;
                            if (GoodsBLL.UpdateGoods(gs))
                            {
                                MessageBox.Show("修改成功","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                                flag = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("库存必须为正整数,请重新操作","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("商品信息填写失误","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请联系管理员:" + ex.Message,"温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            }
            finally
            {
                if (flag)
                {
                    //绑定数据源
                    this.dgv_goods.DataSource = GoodsBLL.GetGoodsandType();
                }

            }
        }
        /// <summary>
        /// 删除商品
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //删除商品               
                if (GoodsBLL.DeleteGoods(id))
                {
                    MessageBox.Show("删除成功", "温馨提示");
                }
                else
                {
                    MessageBox.Show("请选择您要删除的商品", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请联系管理员" + ex,"温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                throw;
            }
            finally
            {
                //绑定数据源
                //初始化文本框数据
                this.dgv_goods.DataSource = GoodsBLL.GetGoodsandType();
                this.txt_goodsname.Text = null;
                this.txt_jinjia.Text = null;
                this.txt_kucun.Text = null;
                this.txt_shoujia.Text = null;
                this.txt_tiaoxingma.Text = null;
                this.txt_zhekou.Text = null;

            }

        }

        private void dgv_goods_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //保存商品ID以便于维护
                id = int.Parse(dgv_goods.Rows[e.RowIndex].Cells[0].Value.ToString());
                //将选中单元格中商品信息提出
                this.txt_goodname.Text = dgv_goods.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txt_tiaoxingma.Text = dgv_goods.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txt_jinjia.Text = dgv_goods.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txt_shoujia.Text = dgv_goods.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.txt_zhekou.Text = dgv_goods.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.txt_kucun.Text = dgv_goods.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.dtp_riqi.Text = dgv_goods.Rows[e.RowIndex].Cells[8].Value.ToString();
                this.cbo_type.Text = dgv_goods.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确的位置", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }


    }
}
