using System.ComponentModel.DataAnnotations;

namespace Presentation.Data;

public class TosEntity
    {
    [Key]
    public string Id { get; set; } = null!;
    public string Titel { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string FirstText { get; set; } = null!;
    public string SecondText { get; set; } = null!;
    public string ThirdText { get; set; } = null!;
    }