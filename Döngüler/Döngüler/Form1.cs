namespace Döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //For olmadan önce tek tek 
            listBox1.Items.Add("Merhaba Ankara");
            listBox1.Items.Add("Merhaba Ankara");
            listBox1.Items.Add("Merhaba Ankara");
            listBox1.Items.Add("Merhaba Ankara");
            listBox1.Items.Add("Merhaba Ankara");

            //Forda tek satırda birden çok yazdır
            int i;
            for (i = 1; i <= 100; i++)
            {
                listBox1.Items.Add("Merhaba Ankara");
            }

            for (i = 1; i <= 6; i++)
            {
                listBox1.Items.Add(i);
            }

            //Break point  sol en köşeden kırmızı break point atılır.

            for (i = 5; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }

            // Sayı toplamları pratik 
            int toplam = 0;
            for (i = 2; i <= 10; i++)
            {
                toplam = toplam + i;
            }

            label1.Text = "Toplam : " + toplam.ToString();


            //Karar yapıları ile Döngü kullanımı
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add("3 bölünür :  " + i);
                }
                if (i % 5 == 0 && i % 7 == 0)
                {
                    listBox1.Items.Add("5 'e ve 7'e bölünür" + i);
                }
            }

            //Klavyeden girilen sayı kadar yazdıran program
            int sayi = Convert.ToInt32(textBox1.Text);
            for (i = 1; i <= sayi; i++)
            {
                listBox1.Items.Add(i);
            }

            //Klavyeden girilen sayının tam bölenlerini bulma
            for (i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }

            //While döngüsü şart sağlandığı sürece
            i = 1;
            while (i <= 5)
            {
                listBox1.Items.Add(i);
                listBox2.Items.Add("Merhaba Elazığ");
                i++;
            }

            int j = 1;
            toplam = 0;
            while (j <= 5)
            {
                toplam = toplam + j;
                j++;
            }
            MessageBox.Show(toplam.ToString());

            //Do While
            i = 1;
            do
            {
                listBox1.Items.Add("Merhaba K.maraş");
            }
            while (i <= 10);
        }

    }
}