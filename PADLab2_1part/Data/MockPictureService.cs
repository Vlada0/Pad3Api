using PADLab2_1part.Models;
using PADLab2_1part.Services;
using PADLab2_1part.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADLab2_1part.Data
{
    public class MockPictureService : IPictureService
    {
        public List<Picture> pictures;
        public MockPictureService()
        {
            pictures = new List<Picture>();
            var picture = new Picture
            {
                Id = new Guid("1ba6b939-2a1a-4d6d-b65a-33f699a82bdb"),
                Name = "PictureName",
                Image = "SomeImage",
                Description = "SomeDescription",
                Author = new Guid("537ded05-ef3f-49a6-a664-d22aacfb4f7f")
            };
            pictures.Add(picture);
        }
        public Task<Picture> CreatePicture(Picture picture)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Picture> GetPictureById(Guid id)
        {
            var picture = pictures.Where(picture => picture.Id == id).FirstOrDefault();
            if (picture == null)
            {
                throw new NotFoundException("Picture not found!");
            }
            return picture;
        }

        public async Task<IEnumerable<Picture>> GetPictures()
        {
            var picture = new Picture();
            picture.Id = new Guid("1ba6b939-2a1a-4d6d-b65a-33f699a82bdb");
            picture.Name = "PictureName";
            picture.Image = "SomeImage";
            picture.Description = "SomeDescription";
            picture.Author = new Guid("537ded05-ef3f-49a6-a664-d22aacfb4f7f");
            var pictureList = new List<Picture>();
            pictureList.Add(picture);
            return pictureList;
        }

        public Task<Picture> Update(Picture picture)
        {
            throw new NotImplementedException();
        }
    }
}
