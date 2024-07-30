using System.ComponentModel.DataAnnotations;

namespace MRazorComponent.MFeedbackWidgets;

public class Feedback
{
    [MaxLength(256)]
    public string? Author { get; set; }
    
    [MaxLength(256)]
    public string? Subject { get; set; }
    
    [Range(1, 5)]
    public int Score { get; set;}
    
    [MaxLength(1000, ErrorMessage = "Mesajul nu poate fi mai lung de 1000 de caractere"),]
    public  string? Message { get; set; }
}   