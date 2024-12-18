using System.ComponentModel.DataAnnotations;

namespace LaptopStore.Models;

public class Client
{
    public int Id { get; set; }

    public int PhoneId { get; set; }

    public Laptop? LaptopId { get; set; }

    public string? NameSurname { get; set; }
    
    [DataType(DataType.DateTime)]
    public DateTime DateTime { get; set; }
}