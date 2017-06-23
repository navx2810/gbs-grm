using System.Collections.Generic;

namespace GRM.Models
{
    public enum Gender { Male, Female }
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public List<Tag> Tags { get; set; }

    }

}