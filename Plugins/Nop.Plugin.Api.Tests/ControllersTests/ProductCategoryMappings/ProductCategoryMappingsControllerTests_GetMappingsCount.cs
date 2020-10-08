﻿using AutoMock;
using Nop.Plugin.Api.Controllers;
using Nop.Plugin.Api.DTOs.ProductCategoryMappings;
using Nop.Plugin.Api.Models.ProductCategoryMappingsParameters;
using Nop.Plugin.Api.Services;
using NUnit.Framework;
using Rhino.Mocks;

namespace Nop.Plugin.Api.Tests.ControllersTests.ProductCategoryMappings
{
    using Microsoft.AspNetCore.Mvc;

    [TestFixture]
    public class ProductCategoryMappingsControllerTests_GetMappingsCount
    {
        [Test]
        public void WhenNoProductCategoryMappingsExist_ShouldReturnOKResultWithCountEqualToZero()
        {
            var parameters = new ProductCategoryMappingsCountParametersModel();

            // arrange
            var autoMocker = new RhinoAutoMocker<ProductCategoryMappingsController>();

            autoMocker.Get<IProductCategoryMappingsApiService>().Stub(x => x.GetMappingsCount()).IgnoreArguments().Return(0);

            // act
            IActionResult result = autoMocker.ClassUnderTest.GetMappingsCount(parameters);

            // assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            Assert.AreEqual(0, ((ProductCategoryMappingsCountRootObject)((OkObjectResult)result).Value).Count);
        }

        [Test]
        public void WhenSingleProductCategoryMappingExists_ShouldReturnOKWithCountEqualToOne()
        {
            var parameters = new ProductCategoryMappingsCountParametersModel();

            // arrange
            var autoMocker = new RhinoAutoMocker<ProductCategoryMappingsController>();

            autoMocker.Get<IProductCategoryMappingsApiService>().Stub(x => x.GetMappingsCount()).IgnoreArguments().Return(1);
            // act
            IActionResult result = autoMocker.ClassUnderTest.GetMappingsCount(parameters);

            // assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            Assert.AreEqual(1, ((ProductCategoryMappingsCountRootObject)((OkObjectResult)result).Value).Count);
        }

        [Test]
        public void WhenCertainNumberOfProductCategoryMappingsExist_ShouldReturnOKWithCountEqualToSameNumberOfProductCategoryMappings()
        {
            var mappingsCountParametersModel = new ProductCategoryMappingsCountParametersModel();
            int mappingsCount = 20;

            // arrange
            var autoMocker = new RhinoAutoMocker<ProductCategoryMappingsController>();

            autoMocker.Get<IProductCategoryMappingsApiService>().Stub(x => x.GetMappingsCount()).IgnoreArguments().Return(mappingsCount);

            // act
            IActionResult result = autoMocker.ClassUnderTest.GetMappingsCount(mappingsCountParametersModel);

            // assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            Assert.AreEqual(mappingsCount, ((ProductCategoryMappingsCountRootObject)((OkObjectResult)result).Value).Count);
        }
    }
}