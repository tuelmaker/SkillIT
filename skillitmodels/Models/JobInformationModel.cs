using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillit.Models
{
    public class JobInformationModel
    {
        public string JobTitle { get; set; } = string.Empty;        
        public string CompanyName { get; set; } = string.Empty;
        public string JobId { get; set; }   = string.Empty;
        public string JobUrl { get; set; }= string.Empty;
        public string Location { get; set; }    = string.Empty;
        public string PostStatus { get; set; }= string.Empty;
        public string PostedDaysAgo { get; set; }= string.Empty;
        public string ApplicantCount { get; set; } = string.Empty;  
        public List<string> MatchingSkills { get; set; } = new List<string>();
        public List<string> MissingSkills { get; set; } =   new List<string>();
        public List<string> ApplicantSkills { get; set; } = new List<string>();
    }
}
