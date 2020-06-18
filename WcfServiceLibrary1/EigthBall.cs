using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EigthBall : IEigthBall
    {
        string[] answers = { "Yes", "No", "Maybe", "Hell no", "Do it", "Eh", "I am not sure"};
        Random rnd;

        public EigthBall()
        {
            rnd = new Random();
        }

        public void AddAnswer(string answer)
        {
            var c = answers.ToList();
            c.Add(answer);
            answers = c.ToArray();
        }

        public string AskQuestion(string question)
        {
            int choose = rnd.Next(0, answers.Length);
            return answers[choose];
        }
    }
}
