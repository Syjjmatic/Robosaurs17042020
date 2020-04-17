using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Fleet
    {
        public List<Robot> fleet;

        public Fleet()
        {
            fleet = new List<Robot> { new Robot(), new Robot(), new Robot() };
        }
    }
}
