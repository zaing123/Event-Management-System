using System.ComponentModel.DataAnnotations;

namespace main1234.Models
{
    public class PostModel
    {

        [Key]
        public int Id { get; set; }
        // Event Name
        public string name { get; set; }

        // Event Description
        public string  description{ get; set; }

        // Event Date
        public DateTime date { get; set; }

        // Event Time
        public TimeSpan time { get; set; }

        // Event Category
        public string category { get; set; }

        // Event Picture (For file upload)
        public string picture { get; set; }
    }

}

