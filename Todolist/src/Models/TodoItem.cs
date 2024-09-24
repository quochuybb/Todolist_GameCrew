using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace Todolist
{
    public class TodoItem
    {
        [Key]
        [Column(name: "task_id")]
        public int TaskId { get; set; }
        [Column(name: "usr_id")]
        public int usr_id { get; set; }
        [Column(name: "title")]
        public string Title { get; set; }
        [Column(name: "description")]
        public string Description { get; set; }
        [Column(name: "status_task")]
        public int Status_task {  get; set; }
        [Column(name: "priority_task")]
        public int Priority_task { get; set; }
        [Column(name: "due_day")]
        public DateTime Due_day { get; set; }
        [Column(name: "created_at")]
        public DateTime Created_at { get; set; }


    }
}
