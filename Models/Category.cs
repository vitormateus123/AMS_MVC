using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST5_Task11_Interface01.Models
{

    public class Category
    {
        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public string ImgUrl { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedOn { get; private set; }

        public Category(string description, string imgUrl)
        {
            Id = Guid.NewGuid();
            Description = description;
            ImgUrl = imgUrl;
            IsActive = true;
            CreatedOn = DateTime.Now;
        }
    }
}