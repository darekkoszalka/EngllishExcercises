using System;
using System.ComponentModel.DataAnnotations;

namespace EnglishLesson.Domain.Common;

public abstract class AuditEntity
{
    [Required]
    public string CreatedBy { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; }
    public string ModificatedBy { get; set; }
    public DateTime ModificatedDate { get; set; }

}

