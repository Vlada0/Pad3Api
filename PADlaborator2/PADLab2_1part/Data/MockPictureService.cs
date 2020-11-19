using PADLab2_1part.Models;
using PADLab2_1part.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADLab2_1part.Data
{
    public class MockPictureService : IPictureService
    {
        public Task<Picture> CreatePicture(Picture picture)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Picture> GetPictureById(Guid id)
        {
            throw new NotImplementedException();
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
