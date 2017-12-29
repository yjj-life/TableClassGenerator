using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableClassGenerator.Models
{
	public class TableSchema
	{
		public bool Primary { get; set; }
		public string Column { get; set; }
		public string DataType { get; set; }
		public int Length { get; set; }
	}
}
