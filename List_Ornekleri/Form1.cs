using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Ornekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler=new List<string>();
            karakterler.Add("Ahmet");
            karakterler.Add("Ayşe");
            karakterler.Add("Mehmet");
            karakterler.Add("Halil");
            karakterler.Add("Yakup");
            karakterler.Add("Yağız");

            foreach(string k in karakterler)
            {
                listBox1.Items.Add(k);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar=new List<int>();
            sayilar.Add(1);
            sayilar.Add(10);
            sayilar.Add(14);               
            sayilar.Add(19);
            sayilar.Add(25);
            sayilar.Add(35);
            sayilar.Add(45);
            
            foreach(int i in sayilar)
            {
                if(i % 5==0)
                {
                    listBox2.Items.Add(i);
                }

               /* if (sayilar.Contains(17))
                {
                    MessageBox.Show("Bu sayı var");
                }
                else
                {
                    MessageBox.Show("Bu sayı yok");
                } */
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<kisiler> kisi = new List<kisiler>();
            kisi.Add(new kisiler()
            {
                ADI = "ALİ",
                SOYADI = "AKTAŞ",
                MESLEK = "OGRETMEN"
            });

            foreach(kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI+" "+k.SOYADI+" "+k.MESLEK);  
            }
        }
    }
}
