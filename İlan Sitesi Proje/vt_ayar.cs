using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace İlan_Sitesi_Proje
{
    class vt_ayar
    {
        public SqlConnection connection = new SqlConnection("Data Source=HPPC;Initial Catalog=ilan_vt;Integrated Security=true");
        public SqlCommand command;
        public SqlDataReader reader;
        public SqlDataAdapter adapter;

        public bool ilan_ekle(object[] ilan_data)
        {
            int musteriID = (int)ilan_data[0];
            string ilanBaslik = (string)ilan_data[1];
            string ilanAciklama = (string)ilan_data[2];
            string ilanSehir = (string)ilan_data[3];
            int aracFiyat = (int)ilan_data[4];
            int aracKm = (int)ilan_data[5];
            string aracMarka = (string)ilan_data[6];
            string aracModel = (string)ilan_data[7];
            int aracMotorHacmi = (int)ilan_data[8];
            int aracYil = (int)ilan_data[9];
            int aracDurum = (int)ilan_data[10];
            int aracTakas = (int)ilan_data[11];
            int aracKimden = (int)ilan_data[12];
            byte[] aracGorsel = (byte[])ilan_data[13];

            try
            {
                connection.Open();
                string sql = "INSERT INTO ilanTablo(musteriID, ilanBaslik, ilanAciklama, ilanSehir, aracFiyat, aracKm, aracMarka, aracModel, aracMotorHacmi, aracYil, aracDurum, aracTakas, aracKimden, aracGorsel) VALUES (@musteriID, @ilanBaslik, @ilanAciklama, @ilanSehir, @aracFiyat, @aracKm, @aracMarka, @aracModel, @aracMotorHacmi, @aracYil, @aracDurum, @aracTakas, @aracKimden, @aracGorsel)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@musteriID", musteriID);
                command.Parameters.AddWithValue("@ilanBaslik", ilanBaslik);
                command.Parameters.AddWithValue("@ilanAciklama", ilanAciklama);
                command.Parameters.AddWithValue("@ilanSehir", ilanSehir);
                command.Parameters.AddWithValue("@aracFiyat", aracFiyat);
                command.Parameters.AddWithValue("@aracKm", aracKm);
                command.Parameters.AddWithValue("@aracMarka", aracMarka);
                command.Parameters.AddWithValue("@aracModel", aracModel);
                command.Parameters.AddWithValue("@aracMotorHacmi", aracMotorHacmi);
                command.Parameters.AddWithValue("@aracYil", aracYil);
                command.Parameters.AddWithValue("@aracDurum", aracDurum);
                command.Parameters.AddWithValue("@aracTakas", aracTakas);
                command.Parameters.AddWithValue("@aracKimden", aracKimden);
                command.Parameters.AddWithValue("@aracGorsel", aracGorsel);
                
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ilan_guncelle(object[] ilan_data, int ilanDurum = 0)
        {
            int ilanID = (int)ilan_data[0];
            string ilanBaslik = (string)ilan_data[1];
            string ilanAciklama = (string)ilan_data[2];
            string ilanSehir = (string)ilan_data[3];
            int aracFiyat = (int)ilan_data[4];
            int aracKm = (int)ilan_data[5];
            string aracMarka = (string)ilan_data[6];
            string aracModel = (string)ilan_data[7];
            int aracMotorHacmi = (int)ilan_data[8];
            int aracYil = (int)ilan_data[9];
            int aracDurum = (int)ilan_data[10];
            int aracTakas = (int)ilan_data[11];
            int aracKimden = (int)ilan_data[12];
            byte[] aracGorsel = (byte[])ilan_data[13];
            bool gorselDegissin = (bool)ilan_data[14];
            bool ilanOnayli = (bool)ilan_data[15];

            string sqlSorgu = "";

            try
            {
                connection.Open();

                if (gorselDegissin)
                {
                    sqlSorgu = "UPDATE ilanTablo SET ilanBaslik = @ilanBaslik, ilanAciklama = @ilanAciklama, ilanSehir = @ilanSehir, aracFiyat = @aracFiyat, aracKm = @aracKm, aracMarka = @aracMarka, aracModel = @aracModel, aracMotorHacmi = @aracMotorHacmi, aracYil = @aracYil, aracDurum = @aracDurum, aracTakas = @aracTakas, aracKimden = @aracKimden, aracGorsel = @aracGorsel, ilanDurum = @ilanDurum WHERE ID = @ilanID";
                }
                else
                {
                    sqlSorgu = "UPDATE ilanTablo SET ilanBaslik = @ilanBaslik, ilanAciklama = @ilanAciklama, ilanSehir = @ilanSehir, aracFiyat = @aracFiyat, aracKm = @aracKm, aracMarka = @aracMarka, aracModel = @aracModel, aracMotorHacmi = @aracMotorHacmi, aracYil = @aracYil, aracDurum = @aracDurum, aracTakas = @aracTakas, aracKimden = @aracKimden, ilanDurum = @ilanDurum WHERE ID = @ilanID";
                }

                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@ilanID", ilanID);
                command.Parameters.AddWithValue("@ilanBaslik", ilanBaslik);
                command.Parameters.AddWithValue("@ilanAciklama", ilanAciklama);
                command.Parameters.AddWithValue("@ilanSehir", ilanSehir);
                command.Parameters.AddWithValue("@aracFiyat", aracFiyat);
                command.Parameters.AddWithValue("@aracKm", aracKm);
                command.Parameters.AddWithValue("@aracMarka", aracMarka);
                command.Parameters.AddWithValue("@aracModel", aracModel);
                command.Parameters.AddWithValue("@aracMotorHacmi", aracMotorHacmi);
                command.Parameters.AddWithValue("@aracYil", aracYil);
                command.Parameters.AddWithValue("@aracDurum", aracDurum);
                command.Parameters.AddWithValue("@aracTakas", aracTakas);
                command.Parameters.AddWithValue("@aracKimden", aracKimden);
                if (gorselDegissin)
                {
                    command.Parameters.AddWithValue("@aracGorsel", aracGorsel);
                }

                if (ilanOnayli)
                {
                    command.Parameters.AddWithValue("@ilanDurum", 1);
                }
                else
                {
                    command.Parameters.AddWithValue("@ilanDurum", 0);
                }

                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ilan_sil(int ilanID)
        {
            try
            {
                // İlanı Sil

                connection.Open();
                string sqlSorgu = "DELETE FROM ilanTablo WHERE ID = @ilanID;";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@ilanID", ilanID);
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool ilan_onayla(int ilanID)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("UPDATE ilanTablo SET ilanDurum = 1 WHERE ID = @ilanID", connection);
                command.Parameters.AddWithValue("ilanID", ilanID);
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ilan_duzenle(object[] ilan_data)
        {
            try
            {
                int ilanID = (int)ilan_data[0];
                string ilanBaslik = (string)ilan_data[1];
                string ilanAciklama = (string)ilan_data[2];
                string ilanSehir = (string)ilan_data[3];
                int aracFiyat = (int)ilan_data[4];
                int aracKm = (int)ilan_data[5];
                string aracMarka = (string)ilan_data[6];
                string aracModel = (string)ilan_data[7];
                int aracMotorHacmi = (int)ilan_data[8];
                int aracYil = (int)ilan_data[9];
                int aracDurum = (int)ilan_data[10];
                int aracTakas = (int)ilan_data[11];
                int aracKimden = (int)ilan_data[12];
                byte[] aracGorsel = (byte[])ilan_data[13];
                
                string sqlSorgu;

                if (aracGorsel != null && aracGorsel.Length > 0)
                {
                    sqlSorgu = "UPDATE ilanTablo SET ilanBaslik = @ilanBaslik, ilanAciklama = @ilanAciklama, ilanSehir = @ilanSehir, aracFiyat = @aracFiyat, aracKm = @aracKm, aracMarka = @aracMarka, aracModel = @aracModel, aracMotorHacmi = @aracMotorHacmi, aracYil = @aracYil, aracDurum = @aracDurum, aracTakas = @aracTakas, aracKimden = @aracKimden, aracGorsel = @aracGorsel WHERE ID = @ilanID";
                }
                else
                {
                    sqlSorgu = "UPDATE ilanTablo SET ilanBaslik = @ilanBaslik, ilanAciklama = @ilanAciklama, ilanSehir = @ilanSehir, aracFiyat = @aracFiyat, aracKm = @aracKm, aracMarka = @aracMarka, aracModel = @aracModel, aracMotorHacmi = @aracMotorHacmi, aracYil = @aracYil, aracDurum = @aracDurum, aracTakas = @aracTakas, aracKimden = @aracKimden WHERE ID = @ilanID";
                }

                connection.Open();
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@ilanID", ilanID);
                command.Parameters.AddWithValue("@ilanBaslik", ilanBaslik);
                command.Parameters.AddWithValue("@ilanAciklama", ilanAciklama);
                command.Parameters.AddWithValue("@ilanSehir", ilanSehir);
                command.Parameters.AddWithValue("@aracFiyat", aracFiyat);
                command.Parameters.AddWithValue("@aracKm", aracKm);
                command.Parameters.AddWithValue("@aracMarka", aracMarka);
                command.Parameters.AddWithValue("@aracModel", aracModel);
                command.Parameters.AddWithValue("@aracMotorHacmi", aracMotorHacmi);
                command.Parameters.AddWithValue("@aracYil", aracYil);
                command.Parameters.AddWithValue("@aracDurum", aracDurum);
                command.Parameters.AddWithValue("@aracTakas", aracTakas);
                command.Parameters.AddWithValue("@aracKimden", aracKimden);
                if (aracGorsel != null && aracGorsel.Length > 0)
                {
                    command.Parameters.AddWithValue("@aracGorsel", aracGorsel);
                }
                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kullanici_ara(string musteriMail)
        {
            connection.Open();
            string sqlSorgu = "SELECT * FROM musteriTablo WHERE musteriMail = @musteriMail;";
            command = new SqlCommand(sqlSorgu, connection);
            command.Parameters.AddWithValue("@musteriMail", musteriMail);
            reader = command.ExecuteReader();
            bool sonuc = reader.Read();
            connection.Close();

            return sonuc;
        }
        public bool kullanici_olustur(object[] kullanici_data)
        {
            string musteriAd = (string)kullanici_data[0];
            string musteriSoyad = (string)kullanici_data[1];
            string musteriMail = (string)kullanici_data[2];
            string musteriTelefon = (string)kullanici_data[3];
            string musteriSifre = (string)kullanici_data[4];
            int uyelikTipi = (int)kullanici_data[5];

            bool sonuc = kullanici_ara(musteriMail);

            if (!sonuc)
            {
                try
                {
                    string sqlSorgu = "INSERT INTO musteriTablo(musteriAd, musteriSoyad, musteriMail, musteriTelefon, musteriSifre, uyelikTipi) VALUES (@musteriAd, @musteriSoyad, @musteriMail, @musteriTelefon, @musteriSifre, @uyelikTipi);";
                    command = new SqlCommand(sqlSorgu, connection);
                    command.Parameters.AddWithValue("@musteriAd", musteriAd);
                    command.Parameters.AddWithValue("@musteriSoyad", musteriSoyad);
                    command.Parameters.AddWithValue("@musteriMail", musteriMail);
                    command.Parameters.AddWithValue("@musteriTelefon", musteriTelefon);
                    command.Parameters.AddWithValue("@musteriSifre", musteriSifre);
                    command.Parameters.AddWithValue("@uyelikTipi", uyelikTipi);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }

            return false;
        }
        public bool kullanici_kontrol(object[] kullanici_data)
        {
            string musteriMail = (string)kullanici_data[0];
            string musteriSifre = (string)kullanici_data[1];
            connection.Open();
            string sqlSorgu = "SELECT * FROM musteriTablo WHERE musteriMail = @musteriMail AND musteriSifre = @musteriSifre;";
            command = new SqlCommand(sqlSorgu, connection);
            command.Parameters.AddWithValue("@musteriMail", musteriMail);
            command.Parameters.AddWithValue("@musteriSifre", musteriSifre);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                if ((int)reader["uyelikTipi"] > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
        public bool kullanici_sil(int kullaniciID)
        {
            try
            {
                // Müşteriyi Sil
                connection.Open();
                string sqlSorgu = "DELETE FROM musteriTablo WHERE ID = @kullaniciID;";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                command.ExecuteNonQuery();
                connection.Close();

                // İlanlarını Sil
                connection.Open();
                sqlSorgu = "DELETE FROM ilanTablo WHERE musteriID = @kullaniciID;";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool kullanici_duzenle(object[] kullanici_data)
        {
            try
            {
                int musteriID = (int)kullanici_data[0];
                string musteriAd = (string)kullanici_data[1];
                string musteriSoyad = (string)kullanici_data[2];
                string musteriMail = (string)kullanici_data[3];
                string musteriTelefon = (string)kullanici_data[4];
                string musteriSifre = (string)kullanici_data[5];
                int uyelikTipi = (int)kullanici_data[6];

                string sqlSorgu;

                if (musteriSifre != null || musteriSifre != "")
                {
                    sqlSorgu = "UPDATE musteriTablo SET musteriAd = @musteriAd, musteriSoyad = @musteriSoyad, musteriMail = @musteriMail, musteriTelefon = @musteriTelefon, musteriSifre = @musteriSifre, uyelikTipi = @uyelikTipi WHERE ID = @musteriID";
                }
                else
                {
                    sqlSorgu = "UPDATE musteriTablo SET musteriAd = @musteriAd, musteriSoyad = @musteriSoyad, musteriMail = @musteriMail, musteriTelefon = @musteriTelefon, uyelikTipi = @uyelikTipi WHERE ID = @musteriID";
                }

                connection.Open();
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@musteriAd", musteriAd);
                command.Parameters.AddWithValue("@musteriSoyad", musteriSoyad);
                command.Parameters.AddWithValue("@musteriMail", musteriMail);
                command.Parameters.AddWithValue("@musteriTelefon", musteriTelefon);
                if (musteriSifre != null || musteriSifre != "")
                {
                    fonksiyonlar funcs = new fonksiyonlar();
                    musteriSifre = funcs.MD5Hash(musteriSifre);
                    command.Parameters.AddWithValue("@musteriSifre", musteriSifre);
                }
                command.Parameters.AddWithValue("@uyelikTipi", uyelikTipi);
                command.Parameters.AddWithValue("@musteriID", musteriID);
                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kullanici_self_duzenle(object[] kullanici_data)
        {
            try
            {
                int musteriID = (int)kullanici_data[0];
                string musteriAd = (string)kullanici_data[1];
                string musteriSoyad = (string)kullanici_data[2];
                string musteriMail = (string)kullanici_data[3];
                string musteriTelefon = (string)kullanici_data[4];
                string musteriSifre = (string)kullanici_data[5];

                string sqlSorgu;

                if (musteriSifre != null || musteriSifre != "")
                {
                    sqlSorgu = "UPDATE musteriTablo SET musteriAd = @musteriAd, musteriSoyad = @musteriSoyad, musteriMail = @musteriMail, musteriTelefon = @musteriTelefon, musteriSifre = @musteriSifre WHERE ID = @musteriID";
                }
                else
                {
                    sqlSorgu = "UPDATE musteriTablo SET musteriAd = @musteriAd, musteriSoyad = @musteriSoyad, musteriMail = @musteriMail, musteriTelefon = @musteriTelefon WHERE ID = @musteriID";
                }

                connection.Open();
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@musteriAd", musteriAd);
                command.Parameters.AddWithValue("@musteriSoyad", musteriSoyad);
                command.Parameters.AddWithValue("@musteriMail", musteriMail);
                command.Parameters.AddWithValue("@musteriTelefon", musteriTelefon);
                if (musteriSifre != null || musteriSifre != "")
                {
                    fonksiyonlar funcs = new fonksiyonlar();
                    musteriSifre = funcs.MD5Hash(musteriSifre);
                    command.Parameters.AddWithValue("@musteriSifre", musteriSifre);
                }
                command.Parameters.AddWithValue("@musteriID", musteriID);
                command.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kullanici_yasakla(int musteriID)
        {
            try
            {
                connection.Open();
                string sqlSorgu = "UPDATE musteriTablo SET uyelikTipi = 0 WHERE ID = @musteriID";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@musteriID", musteriID);
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool marka_ekle(string marka_isim)
        {
            try
            {
                connection.Open();
                string sqlSorgu = "INSERT INTO markaTablo(marka_isim) VALUES (@marka_isim)";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@marka_isim", marka_isim);
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool model_ekle(object[] model_data)
        {
            try
            {
                int markaID = (int)model_data[0];
                string model_isim = (string)model_data[1];
                connection.Open();
                string sqlSorgu = "INSERT INTO modelTablo(markaID, model_isim) VALUES (@markaID, @model_isim)";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@markaID", markaID);
                command.Parameters.AddWithValue("@model_isim", model_isim);
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool marka_sil(int markaID)
        {
            try
            {
                // Markayı Sil
                connection.Open();
                string sqlSorgu = "DELETE FROM markaTablo WHERE ID = @markaID;";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@markaID", markaID);
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool model_sil(int modelID)
        {
            try
            {
                // Modeli Sil
                connection.Open();
                string sqlSorgu = "DELETE FROM modelTablo WHERE ID = @modelID;";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@modelID", modelID);
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool marka_duzenle(object[] marka_data)
        {
            try
            {
                int markaID = (int)marka_data[0];
                string marka_isim = (string)marka_data[1];

                connection.Open();
                string sqlSorgu = "UPDATE markaTablo SET marka_isim = @marka_isim WHERE ID = @markaID;";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@markaID", markaID);
                command.Parameters.AddWithValue("@marka_isim", marka_isim);
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool model_duzenle(object[] model_data)
        {
            try
            {
                int modelID = (int)model_data[0];
                int markaID = (int)model_data[1];
                string model_isim = (string)model_data[2];

                connection.Open();
                string sqlSorgu = "UPDATE modelTablo SET markaID = @markaID, model_isim = @model_isim WHERE ID = @modelID;";
                command = new SqlCommand(sqlSorgu, connection);
                command.Parameters.AddWithValue("@modelID", modelID);
                command.Parameters.AddWithValue("@markaID", markaID);
                command.Parameters.AddWithValue("@model_isim", model_isim);
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public object kullanici_mail_ile_veri_getir(string musteriMail)
        {
            connection.Open();
            string sqlSorgu = "SELECT ID, musteriAd, musteriSoyad, musteriMail, musteriTelefon, uyelikTipi FROM musteriTablo WHERE musteriMail = @musteriMail;";
            command = new SqlCommand(sqlSorgu, connection);
            command.Parameters.AddWithValue("@musteriMail", musteriMail);
            reader = command.ExecuteReader();
            reader.Read();

            object[] kullanici_data = {
                reader["ID"],
                reader["musteriAd"],
                reader["musteriSoyad"],
                reader["musteriMail"],
                reader["musteriTelefon"],
                reader["uyelikTipi"]
            };

            connection.Close();

            return kullanici_data;
        }
        public object kullanici_ID_ile_veri_getir(int musteriID)
        {
            connection.Open();
            string sqlSorgu = "SELECT ID, musteriAd, musteriSoyad, musteriMail, musteriTelefon, uyelikTipi FROM musteriTablo WHERE ID = @musteriID;";
            command = new SqlCommand(sqlSorgu, connection);
            command.Parameters.AddWithValue("@musteriID", musteriID);
            reader = command.ExecuteReader();
            reader.Read();

            object[] kullanici_data = {
                reader["ID"],
                reader["musteriAd"],
                reader["musteriSoyad"],
                reader["musteriMail"],
                reader["musteriTelefon"],
                reader["uyelikTipi"]
            };

            return kullanici_data;
        }
        public object model_ID_ile_getir(int modelID)
        {
            connection.Open();
            command = new SqlCommand("SELECT markaID, model_isim FROM modelTablo WHERE ID = " + modelID, connection);
            reader = command.ExecuteReader();
            reader.Read();
            object[] model_data = {
                reader["markaID"],
                reader["model_isim"]
            };

            return model_data;
        }
        public string marka_ID_ile_getir(int markaID)
        {
            connection.Open();
            command = new SqlCommand("SELECT marka_isim FROM markaTablo WHERE ID = " + markaID, connection);
            reader = command.ExecuteReader();
            reader.Read();
            return reader["marka_isim"].ToString();
        }
        public SqlDataReader marka_getir()
        {
            connection.Open();
            command = new SqlCommand("SELECT * FROM markaTablo", connection);
            reader = command.ExecuteReader();
            return reader;
        }
        public SqlDataReader model_getir(int markaID)
        {
            connection.Open();
            command = new SqlCommand("SELECT * FROM modelTablo WHERE markaID = " + markaID + "", connection);
            reader = command.ExecuteReader();

            return reader;
        }
        public SqlDataReader ilan_getir(int ilanID)
        {
            connection.Open();
            string sql = "SELECT * FROM ilanTablo WHERE ID=" + ilanID;
            Console.WriteLine(sql);
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            return reader;
        }
        public SqlDataAdapter ilan_listele(int ilanDurum = 1)
        {
            connection.Open();

            string sqlSorgu;
            sqlSorgu = "SELECT ilanTablo.ID, aracGorsel, ilanBaslik, aracFiyat, aracKm, (marka_isim + ' ' + model_isim) as aracMarkaModel, aracYil FROM ilanTablo";
            sqlSorgu += " INNER JOIN markaTablo ON ilanTablo.aracMarka = markaTablo.marka_isim ";
            sqlSorgu += " INNER JOIN modelTablo ON ilanTablo.aracModel = modelTablo.model_isim WHERE ilanDurum = " + ilanDurum + ";";

            command = new SqlCommand(sqlSorgu, connection);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        public SqlDataAdapter ilan_filtrele(object[] filtre_data)
        {
            connection.Open();

            string marka = (string)filtre_data[0];
            string model = (string)filtre_data[1];
            string fiyatMin = (string)filtre_data[2];
            string fiyatMax = (string)filtre_data[3];
            string kmMin = (string)filtre_data[4];
            string kmMax = (string)filtre_data[5];
            string yilMin = (string)filtre_data[6];
            string yilMax = (string)filtre_data[7];
            string sehir = (string)filtre_data[8];
            int durum = (int)filtre_data[9];
            int kimden = (int)filtre_data[10];
            int takas = (int)filtre_data[11];

            string sqlSorgu;
            sqlSorgu = "SELECT ilanTablo.ID, aracGorsel, ilanBaslik, aracFiyat, aracKm, (marka_isim + ' ' + model_isim) as aracMarkaModel, aracYil FROM ilanTablo";
            sqlSorgu += " INNER JOIN markaTablo ON ilanTablo.aracMarka = markaTablo.marka_isim ";
            sqlSorgu += " INNER JOIN modelTablo ON ilanTablo.aracModel = modelTablo.model_isim WHERE ilanDurum = 1 ";

            if (marka != "Hepsi")
            {
                sqlSorgu += " AND aracMarka = '" + marka + "' ";
            }

            if (model != "Hepsi")
            {
                sqlSorgu += " AND aracModel = '" + model + "' ";
            }

            if (fiyatMin != "" && fiyatMax != "")
            {
                sqlSorgu += " AND aracFiyat BETWEEN " + fiyatMin + " AND " + fiyatMax + " ";
            }
            else
            {
                if (fiyatMin != "")
                {
                    sqlSorgu += " AND aracFiyat > " + fiyatMin + " ";
                }
                else if (fiyatMax != "")
                {
                    sqlSorgu += " AND aracFiyat > " + fiyatMax + " ";
                }
            }

            if (kmMin != "" && kmMax != "")
            {
                sqlSorgu += " AND aracKm BETWEEN " + kmMin + " AND " + kmMax + " ";
            }
            else
            {
                if (kmMin != "")
                {
                    sqlSorgu += " AND aracKm > " + kmMin + " ";
                }
                else if (kmMax != "")
                {
                    sqlSorgu += " AND aracKm > " + kmMax + " ";
                }
            }

            if (yilMin != "" && yilMax != "")
            {
                sqlSorgu += " AND aracYil BETWEEN " + yilMin + " AND " + yilMax + " ";
            }
            else
            {
                if (yilMin != "")
                {
                    sqlSorgu += " AND aracYil > " + yilMin + " ";
                }
                else if (yilMax != "")
                {
                    sqlSorgu += " AND aracYil > " + yilMax + " ";
                }
            }

            if (sehir != "Hepsi")
            {
                sqlSorgu += " AND ilanSehir = '" + sehir + "' ";
            }

            if (durum > 0)
            {
                sqlSorgu += " AND aracDurum = " + (durum - 1) + " ";
            }

            if (kimden > 0)
            {
                sqlSorgu += " AND aracKimden = " + (kimden - 1) + " ";
            }

            if (takas > 0)
            {
                sqlSorgu += " AND aracTakas = " + (takas - 1) + " ";
            }

            sqlSorgu += ";";

            command = new SqlCommand(sqlSorgu, connection);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        public SqlDataAdapter kullanici_listele()
        {
            connection.Open();

            string sqlSorgu;
            sqlSorgu = "SELECT ID, musteriAd, musteriSoyad, musteriMail, musteriTelefon, IIF(uyelikTipi = 0, 'Yasaklı', IIF(uyelikTipi = 1, 'Bireysel', IIF(uyelikTipi = 2, 'Kurumsal', IIF(uyelikTipi = 3, 'Yönetici', 'Bilinmiyor')))) as uyelikTipi FROM musteriTablo;";
            command = new SqlCommand(sqlSorgu, connection);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        public SqlDataAdapter kullanici_like_ile_listele(string searchText)
        {
            connection.Open();
            string sqlSorgu;
            sqlSorgu = "SELECT ID, musteriAd, musteriSoyad, musteriMail, musteriTelefon, IIF(uyelikTipi = 0, 'Yasaklı', IIF(uyelikTipi = 1, 'Bireysel', IIF(uyelikTipi = 2, 'Kurumsal', IIF(uyelikTipi = 3, 'Yönetici', 'Bilinmiyor')))) as uyelikTipi FROM musteriTablo WHERE ID LIKE '%'+@searchText+'%' OR musteriAd LIKE '%'+@searchText+'%' OR musteriSoyad LIKE '%'+@searchText+'%' OR musteriMail LIKE '%'+@searchText+'%' OR musteriTelefon LIKE '%'+@searchText+'%';";
            command = new SqlCommand(sqlSorgu, connection);
            command.Parameters.AddWithValue("@searchText", searchText);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        public SqlDataAdapter ilan_like_ile_listele(string searchText, int ilanDurum = 1)
        {
            connection.Open();
            string sqlSorgu;
            sqlSorgu = "SELECT ilanTablo.ID, aracGorsel, ilanBaslik, aracFiyat, aracKm, (marka_isim + ' ' + model_isim) as aracMarkaModel, aracYil FROM ilanTablo INNER JOIN markaTablo ON ilanTablo.aracMarka = markaTablo.marka_isim INNER JOIN modelTablo ON ilanTablo.aracModel = modelTablo.model_isim WHERE ilanDurum = @ilanDurum AND (ilanBaslik LIKE '%'+@searchText+'%' OR ilanAciklama LIKE '%'+@searchText+'%');";
            command = new SqlCommand(sqlSorgu, connection);
            command.Parameters.AddWithValue("@searchText", searchText);
            command.Parameters.AddWithValue("@ilanDurum", ilanDurum);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        public SqlDataAdapter kullanici_ilan_listele(int musteriID)
        {
            connection.Open();

            string sqlSorgu;
            sqlSorgu = "SELECT ilanTablo.ID, aracGorsel, ilanBaslik, aracFiyat, aracKm, (marka_isim + ' ' + model_isim) as aracMarkaModel, IIF(ilanDurum = 0, 'Yayımlanmadı', 'Yayımlandı') FROM ilanTablo";
            sqlSorgu += " INNER JOIN markaTablo ON ilanTablo.aracMarka = markaTablo.marka_isim ";
            sqlSorgu += " INNER JOIN modelTablo ON ilanTablo.aracModel = modelTablo.model_isim WHERE musteriID = " + musteriID + ";";

            command = new SqlCommand(sqlSorgu, connection);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        public SqlDataAdapter kullanici_ilan_like_ile_listele(string searchText, int musteriID)
        {
            connection.Open();
            string sqlSorgu;
            sqlSorgu = "SELECT ilanTablo.ID, aracGorsel, ilanBaslik, aracFiyat, aracKm, (marka_isim + ' ' + model_isim) as aracMarkaModel, aracYil FROM ilanTablo INNER JOIN markaTablo ON ilanTablo.aracMarka = markaTablo.marka_isim INNER JOIN modelTablo ON ilanTablo.aracModel = modelTablo.model_isim WHERE musteriID = @musteriID AND (ilanBaslik LIKE '%'+@searchText+'%' OR ilanAciklama LIKE '%'+@searchText+'%');";
            command = new SqlCommand(sqlSorgu, connection);
            command.Parameters.AddWithValue("@searchText", searchText);
            command.Parameters.AddWithValue("@musteriID", musteriID);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        public SqlDataAdapter marka_listele()
        {
            connection.Open();
            string sqlSorgu;
            sqlSorgu = "SELECT ID, marka_isim FROM markaTablo;";
            command = new SqlCommand(sqlSorgu, connection);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        public SqlDataAdapter model_listele()
        {
            connection.Open();
            string sqlSorgu;
            sqlSorgu = "SELECT modelTablo.ID, marka_isim, model_isim FROM modelTablo INNER JOIN markaTablo ON markaTablo.ID = modelTablo.markaID;";
            command = new SqlCommand(sqlSorgu, connection);
            adapter = new SqlDataAdapter(command);
            return adapter;
        }
        
    }
}