﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HMS.Library.Models
{
	public class Billing
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BillingId { get; set; }
		public int? PatientID { get; set; }


		[DataType(DataType.DateTime)]
		public DateTime DateTime { get; set; }

		public decimal Amount { get; set; }



        //Navigation Property
        public Patient? Patient { get; set; }

		public ICollection<BillingDetails>? BillingDetails { get; set; } = new List<BillingDetails>();

	}
}
