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
        public void WhileGettingOwnerInfo_WorkingUserStaticToken_ReturnsUserName()
        {
            var apiService = new TravisApiExperiment();
            var testUser = "jmacgregor-accenture";

            var result = apiService.GetOwner(testUser);

            result.ShouldContain(testUser);
        }

        [Fact]
        public void WhileGettingUserInfo_ValidToken_ReturnsUserName()
        {
            var apiService = new TravisApiExperiment();
            var testUser = "jmacgregor-accenture";

            var result = apiService.GetUser();

            result.ShouldContain(testUser);
        }
    }
}