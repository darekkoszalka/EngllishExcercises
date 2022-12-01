using System;
using System.ComponentModel.DataAnnotations;
using EnglishLesson.Domain.Common;

namespace EnglishLesson.Domain.Entities;

public class ThemeOfWord : AuditEntity
{
	[Key]
	public int Id { get; set; }

	[Required]
	public string Name { get; set; }

    public string Description { get; set; }

}

