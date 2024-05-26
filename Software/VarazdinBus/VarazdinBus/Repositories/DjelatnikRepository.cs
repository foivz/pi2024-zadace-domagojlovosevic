using System;
using System.Data.SqlClient;
using DBLayer;
using VarazdinBus.Models;

namespace VarazdinBus.Repositories
{
    public class DjelatnikRepository
    {
        public static Djelatnik GetDjelatnik(string username)
        {
            string sql = $"SELECT * FROM dbo.Djelatnici WHERE Username = '{username}'";
            return FetchDjelatnik(sql);
        }

        private static Djelatnik FetchDjelatnik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Djelatnik djelatnik = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                djelatnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return djelatnik;
        }

        private static Djelatnik CreateObject(SqlDataReader reader)
        {
            int djelatnikId = int.Parse(reader["id_djelatnika"].ToString());
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            string imeDjelatnika = reader["ImeDjelatnika"].ToString();
            string prezimeDjelatnika = reader["PrezimeDjelatnika"].ToString();
            string radniStaz = reader["RadniStaz"].ToString();
            string datumRodjenja = reader["DatumRodjenja"].ToString();
            string datumPocetka = reader["DatumPocetka"].ToString();

            var djelatnik = new Djelatnik
            {
                djelatnikId = djelatnikId,
                username = username,
                password = password,
                imeDjelatnika = imeDjelatnika,
                prezimeDjelatnika = prezimeDjelatnika,
                radniStaz = radniStaz,
                datumRodjenja = datumRodjenja,
                datumPocetka = datumPocetka
            };

            return djelatnik;
        }
    }
}
