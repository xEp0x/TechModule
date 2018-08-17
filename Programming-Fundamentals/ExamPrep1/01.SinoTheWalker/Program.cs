using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            // ZADACHATA SE PREPORACHWA DA SE RESHI S CHISTA MATEMATIKA!!!!! BEZ IZPOLZWANE NA DateTime


            //parswane na whodnite danni kym wreme wyw format HH:mm:ss
            DateTime leaveTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            //wzimane na krachkite i wremto za edna krachka wyw long tip za da nqma prepylwane
            long stepsToHome = long.Parse(Console.ReadLine());
            long timeForStepInSeconds = long.Parse(Console.ReadLine());

            //izchiliawane na wremto za pribirane w sekundi
            long timeToHomeInSeconds = stepsToHome * timeForStepInSeconds;

            var leaveHours = leaveTime.Hour;
            var leaveMinutes = leaveTime.Minute;
            var leaveSeconds = leaveTime.Second;

            //w sledwashtite 6 reda se izchisliawa wremeto za pristigane. Ne moge da se polzwa TimeSpan poradi prepylwane na TimeSpan-a
            var hoursWalk = timeToHomeInSeconds / 3600;
            var minutesWalk = (timeToHomeInSeconds - hoursWalk * 3600) / 60;
            var secondsWalk = (timeToHomeInSeconds - hoursWalk * 3600) % 60;
            
            var sumSec = (leaveSeconds + secondsWalk) % 60;
            var sumMin = (leaveMinutes + minutesWalk + (leaveSeconds + secondsWalk) / 60) % 60;
            var sumHour = (leaveHours + hoursWalk + (leaveMinutes + minutesWalk + (leaveSeconds + secondsWalk) / 60) / 60) % 24;

            //prewrashtane na wremeto za pribirane ot sekundi wyw wreme w chasowe, minuti i sekundi
            //var timeToWalk = TimeSpan.FromSeconds(timeToHomeInSeconds);

            //izchisliawane na wremeto na pristigane kato se dobawi kym wremeto na tragwane wremeto za hodene
            //var arrivalTime = leaveTime.Add(timeToWalk);

            //Prewrashtane na wremeto na pristigane wyw string podhodiasht za pechatane wyw format HH:mm:ss
            //var arrivalTimeStr = string.Format($"Time Arrival: {arrivalTime.Hour:D2}:{arrivalTime.Minute:D2}:{arrivalTime.Second:D2}");

            var arrivalTimeStr = string.Format($"Time Arrival: {sumHour:D2}:{sumMin:D2}:{sumSec:D2}");
            Console.WriteLine(arrivalTimeStr);
        }
    }
}
