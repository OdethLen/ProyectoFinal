using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Register
    {
		protected string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		//
		protected string lastname;

		public string Lastname
		{
			get { return lastname; }
			set { lastname = value; }
		}

		//
		protected DateTime date;

		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}

		public Register()
		{
			name = "";
			lastname = "";
			date = DateTime.Now;
			
		}
		
		public Register(string name,string lastname, DateTime date)
		{
			this.name = name;
			this.lastname = lastname;
			this.date = date;
		}

		public override string ToString() 
		{
			return "Name: " + name + lastname + "Date: " + date;
		}
	}
}
