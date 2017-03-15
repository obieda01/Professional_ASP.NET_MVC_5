using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechElevator.Web.Models
{
    public class FavoriteQuestions
    {
        private string question;

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        private string answer;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        private List<string> answers;

        public List<string> Answers
        {
            get { return answers; }
        }

        public void Summary()
        {
        }

    }
}