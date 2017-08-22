using System;

namespace Foods.Model
{
    public class Transaction
    {
        public string CustomerImageUrl { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ProductImageUrl { get; set; }
        public bool IsComplete { get; set; }
        public bool IsInProgress => !this.IsComplete;
    }
}
