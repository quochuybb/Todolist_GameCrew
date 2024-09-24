using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist
{
    public class Account
    {
        [Key]
        [Column(name:"id")] 
        public int Id { get; set; }
        [Column(name:"usr")]
        public string Usr {  get; set; }
        [Column(name: "name")]
        public string Name { get; set; }
        [Column(name: "email")]
        public string Email { get; set; }
        [Column(name: "passphrase")]
        public string Passphrase { get; set; }
    }
}
