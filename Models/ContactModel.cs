using System.ComponentModel.DataAnnotations;

namespace main1234.Models
{
    public class ContactModel
    {
        [Key] 

        public string name { get; set; }


        
        public string email { get; set; }

      
        
        public string message { get; set; }
    }
}
