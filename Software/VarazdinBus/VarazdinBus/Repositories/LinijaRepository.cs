using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VarazdinBus.Models;
using DBLayer;

namespace VarazdinBus.Repositories
{
    public class LinijaRepository
    {

        public static List<Linija> GetLinije()
        {
            List<Linija> linije = new List<Linija>();

            string sql = "SELECT * FROM dbo.Linija";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Linija linija = CreateLinija(reader);
                linije.Add(linija);
            }
            reader.Close();
            DB.CloseConnection();
            return linije;
        }

        private static Linija CreateLinija(SqlDataReader reader)
        {
            int idLinije = int.Parse(reader["id_linije"].ToString());
            string nazivLinije = reader["nazivLinije"].ToString();
            int pocetnaStanicaID = int.Parse(reader["pocetnaStanicaID"].ToString());
            int zavrsnaStanicaID = int.Parse(reader["zavrsnaStanicaID"].ToString());
            DateTime vrijemePolaska = DateTime.Parse(reader["vrijemePolaska"].ToString());
            DateTime vrijemeDolaska = DateTime.Parse(reader["vrijemeDolaska"].ToString());
            int vozaciId = int.Parse(reader["vozaci_id"].ToString());


            string pocetnaStanica = StanicaRepository.GetStanicaIme(pocetnaStanicaID);
            string zavrsnaStanica = StanicaRepository.GetStanicaIme(zavrsnaStanicaID);


            string vozaci = VozacRepository.GetVozacUsername(vozaciId);

            return new Linija
            {
                IdLinije = idLinije,
                NazivLinije = nazivLinije,
                PocetnaStanica = pocetnaStanica,
                ZavrsnaStanica = zavrsnaStanica,
                VrijemePolaska = vrijemePolaska,
                VrijemeDolaska = vrijemeDolaska,
                vozaci = vozaci
            };
        }

    }
}
