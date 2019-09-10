using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDodatek.Model
{
    public class GitCommit
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
    }
}
