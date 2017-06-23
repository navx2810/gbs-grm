using System.Collections.Generic;

namespace GRM.Models {
    public class Groomer {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Tag> Tags { get; set; }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = Util.Hash(value);}
        }
        
        
    }
}