using Projet_C.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Player : User
{
    private int credit;
    private string pseudo;
    private DateTime registrationDate;
    private DateTime dateOfBirth;
    public Player(string pseudo, DateTime rd, DateTime dob)
	{
        Credit = 0;
        this.pseudo= pseudo;
        RegistrationDate = rd;  
        DateOfBirth = dob;  
	}

    public int Credit { get; set; }
    public string Pseudo { get; set; }

    public DateTime RegistrationDate { get; set; }
    public DateTime DateOfBirth { get; set; }

}
