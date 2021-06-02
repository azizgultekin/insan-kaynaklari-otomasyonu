using System;
using System.IO;
using System.Windows.Forms;

namespace odev1_deneme
{
    public partial class ik : Form
    {
        public string dosya_yolu_kullanicilar = @"C:\Users\Enesg\OneDrive\Masaüstü\proje\kullanicilar";
        public string dosya_yolu_admin = @"C:\Users\Enesg\OneDrive\Masaüstü\proje\admin";
        public string dosya_yolu_masaustu = @"C:\Users\Enesg\OneDrive\Masaüstü";
        //public string dosya_yolu_kullanicilar = @"C:\Users\Aziz GÜLTEKİN\Desktop\proje\kullanicilar";
        //public string dosya_yolu_admin = @"C:\Users\Aziz GÜLTEKİN\Desktop\proje\admin";
        //public string dosya_yolu_masaustu = @"C:\Users\Aziz GÜLTEKİN\Desktop";
        public static int derinlik_s;
        public ik()
        {
            InitializeComponent();
        }

        class Dugum
        {
            public long veri;
            public Dugum Sol;
            public Dugum Sag;
        }
        class Agac
        {
            public int derinlik_sayisi = 1;
            
            public Dugum kok = new Dugum();
            public Agac()
            {
                kok = null;
            }
            public Dugum ReturnKok()
            {
                return kok;
            }
            public void Ekle(long v)
            {
                Dugum YeniDugum = new Dugum();
                YeniDugum.veri = v;
                ik i = new ik();
                if (kok == null)
                {
                    kok = YeniDugum;
                    this.derinlik_sayisi = derinlik_s;
                    derinlik_s++;
                    i.label8.Text = derinlik_s.ToString();
                }
                else
                {
                    Dugum ebeveyn;
                    Dugum mevcut = kok;

                    while (true)
                    {
                        ebeveyn = mevcut;
                        if (v < mevcut.veri)
                        {
                            mevcut = mevcut.Sol;
                            if (mevcut == null)
                            {
                                ebeveyn.Sol = YeniDugum;
                                this.derinlik_sayisi = derinlik_s;
                                derinlik_s++;
                                i.label8.Text = derinlik_s.ToString();
                                return;
                            }
                        }
                        else
                        {
                            mevcut = mevcut.Sag;
                            if (mevcut == null)
                            {
                                ebeveyn.Sag = YeniDugum;
                                this.derinlik_sayisi = derinlik_s;
                                derinlik_s++;
                                i.label8.Text = derinlik_s.ToString();
                                return;
                            }
                        }
                    }
                }
            }
            public void PreOrder(Dugum k)
            {
                ik s = new ik();
                string yenidosya_yolu = s.dosya_yolu_admin + @"\" + "2" + ".txt";

                if (k != null)
                {
                    if (k.veri != 0)
                    {
                        File.AppendAllText(yenidosya_yolu, k.veri + Environment.NewLine);
                    }
                    PreOrder(k.Sol);
                    PreOrder(k.Sag);
                    File.AppendAllText(yenidosya_yolu, "\n" + Environment.NewLine);
                }

            }
            public void InOrder(Dugum k)
            {
                ik s = new ik();
                string yenidosya_yolu = s.dosya_yolu_admin + @"\" + "1" + ".txt";
                if (k != null)
                {
                    InOrder(k.Sol);
                    if (k.veri != 0)
                    {
                        File.AppendAllText(yenidosya_yolu, k.veri + Environment.NewLine);
                    }
                    InOrder(k.Sag);
                    File.AppendAllText(yenidosya_yolu, "\n" + Environment.NewLine);
                }
            }
            public void PostOrder(Dugum k)
            {
                ik s = new ik();
                string yenidosya_yolu = s.dosya_yolu_admin + @"\" + "0" + ".txt";

                if (k != null)
                {

                    PostOrder(k.Sol);
                    PostOrder(k.Sag);
                    if (k.veri != 0)
                    {
                        File.AppendAllText(yenidosya_yolu, k.veri + Environment.NewLine);
                    }
                }
            }
            public void Tcolustur()
            {
                ik s = new ik();
                string yenidosya_yolu_postorder = s.dosya_yolu_admin + @"\" + "0" + ".txt";
                string yenidosya_yolu_inorder = s.dosya_yolu_admin + @"\" + "1" + ".txt";
                string yenidosya_yolu_preorder = s.dosya_yolu_admin + @"\" + "2" + ".txt";
                bool kontrol = File.Exists(yenidosya_yolu_postorder);
                bool kontrol2 = File.Exists(yenidosya_yolu_postorder);
                bool kontrol3 = File.Exists(yenidosya_yolu_postorder);
                if (kontrol == true && kontrol2 == true && kontrol3 == true)
                {
                    File.Delete(yenidosya_yolu_postorder);
                    File.Delete(yenidosya_yolu_inorder);
                    File.Delete(yenidosya_yolu_preorder);
                    FileStream fs = File.Create(yenidosya_yolu_postorder);
                    FileStream fs2 = File.Create(yenidosya_yolu_inorder);
                    FileStream fs3 = File.Create(yenidosya_yolu_preorder);

                    fs.Close();
                    fs2.Close();
                    fs3.Close();
                }
                else
                {
                    FileStream fs = File.Create(yenidosya_yolu_postorder);
                    FileStream fs2 = File.Create(yenidosya_yolu_inorder);
                    FileStream fs3 = File.Create(yenidosya_yolu_preorder);
                    fs.Close();
                    fs2.Close();
                    fs3.Close();
                }
            }
            public void Verilerigetir(long da)
            {
                ik s = new ik();
                string yenidosya_yolu = s.dosya_yolu_kullanicilar + @"\" + da.ToString() + ".txt";
                bool kontrol = File.Exists(yenidosya_yolu);
                if (kontrol == true)
                {
                    StreamReader sr = File.OpenText(yenidosya_yolu);
                    sr.Close();
                    StreamWriter sw = new StreamWriter(yenidosya_yolu);
                    sw.Write(da);
                    sw.Close();
                    string satir = sr.ReadLine();

                }
                else
                {
                    MessageBox.Show("Kaydınız bulunmamaktadır.");
                }
            }
        }

