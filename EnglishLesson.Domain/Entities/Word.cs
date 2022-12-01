using System;
using System.ComponentModel.DataAnnotations;
using EnglishLesson.Domain.Common;

namespace EnglishLesson.Domain.Entities;

public class Word : AuditEntity
{
	[Key]
	public long Id { get; set; }

	[Required]
	public string English { get; set; }

	[Required]
	public string Polish { get; set; }
}

