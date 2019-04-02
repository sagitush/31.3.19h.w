using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._3._19h.w
{
    class DAO
    {
        static public object GetCountryAndItsCapitalCityName(int countryId)
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = c:\\sagit\\31.3.19HW.db; Version=3;");

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT c.name , a.capiname from country c JOIN capitalCity a on c.id=a.country_id WHERE {countryId}=c.id ", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        Country c = new Country
                        {

                            Name = (string)reader["name"],

                        };


                        CapitalCity a = new CapitalCity
                        {
                            Name = (string)reader["capiname"]
                        };

                        var result = new { a, c };

                        return result;
                    }

                }
            }

            connection.Close();

            return null;
        }

        static public object GetCountryAndItsCapitalCityDetails(int countryId)
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = c:\\sagit\\31.3.19HW.db; Version=3;");

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT c.name ,a.capid, a.capiname,a.numCitizens from country c JOIN capitalCity a on c.id=a.country_id WHERE {countryId}=c.id ", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        Country c = new Country
                        {

                            Name = (string)reader["name"],

                        };


                        CapitalCity a = new CapitalCity
                        {
                            Id = (Int64)reader["capid"],
                            Name = (string)reader["capiname"],
                            NumCitizens = (int)reader["numCitizens"]
                        };

                        var result = new { a, c };

                        return result;
                    }

                }
            }

            connection.Close();

            return null;
        }
        static public object GetCountryAndItsCapitalCityName(string countryName)
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = c:\\sagit\\31.3.19HW.db; Version=3;");

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT c.name , a.capiname from country c JOIN capitalCity a on c.id=a.country_id WHERE '{countryName}'=c.name ", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        Country c = new Country
                        {

                            Name = (string)reader["name"],

                        };


                        CapitalCity a = new CapitalCity
                        {

                            Name = (string)reader["capiname"],

                        };

                        var result = new { a, c };

                        return result;
                    }

                }
            }

            connection.Close();

            return null;

        }
        static public object GetCountryAndItsCapitalCityDetails(string countryName)
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = c:\\sagit\\31.3.19HW.db; Version=3;");

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT c.name ,a.capid, a.capiname,a.numCitizens from country c JOIN capitalCity a on c.id=a.country_id WHERE '{countryName}'=c.name ", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        Country c = new Country
                        {

                            Name = (string)reader["name"],

                        };


                        CapitalCity a = new CapitalCity
                        {
                            Id = (Int64)reader["capid"],
                            Name = (string)reader["capiname"],
                            NumCitizens = (int)reader["numCitizens"]
                        };

                        var result = new { a, c };

                        return result;
                    }

                }
            }
            connection.Close();

            return null;
        }
        public static List<object> GetListOfCountriesAndItsCapitalCitys(string a)
        {
            List<object> result = new List<object>();
            SQLiteConnection connection = new SQLiteConnection($"Data Source = c:\\sagit\\31.3.19HW.db; Version=3;");

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT c.name ,a.capid, a.capiname,a.numCitizens from country c JOIN capitalCity a on c.id=a.country_id WHERE '{a}'<c.name ", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        Country c = new Country
                        {

                            Name = (string)reader["name"],

                        };


                        CapitalCity b = new CapitalCity
                        {
                            Id = (Int64)reader["capid"],
                            Name = (string)reader["capiname"],
                            NumCitizens = (int)reader["numCitizens"]
                        };

                        object r = new { b, c };
                        result = result.Add(r);

                        return result;
                    }

                }


            }

    }
}

