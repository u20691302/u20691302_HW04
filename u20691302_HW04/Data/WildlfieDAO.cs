using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using u20691302_HW04.Models;

namespace u20691302_HW04.Data
{
    internal class wildlifeDAO
    {
        //connection string
        private string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=u20691302_HW04;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\WildLifeDatabase.mdf";

        //fetch and read database into table
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
                        //create new marine animal object and add it to the list to return.
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

        //display one record
        public MarineAnimals FetchOne(int id)
        {
            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.MarineAnimals WHERE Id = @id";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //create new marine animal object and add it to the list to return.
                MarineAnimals marineAnimals = new MarineAnimals();

                //Checks if the reader has rows then we can loop through the list and populate table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    { 
                        marineAnimals.ID = reader.GetInt32(0);
                        marineAnimals.ScientificName = reader.GetString(1);
                        marineAnimals.Habitat = reader.GetString(2);
                        marineAnimals.Population = reader.GetInt32(3);
                        marineAnimals.Status = reader.GetString(4);
                    }
                }
                return marineAnimals;
            } 
        }

        //create or update an item
        public int CreateOrUpdate(MarineAnimals marineAnimals)
        {
            //if marineAnimal.id <= 1 then create

            //if marineAnimal.id > 1 then update
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "";

                if (marineAnimals.ID <= 0)
                {
                    sqlQuery = "INSERT INTO dbo.MarineAnimals Values(@ScientificName, @Habitat, @Population, @Status)";
                }
                else
                {
                    sqlQuery = "UPDATE dbo.MarineAnimals SET ScientificName = @ScientificName, Habitat = @Habitat, Population = @Population, Status = @Status WHERE Id = @Id";
                }
                
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 1000).Value = marineAnimals.ID;
                command.Parameters.Add("@ScientificName", System.Data.SqlDbType.VarChar, 50).Value = marineAnimals.ScientificName;
                command.Parameters.Add("@Habitat", System.Data.SqlDbType.VarChar, 1000).Value = marineAnimals.Habitat;
                command.Parameters.Add("@Population", System.Data.SqlDbType.Int, 50).Value = marineAnimals.Population;
                command.Parameters.Add("@Status", System.Data.SqlDbType.VarChar, 50).Value = marineAnimals.getStatus();


                connection.Open();

                int newID = command.ExecuteNonQuery();

                return newID;
            }
        }

        internal int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM dbo.MarineAnimals WHERE Id = @Id";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 1000).Value = id;
  
                connection.Open();

                int deletedID = command.ExecuteNonQuery();

                return deletedID;
            }
        }
    }
}
