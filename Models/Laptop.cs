using System.ComponentModel.DataAnnotations;

namespace LaptopStore.Models;

/**
 * Clasa Laptop
 */
public class Laptop
{
    public int Id { get; set; }
    
    /**
     * Denumire
     */
    public string? Name { get; set; }
    
    /**
     * Producator
     */
    public virtual Manufacturer? Manufacturer { get; set; }

    /**
     * Data producerii
     */
    [DataType(DataType.DateTime)]
    public DateTime ProductionDateTime { get; set; }
}