using System;
using Xunit;
using PADLab2_1part.Controllers;
using PADLab2_1part.Services;
using PADLab2_1part.Data;
using System.Threading.Tasks;
using System.Web.Http.Results;
using System.Net;

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

        [Fact]
        public async Task Controller_Should_Return_Status_404NotFound()
        {
            IPictureService pictureService = new MockPictureService();
            PictureController pictureController = new PictureController(pictureService);
            var id = new Guid("1ba6b939-2a1a-4d6d-b65a-33f699a82bdb");
            var response = await pictureController.GetPicture(id);

            Assert.NotNull(response);

        }
    }
}
