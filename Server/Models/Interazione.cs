using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Server.Models;
using System.Data;


namespace Server.Models
{
    class Interazione
    {
        private static readonly string connectionString = ConfigurationManager.AppSettings["connectionString"];
        private static MySqlConnection connessione = null;

        public static string ConnectionString => connectionString;
        public static MySqlConnection Connessione { get => connessione; set => connessione = value; }

        public static bool ReadingQuery(string q)
        {
            string cs = @"server=localhost;userid=root;password=;database=a_p_ticket";
            var con = new MySqlConnection(cs);

            con.Open();

            var cmd = new MySqlCommand(q, con);
            MySqlDataReader rdr;

            try
            {   
                cmd.CommandText = q;

                using (rdr = cmd.ExecuteReader())
                {
                    int cont = 0;

                    while (rdr.Read())
                        cont++;

                    if (cont != 0)
                        return true;

                    else
                        return false;
                }       
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERRORE!!! Metodo EseguiQuery_Lettura in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
            }

            return false;
        }
        
        public static DataTable GetEventi(string q)
        {
            string cs = @"server=localhost;userid=root;password=;database=a_p_ticket";
            var con = new MySqlConnection(cs);
            DataTable dt = new DataTable();
            con.Open();
            var cmd = new MySqlCommand(q, con);
            
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                DataRow[] righe = dt.Select();
                return dt;
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERRORE!!! Metodo getEventi in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
            }
            return null;
        }

        //metodo che esegue query che prendono informazioni da il db 
        public static string GetInfo(string q)
        {
            string cs = @"server=localhost;userid=root;password=;database=a_p_ticket";
            var con = new MySqlConnection(cs);

            con.Open();

            var cmd = new MySqlCommand(q, con);
            MySqlDataReader rdr;
            try
            {
                if (ReadingQuery(q))
                {
                    
                        cmd.CommandText = q;
                        string r = "";
                        using (rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                for (int i = 0; i < rdr.FieldCount; i++)
                                    r += rdr[i].ToString() + "-";

                                r += "\n";
                            }

                            return r;
                        }
                    
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Metodo EseguiQuery_Lettura in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
            }

            return null;
        }
        public static bool WritingQuery(string q)
        {
            string cs = @"server=localhost;userid=root;password=;database=a_p_ticket";
            var con = new MySqlConnection(cs);

            con.Open();

            var cmd = new MySqlCommand(q, con);
            MySqlDataReader rdr;
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read()) { }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE IN SCRITTURA DI UNA QUERY in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
                return false;
            }
        }

        public static int GetSingleIntFromDB(string q)
        {
            string cs = @"server=localhost;userid=root;password=;database=a_p_ticket";
            var con = new MySqlConnection(cs);

            con.Open();

            var cmd = new MySqlCommand(q, con);

            try
            {
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE NELLA LETTURA DI UN SINGOLO RISULTATO: " + ex.ToString());
                Console.ReadLine();
                return 0;
            }
        }
    }
}
