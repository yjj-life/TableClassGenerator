using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableClassGenerator.Models
{
	public enum AuthType
	{
		Integration,
		SQLServer
	}

	public class Authentication
	{
		public string ServerName { get; set; }
		public AuthType AuthType { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool Remember { get; set; }
	}
}
