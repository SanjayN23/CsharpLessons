using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class MoviesRepositry
    {
        public static List<Movies> GetMovieDetailsList()
        {
            List<Movies> list = new List<Movies>();



            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand cmd = cn.CreateCommand();
                string SelectAllMovies = "SELECT * FROM movietbl";
                cmd.CommandText = SelectAllMovies;
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Movies movie = new Movies()
                    {
                        Id = sqlDataReader.GetInt32(0),
                        Title = sqlDataReader.GetString(1),
                        Language = sqlDataReader.GetString(2),
                        Hero = sqlDataReader.GetString(3),
                        Director = sqlDataReader.GetString(4),
                        MusicDirector = sqlDataReader.GetString(5),
                        ReleaseDate = sqlDataReader.GetDateTime(6),
                        Cost = sqlDataReader.GetDecimal(7),
                        Collection = sqlDataReader.GetDecimal(8),
                        Review = sqlDataReader.GetDecimal(9)
                    };
                    list.Add(movie);
                }
            }
            return list;
        }
        public static Movies FindMovieById(int id)
        {
            Movies movie = null;



            using (SqlConnection sn = SqlHelper.CreateConnection())
            {
                if (sn.State != ConnectionState.Open)
                {
                    sn.Open();
                }
                SqlCommand selectmovcmd = sn.CreateCommand();
                String selectEmps = "Select * from movietbl where ID=@id";
                selectmovcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmovcmd.CommandText = selectEmps;
                SqlDataReader sqlReader = selectmovcmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    movie = new Movies()
                    {
                        Id = sqlReader.GetInt32(0),
                        Title = sqlReader.GetString(1),
                        Language = sqlReader.GetString(2),
                        Hero = sqlReader.GetString(3),
                        Director = sqlReader.GetString(4),
                        MusicDirector = sqlReader.GetString(5),
                        ReleaseDate = sqlReader.GetDateTime(6),
                        Cost = sqlReader.GetDecimal(7),
                        Collection = sqlReader.GetDecimal(8),
                        Review = sqlReader.GetDecimal(9),
                    };
                }
            }
            return movie;
        }
        public static int AddNewMovieDetails(Movies movie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }



                SqlCommand insertMoviecmd = cn.CreateCommand();



                String insertNewMovQuery = "insert into movietbl values( @ID,@Title,@Language,@Hero,@Director,@MusicDirector,@ReleaseDate,@Cost,@Collection,@Review )";



                insertMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value = movie.Id;

                insertMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = movie.Title;

                insertMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = movie.Language;

                insertMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = movie.Hero;



                insertMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = movie.Director;



                insertMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = movie.MusicDirector;



                insertMoviecmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = movie.ReleaseDate;



                insertMoviecmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = movie.Cost;



                insertMoviecmd.Parameters.Add("@Collection", SqlDbType.Decimal).Value = movie.Collection;



                insertMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = movie.Review;



                insertMoviecmd.CommandText = insertNewMovQuery;



                query_result = insertMoviecmd.ExecuteNonQuery();



            }
            return query_result;
        }
        public static int UpdateMovieDetails(Movies movie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updatemoviecmd = cn.CreateCommand();
                String updateNewMovQuery = "Update movietbl set ID=@id,Title=@title,Language=@language,Hero=@hero,Director=@director,MusicDirector=@musicDirector,ReleaseDate=@releaseDate,Cost=@cost,Collection=@collection,Review=@review where ID=@id";
                updatemoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = movie.Id;



                updatemoviecmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = movie.Title;



                updatemoviecmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = movie.Language;



                updatemoviecmd.Parameters.Add("@hero", SqlDbType.NVarChar).Value = movie.Hero;



                updatemoviecmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = movie.Director;



                updatemoviecmd.Parameters.Add("@musicDirector", SqlDbType.NVarChar).Value = movie.MusicDirector;



                updatemoviecmd.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = movie.ReleaseDate;



                updatemoviecmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = movie.Cost;



                updatemoviecmd.Parameters.Add("@collection", SqlDbType.Decimal).Value = movie.Collection;



                updatemoviecmd.Parameters.Add("@review", SqlDbType.NVarChar).Value = movie.Review;



                updatemoviecmd.CommandText = updateNewMovQuery;



                query_result = updatemoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeleteMovieDetails(int id)
        {
            int query_Result = 0;
            using (SqlConnection sn = SqlHelper.CreateConnection())
            {
                if (sn.State != ConnectionState.Open)
                {
                    sn.Open();
                }
                SqlCommand DeleteCmd = sn.CreateCommand();
                string SqlDeleteQuery = "delete from movietbl where ID=@id";
                DeleteCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                DeleteCmd.CommandText = SqlDeleteQuery;
                query_Result = DeleteCmd.ExecuteNonQuery();
            }
            return query_Result;
        }
    }
}

