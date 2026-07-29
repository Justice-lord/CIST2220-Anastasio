using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace P8Anastasio
{
    public class DBManager
    {
        private string connStr = ConfigurationManager.ConnectionStrings["CardDB"].ConnectionString;
        public void GetCards(BindingList<Card> cards)
        {
            cards.Clear();

            string selectStr = "SELECT * FROM Card";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(selectStr, conn))
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Card card = new Card();

                    card.CardID = reader.GetInt32(0);
                    card.Title = reader.GetString(1);
                    card.Question = reader.GetString(2);
                    card.Answer = reader.GetString(3);
                    card.NumRight = reader.GetInt32(4);
                    card.NumWrong = reader.GetInt32(5);

                    cards.Add(card);
                }
            }
        }

        public void AddCard(Card card)
        {
            string insertStr = "INSERT INTO Card (Title, Question, Answer, NumRight, NumWrong) VALUES (@Title, @Question, @Answer, @NumRight, @NumWrong);";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(insertStr, conn))
            {
                cmd.Parameters.AddWithValue("@Title", card.Title);
                cmd.Parameters.AddWithValue("@Question", card.Question);
                cmd.Parameters.AddWithValue("@Answer", card.Answer);
                cmd.Parameters.AddWithValue("@NumRight", card.NumRight);
                cmd.Parameters.AddWithValue("@NumWrong", card.NumWrong);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveCard(Card card)
        {
            string deleteStr = "DELETE FROM Card WHERE CardID = @CardID;";

            using (SqlConnection conn =new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(deleteStr, conn))
            {
                cmd.Parameters.AddWithValue("@CardID", card.CardID);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCard(Card card)
        {
            string updateStr = "UPDATE Card SET Title = @Title, Question = @Question, Answer = @Answer, NumRight = @NumRight, NumWrong = @NumWrong WHERE CardID = @CardID;";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(updateStr, conn))
            {
                cmd.Parameters.AddWithValue("@Title", card.Title);
                cmd.Parameters.AddWithValue("@Question", card.Question);
                cmd.Parameters.AddWithValue("@Answer", card.Answer);
                cmd.Parameters.AddWithValue("@NumRight", card.NumRight);
                cmd.Parameters.AddWithValue("@NumWrong", card.NumWrong);
                cmd.Parameters.AddWithValue("@CardID", card.CardID);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
