using Soneta.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: ProgramInitializer(typeof(GitDodatek.Inicjator))]


namespace GitDodatek
{
    class Inicjator : IProgramInitializer
    {
        void IProgramInitializer.Initialize()
        {

        }
    }
}
