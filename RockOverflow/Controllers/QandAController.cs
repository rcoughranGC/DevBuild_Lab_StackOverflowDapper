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

            return View();
        }
        public IActionResult Detail(int questId)
        {
            QuestionAnswers questionWithAnswers = DAL.GetAnswersToQuestion(questId);
            return View(questionWithAnswers);
        }
    }
}
