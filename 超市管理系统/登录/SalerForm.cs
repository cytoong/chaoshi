using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using BLL;
using model;

namespace 超市管理系统
{
    public partial class SalerForm : Form
    {

        /// <summary>
        /// 重写WndProc方法,实现窗体移动和禁止双击最大化
        /// </summary>
        /// <param name="m">Windows 消息</param>
        /// //拖动以及禁止双击最大化
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case 0x4e:
        //        case 0xd:
        //        case 0xe:
        //        case 0x14:
        //            base.WndProc(ref m);
        //            break;
        //        case 0x84://鼠标点任意位置后可以拖动窗体
        //            this.DefWndProc(ref m);
        //            if (m.Result.ToInt32() == 0x01)
        //            {
        //                m.Result = new IntPtr(0x02);
        //            }
        //            break;
        //        case 0xA3://禁止双击最大化
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        public SalerForm()
        {
            InitializeComponent();
        }

        private void SalerForm_Load(object sender, EventArgs e)
        {
            //生成流水号
            liushuihao();
            //初始最大化
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.lbl_yuangong.Text = name.Name;

        }
        //
        private void btn_huanban_Click(object sender, EventArgs e)
        {
            //重启程序
            Application.Exit();
            Application.Restart();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //显示添加商品窗体
            Goodsadd add = new Goodsadd();
            add.Show();

        }

        //商品数量
        int num = 1;
        //定义价格和折扣全局变量
        public static double discount;
        public static double price;

