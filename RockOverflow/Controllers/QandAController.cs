using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockOverflow.Models;

namespace RockOverflow.Controllers
{
    public class QandAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string query)
        {
            List<Questions> results = DAL.Search(query);
            return View(results);
        }
        
        public IActionResult AddQuestion()
        {
            ViewData["user"] = DAL.CurrentUser;
            return View();
        }
        public IActionResult InsertQuestion(Questions newQ)
        {
            newQ.posted = DateTime.Now;
            DAL.InsertQuestion(newQ);
            return Redirect($"/QandA/Detail?questId={newQ.id}");
            //return Redirect($"/");
        }

        public IActionResult InsertAnswer(Answers newAns)
        {
            newAns.posted = DateTime.Now;
            DAL.InsertAnswer(newAns);
            return Redirect($"/QandA/Detail?questId={newAns.questionId}");
        }
        public IActionResult EditAnswer(int ansId)
        {
            Answers editAns = DAL.GetAnswerById(ansId);
            return View(editAns);
        }
        public IActionResult UpdateAnswer(Answers ans)
        {
            ans.posted = DateTime.Now;
            DAL.UpdateAnswer(ans);
            return Redirect($"/QandA/Detail?questId={ans.questionId}");
            //Detail(ans.questionId);
        }
        public IActionResult Detail(int questId)
        {
            ViewData["user"] = DAL.CurrentUser;
            QuestionAnswers questionWithAnswers = DAL.GetAnswersToQuestion(questId);
            return View(questionWithAnswers);
        }
    }
}
