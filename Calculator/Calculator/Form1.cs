using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string output = string.Empty;
        int sayi=0;
        int carpil;
        int bölün;
        int sonuc=0;
        int first = 0;
        int toplama = 0;
        int cikarma = 0;
        int carpma = 0;
        int bölme = 0;
        int bsonuc = -1;
        int sum = 0;
        int ext = 0;
        int csonuc=-1;
        public void topla()
        {
            sayi = Int32.Parse(input);
            textBox2.Text = string.Empty;
            textBox2.Text = (sonuc + sayi).ToString();
        }
        public void cikar()
        {
            sayi = Int32.Parse(input);
            textBox2.Text = string.Empty;
            textBox2.Text = (sonuc - sayi).ToString();
         
        }
        public void carp()
        {
            carpil = Int32.Parse(input);
            if (sum > 0)
            {
                textBox2.Text = string.Empty;
                textBox2.Text = (sonuc + (sayi * carpil)).ToString();
            }
           else if (ext > 0)
            {
                textBox2.Text = string.Empty;
                textBox2.Text = (sonuc - (sayi * carpil)).ToString();
            }
            else
            {  if(csonuc==-1&&sayi!=0)
                {
                    csonuc = sayi;
                    sayi = 0;
                }
                textBox2.Text = string.Empty;
                //textBox2.Text = (sonuc + (csonuc * sayi * carpil)).ToString();
                textBox2.Text = (sonuc + (csonuc * carpil)).ToString();
            }
        }
        public void böl() /* bölmeye ayar çekilecek */
        {
            bölün=Int32.Parse(input);
            if (sum > 0)
            {
                textBox2.Text = string.Empty;
                textBox2.Text = (sonuc + (sayi / bölün)).ToString();
            }
            else if (ext > 0)
            {
                textBox2.Text = string.Empty;
                textBox2.Text = (sonuc - (sayi / bölün)).ToString();
            }
            else
            {
                if (bsonuc == -1)
                {
                    bsonuc = sayi;
                    sayi = 0;
                }
                textBox2.Text = string.Empty;
                // textBox2.Text = (sonuc + (sayi / bölün / bsonuc)).ToString();
                textBox2.Text = (sonuc + (bsonuc / bölün)).ToString();
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(carpma>0)
            {

                csonuc *= carpil;
               // sayi = 1;
                sum = 0;
                ext = 0;
            }
            if(bölme>0)
            {
                bsonuc /= bölün;
                csonuc = bsonuc;
            }
            bölme = 0;
            cikarma = 0;
            toplama = 0;
            carpma = 0;
                            sum = 0;
                ext = 0;
            if (first == 0)
            {
                try
                {
                    first = Int32.Parse(input);
                    csonuc = first;

                }
                catch (FormatException)
                { }
            }
            output += "x";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            input = String.Empty;
            carpma++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (toplama > 0)
            {
                sonuc += sayi;
            }
            if (cikarma > 0)
            {
                sonuc -= sayi;
            }
            if (carpma > 0)
            {
                if (sum > 0)
                {
                    sonuc += sayi * carpil;
                    sum = 0;
                }
               else if (ext > 0)
                {
                    sonuc -= sayi * carpil;
                    ext = 0;
                }
                else
                {
                    sonuc +=(csonuc*carpil);
                    csonuc = -1;
                    //sonuc += (csonuc * carpil);
                }
                sum = 0;
                ext = 0;
            }
            if (bölme > 0)
            {
                if (sum > 0)
                {
                    sonuc += sayi / bölün;
                    sum = 0;
                }
                else if (ext > 0)
                {
                    sonuc -= sayi / bölün;
                    ext = 0;
                }
                else
                {
                    sonuc += bsonuc/bölün;
                    bsonuc = -1;
                }
                sum = 0;
                ext = 0;
               
            }
            bölme = 0;
            carpma = 0;
            cikarma = 0;
            toplama = 0;
            if (first == 0)
            {


                try
                {
                    first = Int32.Parse(input);
                    sonuc += first;

                }
                catch (FormatException)
                { }
            }
            output += "+";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            input = String.Empty;
            toplama++;
            sum++;
            /* if(t>0)
             {
                 r1 += result;
             }
             t = 0;
             if (first == 0)
             {


                 try
                 {
                     first = Int32.Parse(input);
                     r1 += first;

                 }
                 catch (FormatException)
                 { }
             }
             input1 += "+";
             textBox1.Text = string.Empty;
             textBox1.Text = input1;
             input = String.Empty;
             t++;
            // r1 += result; */

        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*    this.textBox1.Text = "";
                input += "0";
                input1 += "0";
                this.textBox1.Text += output;
                input = string.Empty;*/
            input += "0";
            output += "0";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (toplama > 0)
            {
                topla();
            }
            if (cikarma > 0)
            {
                cikar();
            }
            if (carpma > 0)
            {
                carp();
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            output += "9";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (carpma > 0)
            {
                carp();
            }
            if (toplama>0)
            {
                /*  result = Int32.Parse(input);
                  // r1 += result;
                  // toplam2 = r1;
                  textBox2.Text = string.Empty;
                  textBox2.Text = (r1+result).ToString(); */
                topla();
            }
            if (cikarma > 0)
            {
                cikar();
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            output += "8";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (carpma > 0)
            {
                carp();
            }
            if (toplama > 0)
            {
                topla();
            }
            if (cikarma > 0)
            {
                cikar();
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            output += "7";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (carpma > 0)
            {
                carp();
            }
            if (toplama > 0)
            {
                topla();
            }
            if (cikarma > 0)
            {
                cikar();
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            output += "6";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (carpma > 0)
            {
                carp();
            }
            if (toplama > 0)
            {
                topla();
            }
            if (cikarma > 0)
            {
                cikar();
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            output += "5";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (carpma > 0)
            {
                carp();
            }
            if (toplama > 0)
            {
                topla();
            }
            if (cikarma > 0)
            {
                cikar();
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            output += "4";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (carpma > 0)
            {
                carp();
            }
            if (toplama > 0)
            {
                topla();
            }
            if (cikarma > 0)
            {
                cikar();
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            output += "2";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (carpma > 0)
            {
                carp();
             /*   carpil = Int32.Parse(input);
                if (sum > 0)
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = (sonuc + (sayi*carpil)).ToString();
                }
                if(ext>0)
                {
                    textBox2.Text = string.Empty;
                    textBox2.Text = (sonuc - (sayi * carpil)).ToString();
             ljhklşk
                }*/
            }
            if (toplama > 0)
            {
                topla();
               // sum = 0;
            }
            if (cikarma > 0)
            {
                cikar();
               // ext = 0;
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (bölme > 0)
            {

                bsonuc /= bölün;
               // sum = 0;
                //ext = 0;
            }
            if(carpma>0)
            {
                csonuc *= carpil;
                bsonuc = csonuc;
            }
            sum = 0;
            ext = 0;
            cikarma = 0;
            toplama = 0;
            carpma = 0;
            bölme = 0;
            if (first == 0)
            {
                try
                {
                    first = Int32.Parse(input);
                    bsonuc = first;

                }
                catch (FormatException)
                { }
            }
            output += "/";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            input = String.Empty;
            bölme++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            output += "3";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            if (carpma > 0)
            {
                carp();
            }
            if (toplama > 0)
            {
                topla();
            }
            if (cikarma > 0)
            {
                cikar();
            }
            if (bölme > 0)
            {
                böl();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (cikarma > 0)
            {
                sonuc -= sayi;
            }
            if (toplama > 0)
            {
                sonuc += sayi;
            }
            if (carpma > 0)
            {
                if (sum > 0)
                {
                    sonuc += sayi * carpil;
                    sum = 0;
                }
               else if (ext > 0)
                {
                    sonuc -= sayi * carpil;
                    ext = 0;
                }
                else
                {
                    sonuc += csonuc * carpil;
                    csonuc = -1;
                }
                sum = 0;
                ext = 0;
            }
            if (bölme > 0)
            {
                if (sum > 0)
                {
                    sonuc += sayi / bölün;
                    sum = 0;
                }
                else if (ext > 0)
                {
                    sonuc -= sayi /bölün;
                    ext = 0;
                }
                else
                {
                    sonuc += bsonuc / sayi / bölün;
                    bsonuc = -1;

                }
                sum = 0;
                ext = 0;
            }
            bölme = 0;
            carpma = 0;
            toplama = 0;
            cikarma = 0;
            if (first == 0)
            {


                try
                {
                    first = Int32.Parse(input);
                    sonuc += first;

                }
                catch (FormatException)
                { }
            }
            output += "-";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
            input = String.Empty;
            cikarma++;
            ext++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            output += "1";
            textBox1.Text = string.Empty;
            textBox1.Text = output;
           if(carpma>0)
            {
                carp();
            }
            if (toplama > 0)
            {
                topla();
            }
            if(cikarma>0)
            {
                cikar();
            }
            if(bölme>0)
            {
                böl();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.AutoSize = false;
            textBox1.Size = new Size(142, 27);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
