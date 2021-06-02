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

namespace odev1_deneme
{


    public partial class basvuru : Form
    {
        long tc;
        public string dosya_yolu_kullanicilar = @"C:\Users\Enesg\OneDrive\Masaüstü\proje\kullanicilar";
        public string dosya_yolu_admin = @"C:\Users\Enesg\OneDrive\Masaüstü\proje\admin";
        public string dosya_yolu_masaustu = @"C:\Users\Enesg\OneDrive\Masaüstü";
        //public string dosya_yolu_kullanicilar = @"C:\Users\Aziz GÜLTEKİN\Desktop\proje\kullanicilar";
        //public string dosya_yolu_admin = @"C:\Users\Aziz GÜLTEKİN\Desktop\proje\admin";

        public basvuru()
        {

            InitializeComponent();

        }
        public void Eskihaledondur()
        {
            eDurumu_2chkBox.Checked = false;
            eDurumu_3chkBox.Checked = false;
            eDurumu_4chkBox.Checked= false;
            isDeneyimi_2chkBox.Checked = false;
            isDeneyimi_3chkBox.Checked = false;
            isDeneyimi_4chkBox.Checked = false;
            isDeneyimi_5chkBox.Checked = false;
            isDeneyimi_6chkBox.Checked = false;
        }
        public void verilerigetir()
        {
            int index2 = 0;
            try
            {
                tc = Convert.ToInt64(tcnoTxt.Text);
                int index = 0;
                int toplam = 0;
                foreach (char n in tc.ToString())
                {

                    if (index < 10)
                    {
                        toplam += Convert.ToInt32(char.ToString(n));
                    }
                    index++;
                }
                index2 = index;
                if (index != 11)
                {
                    MessageBox.Show("11 haneli TC numaranızı doğru girdiğinizden emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("11 haneli TC numaranızı doğru girdiğinizden emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTemizle();
            string yenidosya_yolu = dosya_yolu_kullanicilar + @"\" + tc.ToString() + ".txt";
            dosya_yolu_kullanicilar = yenidosya_yolu;
            bool kontrol = File.Exists(dosya_yolu_kullanicilar);
            if (kontrol == true)
            {
                StreamReader sr = File.OpenText(dosya_yolu_kullanicilar);
                string satir = sr.ReadLine();
            etiket:
                while (satir != "")
                {

                    if (satir.Contains("Ad: ") == true)
                    {
                        if (adTxt.Text == "")
                        {
                            adTxt.Text = (satir.Substring(4));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Soyad: ") == true)
                    {
                        soyadTxt.Text = (satir.Substring(7));
                        satir = sr.ReadLine();
                        goto etiket;
                    }
                    if (satir.Contains("Adresi: ") == true)
                    {
                        adresTxt.Text = (satir.Substring(8));
                        satir = sr.ReadLine();
                        goto etiket;
                    }
                    if (satir.Contains("E-Mail: ") == true)
                    {
                        email_txt.Text = (satir.Substring(8));
                        satir = sr.ReadLine();
                        goto etiket;
                    }
                    if (satir.Contains("Tel No: ") == true)
                    {
                        telnoTxt.Text = (satir.Substring(8));
                        satir = sr.ReadLine();
                        goto etiket;
                    }
                    if (satir.Contains("Doğum Tarihi: ") == true)
                    {
                        dogum_yili_txt.Text = satir.Substring(14);
                        satir = sr.ReadLine();
                        goto etiket;
                    }
                    if (satir.Contains("Yabancı dil: ") == true)
                    {
                        y_dilTxt.Text = (satir.Substring(13));
                        satir = sr.ReadLine();
                        goto etiket;
                    }
                    if (satir.Contains("Ehliyet: ") == true)
                    {
                        ehliyetTxt.Text = (satir.Substring(9));
                        satir = sr.ReadLine();
                        goto etiket;
                    }
                    if (satir.Contains("Okul adı: ") == true)
                    {
                        if (okul_adiTxt.Text == "")
                        {
                            okul_adiTxt.Text = (satir.Substring(10));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (okul_adi_2Txt.Text == "")
                        {
                            okul_adi_2Txt.Text = (satir.Substring(10));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (okul_adi_3Txt.Text == "")
                        {
                            okul_adi_3Txt.Text = (satir.Substring(10));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (okul_adi_4Txt.Text == "")
                        {
                            okul_adi_4Txt.Text = (satir.Substring(10));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Türü: ") == true)
                    {
                        if (turu_Cmb.Text == "")
                        {
                            turu_Cmb.Text = (satir.Substring(6));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (turu2_Cmb.Text == "")
                        {
                            turu2_Cmb.Text = (satir.Substring(6));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (turu3_Cmb.Text == "")
                        {
                            turu3_Cmb.Text = (satir.Substring(6));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (turu4_Cmb.Text == "")
                        {
                            turu4_Cmb.Text = (satir.Substring(6));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Bölümü: ") == true)
                    {
                        if (bolumuTxt.Text == "")
                        {
                            bolumuTxt.Text = (satir.Substring(8));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (bolumu_2Txt.Text == "")
                        {
                            bolumu_2Txt.Text = (satir.Substring(8));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (bolumu_3Txt.Text == "")
                        {
                            bolumu_3Txt.Text = (satir.Substring(8));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (bolumu_4Txt.Text == "")
                        {
                            bolumu_4Txt.Text = (satir.Substring(8));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Başlangış tarihi: ") == true)
                    {
                        if (basTarihiTxt.Text == "")
                        {
                            basTarihiTxt.Text = (satir.Substring(18));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (basTarihi_2Txt.Text == "")
                        {
                            basTarihi_2Txt.Text = (satir.Substring(18));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (basTarihi_3Txt.Text == "")
                        {
                            basTarihi_3Txt.Text = (satir.Substring(18));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (basTarihi_4Txt.Text == "")
                        {
                            basTarihi_4Txt.Text = (satir.Substring(18));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Bitiş tarihi: ") == true)
                    {
                        if (bitTarihiTxt.Text == "")
                        {
                            bitTarihiTxt.Text = (satir.Substring(14));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (bitTarihi_2Txt.Text == "")
                        {
                            bitTarihi_2Txt.Text = (satir.Substring(14));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (bitTarihi_3Txt.Text == "")
                        {
                            bitTarihi_3Txt.Text = (satir.Substring(14));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (bitTarihi_4Txt.Text == "")
                        {
                            bitTarihi_4Txt.Text = (satir.Substring(14));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Not ortalaması: ") == true)
                    {
                        if (notOrtTxt.Text == "")
                        {
                            notOrtTxt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (notOrt_2Txt.Text == "")
                        {
                            notOrt_2Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (notOrt_3Txt.Text == "")
                        {
                            notOrt_3Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (notOrt_4Txt.Text == "")
                        {
                            notOrt_4Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Çalıştığı yer adı: ") == true)
                    {
                        if (calistigiyer_AdiTxt.Text == "")
                        {
                            calistigiyer_AdiTxt.Text = (satir.Substring(19));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (calistigiyer_Adi_2Txt.Text == "")
                        {
                            calistigiyer_Adi_2Txt.Text = (satir.Substring(19));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (calistigiyer_Adi_3Txt.Text == "")
                        {
                            calistigiyer_Adi_3Txt.Text = (satir.Substring(19));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (calistigiyer_Adi_4Txt.Text == "")
                        {
                            calistigiyer_Adi_4Txt.Text = (satir.Substring(19));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (calistigiyer_Adi_5Txt.Text == "")
                        {
                            calistigiyer_Adi_5Txt.Text = (satir.Substring(19));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (calistigiyer_Adi_6Txt.Text == "")
                        {
                            calistigiyer_Adi_6Txt.Text = (satir.Substring(19));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("İş adresi: ") == true)
                    {
                        if (isAdresiTxt.Text == "")
                        {
                            isAdresiTxt.Text = (satir.Substring(11));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (isAdresi_2Txt.Text == "")
                        {
                            isAdresi_2Txt.Text = (satir.Substring(11));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (isAdresi_3Txt.Text == "")
                        {
                            isAdresi_3Txt.Text = (satir.Substring(11));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (isAdresi_4Txt.Text == "")
                        {
                            isAdresi_4Txt.Text = (satir.Substring(11));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (isAdresi_5Txt.Text == "")
                        {
                            isAdresi_5Txt.Text = (satir.Substring(11));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (isAdresi_6Txt.Text == "")
                        {
                            isAdresi_6Txt.Text = (satir.Substring(11));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Pozisyon veya görevi: ") == true)
                    {
                        if (istecPozveyaGor_Txt.Text == "")
                        {
                            istecPozveyaGor_Txt.Text = (satir.Substring(22));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecPozveyaGor_2Txt.Text == "")
                        {
                            istecPozveyaGor_2Txt.Text = (satir.Substring(22));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecPozveyaGor_3Txt.Text == "")
                        {
                            istecPozveyaGor_3Txt.Text = (satir.Substring(22));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecPozveyaGor_4Txt.Text == "")
                        {
                            istecPozveyaGor_4Txt.Text = (satir.Substring(22));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecPozveyaGor_5Txt.Text == "")
                        {
                            istecPozveyaGor_5Txt.Text = (satir.Substring(22));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecPozveyaGor_6Txt.Text == "")
                        {
                            istecPozveyaGor_6Txt.Text = (satir.Substring(22));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }
                    if (satir.Contains("Tecrübe süresi: ") == true)
                    {
                        if (istecSur_Txt.Text == "")
                        {
                            istecSur_Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecSur_2Txt.Text == "")
                        {
                            istecSur_2Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecSur_3Txt.Text == "")
                        {
                            istecSur_3Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecSur_4Txt.Text == "")
                        {
                            istecSur_4Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecSur_5Txt.Text == "")
                        {
                            istecSur_5Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                        else if (istecSur_6Txt.Text == "")
                        {
                            istecSur_6Txt.Text = (satir.Substring(16));
                            satir = sr.ReadLine();
                            goto etiket;
                        }
                    }


                    satir = sr.ReadLine();
                }

                sr.Close();

            }
            else
            {
                if (index2 == 11)
                {
                    MessageBox.Show("Kaydınız bulunmamaktadır.");
                }

            }
            dosya_yolu_kullanicilar = dosya_yolu_kullanicilar;
        }

        public void verilerisil()
        {
            string tc = tcnoTxt.Text;
            string yenidosya_yolu = dosya_yolu_kullanicilar + @"\" + tc + ".txt";
            File.Delete(yenidosya_yolu);
            MessageBox.Show("Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTemizle();
        }

        public void txtTemizle()
        {
            adTxt.Text = "";
            soyadTxt.Text = "";
            adresTxt.Text = "";
            telnoTxt.Text = "";
            email_txt.Text = "";
            dogum_yili_txt.Text = "";
            y_dilTxt.Text = "";
            ehliyetTxt.Text = "";
            okul_adiTxt.Text = "";
            okul_adi_2Txt.Text = "";
            okul_adi_3Txt.Text = "";
            okul_adi_4Txt.Text = "";
            turu_Cmb.Text = "";
            turu2_Cmb.Text = "";
            turu3_Cmb.Text = "";
            turu4_Cmb.Text = "";
            bolumuTxt.Text = "";
            bolumu_2Txt.Text = "";
            bolumu_3Txt.Text = "";
            bolumu_4Txt.Text = "";
            basTarihiTxt.Text = "";
            basTarihi_2Txt.Text = "";
            basTarihi_3Txt.Text = "";
            basTarihi_4Txt.Text = "";
            bitTarihiTxt.Text = "";
            bitTarihi_2Txt.Text = "";
            bitTarihi_3Txt.Text = "";
            bitTarihi_4Txt.Text = "";
            notOrtTxt.Text = "";
            notOrt_2Txt.Text = "";
            notOrt_3Txt.Text = "";
            notOrt_4Txt.Text = "";
            calistigiyer_AdiTxt.Text = "";
            calistigiyer_Adi_2Txt.Text = "";
            calistigiyer_Adi_3Txt.Text = "";
            calistigiyer_Adi_4Txt.Text = "";
            calistigiyer_Adi_5Txt.Text = "";
            calistigiyer_Adi_6Txt.Text = "";
            isAdresiTxt.Text = "";
            isAdresi_2Txt.Text = "";
            isAdresi_3Txt.Text = "";
            isAdresi_4Txt.Text = "";
            isAdresi_5Txt.Text = "";
            isAdresi_6Txt.Text = "";
            istecPozveyaGor_Txt.Text = "";
            istecPozveyaGor_2Txt.Text = "";
            istecPozveyaGor_3Txt.Text = "";
            istecPozveyaGor_4Txt.Text = "";
            istecPozveyaGor_5Txt.Text = "";
            istecPozveyaGor_6Txt.Text = "";
            istecSur_Txt.Text = "";
            istecSur_2Txt.Text = "";
            istecSur_3Txt.Text = "";
            istecSur_4Txt.Text = "";
            istecSur_5Txt.Text = "";
            istecSur_6Txt.Text = "";
        }
        public void Guncelle()
        {
            string tc = tcnoTxt.Text;
            txtTemizle();
            string yenidosya_yolu = dosya_yolu_kullanicilar + @"\" + tc + ".txt";
            bool kontrol = File.Exists(yenidosya_yolu);
            if (kontrol == true)
            {
                File.Delete(yenidosya_yolu);
                dosyakaydet();
                MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dosyakaydet();
                MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void dosyakaydet()
        {
            int index2 = 0;
            try
            {
                tc = Convert.ToInt64(tcnoTxt.Text);
                int index = 0;
                int toplam = 0;
                foreach (char n in tc.ToString())
                {

                    if (index < 10)
                    {
                        toplam += Convert.ToInt32(char.ToString(n));
                    }
                    index++;
                }
                index2 = index;
                if (index != 11)
                {
                    MessageBox.Show("11 haneli TC numaranızı doğru girdiğinizden emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("11 haneli TC numaranızı doğru girdiğinizden emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string yenidosya_yolu = dosya_yolu_kullanicilar + @"\" + tc + ".txt";
            bool kontrol = File.Exists(yenidosya_yolu);
            if (kontrol == true)
            {
                MessageBox.Show("Dosya sistemde mevcut");
            }
            else
            {
                if(index2==11)
                {
                    FileStream fs = File.Create(yenidosya_yolu);
                    fs.Close();

                    LinkedList l = new LinkedList();

                    l.SonaEkle(Convert.ToInt64(tcnoTxt.Text), adTxt.Text, soyadTxt.Text, adresTxt.Text, email_txt.Text,telnoTxt.Text, dogum_yili_txt.Text, y_dilTxt.Text, ehliyetTxt.Text, okul_adiTxt.Text, okul_adi_2Txt.Text, okul_adi_3Txt.Text, okul_adi_4Txt.Text, turu_Cmb.Text, turu2_Cmb.Text, turu3_Cmb.Text, turu4_Cmb.Text, bolumuTxt.Text, bolumu_2Txt.Text, bolumu_3Txt.Text, bolumu_4Txt.Text, basTarihiTxt.Text, basTarihi_2Txt.Text, basTarihi_3Txt.Text, basTarihi_4Txt.Text, bitTarihiTxt.Text, bitTarihi_2Txt.Text, bitTarihi_3Txt.Text, bitTarihi_4Txt.Text, notOrtTxt.Text, notOrt_2Txt.Text, notOrt_3Txt.Text, notOrt_4Txt.Text, calistigiyer_AdiTxt.Text, calistigiyer_Adi_2Txt.Text, calistigiyer_Adi_3Txt.Text, calistigiyer_Adi_4Txt.Text,calistigiyer_Adi_5Txt.Text,calistigiyer_Adi_6Txt.Text, isAdresiTxt.Text, isAdresi_2Txt.Text, isAdresi_3Txt.Text, isAdresi_4Txt.Text,isAdresi_5Txt.Text,isAdresi_6Txt.Text, istecPozveyaGor_Txt.Text, istecPozveyaGor_2Txt.Text, istecPozveyaGor_3Txt.Text, istecPozveyaGor_4Txt.Text,istecPozveyaGor_5Txt.Text,istecPozveyaGor_6Txt.Text, istecSur_Txt.Text, istecSur_2Txt.Text, istecSur_3Txt.Text, istecSur_4Txt.Text,istecSur_5Txt.Text,istecSur_6Txt.Text);
                    l.dugumyazdir(yenidosya_yolu);
                }
            }
            txtTemizle();
        }
        class Dugum
        {
            public Dugum Sonraki;
            public long tc;
            public string ad;
            public string soyad;
            public string adres;
            public string email;
            public string tel_no;
            public string d_tarihi;
            public string y_dil;
            public string ehliyet;
            public string e_durumu_okul_adi;
            public string e_durumu_okul_adi2;
            public string e_durumu_okul_adi3;
            public string e_durumu_okul_adi4;
            public string e_durumu_turu;
            public string e_durumu_turu2;
            public string e_durumu_turu3;
            public string e_durumu_turu4;
            public string e_durumu_bolumu;
            public string e_durumu_bolumu2;
            public string e_durumu_bolumu3;
            public string e_durumu_bolumu4;
            public string e_durumu_baslangic_tarihi;
            public string e_durumu_baslangic_tarihi2;
            public string e_durumu_baslangic_tarihi3;
            public string e_durumu_baslangic_tarihi4;
            public string e_durumu_bitis_tarihi;
            public string e_durumu_bitis_tarihi2;
            public string e_durumu_bitis_tarihi3;
            public string e_durumu_bitis_tarihi4;
            public string e_durumu_not_ortalamasi;
            public string e_durumu_not_ortalamasi2;
            public string e_durumu_not_ortalamasi3;
            public string e_durumu_not_ortalamasi4;
            public string i_deneyimi_calıstigi_yer_adi;
            public string i_deneyimi_calıstigi_yer_adi2;
            public string i_deneyimi_calıstigi_yer_adi3;
            public string i_deneyimi_calıstigi_yer_adi4;
            public string i_deneyimi_calıstigi_yer_adi5;
            public string i_deneyimi_calıstigi_yer_adi6;
            public string i_deneyimi_is_adresi;
            public string i_deneyimi_is_adresi2;
            public string i_deneyimi_is_adresi3;
            public string i_deneyimi_is_adresi4;
            public string i_deneyimi_is_adresi5;
            public string i_deneyimi_is_adresi6;
            public string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi;
            public string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi2;
            public string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi3;
            public string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi4;
            public string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi5;
            public string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi6;
            public string i_deneyimi_is_tecrubesi_suresi;
            public string i_deneyimi_is_tecrubesi_suresi2;
            public string i_deneyimi_is_tecrubesi_suresi3;
            public string i_deneyimi_is_tecrubesi_suresi4;
            public string i_deneyimi_is_tecrubesi_suresi5;
            public string i_deneyimi_is_tecrubesi_suresi6;
        }
        class LinkedList
        {
            basvuru b = new basvuru();
            public Dugum Head;
            public void dugumyazdir(string yenidosya_yolu)
            {

                StreamWriter sw = new StreamWriter(yenidosya_yolu);
                Dugum Aktif = Head;
                while (Aktif != null)
                {
                    sw.WriteLine("TC No:" + Aktif.tc);
                    sw.WriteLine("Ad: " + Aktif.ad);
                    sw.WriteLine("Soyad: " + Aktif.soyad);
                    sw.WriteLine("Adresi: " + Aktif.adres);
                    sw.WriteLine("E-Mail: " + Aktif.email);
                    sw.WriteLine("Tel No: " + Aktif.tel_no);
                    sw.WriteLine("Doğum Tarihi: " + Aktif.d_tarihi);
                    if (b.y_dilTxt.Text == null)
                    {
                        sw.WriteLine("Yabancı dil: ");
                    }
                    else
                    {
                        sw.WriteLine("Yabancı dil: " + Aktif.y_dil);
                    }

                    if (b.ehliyetTxt.Text == null)
                    {
                        sw.WriteLine("Ehliyet: ");
                    }
                    else
                    {
                        sw.WriteLine("Ehliyet: " + Aktif.ehliyet);
                    }

                    sw.WriteLine("--------------------" + "\nEğitim Bilgileri\nOkul adı: " + Aktif.e_durumu_okul_adi);
                    sw.WriteLine("Türü: " + Aktif.e_durumu_turu);
                    sw.WriteLine("Bölümü: " + Aktif.e_durumu_bolumu);
                    sw.WriteLine("Başlangış tarihi: " + Aktif.e_durumu_baslangic_tarihi);
                    sw.WriteLine("Bitiş tarihi: " + Aktif.e_durumu_bitis_tarihi);
                    sw.WriteLine("Not ortalaması: " + Aktif.e_durumu_not_ortalamasi + "\n--------------------");
                    if (b.okul_adi_2Txt.Enabled == false)
                    {
                        sw.WriteLine("Okul adı: " + Aktif.e_durumu_okul_adi2);
                    }
                    if (b.turu2_Cmb.Enabled == false)
                    {
                        sw.WriteLine("Türü: " + Aktif.e_durumu_turu2);
                    }
                    if (b.bolumu_2Txt.Enabled == false)
                    {
                        sw.WriteLine("Bölümü: " + Aktif.e_durumu_bolumu2);
                    }
                    if (b.basTarihi_2Txt.Enabled == false)
                    {
                        sw.WriteLine("Başlangış tarihi: " + Aktif.e_durumu_baslangic_tarihi2);
                    }
                    if (b.bitTarihi_2Txt.Enabled == false)
                    {
                        sw.WriteLine("Bitiş tarihi: " + Aktif.e_durumu_bitis_tarihi2);
                    }
                    if (b.notOrt_2Txt.Enabled == false)
                    {
                        sw.WriteLine("Not ortalaması: " + Aktif.e_durumu_not_ortalamasi2 + "\n--------------------");
                    }
                    if (b.okul_adi_3Txt.Enabled == false)
                    {
                        sw.WriteLine("Okul adı: " + Aktif.e_durumu_okul_adi3);
                    }
                    if (b.turu3_Cmb.Enabled == false)
                    {
                        sw.WriteLine("Türü: " + Aktif.e_durumu_turu3);
                    }
                    if (b.bolumu_3Txt.Enabled == false)
                    {
                        sw.WriteLine("Bölümü: " + Aktif.e_durumu_bolumu3);
                    }
                    if (b.basTarihi_3Txt.Enabled == false)
                    {
                        sw.WriteLine("Başlangış tarihi: " + Aktif.e_durumu_baslangic_tarihi3);
                    }

                    if (b.bitTarihi_3Txt.Enabled == false)
                    {
                        sw.WriteLine("Bitiş tarihi: " + Aktif.e_durumu_bitis_tarihi3);
                    }
                    if (b.notOrt_3Txt.Enabled == false)
                    {
                        sw.WriteLine("Not ortalaması: " + Aktif.e_durumu_not_ortalamasi3 + "\n--------------------");
                    }
                    if (b.okul_adi_4Txt.Enabled == false)
                    {
                        sw.WriteLine("Okul adı: " + Aktif.e_durumu_okul_adi4);
                    }
                    if (b.turu4_Cmb.Enabled == false)
                    {
                        sw.WriteLine("Türü: " + Aktif.e_durumu_turu4);
                    }

                    if (b.bolumu_4Txt.Enabled == false)
                    {
                        sw.WriteLine("Bölümü: " + Aktif.e_durumu_bolumu4);
                    }
                    if (b.basTarihi_4Txt.Enabled == false)
                    {
                        sw.WriteLine("Başlangış tarihi: " + Aktif.e_durumu_baslangic_tarihi4);
                    }
                    if (b.bitTarihi_4Txt.Enabled == false)
                    {
                        sw.WriteLine("Bitiş tarihi: " + Aktif.e_durumu_bitis_tarihi4);
                    }
                    if (b.notOrt_4Txt.Enabled == false)
                    {
                        sw.WriteLine("Not ortalaması: " + Aktif.e_durumu_not_ortalamasi4 + "\n--------------------");
                    }
                    sw.WriteLine("İş Deneyimi\nÇalıştığı yer adı: " + Aktif.i_deneyimi_calıstigi_yer_adi);
                    sw.WriteLine("İş adresi: " + Aktif.i_deneyimi_is_adresi);
                    sw.WriteLine("Pozisyon veya görevi: " + Aktif.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi);
                    sw.WriteLine("Tecrübe süresi: " + Aktif.i_deneyimi_is_tecrubesi_suresi + "\n--------------------");
                    if (b.calistigiyer_Adi_2Txt.Enabled == false)
                    {
                        sw.WriteLine("Çalıştığı yer adı: " + Aktif.i_deneyimi_calıstigi_yer_adi2);
                    }
                    if (b.isAdresi_2Txt.Enabled == false)
                    {
                        sw.WriteLine("İş adresi: " + Aktif.i_deneyimi_is_adresi2);
                    }
                    if (b.istecPozveyaGor_2Txt.Enabled == false)
                    {
                        sw.WriteLine("Pozisyon veya görevi: " + Aktif.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi2);
                    }
                    if (b.istecSur_2Txt.Enabled == false)
                    {
                        sw.WriteLine("Tecrübe süresi: " + Aktif.i_deneyimi_is_tecrubesi_suresi2 + "\n--------------------");
                    }
                    if (b.calistigiyer_Adi_3Txt.Enabled == false)
                    {
                        sw.WriteLine("Çalıştığı yer adı: " + Aktif.i_deneyimi_calıstigi_yer_adi3);
                    }
                    if (b.isAdresi_3Txt.Enabled == false)
                    {
                        sw.WriteLine("İş adresi: " + Aktif.i_deneyimi_is_adresi3);
                    }
                    if (b.istecPozveyaGor_3Txt.Enabled == false)
                    {
                        sw.WriteLine("Pozisyon veya görevi: " + Aktif.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi3);
                    }
                    if (b.istecSur_3Txt.Enabled == false)
                    {
                        sw.WriteLine("Tecrübe süresi: " + Aktif.i_deneyimi_is_tecrubesi_suresi3 + "\n--------------------");
                    }

                    if (b.calistigiyer_Adi_4Txt.Enabled == false)
                    {
                        sw.WriteLine("Çalıştığı yer adı: " + Aktif.i_deneyimi_calıstigi_yer_adi4);
                    }
                    if (b.isAdresi_4Txt.Enabled == false)
                    {
                        sw.WriteLine("İş adresi: " + Aktif.i_deneyimi_is_adresi4);
                    }
                    if (b.istecPozveyaGor_4Txt.Enabled == false)
                    {
                        sw.WriteLine("Pozisyon veya görevi: " + Aktif.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi4);
                    }
                    if (b.istecSur_4Txt.Enabled == false)
                    {
                        sw.WriteLine("Tecrübe süresi: " + Aktif.i_deneyimi_is_tecrubesi_suresi4 + "\n--------------------");
                    }
                    if (b.calistigiyer_Adi_5Txt.Enabled == false)
                    {
                        sw.WriteLine("Çalıştığı yer adı: " + Aktif.i_deneyimi_calıstigi_yer_adi5);
                    }
                    if (b.isAdresi_5Txt.Enabled == false)
                    {
                        sw.WriteLine("İş adresi: " + Aktif.i_deneyimi_is_adresi5);
                    }
                    if (b.istecPozveyaGor_5Txt.Enabled == false)
                    {
                        sw.WriteLine("Pozisyon veya görevi: " + Aktif.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi5);
                    }
                    if (b.istecSur_5Txt.Enabled == false)
                    {
                        sw.WriteLine("Tecrübe süresi: " + Aktif.i_deneyimi_is_tecrubesi_suresi5 + "\n--------------------");
                    }
                    if (b.calistigiyer_Adi_6Txt.Enabled == false)
                    {
                        sw.WriteLine("Çalıştığı yer adı: " + Aktif.i_deneyimi_calıstigi_yer_adi6);
                    }
                    if (b.isAdresi_6Txt.Enabled == false)
                    {
                        sw.WriteLine("İş adresi: " + Aktif.i_deneyimi_is_adresi6);
                    }
                    if (b.istecPozveyaGor_6Txt.Enabled == false)
                    {
                        sw.WriteLine("Pozisyon veya görevi: " + Aktif.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi6);
                    }
                    if (b.istecSur_6Txt.Enabled == false)
                    {
                        sw.WriteLine("Tecrübe süresi: " + Aktif.i_deneyimi_is_tecrubesi_suresi6 + "\n--------------------");
                    }
                    sw.Close();
                    MessageBox.Show("Başarıyla Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.AppendAllText(yenidosya_yolu, "--------------------" + Environment.NewLine);
                    File.AppendAllText(yenidosya_yolu, "--------------------\n\n\n" + Environment.NewLine);
                    Aktif = Aktif.Sonraki;
                }
                sw.Close();
            }
            public void SonaEkle(long tc, string ad, string soyad, string adres, string email,string tel_no, string d_tarihi, string y_dil, string ehliyet, string e_durumu_okul_adi, string e_durumu_okul_adi2, string e_durumu_okul_adi3, string e_durumu_okul_adi4, string e_durumu_turu, string e_durumu_turu2, string e_durumu_turu3, string e_durumu_turu4, string e_durumu_bolumu, string e_durumu_bolumu2, string e_durumu_bolumu3, string e_durumu_bolumu4, string e_durumu_baslangic_tarihi, string e_durumu_baslangic_tarihi2, string e_durumu_baslangic_tarihi3, string e_durumu_baslangic_tarihi4, string e_durumu_bitis_tarihi, string e_durumu_bitis_tarihi2, string e_durumu_bitis_tarihi3, string e_durumu_bitis_tarihi4, string e_durumu_not_ortalamasi, string e_durumu_not_ortalamasi2, string e_durumu_not_ortalamasi3, string e_durumu_not_ortalamasi4, string i_deneyimi_calıstigi_yer_adi, string i_deneyimi_calıstigi_yer_adi2, string i_deneyimi_calıstigi_yer_adi3, string i_deneyimi_calıstigi_yer_adi4, string i_deneyimi_calıstigi_yer_adi5, string i_deneyimi_calıstigi_yer_adi6, string i_deneyimi_is_adresi, string i_deneyimi_is_adresi2, string i_deneyimi_is_adresi3, string i_deneyimi_is_adresi4, string i_deneyimi_is_adresi5, string i_deneyimi_is_adresi6, string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi, string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi2, string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi3, string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi4, string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi5, string i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi6, string i_deneyimi_is_tecrubesi_suresi, string i_deneyimi_is_tecrubesi_suresi2, string i_deneyimi_is_tecrubesi_suresi3, string i_deneyimi_is_tecrubesi_suresi4, string i_deneyimi_is_tecrubesi_suresi5, string i_deneyimi_is_tecrubesi_suresi6)
            {
                if (Head == null)
                {
                    basvuru f = new basvuru();
                    Dugum ilk = new Dugum();
                    ilk.tc = tc;
                    ilk.ad = ad;
                    ilk.soyad = soyad;
                    ilk.adres = adres;
                    ilk.email = email;
                    ilk.tel_no = tel_no;
                    ilk.d_tarihi = d_tarihi;
                    ilk.y_dil = y_dil;
                    ilk.ehliyet = ehliyet;
                    ilk.e_durumu_okul_adi = e_durumu_okul_adi;
                    ilk.e_durumu_okul_adi2 = e_durumu_okul_adi2;
                    ilk.e_durumu_okul_adi3 = e_durumu_okul_adi3;
                    ilk.e_durumu_okul_adi4 = e_durumu_okul_adi4;
                    ilk.e_durumu_turu = e_durumu_turu;
                    ilk.e_durumu_turu2 = e_durumu_turu2;
                    ilk.e_durumu_turu3 = e_durumu_turu3;
                    ilk.e_durumu_turu4 = e_durumu_turu4;
                    ilk.e_durumu_bolumu = e_durumu_bolumu;
                    ilk.e_durumu_bolumu2 = e_durumu_bolumu2;
                    ilk.e_durumu_bolumu3 = e_durumu_bolumu3;
                    ilk.e_durumu_bolumu4 = e_durumu_bolumu4;
                    ilk.e_durumu_baslangic_tarihi = e_durumu_baslangic_tarihi;
                    ilk.e_durumu_baslangic_tarihi2 = e_durumu_baslangic_tarihi2;
                    ilk.e_durumu_baslangic_tarihi3 = e_durumu_baslangic_tarihi3;
                    ilk.e_durumu_baslangic_tarihi4 = e_durumu_baslangic_tarihi4;
                    ilk.e_durumu_bitis_tarihi = e_durumu_bitis_tarihi;
                    ilk.e_durumu_bitis_tarihi2 = e_durumu_bitis_tarihi2;
                    ilk.e_durumu_bitis_tarihi3 = e_durumu_bitis_tarihi3;
                    ilk.e_durumu_bitis_tarihi4 = e_durumu_bitis_tarihi4;
                    ilk.e_durumu_not_ortalamasi = e_durumu_not_ortalamasi;
                    ilk.e_durumu_not_ortalamasi2 = e_durumu_not_ortalamasi2;
                    ilk.e_durumu_not_ortalamasi3 = e_durumu_not_ortalamasi3;
                    ilk.e_durumu_not_ortalamasi4 = e_durumu_not_ortalamasi4;
                    ilk.i_deneyimi_calıstigi_yer_adi = i_deneyimi_calıstigi_yer_adi;
                    ilk.i_deneyimi_calıstigi_yer_adi2 = i_deneyimi_calıstigi_yer_adi2;
                    ilk.i_deneyimi_calıstigi_yer_adi3 = i_deneyimi_calıstigi_yer_adi3;
                    ilk.i_deneyimi_calıstigi_yer_adi4 = i_deneyimi_calıstigi_yer_adi4;
                    ilk.i_deneyimi_calıstigi_yer_adi5 = i_deneyimi_calıstigi_yer_adi5;
                    ilk.i_deneyimi_calıstigi_yer_adi6 = i_deneyimi_calıstigi_yer_adi6;
                    ilk.i_deneyimi_is_adresi = i_deneyimi_is_adresi;
                    ilk.i_deneyimi_is_adresi2 = i_deneyimi_is_adresi2;
                    ilk.i_deneyimi_is_adresi3 = i_deneyimi_is_adresi3;
                    ilk.i_deneyimi_is_adresi4 = i_deneyimi_is_adresi4;
                    ilk.i_deneyimi_is_adresi5 = i_deneyimi_is_adresi5;
                    ilk.i_deneyimi_is_adresi6 = i_deneyimi_is_adresi6;
                    ilk.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi;
                    ilk.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi2 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi2;
                    ilk.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi3 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi3;
                    ilk.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi4 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi4;
                    ilk.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi5 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi5;
                    ilk.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi6 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi6;
                    ilk.i_deneyimi_is_tecrubesi_suresi = i_deneyimi_is_tecrubesi_suresi;
                    ilk.i_deneyimi_is_tecrubesi_suresi2 = i_deneyimi_is_tecrubesi_suresi2;
                    ilk.i_deneyimi_is_tecrubesi_suresi3 = i_deneyimi_is_tecrubesi_suresi3;
                    ilk.i_deneyimi_is_tecrubesi_suresi4 = i_deneyimi_is_tecrubesi_suresi4;
                    ilk.i_deneyimi_is_tecrubesi_suresi5 = i_deneyimi_is_tecrubesi_suresi5;
                    ilk.i_deneyimi_is_tecrubesi_suresi6 = i_deneyimi_is_tecrubesi_suresi6;
                    Head = ilk;
                }
                else
                {
                    Dugum Eklenecek2 = new Dugum();
                    basvuru f = new basvuru();
                    Eklenecek2.tc = tc;
                    Eklenecek2.ad = ad;
                    Eklenecek2.soyad = soyad;
                    Eklenecek2.adres = adres;
                    Eklenecek2.email = email;
                    Eklenecek2.tel_no = tel_no;
                    Eklenecek2.d_tarihi = d_tarihi;
                    Eklenecek2.y_dil = y_dil;
                    Eklenecek2.ehliyet = ehliyet;
                    Eklenecek2.e_durumu_okul_adi = e_durumu_okul_adi;
                    Eklenecek2.e_durumu_okul_adi2 = e_durumu_okul_adi2;
                    Eklenecek2.e_durumu_okul_adi3 = e_durumu_okul_adi3;
                    Eklenecek2.e_durumu_okul_adi4 = e_durumu_okul_adi4;
                    Eklenecek2.e_durumu_turu = e_durumu_turu;
                    Eklenecek2.e_durumu_turu2 = e_durumu_turu2;
                    Eklenecek2.e_durumu_turu3 = e_durumu_turu3;
                    Eklenecek2.e_durumu_turu4 = e_durumu_turu4;
                    Eklenecek2.e_durumu_bolumu = e_durumu_bolumu;
                    Eklenecek2.e_durumu_bolumu2 = e_durumu_bolumu2;
                    Eklenecek2.e_durumu_bolumu3 = e_durumu_bolumu3;
                    Eklenecek2.e_durumu_bolumu4 = e_durumu_bolumu4;
                    Eklenecek2.e_durumu_baslangic_tarihi = e_durumu_baslangic_tarihi;
                    Eklenecek2.e_durumu_baslangic_tarihi2 = e_durumu_baslangic_tarihi2;
                    Eklenecek2.e_durumu_baslangic_tarihi3 = e_durumu_baslangic_tarihi3;
                    Eklenecek2.e_durumu_baslangic_tarihi4 = e_durumu_baslangic_tarihi4;
                    Eklenecek2.e_durumu_bitis_tarihi = e_durumu_bitis_tarihi;
                    Eklenecek2.e_durumu_bitis_tarihi2 = e_durumu_bitis_tarihi2;
                    Eklenecek2.e_durumu_bitis_tarihi3 = e_durumu_bitis_tarihi3;
                    Eklenecek2.e_durumu_bitis_tarihi4 = e_durumu_bitis_tarihi4;
                    Eklenecek2.e_durumu_not_ortalamasi = e_durumu_not_ortalamasi;
                    Eklenecek2.e_durumu_not_ortalamasi2 = e_durumu_not_ortalamasi2;
                    Eklenecek2.e_durumu_not_ortalamasi3 = e_durumu_not_ortalamasi3;
                    Eklenecek2.e_durumu_not_ortalamasi4 = e_durumu_not_ortalamasi4;
                    Eklenecek2.i_deneyimi_calıstigi_yer_adi = i_deneyimi_calıstigi_yer_adi;
                    Eklenecek2.i_deneyimi_calıstigi_yer_adi2 = i_deneyimi_calıstigi_yer_adi2;
                    Eklenecek2.i_deneyimi_calıstigi_yer_adi3 = i_deneyimi_calıstigi_yer_adi3;
                    Eklenecek2.i_deneyimi_calıstigi_yer_adi4 = i_deneyimi_calıstigi_yer_adi4;
                    Eklenecek2.i_deneyimi_calıstigi_yer_adi5 = i_deneyimi_calıstigi_yer_adi5;
                    Eklenecek2.i_deneyimi_calıstigi_yer_adi6 = i_deneyimi_calıstigi_yer_adi6;
                    Eklenecek2.i_deneyimi_is_adresi = i_deneyimi_is_adresi;
                    Eklenecek2.i_deneyimi_is_adresi2 = i_deneyimi_is_adresi2;
                    Eklenecek2.i_deneyimi_is_adresi3 = i_deneyimi_is_adresi3;
                    Eklenecek2.i_deneyimi_is_adresi4 = i_deneyimi_is_adresi4;
                    Eklenecek2.i_deneyimi_is_adresi5 = i_deneyimi_is_adresi5;
                    Eklenecek2.i_deneyimi_is_adresi6 = i_deneyimi_is_adresi6;
                    Eklenecek2.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi;
                    Eklenecek2.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi2 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi2;
                    Eklenecek2.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi3 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi3;
                    Eklenecek2.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi4 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi4;
                    Eklenecek2.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi5 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi5;
                    Eklenecek2.i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi6 = i_deneyimi_is_tecrubesi_pozisyon_veya_gorevi6;
                    Eklenecek2.i_deneyimi_is_tecrubesi_suresi = i_deneyimi_is_tecrubesi_suresi;
                    Eklenecek2.i_deneyimi_is_tecrubesi_suresi2 = i_deneyimi_is_tecrubesi_suresi2;
                    Eklenecek2.i_deneyimi_is_tecrubesi_suresi3 = i_deneyimi_is_tecrubesi_suresi3;
                    Eklenecek2.i_deneyimi_is_tecrubesi_suresi4 = i_deneyimi_is_tecrubesi_suresi4;
                    Eklenecek2.i_deneyimi_is_tecrubesi_suresi5 = i_deneyimi_is_tecrubesi_suresi5;
                    Eklenecek2.i_deneyimi_is_tecrubesi_suresi6 = i_deneyimi_is_tecrubesi_suresi6;

                    Dugum Aktif = Head;
                    while (Aktif.Sonraki != null)
                    {
                        Aktif = Aktif.Sonraki;
                    }
                    Aktif.Sonraki = Eklenecek2;

                }
            }
        }
        private void eDurumu_2chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (eDurumu_2chkBox.Checked == true)
            {
                okul_adi_2Txt.Enabled = true;
                turu2_Cmb.Enabled = true;
                bolumu_2Txt.Enabled = true;
                basTarihi_2Txt.Enabled = true;
                bitTarihi_2Txt.Enabled = true;
                notOrt_2Txt.Enabled = true;
            }
            else
            {
                okul_adi_2Txt.Enabled = false;
                turu2_Cmb.Enabled = false;
                bolumu_2Txt.Enabled = false;
                basTarihi_2Txt.Enabled = false;
                bitTarihi_2Txt.Enabled = false;
                notOrt_2Txt.Enabled = false;
            }
        }

        private void eDurumu_3chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (eDurumu_3chkBox.Checked == true)
            {
                okul_adi_3Txt.Enabled = true;
                turu3_Cmb.Enabled = true;
                bolumu_3Txt.Enabled = true;
                basTarihi_3Txt.Enabled = true;
                bitTarihi_3Txt.Enabled = true;
                notOrt_3Txt.Enabled = true;
            }
            else
            {
                okul_adi_3Txt.Enabled = false;
                turu3_Cmb.Enabled = false;
                bolumu_3Txt.Enabled = false;
                basTarihi_3Txt.Enabled = false;
                bitTarihi_3Txt.Enabled = false;
                notOrt_3Txt.Enabled = false;
            }
        }

        private void eDurumu_4chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (eDurumu_4chkBox.Checked == true)
            {
                okul_adi_4Txt.Enabled = true;
                turu4_Cmb.Enabled = true;
                bolumu_4Txt.Enabled = true;
                basTarihi_4Txt.Enabled = true;
                bitTarihi_4Txt.Enabled = true;
                notOrt_4Txt.Enabled = true;
            }
            else
            {
                okul_adi_4Txt.Enabled = false;
                turu4_Cmb.Enabled = false;
                bolumu_4Txt.Enabled = false;
                basTarihi_4Txt.Enabled = false;
                bitTarihi_4Txt.Enabled = false;
                notOrt_4Txt.Enabled = false;
            }
        }

        private void isDeneyimi_2chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isDeneyimi_2chkBox.Checked == true)
            {
                calistigiyer_Adi_2Txt.Enabled = true;
                isAdresi_2Txt.Enabled = true;
                istecPozveyaGor_2Txt.Enabled = true;
                istecSur_2Txt.Enabled = true;
            }
            else
            {
                calistigiyer_Adi_2Txt.Enabled = false;
                isAdresi_2Txt.Enabled = false;
                istecPozveyaGor_2Txt.Enabled = false;
                istecSur_2Txt.Enabled = false;
            }
        }

        private void isDeneyimi_3chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isDeneyimi_3chkBox.Checked == true)
            {
                calistigiyer_Adi_3Txt.Enabled = true;
                isAdresi_3Txt.Enabled = true;
                istecPozveyaGor_3Txt.Enabled = true;
                istecSur_3Txt.Enabled = true;
            }
            else
            {
                calistigiyer_Adi_3Txt.Enabled = false;
                isAdresi_3Txt.Enabled = false;
                istecPozveyaGor_3Txt.Enabled = false;
                istecSur_3Txt.Enabled = false;
            }
        }

        private void isDeneyimi_4chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isDeneyimi_4chkBox.Checked == true)
            {
                calistigiyer_Adi_4Txt.Enabled = true;
                isAdresi_4Txt.Enabled = true;
                istecPozveyaGor_4Txt.Enabled = true;
                istecSur_4Txt.Enabled = true;
            }
            else
            {
                calistigiyer_Adi_4Txt.Enabled = false;
                isAdresi_4Txt.Enabled = false;
                istecPozveyaGor_4Txt.Enabled = false;
                istecSur_4Txt.Enabled = false;
            }
        }

        private void okul_adiTxt_TextChanged(object sender, EventArgs e)
        {
            if (okul_adiTxt.Text != "")
            {
                eDurumu_2chkBox.Enabled = true;

            }
        }

        private void okul_adi_2Txt_TextChanged(object sender, EventArgs e)
        {
            if (okul_adi_2Txt.Text != "")
            {
                eDurumu_3chkBox.Enabled = true;

            }
        }

        private void okul_adi_3Txt_TextChanged(object sender, EventArgs e)
        {
            if (okul_adi_3Txt.Text != "")
            {
                eDurumu_4chkBox.Enabled = true;
            }
        }

        private void calistigiyer_AdiTxt_TextChanged(object sender, EventArgs e)
        {
            if (calistigiyer_AdiTxt.Text != "")
            {
                isDeneyimi_2chkBox.Enabled = true;
            }
        }

        private void calistigiyer_Adi_2Txt_TextChanged(object sender, EventArgs e)
        {
            if (calistigiyer_Adi_2Txt.Text != "")
            {
                isDeneyimi_3chkBox.Enabled = true;

            }
        }

        private void calistigiyer_Adi_3Txt_TextChanged(object sender, EventArgs e)
        {
            if (calistigiyer_Adi_3Txt.Text != "")
            {
                isDeneyimi_4chkBox.Enabled = true;
            }
        }

        private void kayitol_Btn_Click(object sender, EventArgs e)
        {
            dosyakaydet();
            Eskihaledondur();
        }

        private void kapat_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            verilerisil();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            verilerigetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Guncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baslangic b = new baslangic();
            b.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void isDeneyimi_5chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isDeneyimi_5chkBox.Checked == true)
            {
                calistigiyer_Adi_5Txt.Enabled = true;
                isAdresi_5Txt.Enabled = true;
                istecPozveyaGor_5Txt.Enabled = true;
                istecSur_5Txt.Enabled = true;
            }
            else
            {
                calistigiyer_Adi_5Txt.Enabled = false;
                isAdresi_5Txt.Enabled = false;
                istecPozveyaGor_5Txt.Enabled = false;
                istecSur_5Txt.Enabled = false;
            }
        }

        private void isDeneyimi_6chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isDeneyimi_6chkBox.Checked == true)
            {
                calistigiyer_Adi_6Txt.Enabled = true;
                isAdresi_6Txt.Enabled = true;
                istecPozveyaGor_6Txt.Enabled = true;
                istecSur_6Txt.Enabled = true;
            }
            else
            {
                calistigiyer_Adi_6Txt.Enabled = false;
                isAdresi_6Txt.Enabled = false;
                istecPozveyaGor_6Txt.Enabled = false;
                istecSur_6Txt.Enabled = false;
            }
        }

        private void calistigiyer_Adi_4Txt_TextChanged(object sender, EventArgs e)
        {
            if (calistigiyer_Adi_4Txt.Text != "")
            {
                isDeneyimi_5chkBox.Enabled = true;
            }
        }

        private void calistigiyer_Adi_6Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void calistigiyer_Adi_5Txt_TextChanged(object sender, EventArgs e)
        {
            if (calistigiyer_Adi_5Txt.Text != "")
            {
                isDeneyimi_6chkBox.Enabled = true;
            }
        }
    }
}
