using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMessenger.models
{
    public class Message
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("User")]
        public string fromuserid { get; set; }
        public User fromuser { get; set; }

        [ForeignKey("User")]
        public string touserid { get; set; }
        public User touser { get; set; }

        public string messagetext { get; set; }
    }
}
