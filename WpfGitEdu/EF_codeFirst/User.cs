using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_codeFirst
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public Uri WebPage
        {
            get
            {
                return new Uri(this.WebPageDb);
            }
            set
            {
                this.WebPageDb = value.ToString();
            }
        }

        [Column("WebPage")]
        public string WebPageDb { get; set; }
    

        public int Age { get; set; }
        public city City { get; set; }
        public money Money { get; set; }
        public List<friend> friends { get; set; }
      

   }

    public class city
    {
        public string Name { get; set; }
        public int CitizenCount { get; set; }
    }
}
