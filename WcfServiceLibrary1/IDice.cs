using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface IDice
    {
        [OperationContract]
        SpecialDice rollDice(int faces);

        [OperationContract]
        List<SpecialDice> LastRoles();

        [OperationContract]
        void Clear();

        [OperationContract]
        List<SpecialDice> GetNatuerls();

        [OperationContract]
        List<SpecialDice> DiceFaces(int faces);
    }

    [DataContract]
    public class SpecialDice
    {
        [DataMember]
        public int Faces { get; private set; } = 6;
        [DataMember]
        public int Rolled { get; private set; }

        public int modifier { get; private set; }

        [DataMember]
        public string roll
        {
            get => (Rolled == Faces) ? $"Natuarel {Faces}" : (Rolled + modifier).ToString();
            set { }
        }

        private Random rnd;

        public SpecialDice(int faces)
        {
            this.Faces = faces;
            rnd = new Random();
        }

        public void Roll()
        {
            Rolled = rnd.Next(Faces) + 1;
        }
    }
}
