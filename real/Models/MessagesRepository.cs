using real.Hubs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace real.Models
{
    public class MessagesRepository
    {
        readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public IEnumerable<Messages> GetAllMessages()
        {
            var messages = new List<Messages>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var command = new SqlCommand(@"SELECT [mobile]=(SUBSTRING([mobile], 1, 4)+'**'+SUBSTRING([mobile], 7, 2)), [ognoo] FROM [dbo].[sms_db] ORDER BY ID DESC", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        messages.Add(item: new Messages { Mobile= (string)reader["mobile"], Ognoo = Convert.ToDateTime(reader["ognoo"]) });
                    }
                }

            }
            return messages;


        }

        public IEnumerable<QuizAsuult> GetQuizAsuult(string _gval)
        {
            var quizAsuult = new List<QuizAsuult>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var command = new SqlCommand(String.Format(@"SELECT td.id,td.title FROM test_db td RIGHT JOIN ( SELECT dbo.splitstring2(tt.Name)as ad,dbo.splitstring3(tt.Name)as hd FROM dbo.splitstring( (SELECT se.config  FROM sms_exams AS se WHERE se.quidval='{0}' ) ) AS tt WHERE tt.Name LIKE  '%:%' )as dd ON dd.ad=td.id", _gval), connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        quizAsuult.Add(item: new QuizAsuult { Id = (int)reader["id"], Title = (string)reader["title"] });
                    }
                }

            }
            return quizAsuult;
        }

        public IEnumerable<QuizHariult> GetQuizHariult(int qid)
        {
            var quizHariult = new List<QuizHariult>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var command = new SqlCommand(String.Format(@"exec [sms_ExamGet_Choice] {0},{0} ", qid), connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        quizHariult.Add(item: new QuizHariult { Id = (int)reader["id"], Title = (string)reader["title"], Is_true = (int)reader["is_true"], Test_id = (int)reader["test_id"] });
                    }
                }

            }
            return quizHariult;
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.SendMessages();
            }
        }
    }
}