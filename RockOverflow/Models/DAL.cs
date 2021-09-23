using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using RockOverflow.Models;

namespace RockOverflow.Models
{
    public class DAL
    {
        public static string CurrentUser = null;
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=rockoverflow;Uid=root;Password=abc123");

        // Get all questions
        public static List<Questions> GetAllQuestions()
        {
            return DB.GetAll<Questions>().ToList();
        }
        // Search 
        public static List<Questions> Search(string query)
        {
            
            var keyValPair = new { search = $"%{query}%" };
            string sql = "select * from questions where title like @search";
            List<Questions> results = DB.Query<Questions>(sql, keyValPair).ToList();
            //List<QuestionAnswers> pairedResults = new List<QuestionAnswers>();

            // Was thinking to add the answers with the search results but can't 
            // thnk of how exactly.
            // Instead I will work this into the Detail View.

            //foreach (Questions question in results)
            //{
            //    pairedResults.Add(question);
            //}

            return results;
        }
            

        //Get one Question
        public static Questions GetQuestion(int id)
        {
            return DB.Get<Questions>(id);
        }

        //Get Answers to a Question
        public static QuestionAnswers GetAnswersToQuestion(int questionId)
        {
            var keyValue = new { quesId = questionId };
            string sql = "select * from answers where questionId = @quesId";
            QuestionAnswers qAns = new QuestionAnswers();
            qAns.ques = DAL.GetQuestion(questionId);
            qAns.quesAnswers =DB.Query<Answers>(sql, keyValue).ToList();

            return qAns;
        }

        // Add a question
        public static void InsertQuestion(Questions newQ)
        {
            //newQ.username = DAL.CurrentUser;
            DB.Insert(newQ);

        }
        public static void InsertAnswer(Answers newAns)
        {
            DB.Insert(newAns);
        }


    }
}
