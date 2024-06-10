using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_hinhtron
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txt1.Text);
            double dientich;
            dientich = bankinh * bankinh * Math.PI;
            lblkq.Text = "-Diện tích" + Convert.ToDouble(dientich);

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txt1.Text);
            string thongbao = "";
            double chuvi;
            chuvi = bankinh * 2 * Math.PI;
            lblkq.Text = "-Chu vi" + Convert.ToDouble(chuvi);
        }

        private void button1_Click_1(object sender, EventArgs e)
        { double bankinh=Convert.ToDouble(txt1.Text);
            if(radioButton1.Checked)
            { double chuvi=bankinh*2*Math.PI;
            String thongbao= "-Diện tích" + Convert.ToString(chuvi);
                MessageBox.Show(thongbao, "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            if (radioButton2.Checked)
            {
                double dientich=bankinh * bankinh * Math.PI;
                string thongbao = "-Diện tích"+Convert.ToString(dientich);

            }
            
        }
    

