using System.ComponentModel.DataAnnotations;

namespace LaptopStore.Models;

/**
 * Clasa producător
 */
public class Manufacturer
{
    public int Id { get; set; }
    
    /**
     * Denumire
     */
    public string? Name { get; set; }
    
    /**
     * Adresa
     */
    public string? Address { get; set; }
    
    /**
     * IDNO/Cod Fiscal
     */
    [MinLength(11), MaxLength(13), RegularExpression("^\\d+$")]
    public string? Idno { get; set; }
}