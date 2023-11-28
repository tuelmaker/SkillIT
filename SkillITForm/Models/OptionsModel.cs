using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillIT.Models
{
    public class OptionsModel
    {
        public int LoginWait { get; set; }  = 25000;
        public int PageLoadWait { get; set; } = 1000;
        public int JobNavigationWait { get; set; } = 100;
        public BrowserOptionEnum BrowserSelected { get; set; }  = BrowserOptionEnum.Chrome;
    }
}
