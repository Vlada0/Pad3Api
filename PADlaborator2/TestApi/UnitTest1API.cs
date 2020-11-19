using System;
using Xunit;
using PADLab2_1part.Controllers;
using PADLab2_1part.Services;
using PADLab2_1part.Data;

namespace TestApi
{
    public class UnitTest1API
    {
        [Fact]
        public void GetNumberOfPictures()
        {
            IPictureService pictureService = new MockPictureService();
            PictureController pictureController = new PictureController(pictureService);
            var result = pictureController.GetPictures();
            Assert.NotNull(result);
        }
    }
}
