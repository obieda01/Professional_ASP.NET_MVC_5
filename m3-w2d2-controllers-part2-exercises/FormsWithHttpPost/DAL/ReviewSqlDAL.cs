using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private string connectionString = @"Data Source=DESKTOP-U3MOBAH\ss;Initial Catalog=Squirrel;Integrated Security=True";
        private string selectAllCommand = @"SELECT * FROM reviews";

        private const string insertSqlReview =
            "INSERT INTO [dbo].[reviews] ([username],[rating],[review_title],[review_text])VALUES(@username,@rating,@review_title,@review_text)";

        public string ConnectionString
        {
            get { return connectionString; }
        }
        public string SelectAllCommand
        {
            get { return selectAllCommand; }
            set { selectAllCommand = value; }
        }

        public List<Review> GetAllReviews()
        {
            List<Review> allReviews = new List<Review>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(SelectAllCommand, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Review localReview = new Review();
                        localReview.Username = Convert.ToString(reader["username"]);
                        localReview.Rating = Convert.ToUInt16(reader["rating"]);
                        localReview.Message = Convert.ToString(reader["review_text"]);
                        localReview.Title = Convert.ToString(reader["review_title"]);
                        localReview.ReviewDate = Convert.ToDateTime(reader["review_date"]);
                        allReviews.Add(localReview);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return allReviews;
        }

        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(insertSqlReview, conn);
                    command.Parameters.AddWithValue("@username", newReview.Username);
                    command.Parameters.AddWithValue("@rating", newReview.Rating);
                    command.Parameters.AddWithValue("@review_title", newReview.Title);
                    command.Parameters.AddWithValue("@review_text", newReview.Message);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}