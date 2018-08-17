using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    public class Jarvis
    {
        public long Energy { get; set; }

        public Head Head { get; set; }

        public Torso Torso { get; set; }

        public List<Arm> Arms { get; set; }

        public List<Leg> Legs { get; set; }
        
        public void AddHead(Head currentHead)
        {
            if (Head == null)
            {
                Head = currentHead;
            }

            if (currentHead.Energy < Head.Energy)
            {
                Head = currentHead;
            }
        }

        public void AddTorso(Torso currentTorso)
        {
            if (Torso == null)
            {
                Torso = currentTorso;
            }

            if (currentTorso.Energy < Torso.Energy)
            {
                Torso = currentTorso;
            }
        }

        public void AddArm(Arm currentArm)
        {
            if (Arms == null)
            {
                Arms = new List<Arm>();
            }

            if (Arms.Count < 2)
            {
                Arms.Add(currentArm);
            }
            else
            {
                for (int i = 0; i < Arms.Count; i++)
                {
                    if (currentArm.Energy < Arms[i].Energy)
                    {
                        Arms.RemoveAt(i);
                        Arms.Add(currentArm);
                    }
                }
            }
        }

        public void AddLeg(Leg currentLeg)
        {
            if (Legs == null)
            {
                Legs = new List<Leg>();
            }

            if (Legs.Count < 2)
            {
                Legs.Add(currentLeg);
            }
            else
            {
                for (int i = 0; i < Legs.Count; i++)
                {
                    if (currentLeg.Energy < Legs[i].Energy)
                    {
                        Legs.RemoveAt(i);
                        Legs.Add(currentLeg);
                    }
                }
            }
        }

        public override string ToString()
        {
            bool isPartsEnough = Head == null || Torso == null || Arms.Count < 2 || Legs.Count < 2;

            if (isPartsEnough)
            {
                return "We need more parts!";

            }

            long totalEnergy = Head.Energy + Torso.Energy 
                + Arms.Select(a => long.Parse(a.Energy.ToString())).Sum() 
                + Legs.Select(l => long.Parse(l.Energy.ToString())).Sum();

            if (totalEnergy > Energy)
            {
                return "We need more power!";
            }

            StringBuilder sb = new StringBuilder();

            sb.Append($"Jarvis:\n");
            sb.Append(Head.ToString());
            sb.Append(Torso.ToString());

            foreach (var arm in Arms.OrderBy(a => a.Energy))
            {
                sb.Append(arm.ToString());
            }

            foreach (var leg in Legs.OrderBy(l => l.Energy))
            {
                sb.Append(leg.ToString());
            }

            return sb.ToString();
        }
    }
}
