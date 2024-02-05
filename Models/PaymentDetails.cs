using PaymentAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class PaymentDetails
    {
        [Key]
        public int PaymentDetailsId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string CardOwnerName { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string CardNumber { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string ExpirationDate { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string SecurityCode { get; set; } = "";     
        
    }
    
}

