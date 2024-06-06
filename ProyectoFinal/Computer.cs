using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using Microsoft.VisualBasic.Devices;

namespace ProyectoFinal
{
    internal class Computer:Register 
    {

        protected int computernumber;
            
        public int Computernumber
        {
            get { return computernumber; }
            set { computernumber = value; }
        }

        //Propiedad de solo lectura 
        protected double cost = 0.26;

        public double Cost
        {
            get { return cost; }
        }

        private int printnumber;

        public int Print_number
        {
            get { return printnumber; }
            set { printnumber = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        //Constructor

        public Computer() : base()
        {
            computernumber = 0;
            cost = 0.26;
            total = 0;
        }

        public Computer(string name,string lastname, DateTime date, int computernumber, int printnumber) : base(name,lastname, date)
        {
            this.computernumber = computernumber;
            this.printnumber = printnumber;
        }

        public override string ToString()
        {
            return "Name: " + name + "Date: " + date + "Computer number: " + computernumber;
        }

        //Método con paramentros  y regreso de datos
        public double Gettotal(double cost, int printnumber)
        {
            double total = cost * printnumber;
            return total;
        }


       


    }
}
