using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Çarpı işaretine tıklandığında programı kapatır.
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Mevcut formu hareket ettirmemizi sağlar.
        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move ==1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        public string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index))
                    .Insert(index, replace);
        }

        int hataSayma = 0;
        // Proje dosyasında bulunan kategori adlı klasörde bulunan txt uzantılı metin belgelerinin isimlerini string yapısındaki kategori değişkenine atama yapmamızı sağlıyor.
        string[] kategori = { "İsimler", "Hayvanlar", "Eşyalar", "Şehirler", "Ülkeler" };
        Random rnd = new Random();
        List<string> secilenKelimeler = new List<string>();
        string kelime = "";


        private void Form1_Load(object sender, EventArgs e)
        {
            oyunBasla();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        int puan = 0;


        private void harf(object sender, EventArgs e)
        {
            Button secilenHarf = sender as Button;
            // Seçilen harfin bir daha seçilememesini sağlar.
            secilenHarf.Enabled = false;

            // seçilen harfin kelimede olup olmadığını kontrol eder eğer ki seçilen harf kelimede yok ise if bloğunun içerisindeki olayları gerçekleştirir.
            if (kelime.Contains(secilenHarf.Text) == false)
            {
                // hataSayma değişkenini global bir değişken olarak tanımlamıştık her hatalı harf seçiminde bu değeri 1 arttırarak resmin devam etmesini sağlıyoruz.
                hataSayma++;
                // hata sayısına göre adam asma resimleri klasöründe bulunan resimleri sırasıyla pictureBox1 öğesine yansıtıyoruz.
                pictureBox1.Load("Adam Resimleri/" + hataSayma + ".png");
                // Yapılan her hatada başlangıçta 10 olarak tanımlanmış değeri bir bir azaltmamıza yarıyor.
                label5.Text = (10 - hataSayma).ToString();
            }

            // Yukarıda ki if bloğu false değilde true döndurduğunde aşağıda bulunan else bloğunun içerisine giriyor.
            else
            {
                string yazi = lbl_tahmin.Text.Replace(" ", "");
                for (int i = 0;i < kelime.Length; i++)
                {
                    // Seçilen harfin kelimede olup olmadığını kontrol eder var ise aşağıda kod bloğu çalışmaya başlar.
                    if (kelime[i].ToString() == secilenHarf.Text)
                    {
                        // Doğru seçilen harf tahmin kısmındaki yerini alır ve kullanıcı doğru bir tahmin yaptığından dolayı puan değişkeni 10 puan arttırılır. 
                        yazi = ReplaceAt(yazi, i, 1, secilenHarf.Text);
                        puan += 10;
                    }
                }

                string sonuc = "";
                for(int i = 0; i < yazi.Length; i++)
                {
                    sonuc += yazi[i].ToString() + " ";
                    lbl_tahmin.Text = sonuc;
                    label8.Text = puan.ToString();

                }
            }
            // Kalan hak 0 olduğu takdirde aşağıda if bloğuna giriş yapar.
            if (label5.Text == "0")
            {
                // Her yanlış harf için puan kırılır ve programın sonunda mevcut puandan çıkarılıp kullanıcıya gösterilir.
                puan -= lbl_tahmin.Text.Length * 10;
                label8.Text = puan.ToString();
                label8.Text = puan.ToString();
                // Kalan hak 0 olduğunda bu blok çalışacağından dolayı oyunu kaybetmiş oluyoruz ve tekrar oynamak ister misiniz sorusunu göstermek için bir messageBox kullanıyoruz.
                DialogResult dialogResult = MessageBox.Show("Maalesef Kaybettiniz Kelime : " + kelime + " Tekrar Oynamak İstiyor Musunuz ?", "Oyun Sonu", MessageBoxButtons.YesNo);
                // Evet seçildiğinde aşağıdaki if bloğu çalışır ve sizi oyunBitir metoduna yönlendirir.
                if (dialogResult == DialogResult.Yes)
                    oyunBitir();
                // Hayır seçeneği seçildiği takdirde uygulamayı kapatır.
                else
                    Application.Exit();
            }

            // Kelimede bulanan bir harf seçildiğinde aşağıdaki if bloğu çalışır.
            if (lbl_tahmin.Text.Replace(" ", "") == kelime)
            {
                // Doğru yapılan her harf tahmininde kelimede bulunduğu sayı kadar 10 puan alır. (Eren kelimesinde "E" seçildiğinde kelime içerisinde 2 tane "E" olduğundan dolayı 20 puan kazanır.)
                puan += lbl_tahmin.Text.Length * 10;
                label8.Text = puan.ToString();
                // Evet seçildiğinde aşağıdaki if bloğu çalışır ve sizi oyunBitir metoduna yönlendirir.
                DialogResult dialogResult = MessageBox.Show("Tebrikler Kazandınız Kelime : " + kelime + " Tekrar Oynamak İstiyor Musunuz ?", "Oyun Sonu", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    oyunBitir();
                // Hayır seçeneği seçildiği takdirde uygulamayı kapatır
                else
                    Application.Exit();
            }
        }

        private void oyunBasla()
        {
            secilenKelimeler.Clear();
            // Program başlangıcında boş bir resim ekliyo. Hata sayısı arttıkça resim değişiyor.
            pictureBox1.Load("Adam Resimleri/" + hataSayma + ".png");
            // Seçilecek olan kelimenin katagorisini rastgele bir şekilde seçiyoruz.
            label3.Text = kategori[rnd.Next(kategori.Length)];
            // Katagoride seçilen txt dosyasını label3 textine yansıtma yapıyoruz.
            FileStream fs = new FileStream("Kategori/" + label3.Text + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                secilenKelimeler.Add(yazi.ToUpper());
                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            // Seçilen kelimenin uzunluğu kadar "_" işareti koyuyoruz.
            kelime = secilenKelimeler[rnd.Next(secilenKelimeler.Count)];
            for (int i = 0; i < kelime.Length; i++)
                lbl_tahmin.Text += "_ ";
        }
        private void oyunBitir()
        {
            // Mevcut oyunda bulunan herşeyi sıfırlar ve yeni bir oyun açma imkanı sunar.
            foreach (Control btns in this.Controls)
                if (btns is Button)
                    ((Button)btns).Enabled = true;
            lbl_tahmin.Text = "";
            label5.Text = "10";
            hataSayma = 0;
            oyunBasla();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
