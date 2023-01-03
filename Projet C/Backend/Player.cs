using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Player
{
    private int credit;
    private string pseudo;
    private DateTime registrationDate;
    private DateTime dateOfBirth;
    public Player(string pseudo, DateTime rd, DateTime dob)
	{
        credit= 0;
        this.pseudo= pseudo;
        registrationDate = rd;  
        dateOfBirth = dob;  
	}
    public int credit { get; set; }
    public string credit { get; set; }
    public DateTime registrationDate { get; set; }
    public DateTime dateOfBirth { get; set; }

}
