using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Odev_VeriYapıları_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string metin = "";

        LinkedListStack cumlelistStack = new LinkedListStack();
        LinkedListStack kelimelistStack = new LinkedListStack();
        LinkedListStack essizkelimestack = new LinkedListStack();



        private void Form1_Load(object sender, EventArgs e)
        {











        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Lütfen Bir Dosya Seçiniz";
            openFileDialog.FileName = "Dosya Seç";
            openFileDialog.InitialDirectory = @"C:\Users\Hayalim\Desktop\Ödev Deneme Metinleri";            //ilk açılacak dizini belirtiyoruz openfilediolog açılınca
            openFileDialog.Filter = "Metin dosyaları (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";


            openFileDialog.ShowDialog();
            textBox1.Text = openFileDialog.FileName;
            StreamReader streamReader = new StreamReader(openFileDialog.OpenFile());
            metin = streamReader.ReadToEnd();










        }

        private void button3_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(metin);
            string cumle = "";
            int cumledeki_kelimesayi = 0;
            foreach (var harf in metin)
            {
                if (harf.ToString() == "\n")
                {
                    cumlelistStack.Push(cumle,cumledeki_kelimesayi);//son kelimeyi almak için
                    cumledeki_kelimesayi = 0;

                    cumle = "";


                }
                else
                {
                    if (harf.ToString() == " ")
                    {
                        cumle += harf.ToString();
                        cumledeki_kelimesayi++;
                    }
                    else
                    {
                        cumle += harf.ToString();
                    }

                }


            }
            cumlelistStack.Push(cumle, cumledeki_kelimesayi);//son cumleyi eklemek için
            textBox2.Text = cumlelistStack.cumleYazdir();







           


            string[] kelime_dizi = metin.Split(' ');
            foreach (var kelime in kelime_dizi)//[ağaç,elma armut]
            {
                kelimelistStack.Push(kelime.ToLower(),cumledeki_kelimesayi);
                
                essizkelimestack.Push(kelime.ToLower(),cumledeki_kelimesayi,true);
            }

            LinkedListNode uniq = new LinkedListNode();
            textBox3.Text = kelimelistStack.kelimeyaz();
           



          

            cumlelistStack.Push(cumle, cumledeki_kelimesayi);
            
            int[] metin_cumle_ayir = cumlelistStack.MetinCumleAyirici();
            int[] cumle_kelime_ayir = kelimelistStack.MetinCumleAyirici();

            int i = 1;

            foreach (var item in metin_cumle_ayir)
            {
                i++;
                
            }
            
            textBox5.Text = ((i-1).ToString() + " cümle vardır");







      


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
             HashTable hashTable = new HashTable();
        }
    }
}
