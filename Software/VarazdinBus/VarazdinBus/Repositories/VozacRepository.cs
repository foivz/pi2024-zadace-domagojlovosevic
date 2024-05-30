using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using VarazdinBus.Models;

namespace VarazdinBus.Repositories
{
    public class VozacRepository
    {
        public static Vozac GetVozac(string username)
        {
            string sql = $"SELECT * FROM dbo.Vozaci WHERE Username ='{username}'";
            return FetchVozac(sql);
        }

        private static Vozac FetchVozac(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Vozac vozac = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                vozac = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vozac;
        }

        public static List<Vozac> GetAllVozaci()
        {
            List<Vozac> vozaci = new List<Vozac>();
            string sql = "SELECT * FROM dbo.Vozaci";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Vozac vozac = CreateObject(reader);
                    vozaci.Add(vozac);
                }
            }
            reader.Close();
            DB.CloseConnection();
            return vozaci;
        }



        private static Vozac CreateObject(SqlDataReader reader)
        {
            int vozacId = int.Parse(reader["vozac_id"].ToString());
            string username = reader["username"].ToString();
            string password = reader["password"].ToString();
            string imeVozaca = reader["ime_vozaca"].ToString();
            string prezimeVozaca = reader["prezime_vozaca"].ToString();
            string dozvola = reader["dozvola"].ToString();
            DateTime datumRodjenja = DateTime.Parse(reader["datum_rodjenja"].ToString());
            DateTime datumPocetka = DateTime.Parse(reader["datum_pocetka"].ToString());

            var vozac = new Vozac
            {
                vozacId = vozacId,
                username = username,
                password = password,
                imeVozaca = imeVozaca,
                prezimeVozaca = prezimeVozaca,
                dozvola = dozvola,
                datumRodjenja = datumRodjenja,
                datumPocetka = datumPocetka
            };

            return vozac;
        }
        public static string GetVozacUsername(int vozacId)
        {
            string sql = $"SELECT * FROM dbo.Vozaci WHERE vozac_id ='{vozacId}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Vozac vozac = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                vozac = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vozac.imeVozaca + " " + vozac.prezimeVozaca;
        }
        public static void CreateVozac(string imeVozaca, string prezimeVozaca, string username, string password, string dozvola, DateTime datumRodjenja, DateTime datumPocetka)
        {
            string sql = $"INSERT INTO dbo.vozaci (username, password, ime_vozaca, prezime_vozaca, dozvola, datum_rodjenja, datum_pocetka) " +
                $"VALUES ('{username}', '{password}', '{imeVozaca}', '{prezimeVozaca}', '{dozvola}', '{datumRodjenja.ToString("yyyy-MM-dd")}', '{datumPocetka.ToString("yyyy-MM-dd")}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
