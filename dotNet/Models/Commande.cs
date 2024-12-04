namespace dotNet.Models
{
    
    public class Commande
    {
        public int Id { get; set; }             
        public int ClientId { get; set; }       
        public Client Client { get; set; }    
        public int ProductId { get; set; }     
        public Product Product { get; set; }    

        public DateTime OrderDate { get; set; }   
        public decimal TotalAmount { get; set; } 
        public string Status { get; set; }         
     }

}
