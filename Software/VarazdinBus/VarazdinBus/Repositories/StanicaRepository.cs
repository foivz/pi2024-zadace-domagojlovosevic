using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VarazdinBus.Models;
using DBLayer;

namespace VarazdinBus.Repositories
{
    public class StanicaRepository
    {
        public static List<Stanica> GetStanice()
        {
            var stanice = new List<Stanica>();

            string sql = "SELECT * FROM dbo.Stanica";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Stanica stanica = CreateStanica(reader);
                stanice.Add(stanica);
            }
            reader.Close();
            DB.CloseConnection();

            return stanice;
        }

        private static Stanica CreateStanica(SqlDataReader reader)
        {
            int id_stanice = Convert.ToInt32(reader["id_stanice"]);
            string nazivStanice = Convert.ToString(reader["nazivStanice"]);
            string lokacijaStanice = Convert.ToString(reader["lokacijaStanice"]);

            return new Stanica
            {
                id_stanice = id_stanice,
                nazivStanice = nazivStanice,
                lokacijaStanice = lokacijaStanice
            };
        }
    }
}
