using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurs;

        public Herd()
        {
            dinosaurs = new List<Dinosaur> { new Dinosaur(), new Dinosaur(), new Dinosaur() };
        }
    }
}
