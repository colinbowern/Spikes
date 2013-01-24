using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Contoso.DotNetBoilerplate.UI.Controllers;
using FluentAssertions;
using Xunit;

namespace Contoso.DotNetBoilerplate.Tests.UnitTests.UI.Controllers
{
    public class HomeControllerFacts
    {
        [Fact]
        public void Index_DefaultParameters_ReturnsViewResult()
        {
            var target = new HomeController();

            var actual = target.Index();

            actual.Should().BeAssignableTo<ViewResult>();
        }
    }
}
