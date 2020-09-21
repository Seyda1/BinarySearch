using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace binarysearch
{
    
      
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        Elemanlar eleman = new Elemanlar();
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            Random random = new Random();
            for (int i = 0; i < eleman.sayilar.Length; i++)
            {
                eleman.sayilar[i] = random.Next(1, 1000);
            }
            Array.Sort(eleman.sayilar);
            
          
            textBox1.Text = Convert.ToString(eleman.sayilar[0]);
            textBox2.Text = Convert.ToString(eleman.sayilar[1]);
            textBox7.Text = Convert.ToString(eleman.sayilar[2]);
            textBox3.Text = Convert.ToString(eleman.sayilar[3]);
            textBox5.Text = Convert.ToString(eleman.sayilar[4]);
            textBox8.Text = Convert.ToString(eleman.sayilar[5]);
            textBox4.Text = Convert.ToString(eleman.sayilar[6]);
            textBox9.Text = Convert.ToString(eleman.sayilar[7]);
            textBox6.Text = Convert.ToString(eleman.sayilar[8]);
            textBox10.Text = Convert.ToString(eleman.sayilar[9]);
           
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            label2.Visible = false;
            
            
        
        }
      
        private int aranan_sayi;
        private int enBuyukIndis = 9;//sayilar.length-1
        private int enKucukIndis = 0;
        private  int orta;
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            aranan_sayi = Convert.ToInt32(textBox11.Text);
          
           
                while (enKucukIndis <= enBuyukIndis)
                {

                    orta = (enKucukIndis + enBuyukIndis) / 2;

                    if (aranan_sayi == eleman.sayilar[orta])
                    {
                        islemler();
                        
                        label2.Visible = true;
                        label2.Text = "***aradığınız sayı [ " + orta  + " ] indisinde bulundu***";
                        textBox11.Enabled = false;
                        break;

                    }

                    else if (aranan_sayi < eleman.sayilar[orta])
                    {
                       
                        enBuyukIndis = orta - 1;
                        islemler();
                        if (enBuyukIndis < enKucukIndis)
                        {
                            
                            label2.Text = "***ARADIĞINIZ SAYI BULUNAMADI!!***";
                            textBox11.Enabled = false;
                           
                        }
                        break;
                       
                    }
                    else if (aranan_sayi > eleman.sayilar[orta])
                    {
                        enKucukIndis = orta + 1;
                       
                        islemler();
                        if (enBuyukIndis < enKucukIndis)
                        {
                            label2.Visible = true;
                            label2.Text = "***ARADIĞINIZ SAYI BULUNAMADI!!***";
                            textBox11.Enabled = false;
                            
                        }
                        break;
                        
                    }
                  

                }
               
        }

        private void islemler()
        {
           
            if (orta == 0)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
            else if (orta == 1)
            {
                pictureBox5.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (orta == 2)
            {
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (orta == 3)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (orta == 4)
            {
              
                pictureBox5.Visible = true;
            }
            else if (orta == 5)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (orta == 6)
            {
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = true;
                
            }
            else if (orta == 7)
            {
                pictureBox5.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = true;
                
            }
            else if (orta == 8)
            {
                pictureBox10.Visible = false;
                pictureBox9.Visible = true;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }
            else if (orta == 9)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
            {
                
                           
                
            }
    }
}
