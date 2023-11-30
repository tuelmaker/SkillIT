using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkillIT.Models;
using System;

namespace SkillITTest
{
    [TestClass]
    public class UnitTestModels
    {
        //Test that the JobSkillModel class from Models library has not changed
        [TestMethod]
        public void ValidateJobSkillModel()
        {
            JobSkillModel jobSkillModel = new JobSkillModel();
            jobSkillModel.JobTitle = "JobTitle";
            jobSkillModel.CompanyName = "CompanyName";
            jobSkillModel.JobId = "JobId";
            jobSkillModel.JobUrl = "JobUrl";
            jobSkillModel.Location = "Location";
            jobSkillModel.PostStatus = "PostStatus";
            jobSkillModel.PostedDaysAgo = "PostedDaysAgo";
            jobSkillModel.ApplicantCount = 1;
            jobSkillModel.MatchingSkills.Add("MatchingSkills");
            jobSkillModel.MissingSkills.Add("MissingSkills");
            jobSkillModel.ApplicantSkills.Add("ApplicantSkills");
            jobSkillModel.SkillCategory = "SkillCategory";
            jobSkillModel.SkillName = "SkillName";

            Assert.AreEqual("JobTitle", jobSkillModel.JobTitle);
            Assert.AreEqual("CompanyName", jobSkillModel.CompanyName);
            Assert.AreEqual("JobId", jobSkillModel.JobId);
            Assert.AreEqual("JobUrl", jobSkillModel.JobUrl);
            Assert.AreEqual("Location", jobSkillModel.Location);
            Assert.AreEqual("PostStatus", jobSkillModel.PostStatus);
            Assert.AreEqual("PostedDaysAgo", jobSkillModel.PostedDaysAgo);
            Assert.AreEqual(1, jobSkillModel.ApplicantCount);
            Assert.AreEqual("MatchingSkills", jobSkillModel.MatchingSkills[0]);
            Assert.AreEqual("MissingSkills", jobSkillModel.MissingSkills[0]);
            Assert.AreEqual("ApplicantSkills", jobSkillModel.ApplicantSkills[0]);
            Assert.AreEqual("SkillCategory", jobSkillModel.SkillCategory);
            Assert.AreEqual("SkillName", jobSkillModel.SkillName);
        }

        //Test that the JobInformationModel class from Models library has not changed
        [TestMethod]
        public void ValidateJobInformationModel()
        {
            JobInformationModel jobInformationModel = new JobInformationModel();
            jobInformationModel.JobTitle = "JobTitle";
            jobInformationModel.CompanyName = "CompanyName";
            jobInformationModel.JobId = "JobId";
            jobInformationModel.JobUrl = "JobUrl";
            jobInformationModel.Location = "Location";
            jobInformationModel.PostStatus = "PostStatus";
            jobInformationModel.PostedDaysAgo = "PostedDaysAgo";
            jobInformationModel.ApplicantCount = 1;
            jobInformationModel.MatchingSkills.Add("MatchingSkills");
            jobInformationModel.MissingSkills.Add("MissingSkills");
            jobInformationModel.ApplicantSkills.Add("ApplicantSkills");

            Assert.AreEqual("JobTitle", jobInformationModel.JobTitle);
            Assert.AreEqual("CompanyName", jobInformationModel.CompanyName);
            Assert.AreEqual("JobId", jobInformationModel.JobId);
            Assert.AreEqual("JobUrl", jobInformationModel.JobUrl);
            Assert.AreEqual("Location", jobInformationModel.Location);
            Assert.AreEqual("PostStatus", jobInformationModel.PostStatus);
            Assert.AreEqual("PostedDaysAgo", jobInformationModel.PostedDaysAgo);
            Assert.AreEqual(1, jobInformationModel.ApplicantCount);
            Assert.AreEqual("MatchingSkills", jobInformationModel.MatchingSkills[0]);
            Assert.AreEqual("MissingSkills", jobInformationModel.MissingSkills[0]);
            Assert.AreEqual("ApplicantSkills", jobInformationModel.ApplicantSkills[0]);
        }
    }
}
