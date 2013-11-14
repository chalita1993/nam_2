using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string op1;
            string op2;
            string op3;
            string op4;
            string op5;
            string op6;
            string op7;
            string op8;
                   // string str = ("รายการที่เลือก :" );
            if (optMale.Checked == true)
            {
               op1= "ชาย" ;
            }
            else
            {
                op1 = "หญิง" ;
            }

          //  str = str + ("อายุ :" );
            if (opt1.Checked == true)
            {
                op2= "น้อยกว่า 20 ปี" ;
            }
            else  if (opt2.Checked == true)
            {
                op2 = "20-40 ปี";
            }
            else 
            {
                op2 = "มากกว่า 40 ปี";
            }

           // str = str + ("อายุรถของคุณ :" );
            if (opt4.Checked == true)
            {
                op3= "ต่ำกว่า 5 ปี" ;
            }
            else if (opt5.Checked == true)
            {
                op3 = "5-10 ปี";
            }
            else 
            {
                op3 = "มากกว่า 10 ปี";
            }

           // str = str + ("คุณตรวจสภาพรถของคุณบ่อยแค่ไหน :");
            if (opt7.Checked == true)
            {
                op4= "บ่อยมาก" ;
            }
            else    if (opt8.Checked == true)
            {
                op4= "บ่อย" ;
            }
            else   if (opt9.Checked == true)
            {
                op4= "พอสมควร" ;
            }
            else if (opt10.Checked == true)
            {
               op4= "น้อย" ;
            }
            else 
            {
                op4= "ไม่เคยเลย" ;
            }

            //str = str + ("คุณตรวจสภาพรถของคุณก่อนออกเดินทางหรือไม่ :" );
            if (opt12.Checked == true)
            {
                op5= "ทุกครั้ง" ;
            }
            else  if (opt13.Checked == true)
            {
                op5 = "เป็นบางครั้ง";
            }
            else  if (opt14.Checked == true)
            {
                op5 = "นานๆครั้ง";
            }
            else  
            {
                op5 = "ไม่เคยเลย";
            }

            //str = str + ("วิธีการตรวจสภาพรถของคุณ :" );
            if (opt16.Checked == true)
            {
                op6 =  "เข้าศูนย์" ;
            }
            else  if (opt17.Checked == true)
            {
              op6 = "เข้าอู่" ;
            }
            else  if (opt18.Checked == true)
            {
                op6 =  "ตรวจด้วยตนเอง" ;
            }
            else   
            {
                op6= "ไม่เคยเลย" ;
            }

          //  str = str + ("รถของคุณซ่อมบ่อยแค่ไหน :" );
            if (opt20.Checked == true)
            {
                op7= "บ่อยมาก" ;
            }
            else   if (opt21.Checked == true)
            {
                op7= "บ่อย" ;
            }
            else if (opt22.Checked == true)
            {
                op7= "พอสมควร" ;
            }
            else  if (opt23.Checked == true)
            {
                op7="น้อย" ;
            }
            else 
            {
                op7= "ไม่เคยเลย" ;
            }

          //  str = str + ("คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน :" );
            if (opt25.Checked == true)
            {
               op8= "มากที่สุด" ;
            }
            else if (opt26.Checked == true)
            {
                op8= "มาก" ;
            }
            else  if (opt27.Checked == true)
            {
                op8= "พอสมควร" ;
            }
            else  if (opt28.Checked == true)
            {
                op8= "น้อย" ;
            }
            else 
            {
               op8= "ไม่เคยเลย" ;
            }


            Form2 frm = new Form2(op1,op2,op3 ,op4 ,op5 ,op6 ,op7 ,op8 );
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
