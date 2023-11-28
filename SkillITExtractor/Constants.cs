using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillITForm
{
    internal class Constants
    {
        public const int JOB_INCREMENT_NUMBER = 25;
        public const string JOB_LINK_CLASS_NAME = ".disabled.ember-view.job-card-container__link.job-card-list__title";
        public const string ROOT_JOB_DETAIL_CONTAINER_CLASS_NAME = ".job-view-layout.jobs-details";
        public const string JOBS_FOUND_COUNT_CLASS_NAME = "jobs-search-results-list__subtitle";
        public const string JOB_DETAIL_PANEL_CLASS_NAME = ".display-flex.justify-space-between.flex-wrap";
        public const string JOB_TITLE_CLASS_NAME = ".t-24.t-bold.job-details-jobs-unified-top-card__job-title";
        public const string JOB_DETAIL_LOGISTICS_CLASS_NAME = "job-details-jobs-unified-top-card__primary-description";
        public const string JOB_SKILLS_SECTION_CLASS_NAME = ".app-aware-link.job-details-how-you-match__skills-item-subtitle.t-14.overflow-hidden";
        
        public const string JOB_DETAIL_SPLIT_CHAR = "·";
        public const string JOB_SKILLS_SPLIT_STRING_COMMA = ",";
        public const string JOB_SKILLS_SPLIT_STRING_AND_WITH_BUFFERS = " and ";
        public const string JOB_DETAIL_SPLIT_DOUBLE_SPACE = "  ";

        public const int JOB_DETAIL_SEGMENT_COUNT = 3;
        public const int JOB_DETAIL_SEGMENT_APPLICANT_INDEX = 2;


        public const string JOB_POSTING_STATUS_REPOSTED = "Reposted";
        public const string JOB_POSTING_STATUS_NEW = "New";



        #region Login Constants
        public const string LOGIN_BUTTON_CLASS_NAME = ".nav__button-secondary.btn-md.btn-secondary-emphasis";
        public const string USERNAME_TEXTBOX_ID = "username";
        public const string PASSWORD_TEXTBOX_ID = "password";
        public const string LOGIN_SUBMIT_BUTTON_CLASS_NAME = ".btn__primary--large.from__button--floating";
        public const string LOGIN_STATUS_EVALUATION_CLASS_NAME = ".global-nav__me.artdeco-dropdown.artdeco-dropdown--placement-bottom.artdeco-dropdown--justification-left.ember-view";
        #endregion


        #region General
        public const string ANCHOR_TAG = "a";
        public const string SPAN_TAG = "span";
        public const string HREF_ATTRIBUTE = "href";
        #endregion

        #region Resource Lookup Constants
        public const string DUMP_ERROR_RESOURCE_DESCRIPTION_LOOKUP_NAME = "Dump_Error_Description";
        public const string DUMP_ERROR_RESOURCE_TITLE_LOOKUP_NAME = "Dump_Error_Title";
        public const string APPLICANT_COUNT_MISSING_LOOKUP_NAME = "Applicant_Count_Missing";
        public const string LOGIN_FAILURE_LOOKUP_NAME = "Login_Failure";
        public const string NO_JOBS_FOUND_LOOKUP_NAME = "No_Jobs_Found_Search_Response";
        public const string NOTHING_TO_SAVE_LOOKUP_NAME = "Save_Extract_Missing";
        #endregion

        public const string COMMA = ",";
        public const string SINGLESPACE = " ";


        public const string ERROR_TITLE = "Error";

        public const string ISOLATED_STORAGE_FILE_JSON = "SkillIT_OPTIONS.json";

        public const string BASE_JOB_SEARCH_URL = "https://www.linkedin.com/jobs/search/?currentJobId=";

        public const int DEFAULT_ZOOM_LEVEL = 100;
        public const int MAGNIFIED_ZOOM_LEVEL = 25;

    }
}
