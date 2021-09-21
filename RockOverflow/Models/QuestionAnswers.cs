using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockOverflow.Models
{
    public class QuestionAnswers
    {
        public Questions ques { get; set; }
        public List<Answers> quesAnswers { get; set; }
    }
}
