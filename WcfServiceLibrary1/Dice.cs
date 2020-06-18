using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Dice : IDice
    {
        List<SpecialDice> rolls = new List<SpecialDice>();

        public Dice()
        {

        }

        public void Clear()
        {
            rolls = new List<SpecialDice>();
        }

        public List<SpecialDice> DiceFaces(int faces)
        {
            return rolls.Where(x => x.Faces == faces).ToList();
        }

        public List<SpecialDice> GetNatuerls()
        {
            return rolls.Where(x => x.Rolled == x.Faces).ToList();
        }

        public List<SpecialDice> LastRoles()
        {
            return rolls;
        }

        public SpecialDice rollDice()
        {
            SpecialDice d = new SpecialDice(6);
            d.Roll();
            return d;
        }

        public SpecialDice rollDice(int faces)
        {
            SpecialDice d = new SpecialDice(faces);
            d.Roll();
            rolls.Add(d);
            return d;
        }
    }
}