        /// <summary>
        /// 导入商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_daoru_Click(object sender, EventArgs e)
        {

            int allNum = 0;  //统计商品总数
            bool b = true;  //用于判断商品是否存在
            //如果按的是“回车键”            
            //获取条形码
            string barCode = this.txt_shangping.Text;
            if (true)
            {
                //购物列表中不存在该商品
                //根据输入的条形码，查询商品信息
                DataTable dt_goods = GoodsBLL.SelectGoodsTypeByBarCode(barCode);
                //未查询到商品
                if (dt_goods.Rows.Count == 0)
                {
                    MessageBox.Show("商品未找到，请检查条形码是否正确！", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dt_goods.Rows[0]["StockNum"].ToString() == "0")
                {
                    MessageBox.Show("商品以售空,请及时补货", "温馨提示");
                    return;
                }

                bool flag = true;
                //商品是否存在于购物车 计算商品数量
                for (int i = 0; i < this.lv_sales.Items.Count; i++)
                {
                    //判断添加商品数量是否超过库存
                    if (dt_goods.Rows[0]["GoodsName"].ToString() == this.lv_sales.Items[i].SubItems[2].Text)
                    {
                        string goodsName = dt_goods.Rows[0]["GoodsName"].ToString();
                        int stockNum = GoodsBLL.GetStockNumByGoodsName(goodsName); ;
                        if (stockNum == num)
                        {
                            MessageBox.Show("库存数不足", "温馨提示");
                            b = false;
                            flag = false;
                            break;
                        }
                        else
                        {
                            if (flag)
                            {
                                this.lv_sales.Items[i].SubItems[6].Text = (int.Parse(this.lv_sales.Items[i].SubItems[6].Text) + 1).ToString();
                                num++;//商品存在则数量加  1
                                b = false;//如果商品存在则把布尔变量b--赋值为false              
                                discount = double.Parse(dt_goods.Rows[0]["Discount"].ToString());
                                price = double.Parse(dt_goods.Rows[0]["SalePrice"].ToString()) * discount;
                                //显示金额信息
                                this.lbl_money.Text = sum.ToString();
                            }

                        }
                    }
                    else
                    {
                        //初始化数量
                        num = 1;
                    }
                }
                if (b)
                {
                    //创建购物项
                    ListViewItem item = new ListViewItem(dt_goods.Rows[0]["BarCode"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["GoodsID"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["GoodsName"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["TypeName"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["SalePrice"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["Discount"].ToString());
                    item.SubItems.Add(num.ToString());

                    //for (int i = 0; i < lv_sales.Items.Count; i++)
                    //{
                    //    //记录商品ID，结算时需要用到该值                           
                    //    id1[i] = int.Parse(dt_goods.Rows[0]["GoodsID"].ToString());
                    //}
                    //添加至购物车列表
                    this.lv_sales.Items.Add(item);
                }
                //获取ListView（商品）中所有行并显示
                for (int i = 0; i < this.lv_sales.Items.Count; i++)
                {
                    allNum += int.Parse(this.lv_sales.Items[i].SubItems[6].Text);
                }
                if (flag)
                {
                    allGoodsNum = allNum;
                    lbl_goods.Text = allNum.ToString();
                    discount = double.Parse(dt_goods.Rows[0]["Discount"].ToString());
                    price = double.Parse(dt_goods.Rows[0]["SalePrice"].ToString()) * discount;
                    //求和
                    sum += (price);
                    //显示金额信息
                    this.lbl_money.Text = sum.ToString();
                }


            }

        }
        //生成流水单号
        private void liushuihao()
        {
            this.lbl_danhao.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        //定义全局变量，接收价格总和
        double sum = 0;

        int allGoodsNum = 0;
        //在条形码文本框获得焦点时，按下键盘任意键并释放时触发事件
        /// <summary>
        /// 导入商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_shangping_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //查询VIP表获取VIP姓名
        private void btn_chaxun_Click(object sender, EventArgs e)
        {

        }

        private void lv_sales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        bool messge;//销售成功
        int stocknum = 0;//库存
        /// <summary>
        /// 确定购买按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_jiezhang_Click(object sender, EventArgs e)
        {
            if (this.lv_sales.Items.Count == 0)
            {
                MessageBox.Show("当前无添加商品", "温馨提示");
                return;
            }
            else
            {
                //检索是否能否成功销售
                int error = 0;
                for (int i = 0; i < this.lv_sales.Items.Count; i++)
                {
                    stocknum = int.Parse(this.lv_sales.Items[i].SubItems[6].Text.ToString());
                    if (!GoodsBLL.UpdateGoodsStockNum(this.lv_sales.Items[i].SubItems[2].Text.ToString(), stocknum))
                    {
                        error++;
                    }
                }
                if (error > 0)
                {
                    MessageBox.Show("库存数可能不足", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    //存已买的商品的信息
                    string info = "单号：" + lbl_danhao.Text +"\r\n";
                    //将商品信息存入字符变量info
                    for (int i = 0; i < this.lv_sales.Items.Count; i++)
                    {

                        info +=  "商品名字:" + this.lv_sales.Items[i].SubItems[2].Text + "\r\n商品价格:" + this.lv_sales.Items[i].SubItems[4].Text + "\r\n商品折扣:" + this.lv_sales.Items[i].SubItems[5].Text + "\r\n商品数量:" + this.lv_sales.Items[i].SubItems[6].Text + "\r\n";
                    }
                    info += "总金额：" + lbl_money.Text + "\r\n";
                    info += "购物员：" + lbl_yuangong.Text;
                    //创建打印信息
                    for (int i = 0; i < this.lv_sales.Items.Count; i++)
                    {
                        if (stocknum >= 0)
                        {
                            using (StreamWriter st = new StreamWriter(@"D:\小票.txt", false, Encoding.UTF8))
                            {
                                if (!TextBoxBll.Intextnull(this.txt_shishou.Text, 2)||TextBoxBll.Intextnull(this.txt_shishou.Text,1))
                                {
                                    if (this.txt_shishou.Text == "")
                                    {
                                        MessageBox.Show("请输入实收金额", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        return;
                                    }
                                    else if (this.txt_shishou.Text != null && double.Parse(this.txt_shishou.Text.ToString()) >= double.Parse(this.lbl_money.Text.ToString()))
                                    {
                                        st.Write(info);
                                        st.Flush();
                                        messge = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("实收金额小于应付金额", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("请正确输入预收金额", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }

                            }
                        }
                    }


                }

                //结算成功
                if (messge)
                {
                    //将信息保存至销售表
                    int Salesmanid = SalemanBll.SelectSalemanByName(this.lbl_yuangong.Text);
                    DateTime time = DateTime.Parse(DateTime.Now.ToString("yyyy年MM月dd日"));
                    SaleBll.InsertSale(this.lbl_danhao.Text, time, sum, Salesmanid);
                    for (int j = 0; j < lv_sales.Items.Count; j++)
                    {
                        //将信息保存至销售详情表
                        SalesDetail sale = new SalesDetail()
                        {
                            GoodsID = GoodsBLL.GetGoodsIDbyGoodsName(this.lv_sales.Items[j].SubItems[2].Text),
                            Quantity = num,
                            SalesID = SaleBll.GetSDIDByTime(this.lbl_danhao.Text),
                            AloneAmount = decimal.Parse(this.lv_sales.Items[j].SubItems[4].Text) * decimal.Parse(this.lv_sales.Items[j].SubItems[5].Text)
                        };
                        SalesDailBLL.InsertSaleDail(sale);
                    }
                    if (isVIP)
                    {
                        VipBll.UpdatejifenByPhone(this.txt_vip.Text, int.Parse(sum.ToString()));
                    }

                    MessageBox.Show("结算成功，祝您生活愉快", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //信息初始化
                    this.lv_sales.Items.Clear();
                    this.lbl_goods.Text = "0";
                    liushuihao();
                    this.lbl_money.Text = "0.0000";
                    num = 1;
                    this.lbl_zhaoling.Text = "0.0";
                    this.txt_shishou.Text = "";
                    error = 0;
                    sum = 0;
                }


            }
        }
        /// <summary>
        /// 删除购物车所选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.lv_sales.Items.Clear();
            this.lbl_goods.Text = "0";
            this.lbl_money.Text = "0.00";
            this.txt_shangping.Text = "";
            sum = 0;
            price = 0;
            //信息初始化                             
            this.lbl_money.Text = "0.00";
            num = 1;
            this.lbl_zhaoling.Text = "0.0";
            this.txt_shishou.Text = "";
           
            sum = 0;
        }

        private void txt_shangping_TextChanged(object sender, EventArgs e)
        {

        }

        private void lv_sales_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_shishou_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    double Money;
                    Money = double.Parse(this.txt_shishou.Text);
                    if (Money < sum)
                    {
                        MessageBox.Show("您的余额不足", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        lbl_zhaoling.Text = (Money - sum).ToString();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("请输入实收金额", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        bool isVIP=false;//是否为会员
        private void btn_jiansuo_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxBll.Intextnull(this.txt_vip.Text, 3))
                {
                    MessageBox.Show("请正确填写电话号码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (VipBll.SelectVipBymobilebool(this.txt_vip.Text))
                    {
                        isVIP = true;
                        DataTable dt = VipBll.SetVipByMobile(this.txt_vip.Text);
                        MessageBox.Show("尊敬的会员：" + dt.Rows[0][1].ToString() + ",你好！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                }
            }
            catch (Exception )
            {              
            }
            
        }



    }
}
