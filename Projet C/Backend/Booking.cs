using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Booking
{
	private DateTime bookingDate;
	public Booking(DateTime bd)
	{
		bookingDate= bd;	
	}
	public void Delete()
	{
        bookingDate= null;

    }
	public DateTime bookingDate { get; set; }
}
