using System.Collections.Generic;
using System.Data.SqlClient;
using u20691302_HW04.Models;

namespace u20691302_HW04.Data
{
    internal class wildlifeDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WildLifeDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<MarineAnimals> FetchAll()
        {
            List<MarineAnimals> returnList = new List<MarineAnimals>();

            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.MarineAnimals";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //Checks if the reader has rows then we can loop through the list and populate table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create new wildlife and addd it to the list to return.
                        MarineAnimals marineAnimals = new MarineAnimals();

                        marineAnimals.ID = reader.GetInt32(0);
                        marineAnimals.ScientificName = reader.GetString(1);
                        marineAnimals.Habitat = reader.GetString(2);
                        marineAnimals.Population = reader.GetInt32(3);
                        marineAnimals.Status = reader.GetString(4);

                        returnList.Add(marineAnimals);
                    }
                }
            }
            return returnList;
        }
    }
}