        public void Listeleme()
        {
            int sayac = 0;
            l.Items.Clear();
            string yenidosya_yolu = sec();
            File.AppendAllText(yenidosya_yolu, "\n\n" + Environment.NewLine);
            bool kontrol = File.Exists(yenidosya_yolu);
            if (kontrol == true)
            {
                StreamReader sr = File.OpenText(yenidosya_yolu);
                string satir = sr.ReadLine();
                while (satir != "")
                {
                    string yenidosya_yolu2 = dosya_yolu_kullanicilar + @"\" + satir + ".txt";
                    StreamReader sr2 = File.OpenText(yenidosya_yolu2);
                    string satir2 = sr2.ReadLine();
                    bool kontrol2 = File.Exists(yenidosya_yolu2);

                    if (kontrol2 == true)
                    {
                        while (satir2 != "")
                        {
                            if (ik_ad_listele_txt.Text != "")
                            {

                                if (satir2.Contains("Ad: " + ik_ad_listele_txt.Text) == true)
                                {
                                    sr2 = File.OpenText(yenidosya_yolu2);
                                    satir2 = sr2.ReadLine();
                                    while (satir2 != "")
                                    {
                                        if (ik_mezun_dg_txt.Text != "")
                                        {

                                            if (satir2.Contains("Türü: " + ik_mezun_dg_txt.Text) == true)
                                            {
                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_yabancidil_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Yabancı dil: ") == true && satir2.Contains(ik_yabancidil_txt.Text) == true)
                                                        {
                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_min_deneyim_suresi_cmb.Text != "")
                                                                {
                                                                    double d_suresi = Deneyim_sure_bul(yenidosya_yolu2);
                                                                    
                                                                    if (d_suresi >= Convert.ToDouble(ik_min_deneyim_suresi_cmb.Text))
                                                                    {
                                                                       
                                                                        sr2 = File.OpenText(yenidosya_yolu2);
                                                                        satir2 = sr2.ReadLine();
                                                                        while (satir2 != "")
                                                                        {
                                                                            if (ik_belirli_yas_txt.Text != "")
                                                                            {
                                                                                int yas = Yas_bul(yenidosya_yolu2);

                                                                                if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                                                {

                                                                                    sr2 = File.OpenText(yenidosya_yolu2);
                                                                                    satir2 = sr2.ReadLine();
                                                                                    while (satir2 != "")
                                                                                    {
                                                                                        if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                                        {
                                                                                            if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                                            {
                                                                                                Istenilenveriyicek(yenidosya_yolu2);
                                                                                                sayac++;
                                                                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                                goto enes;
                                                                                            }
                                                                                            satir2 = sr2.ReadLine();
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                                                            sayac++;
                                                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                            goto enes;
                                                                                        }
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    goto enes;
                                                                                }

                                                                                satir2 = sr2.ReadLine();
                                                                            }
                                                                            else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                            {
                                                                                if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                                {
                                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                                    sayac++;
                                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                    goto enes;
                                                                                }
                                                                                satir2 = sr2.ReadLine();
                                                                            }
                                                                            else
                                                                            {
                                                                                Istenilenveriyicek(yenidosya_yolu2);
                                                                                sayac++;
                                                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                goto enes;
                                                                            }
                                                                        }

                                                                    }
                                                                    else
                                                                    {
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }

                                                                else if (ik_belirli_yas_txt.Text != "")
                                                                {
                                                                    int yas = Yas_bul(yenidosya_yolu2);

                                                                    if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                                    {

                                                                        sr2 = File.OpenText(yenidosya_yolu2);
                                                                        satir2 = sr2.ReadLine();
                                                                        while (satir2 != "")
                                                                        {
                                                                            if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                            {
                                                                                if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                                {
                                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                                    sayac++;
                                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                    goto enes;
                                                                                }
                                                                                satir2 = sr2.ReadLine();
                                                                            }
                                                                            else
                                                                            {
                                                                                Istenilenveriyicek(yenidosya_yolu2);
                                                                                sayac++;
                                                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                goto enes;
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        goto enes;
                                                                    }

                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }

                                                            }


                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else if (ik_min_deneyim_suresi_cmb.Text != "")
                                                    {
                                                        double d_suresi = Deneyim_sure_bul(yenidosya_yolu2);
                                                        if (d_suresi >= Convert.ToDouble(ik_min_deneyim_suresi_cmb.Text))
                                                        {
                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_yas_txt.Text != "")
                                                                {
                                                                    int yas = Yas_bul(yenidosya_yolu2);

                                                                    if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                                    {

                                                                        sr2 = File.OpenText(yenidosya_yolu2);
                                                                        satir2 = sr2.ReadLine();
                                                                        while (satir2 != "")
                                                                        {
                                                                            if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                            {
                                                                                if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                                {
                                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                                    sayac++;
                                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                    goto enes;
                                                                                }
                                                                                satir2 = sr2.ReadLine();
                                                                            }
                                                                            else
                                                                            {
                                                                                Istenilenveriyicek(yenidosya_yolu2);
                                                                                sayac++;
                                                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                goto enes;
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        goto enes;
                                                                    }

                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }

                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else if (ik_belirli_yas_txt.Text != "")
                                                    {
                                                        int yas = Yas_bul(yenidosya_yolu2);

                                                        if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                        {

                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }

                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }

                                                }

                                            }
                                            else
                                            {

                                            }
                                            satir2 = sr2.ReadLine();

                                        }
                                        else if (ik_yabancidil_txt.Text != "")
                                        {
                                            if (satir2.Contains("Yabancı dil: ") == true && satir2.Contains(ik_yabancidil_txt.Text) == true)
                                            {
                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_min_deneyim_suresi_cmb.Text != "")
                                                    {
                                                        double d_suresi = Deneyim_sure_bul(yenidosya_yolu2);
                                                        if (d_suresi >= Convert.ToDouble(ik_min_deneyim_suresi_cmb.Text))
                                                        {
                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_yas_txt.Text != "")
                                                                {
                                                                    int yas = Yas_bul(yenidosya_yolu2);

                                                                    if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                                    {

                                                                        sr2 = File.OpenText(yenidosya_yolu2);
                                                                        satir2 = sr2.ReadLine();
                                                                        while (satir2 != "")
                                                                        {
                                                                            if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                            {
                                                                                if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                                {
                                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                                    sayac++;
                                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                    goto enes;
                                                                                }
                                                                                satir2 = sr2.ReadLine();
                                                                            }
                                                                            else
                                                                            {
                                                                                Istenilenveriyicek(yenidosya_yolu2);
                                                                                sayac++;
                                                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                goto enes;
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        goto enes;
                                                                    }

                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }

                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }

                                                    else if (ik_belirli_yas_txt.Text != "")
                                                    {
                                                        int yas = Yas_bul(yenidosya_yolu2);

                                                        if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                        {

                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }

                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }

                                                }


                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else if (ik_min_deneyim_suresi_cmb.Text != "")
                                        {
                                            double d_suresi = Deneyim_sure_bul(yenidosya_yolu2);
                                            if (d_suresi >= Convert.ToDouble(ik_min_deneyim_suresi_cmb.Text))
                                            {
                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_belirli_yas_txt.Text != "")
                                                    {
                                                        int yas = Yas_bul(yenidosya_yolu2);

                                                        if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                        {

                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }

                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                goto enes;
                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else if (ik_belirli_yas_txt.Text != "")
                                        {
                                            int yas = Yas_bul(yenidosya_yolu2);

                                            if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                            {

                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                goto enes;
                                            }

                                            satir2 = sr2.ReadLine();
                                        }
                                        else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                        {
                                            if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                            {
                                                Istenilenveriyicek(yenidosya_yolu2);
                                                sayac++;
                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                goto enes;
                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else
                                        {
                                            Istenilenveriyicek(yenidosya_yolu2);
                                            sayac++;
                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                            goto enes;
                                        }
                                    }
                                }
                                satir2 = sr2.ReadLine();

                            }
                            else if (ik_mezun_dg_txt.Text != "")
                            {

                                if (satir2.Contains("Türü: " + ik_mezun_dg_txt.Text) == true)
                                {
                                    sr2 = File.OpenText(yenidosya_yolu2);
                                    satir2 = sr2.ReadLine();
                                    while (satir2 != "")
                                    {
                                        if (ik_yabancidil_txt.Text != "")
                                        {
                                            if (satir2.Contains("Yabancı dil: ") == true && satir2.Contains(ik_yabancidil_txt.Text) == true)
                                            {
                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_min_deneyim_suresi_cmb.Text != "")
                                                    {
                                                        double d_suresi = Deneyim_sure_bul(yenidosya_yolu2);
                                                        if (d_suresi >= Convert.ToDouble(ik_min_deneyim_suresi_cmb.Text))
                                                        {
                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_yas_txt.Text != "")
                                                                {
                                                                    int yas = Yas_bul(yenidosya_yolu2);

                                                                    if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                                    {

                                                                        sr2 = File.OpenText(yenidosya_yolu2);
                                                                        satir2 = sr2.ReadLine();
                                                                        while (satir2 != "")
                                                                        {
                                                                            if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                            {
                                                                                if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                                {
                                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                                    sayac++;
                                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                    goto enes;
                                                                                }
                                                                                satir2 = sr2.ReadLine();
                                                                            }
                                                                            else
                                                                            {
                                                                                Istenilenveriyicek(yenidosya_yolu2);
                                                                                sayac++;
                                                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                                goto enes;
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }

                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }

                                                    else if (ik_belirli_yas_txt.Text != "")
                                                    {
                                                        int yas = Yas_bul(yenidosya_yolu2);

                                                        if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                        {

                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }

                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }

                                                }


                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else if (ik_min_deneyim_suresi_cmb.Text != "")
                                        {
                                            double d_suresi = Deneyim_sure_bul(yenidosya_yolu2);
                                            if (d_suresi >= Convert.ToDouble(ik_min_deneyim_suresi_cmb.Text))
                                            {
                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_belirli_yas_txt.Text != "")
                                                    {
                                                        int yas = Yas_bul(yenidosya_yolu2);

                                                        if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                        {

                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }

                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                goto enes;
                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else if (ik_belirli_yas_txt.Text != "")
                                        {
                                            int yas = Yas_bul(yenidosya_yolu2);

                                            if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                            {

                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                goto enes;
                                            }

                                            satir2 = sr2.ReadLine();
                                        }
                                        else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                        {
                                            if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                            {
                                                Istenilenveriyicek(yenidosya_yolu2);
                                                sayac++;
                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                goto enes;
                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else
                                        {
                                            Istenilenveriyicek(yenidosya_yolu2);
                                            sayac++;
                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                            goto enes;
                                        }

                                    }

                                }
                                satir2 = sr2.ReadLine();
                            }
                            else if (ik_yabancidil_txt.Text != "")
                            {
                                if (satir2.Contains("Yabancı dil: ") == true && satir2.Contains(ik_yabancidil_txt.Text) == true)
                                {
                                    sr2 = File.OpenText(yenidosya_yolu2);
                                    satir2 = sr2.ReadLine();
                                    while (satir2 != "")
                                    {
                                        if (ik_min_deneyim_suresi_cmb.Text != "")
                                        {
                                            double d_suresi = Deneyim_sure_bul(yenidosya_yolu2);
                                            if (d_suresi >= Convert.ToDouble(ik_min_deneyim_suresi_cmb.Text))
                                            {
                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_belirli_yas_txt.Text != "")
                                                    {
                                                        int yas = Yas_bul(yenidosya_yolu2);

                                                        if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                                        {

                                                            sr2 = File.OpenText(yenidosya_yolu2);
                                                            satir2 = sr2.ReadLine();
                                                            while (satir2 != "")
                                                            {
                                                                if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                                {
                                                                    if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                                    {
                                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                                        sayac++;
                                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                        goto enes;
                                                                    }
                                                                    satir2 = sr2.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Istenilenveriyicek(yenidosya_yolu2);
                                                                    sayac++;
                                                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                                    goto enes;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            goto enes;
                                                        }

                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                goto enes;
                                            }
                                            satir2 = sr2.ReadLine();
                                        }

                                        else if (ik_belirli_yas_txt.Text != "")
                                        {
                                            int yas = Yas_bul(yenidosya_yolu2);

                                            if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                            {

                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                goto enes;
                                            }

                                            satir2 = sr2.ReadLine();
                                        }
                                        else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                        {
                                            if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                            {
                                                Istenilenveriyicek(yenidosya_yolu2);
                                                sayac++;
                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                goto enes;
                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else
                                        {
                                            Istenilenveriyicek(yenidosya_yolu2);
                                            sayac++;
                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                            goto enes;
                                        }

                                    }


                                }
                                satir2 = sr2.ReadLine();
                            }
                            else if (ik_min_deneyim_suresi_cmb.Text != "")
                            {
                                double d_suresi = Deneyim_sure_bul(yenidosya_yolu2);
                                if (d_suresi >= Convert.ToDouble(ik_min_deneyim_suresi_cmb.Text))
                                {
                                    sr2 = File.OpenText(yenidosya_yolu2);
                                    satir2 = sr2.ReadLine();
                                    while (satir2 != "")
                                    {
                                        if (ik_belirli_yas_txt.Text != "")
                                        {
                                            int yas = Yas_bul(yenidosya_yolu2);

                                            if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                            {

                                                sr2 = File.OpenText(yenidosya_yolu2);
                                                satir2 = sr2.ReadLine();
                                                while (satir2 != "")
                                                {
                                                    if (ik_belirli_tip_ehliyet_txt.Text != "")
                                                    {
                                                        if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                                        {
                                                            Istenilenveriyicek(yenidosya_yolu2);
                                                            sayac++;
                                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                            goto enes;
                                                        }
                                                        satir2 = sr2.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Istenilenveriyicek(yenidosya_yolu2);
                                                        sayac++;
                                                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                        goto enes;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                goto enes;
                                            }

                                            satir2 = sr2.ReadLine();
                                        }
                                        else if (ik_belirli_tip_ehliyet_txt.Text != "")
                                        {
                                            if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                            {
                                                Istenilenveriyicek(yenidosya_yolu2);
                                                sayac++;
                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                goto enes;
                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else
                                        {
                                            Istenilenveriyicek(yenidosya_yolu2);
                                            sayac++;
                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                            goto enes;
                                        }
                                    }

                                }
                                else
                                {
                                    goto enes;
                                }
                            }
                            else if (ik_belirli_yas_txt.Text != "")
                            {
                                int yas = Yas_bul(yenidosya_yolu2);

                                if (yas <= Convert.ToInt32(ik_belirli_yas_txt.Text))
                                {

                                    sr2 = File.OpenText(yenidosya_yolu2);
                                    satir2 = sr2.ReadLine();
                                    while (satir2 != "")
                                    {
                                        if (ik_belirli_tip_ehliyet_txt.Text != "")
                                        {
                                            if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                            {
                                                Istenilenveriyicek(yenidosya_yolu2);
                                                sayac++;
                                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                                goto enes;
                                            }
                                            satir2 = sr2.ReadLine();
                                        }
                                        else
                                        {
                                            Istenilenveriyicek(yenidosya_yolu2);
                                            sayac++;
                                            label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                            goto enes;
                                        }
                                    }
                                }
                                else
                                {
                                    goto enes;
                                }

                                satir2 = sr2.ReadLine();
                            }
                            else if (ik_belirli_tip_ehliyet_txt.Text != "")
                            {
                                if (satir2.Contains("Ehliyet: ") == true && satir2.Contains(ik_belirli_tip_ehliyet_txt.Text) == true)
                                {
                                    Istenilenveriyicek(yenidosya_yolu2);
                                    sayac++;
                                    label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                    goto enes;
                                }
                                satir2 = sr2.ReadLine();
                            }
                            else
                            {
                                Istenilenveriyicek(yenidosya_yolu2);
                                sayac++;
                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                goto enes;
                            }
                        }
                        sr2.Close();
                    }
                enes:
                    satir = sr.ReadLine();



                }


                sr.Close();

            }


        }
        public double Deneyim_sure_bul(string yenidosya_yolu)
        {

            bool kontrol = File.Exists(yenidosya_yolu);
            if (kontrol == true)
            {
                double a=0;
                double d_sure=0;
                StreamReader sr = File.OpenText(yenidosya_yolu);
                string satir = sr.ReadLine();
                while (satir != "")
                {
                    if (satir.Contains("Tecrübe süresi: ") == true)
                    {
                        d_sure = d_sure+ Convert.ToDouble(satir.Substring(16));
                        a = d_sure;
                    }
                    
                    satir = sr.ReadLine();
                }
                return a;
            }
            return 0;
        }
        public int Yas_bul(string yenidosya_yolu)
        {
            bool kontrol = File.Exists(yenidosya_yolu);
            if (kontrol == true)
            {
                StreamReader sr = File.OpenText(yenidosya_yolu);
                string satir = sr.ReadLine();
                while (satir != "")
                {
                    if (satir.Contains("Doğum Tarihi: ") == true)
                    {
                        int a;
                        string b= satir.Substring(14);
                        a = Convert.ToInt32(b);
                        int yas;
                        yas = DateTime.Now.Year - a;
                        return yas;
                    }
                    satir = sr.ReadLine();
                }

            }
            return 0;

        }
        public string sec()
        {
            string yenidosya_yolu = "";
            if (ik_postorder_rb.Checked == true)
            {
                yenidosya_yolu = dosya_yolu_admin + @"\" + "0" + ".txt";
            }
            else if (ik_inorder_rb.Checked == true)
            {
                yenidosya_yolu = dosya_yolu_admin + @"\" + "1" + ".txt";
            }
            else if (ik_preorder_rb.Checked == true)
            {
                yenidosya_yolu = dosya_yolu_admin + @"\" + "2" + ".txt";
            }
            return yenidosya_yolu;
        }
        public void Cikti_Al()
        {
            if (l.Items.Count == 0)
            {
                MessageBox.Show("Çıktı alınamaz , liste boş!!!!", " Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kontrol = File.Exists(dosya_yolu_masaustu);
                if (kontrol == true)
                {
                    File.Delete(dosya_yolu_masaustu + @"\" + "Cikti.txt");
                    FileStream fs = File.Create(dosya_yolu_masaustu + @"\" + "Cikti.txt");
                    fs.Close();
                    StreamWriter sw = new StreamWriter(dosya_yolu_masaustu + @"\" + "Cikti.txt");
                    for (int i = 0; i < l.Items.Count; i++)
                    {
                        sw.WriteLine(l.Items[i]);
                    }
                    sw.Close();
                }
                else
                {
                    FileStream fs = File.Create(dosya_yolu_masaustu + @"\" + "Cikti.txt");
                    fs.Close();
                    StreamWriter sw = new StreamWriter(dosya_yolu_masaustu + @"\" + "Cikti.txt");
                    for (int i = 0; i < l.Items.Count; i++)
                    {
                        sw.WriteLine(l.Items[i]);
                    }
                    sw.Close();


                }
            }


        }
        public void Ad_listele()
        {
            int sayac = 0;
            string yenidosya_yolu = sec();
            l.Items.Clear();
            File.AppendAllText(yenidosya_yolu, "\n\n" + Environment.NewLine);
            bool kontrol = File.Exists(yenidosya_yolu);
            if (kontrol == true)
            {
                StreamReader sr = File.OpenText(yenidosya_yolu);
                string satir = sr.ReadLine();
                while (satir != "")
                {
                    string yenidosya_yolu2 = dosya_yolu_kullanicilar + @"\" + satir + ".txt";
                    StreamReader sr2 = File.OpenText(yenidosya_yolu2);
                    string satir2 = sr2.ReadLine();
                    bool kontrol2 = File.Exists(yenidosya_yolu2);

                    if (kontrol2 == true)
                    {
                        while (satir2 != "")
                        {
                            if (satir2.Contains("Ad: ") == true)
                            {
                                
                                l.Items.Add(satir2.Substring(4));
                                sayac++;
                                label7.Text = "Eleman Sayısı: " + sayac.ToString();
                                goto yolla;
                            }
                            satir2 = sr2.ReadLine();
                        }
                        sr2.Close();
                    }
                yolla:
                    satir = sr.ReadLine();
                }
                sr.Close();
            }
        }
        public void Tumverilericek()
        {
            int sayac = 0;
            string yenidosya_yolu = sec();
            l.Items.Clear();
            File.AppendAllText(yenidosya_yolu, "\n\n" + Environment.NewLine);
            bool kontrol = File.Exists(yenidosya_yolu);
            if (kontrol == true)
            {
                StreamReader sr = File.OpenText(yenidosya_yolu);
                string satir = sr.ReadLine();

                while (satir != "")
                {
                    string yenidosya_yolu2 = dosya_yolu_kullanicilar + @"\" + satir + ".txt";
                    StreamReader sr2 = File.OpenText(yenidosya_yolu2);
                    string satir2 = sr2.ReadLine();
                    bool kontrol2 = File.Exists(yenidosya_yolu2);

                    if (kontrol2 == true)
                    {

                        while (satir2 != "")
                        {
                            l.Items.Add(satir2);
                            satir2 = sr2.ReadLine();
                        }
                        sayac++;
                        label7.Text = "Eleman Sayısı: " + sayac.ToString();
                        sr2.Close();

                    }
                    satir = sr.ReadLine();
                }
                sr.Close();
            }
        }
        public void Istenilenveriyicek(string yenidosya_yolu2)
        {

            StreamReader sr = File.OpenText(yenidosya_yolu2);
            string satir = sr.ReadLine();
            bool kontrol2 = File.Exists(yenidosya_yolu2);

            if (kontrol2 == true)
            {

                while (satir != "")
                {
                    l.Items.Add(satir);
                    satir = sr.ReadLine();
                }
                sr.Close();

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Cikti_Al();
        }
        private void ik_Load_1(object sender, EventArgs e)
        {
            Agac a1 = new Agac();
            a1.Tcolustur();
            string yenidosya_yolu;
            if (ik_postorder_rb.Checked == true)
            {
                yenidosya_yolu = dosya_yolu_admin + @"\" + "0" + ".txt";
            }
            else if (ik_inorder_rb.Checked == true)
            {
                yenidosya_yolu = dosya_yolu_admin + @"\" + "1" + ".txt";
            }
            else if (ik_preorder_rb.Checked == true)
            {
                yenidosya_yolu = dosya_yolu_admin + @"\" + "2" + ".txt";
            }

            DirectoryInfo di = new DirectoryInfo(dosya_yolu_kullanicilar);
            FileInfo[] rgfiles = di.GetFiles();

            foreach (FileInfo fi in rgfiles)
            {
                string a = fi.Name;
                int b = a.IndexOf(".");
                long s = Convert.ToInt64(a.Substring(0, b));

                a1.Ekle(s);

            }
            a1.PreOrder(a1.ReturnKok());
            a1.InOrder(a1.ReturnKok());
            a1.PostOrder(a1.ReturnKok());
           
        }
        private void ik_tümliste_btn_Click(object sender, EventArgs e)
        {
            Tumverilericek();
            label8.Text ="Ağacın Derinliği: "+ derinlik_s.ToString();
        }
        private void ik_postorder_rb_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ik_arama_yap_txt_Click(object sender, EventArgs e)
        {
            Listeleme();
            if (l.Items.Count==0)
            {
                label7.Text = "Eleman Sayısı: 0";
            }
            
        }
        private void ik_ad_listele_btn_Click(object sender, EventArgs e)
        {
            Ad_listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baslangic b = new baslangic();
            b.Show();
            this.Hide();
        }

        private void ik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}

