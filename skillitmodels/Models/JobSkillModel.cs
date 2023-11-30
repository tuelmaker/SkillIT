using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillIT.Models
{
    public class JobModel
    {

        [JsonProperty(Required = Required.Always)]
        public string JobTitle { get; set; } = string.Empty;
        
        [JsonProperty(Required = Required.Always)]
        public string CompanyName { get; set; } = string.Empty;
        
        [JsonProperty(Required = Required.Always)]
        public string JobId { get; set; } = string.Empty;

        public string JobUrl { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string PostStatus { get; set; } = string.Empty;
        public string PostedDaysAgo { get; set; } = string.Empty;
        public int ApplicantCount { get; set; } = -1;

        [JsonProperty(Required = Required.Always)]
        public List<string> MatchingSkills { get; set; } = new List<string>();

        /// <summary>
        /// We are not making this required since there may be no missing skills listed
        /// </summary>
        public List<string> MissingSkills { get; set; } = new List<string>();

        [JsonProperty(Required = Required.Always)]
        public List<string> ApplicantSkills { get; set; } = new List<string>();
       
    }

    public class JobSkillModel : JobModel
    {
        [JsonProperty(Required = Required.Always)]
        public string SkillCategory { get; set; } = string.Empty;

        [JsonProperty(Required = Required.Always)]
        public string SkillName { get; set; } = string.Empty;
        
    }
}
