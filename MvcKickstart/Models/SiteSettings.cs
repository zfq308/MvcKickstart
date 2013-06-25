﻿using System.ComponentModel.DataAnnotations;
using Spruce.Schema.Attributes;

namespace MvcKickstart.Models
{
	public class SiteSettings
	{
		[AutoIncrement]
		public int Id { get; set; }

		[StringLength(100)]
		public string AnalyticsToken { get; set; }
	}
}