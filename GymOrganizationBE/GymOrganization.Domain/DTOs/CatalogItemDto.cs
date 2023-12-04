namespace GymOrganization.Domain.DTOs;

public class CatalogItemDto
{
    public Guid Id { get; set; }
    public string ShortName { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}