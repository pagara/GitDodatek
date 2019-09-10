using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDodatek.Abstract
{
    public interface IGitData
    {
        int GetCommits(string path);

    }
}
