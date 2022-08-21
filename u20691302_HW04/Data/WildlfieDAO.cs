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



        //fetch and read database into table MarineAnimals
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

        //fetch and read database into table BigCats
        public List<BigCats> FetchAllCats()
        {
            List<BigCats> returnList = new List<BigCats>();

            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.BigCats";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //Checks if the reader has rows then we can loop through the list and populate table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create new marine animal object and add it to the list to return.
                        BigCats bigCats = new BigCats();

                        bigCats.ID = reader.GetInt32(0);
                        bigCats.ScientificName = reader.GetString(1);
                        bigCats.Habitat = reader.GetString(2);
                        bigCats.Population = reader.GetInt32(3);
                        bigCats.Status = reader.GetString(4);

                        returnList.Add(bigCats);
                    }
                }
            }
            return returnList;
        }

        //fetch and read database into table Primates
        public List<Primates> FetchAllPrimates()
        {
            List<Primates> returnList = new List<Primates>();

            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Primates";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //Checks if the reader has rows then we can loop through the list and populate table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create new marine animal object and add it to the list to return.
                        Primates primates = new Primates();

                        primates.ID = reader.GetInt32(0);
                        primates.ScientificName = reader.GetString(1);
                        primates.Habitat = reader.GetString(2);
                        primates.Population = reader.GetInt32(3);
                        primates.Status = reader.GetString(4);

                        returnList.Add(primates);
                    }
                }
            }
            return returnList;
        }



        //display one record Marine animals
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

        //display one record BigCats
        public BigCats FetchOneBigCats(int id)
        {
            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.BigCats WHERE Id = @id";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //create new big cat object and add it to the list to return.
                BigCats bigCats = new BigCats();

                //Checks if the reader has rows then we can loop through the list and populate table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bigCats.ID = reader.GetInt32(0);
                        bigCats.ScientificName = reader.GetString(1);
                        bigCats.Habitat = reader.GetString(2);
                        bigCats.Population = reader.GetInt32(3);
                        bigCats.Status = reader.GetString(4);
                    }
                }
                return bigCats;
            }
        }

        //display one record Primates
        public Primates FetchOnePrimates(int id)
        {
            //access database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Primates WHERE Id = @id";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //create new big cat object and add it to the list to return.
                Primates primates = new Primates();

                //Checks if the reader has rows then we can loop through the list and populate table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        primates.ID = reader.GetInt32(0);
                        primates.ScientificName = reader.GetString(1);
                        primates.Habitat = reader.GetString(2);
                        primates.Population = reader.GetInt32(3);
                        primates.Status = reader.GetString(4);
                    }
                }
                return primates;
            }
        }



        //create or update an item marine animals
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

        //create or update an item big cats
        public int CreateOrUpdateBigCats(BigCats bigCats)
        {
            //if bigCat.id <= 1 then create

            //if bigCat.id > 1 then update
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "";

                if (bigCats.ID <= 0)
                {
                    sqlQuery = "INSERT INTO dbo.BigCats Values(@ScientificName, @Habitat, @Population, @Status)";
                }
                else
                {
                    sqlQuery = "UPDATE dbo.BigCats SET ScientificName = @ScientificName, Habitat = @Habitat, Population = @Population, Status = @Status WHERE Id = @Id";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 1000).Value = bigCats.ID;
                command.Parameters.Add("@ScientificName", System.Data.SqlDbType.VarChar, 50).Value = bigCats.ScientificName;
                command.Parameters.Add("@Habitat", System.Data.SqlDbType.VarChar, 1000).Value = bigCats.Habitat;
                command.Parameters.Add("@Population", System.Data.SqlDbType.Int, 50).Value = bigCats.Population;
                command.Parameters.Add("@Status", System.Data.SqlDbType.VarChar, 50).Value = bigCats.getStatus();


                connection.Open();

                int newID = command.ExecuteNonQuery();

                return newID;
            }
        }

        //create or update an item primates
        public int CreateOrUpdatePrimates(Primates primates)
        {
            //if primates.id <= 1 then create

            //if primates.id > 1 then update
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "";

                if (primates .ID <= 0)
                {
                    sqlQuery = "INSERT INTO dbo.Primates Values(@ScientificName, @Habitat, @Population, @Status)";
                }
                else
                {
                    sqlQuery = "UPDATE dbo.Primates SET ScientificName = @ScientificName, Habitat = @Habitat, Population = @Population, Status = @Status WHERE Id = @Id";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 1000).Value = primates.ID;
                command.Parameters.Add("@ScientificName", System.Data.SqlDbType.VarChar, 50).Value = primates.ScientificName;
                command.Parameters.Add("@Habitat", System.Data.SqlDbType.VarChar, 1000).Value = primates.Habitat;
                command.Parameters.Add("@Population", System.Data.SqlDbType.Int, 50).Value = primates.Population;
                command.Parameters.Add("@Status", System.Data.SqlDbType.VarChar, 50).Value = primates.getStatus();


                connection.Open();

                int newID = command.ExecuteNonQuery();

                return newID;
            }
        }



        //delete marine animals
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

        //delete big cats
        internal int DeleteBigCats(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM dbo.BigCats WHERE Id = @Id";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 1000).Value = id;

                connection.Open();

                int deletedID = command.ExecuteNonQuery();

                return deletedID;
            }
        }

        //delete primates
        internal int DeletePrimates(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM dbo.Primates WHERE Id = @Id";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int, 1000).Value = id;

                connection.Open();

                int deletedID = command.ExecuteNonQuery();

                return deletedID;
            }
        }

    }
}
