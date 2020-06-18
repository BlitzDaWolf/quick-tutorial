using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface IEigthBall
    {
        [OperationContract]
        string AskQuestion(string question);

        [OperationContract]
        void AddAnswer(string answer);
    }
}
