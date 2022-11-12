using Owner.API.Model;
using System.Collections.Generic;

namespace Owner.API.Data
{
    public class OwnersData
    {
        public List<OwnerModel> GetAllOwner()
        {
            return new List<OwnerModel>
            {
                new OwnerModel
                {
                Id = 1,
                Name = "Merve",
                Surname = "Bakır",
                Date = System.DateTime.Now,
                Description = "xxxxx",
                Type = "A"
                },
                new OwnerModel
                {
                Id = 2,
                Name = "Leyla",
                Surname = "Bakır",
                Date = System.DateTime.Now,
                Description = "yyyyyy",
                Type = "b"
                },
               new OwnerModel
                {
                Id = 3,
                Name = "Onur",
                Surname = "Bakır",
                Date = System.DateTime.Now,
                Description = "zzzzzz",
                Type = "C"
                },
               new OwnerModel
                {
                Id = 4,
                Name = "Ali",
                Surname = "Yılmaz",
                Date = System.DateTime.Now,
                Description = "ssssssss",
                Type = "D"
                },
               new OwnerModel
                {
                Id = 5,
                Name = "Ayşe",
                Surname = "Yılmaz",
                Date = System.DateTime.Now,
                Description = "kkkkkkkkk",
                Type = "E"
                },
            };
        }
    }
}
