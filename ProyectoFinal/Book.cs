using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Book:Register
    {
		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		//
		private string author;

		public string Author
		{
			get { return author; }
			set { author = value; }
		}
		//
		private string publisher;

		public string Publisher
		{
			get { return publisher; }
			set { publisher = value; }
		}
		//
		



		//
		protected DateTime enddate;

		public DateTime Enddate
		{
			get { return enddate; }
			set { enddate = value; }
		}


		//Constuctor sin parametros 
		public Book ():base()
		{
			title = "";
			author = "";
			publisher = "";			
			enddate = DateTime.Now;
		}
		//Constructor con parametros
		public Book(string name, string lastname, string title, string author, string publisher, DateTime date, DateTime enddate) : base(name,lastname,date)
		{
			this.title = title;
			this.author=author;
			this.publisher=publisher;			
			this.enddate = enddate;
        }

        public override string ToString()
        {
            return "Name: ";
        }

       


    }
}
