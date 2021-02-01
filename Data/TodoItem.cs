using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Data
{
    public enum Status
    {
        Inbox,
        Done,
        Important,
        Trash
    }

    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public Status StatusType { get; set; }

        public int UserId { get; set; }
        public BecUser User { get; set; }
    }
}
