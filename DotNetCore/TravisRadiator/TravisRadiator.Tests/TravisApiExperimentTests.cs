using System;
using Microsoft.Extensions.Options;
using NSubstitute;
using Shouldly;
using TravisRadiator.ApiService;
using TravisRadiator.Web.Models;
using Xunit;

namespace TravisRadiator.Tests
{
    public class TravisApiExperimentTests
    {
        [Fact]
        public void WhileGettingOwnerInfo_WorkingUserStaticToken_ReturnHasUserName()
        {
            var apiService = new TravisApiExperiment();
            var testUser = "jmacgregor-accenture";

            var result = apiService.GetOwner(testUser);

            result.ShouldContain(testUser);
        }

        [Fact]
        public void WhileGettingUserInfo_ValidToken_ReturnHasUserName()
        {
            var apiService = new TravisApiExperiment();
            var testUser = "jmacgregor-accenture";

            var result = apiService.GetUser();

            result.ShouldContain(testUser);
        }

        [Fact]
        public void WhileGettingOwnerInfo_WorkingNonTokenUser_ReturnHasUserName()
        {
            var apiService = new TravisApiExperiment();
            var testUser = "jdmac020";

            var result = apiService.GetOwner(testUser);

            result.ShouldContain(testUser);
        }

        [Fact]
        public void WhileGettingOwnerInfo_WorkingNonMeUser_ReturnHasUserName()
        {
            var apiService = new TravisApiExperiment();
            var testUser = "mmuir-accenture";

            var result = apiService.GetOwner(testUser);

            result.ShouldContain(testUser);
        }

        [Fact]
        public void WhileGettingRepos_WorkingNonTokenUser_ReturnHasExpectedRepo()
        {
            var apiService = new TravisApiExperiment();
            var testUser = "mmuir-accenture";
            var expectedRepo = "travisToy";

            var result = apiService.GetRepos(testUser);

            result.ShouldContain(testUser);
        }
    }
}