using Microsoft.Extensions.Logging;
using Vaquinha.Domain.ViewModels;
using Vaquinha.MVC.Controllers;
using Vaquinha.Domain;
using Xunit;
using NToastNotify;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;


namespace Vaquinha.Unit.Tests.ControllerTests
{
    public class HomeControllerTests
    {
        private readonly Mock<IHomeInfoService> _homeInfoService = new Mock<IHomeInfoService>();
        private readonly Mock<ILogger<HomeController>> _logger = new Mock<ILogger<HomeController>>();
        private readonly Mock<IToastNotification> _toastNotification = new Mock<IToastNotification>();
       

        public HomeControllerTests()
        {
             
             
        }

        [Fact]
        [Trait("HomeController", "HomeController_Index_RetornaTelaInicialComSucesso")]
         public void HomeController_Index_RetornaTelaInicialComSucesso()
         {
             //Arrange
             var controller = new HomeController(_logger.Object,_homeInfoService.Object,_toastNotification.Object);

             //Act
             var result =  controller.Index();
            
             //Assert
             result.Should().BeOfType<Task<IActionResult>>();

         }
    }
}
