using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terzi_Takip_Otomasyonu
{

    class Veritabanı
    {
        SqlConnection con;

        public Veritabanı()
        {
            con = new SqlConnection("server=.database =TerziTakip;Integrated Security = true");
        }

        public bool KıyafetEkle(int tbÖlçüNo1, string tbEtek, string tbElbise, string tbPantolon, string tbTişört, string tbCeket, string tbGömlek)
        {

            bool durum = false;
            SqlCommand cmd = new SqlCommand("Insert into Kıyafetler(Olcu_no,Etek,Elbise.Pantolon,Tişört,Ceket,Gömlek)values(@Olcu_no,@Etek,@Elbise,@Pantolon,@Tişört,@Ceket,@Gömlek");
            cmd.Parameters.AddWithValue("@Olcu_no", tbÖlçüNo1);
            cmd.Parameters.AddWithValue("@Etek",tbEtek);
            cmd.Parameters.AddWithValue("ELbise", tbElbise);
            cmd.Parameters.AddWithValue("@Pantolon",tbPantolon);
            cmd.Parameters.AddWithValue("@Tişört",tbTişört);
            cmd.Parameters.AddWithValue("@Ceket", tbCeket);
            cmd.Parameters.AddWithValue("@Gömlek", tbGömlek);
            con.Open();
          try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception){
                

            }
            con.Close();
            return;
            }
        public bool KisiEkle(string tbMüşteriAdı1, string tbMüşteriSoyadı1, string tbTelefonNo1, string lblCinsiyet1, string tbEPosta1, string tbAdres1)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("Insert into Müsteriler (tbMüşteriAdı1, tbMüşteriSoyadı1, tbTelefonNo1, lblCinsiyet1, tbEPosta1, tbAdres1) values (@adı, @soyadı, @Cinsiyet, @Telefon_no, @E_posta, @Adres)", con);
            cmd.Parameters.AddWithValue("@adı", tbMüşteriAdı1);
            cmd.Parameters.AddWithValue("@soyadı", tbMüşteriSoyadı1);
            cmd.Parameters.AddWithValue("@Telefon_no", tbTelefonNo1);
            cmd.Parameters.AddWithValue("@Cinsiyet", lblCinsiyet1);
            cmd.Parameters.AddWithValue("@E_posta", tbEPosta1);
            cmd.Parameters.AddWithValue("@Adres", tbAdres1);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception){
                

            }
            con.Close();
            return;
        }
        public bool OdemeEkle(string tbFiyat1, string tbAlışTarihi1, string tbTeslimTarihi1, string tbSonÖdemeTarihi1, string tbTahsilat1)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("Insert into Müsteriler (tbFiyat1, tbAlışTarihi1, tbTeslimTarihi1, tbSonÖdemeTarihi1, tbTahsilat1) values (@Fiyat, @Alış, @Teslim, @Son_odeme, @Tahsilat)", con);
            cmd.Parameters.AddWithValue("@Fiyat", tbFiyat1);
            cmd.Parameters.AddWithValue("@Alış", tbAlışTarihi1);
            cmd.Parameters.AddWithValue("@Teslim", tbTeslimTarihi1);
            cmd.Parameters.AddWithValue("@Son_odeme", tbSonÖdemeTarihi1);
            cmd.Parameters.AddWithValue("@Tahsilat", tbTahsilat1);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {


            }
            con.Close();
            return;
        }
        public bool IslemEkle(string tbDikim, string tbTadil, string tbTamir)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("Insert into Müsteriler (tbDikim, tbTadil, tbTamir) values (@Dikim, @Tadil, @Tamir)", con);
            cmd.Parameters.AddWithValue("@Dikim", tbDikim);
            cmd.Parameters.AddWithValue("@Tadil", tbTadil);
            cmd.Parameters.AddWithValue("@Tamir", tbTamir);
          
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {


            }
            con.Close();
            return;
        }
        public bool OlcuEkle(string tbGöğüs, string tbBel, string tbBasen, string tbKol_boyu, string tbOmuz, string tbBilek)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("Insert into Müsteriler (tbGöğüs, tbBel, tbBasen,tbKol_boyu, tbOmuz, tbBilek) values (@Göğüs, @Bel, @Basen ,@Kol_boyu, @Omuz, @Bilek)", con);
            cmd.Parameters.AddWithValue("@Göğüs", tbGöğüs);
            cmd.Parameters.AddWithValue("@Bel", tbBel);
            cmd.Parameters.AddWithValue("@Basen", tbBasen);
            cmd.Parameters.AddWithValue("@Kol_boyu", tbKol_boyu);
            cmd.Parameters.AddWithValue("@Omuz", tbOmuz);
            cmd.Parameters.AddWithValue("@Bilek", tbBilek);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {


            }
            con.Close();
            return;
        }




        public bool AdresEkle(string tbCadde, string tbMahalle, string tbSokak,string tbBina_no, string tbİlçe, string tbŞehir)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("Insert into Müsteriler (tbCadde, tbMahalle, tbSokak, tbBina_no,tbİlçe, tbŞehir) values (@Cadde, @Mahalle, @Sokak,@Bina_no, @İlçe, @Şehir)", con);
            cmd.Parameters.AddWithValue("@Cadde", tbCadde);
            cmd.Parameters.AddWithValue("@Mahalle", tbMahalle);
            cmd.Parameters.AddWithValue("@Sokak", tbSokak);
            cmd.Parameters.AddWithValue("@Bina_no", tbBina_no);
            cmd.Parameters.AddWithValue("@İlçe", tbİlçe);
            cmd.Parameters.AddWithValue("@Şehir", tbŞehir);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {


            }
            con.Close();
            return;
        }
    }

      
      

} 
