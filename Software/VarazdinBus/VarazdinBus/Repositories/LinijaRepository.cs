﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VarazdinBus.Models;
using DBLayer;
using System.Windows.Forms;

namespace VarazdinBus.Repositories
{
    public class LinijaRepository
    {
        public static Linija GetLinijaByName(string nazivLinije)
        {
            string sql = $"SELECT * FROM dbo.Linija WHERE nazivLinije = '{nazivLinije}'";
            return FetchLinija(sql);
        }


        private static Linija FetchLinija(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Linija linija = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                linija = CreateLinija(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return linija;
        }

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
        public static void DodajNovuLiniju(string nazivLinije, int pocetnaStanicaID, int zavrsnaStanicaID, TimeSpan vrijemePolaska, TimeSpan vrijemeDolaska, int vozaciId)
        {
            string sql = $"INSERT INTO dbo.Linija (nazivLinije, pocetnaStanicaID, zavrsnaStanicaID, vrijemePolaska, vrijemeDolaska, vozaci_id) " +
             $"VALUES ('{nazivLinije}', {pocetnaStanicaID}, {zavrsnaStanicaID}, '{vrijemePolaska}', " +
             $"'{vrijemeDolaska}', {vozaciId})";

            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                MessageBox.Show("Unesna je nova linija", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show($"Greška kod unosa podataka: {ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteTable(string id)
        {
            string sql = $"DELETE FROM dbo.Linija WHERE id_linije='{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static List<Linija> GetLinijeSearch(string nazivLinije)
        {
            List<Linija> linije = new List<Linija>();

            string sql = $"SELECT * FROM dbo.Linija WHERE nazivLinije LIKE '%{nazivLinije}%'";
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
        public static void IzmjeniLiniju(int idLinije, string nazivLinije, int pocetnaStanicaID, int zavrsnaStanicaID, TimeSpan vrijemePolaska, TimeSpan vrijemeDolaska, int vozaciId)
        {
            string sql = $"UPDATE dbo.Linija SET nazivLinije = '{nazivLinije}', pocetnaStanicaID = {pocetnaStanicaID}, zavrsnaStanicaID = {zavrsnaStanicaID}, " +
                         $"vrijemePolaska = '{vrijemePolaska}', vrijemeDolaska = '{vrijemeDolaska}', vozaci_id = {vozaciId} WHERE id_linije = {idLinije}";

            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            } catch (Exception ex)
            {
                MessageBox.Show($"Greška kod ažuriranja linije: {ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
