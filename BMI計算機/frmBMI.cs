using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
            picbox1.Image = Properties.Resources.BMI對照表;
            this.AcceptButton = btnRun;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            double height, weight;

            //顯示結果
            //lblResult.Text = $"{bmi:F2}"; //格式化字串 F:固定小數點格式 2:表示顯示兩位小數

            bool isHeightValid = double.TryParse(txtHeight.Text, out height);
            bool isWeightValid = double.TryParse(txtWeight.Text, out weight);

            //計算BMI
            double bmi = weight / (height * height);

            if (isHeightValid && isWeightValid)
            {
                height /= 100;
                bmi = weight / (height * height);
                lblResult.Text = $"{bmi:F2}";
            }
            else
            {
                lblResult.Text = "";
                lblResult0.Text = "";
                lblResult.BackColor = SystemColors.Control;
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //lblResult.Text = "";
                //lblResult0.Text = "";
                return;
            }

            string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };

            Color[] colorList = { Color.LightBlue, Color.Green, Color.Orange, Color.DarkOrange, Color.Red, Color.Purple };

            string strResult = "";
            Color colorResult = Color.Black;
            int resultIndex = 0;
            if (bmi < 18.5)
            {
                resultIndex = 0;
            }
            else if (bmi < 24)
            {
                resultIndex = 1;
            }
            else if (bmi < 27)
            {
                resultIndex = 2;
            }
            else if (bmi < 30)
            {
                resultIndex = 3;
            }
            else if (bmi < 35)
            {
                resultIndex = 4;
            }
            else
            {
                resultIndex = 5;
            }
            strResult = strResultList[resultIndex];
            colorResult = colorList[resultIndex];

            lblResult.Text = $"{bmi:F2} {strResult}";
            lblResult.BackColor = colorResult;

            //計算理想體重
            double idealweight = 22 * height * height;
            lblResult0.Text = $"{idealweight:F1}";
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // 清空輸入欄位
            txtHeight.Text = "";
            txtWeight.Text = "";

            // 清空結果
            lblResult.Text = "";
            lblResult0.Text = "";

            // 還原背景色
            lblResult.BackColor = SystemColors.Control;

            // 游標回到身高欄位
            txtHeight.Focus();
        }
    }
}
