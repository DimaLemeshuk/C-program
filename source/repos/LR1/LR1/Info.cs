using System;

public class Info
{
	public GameAccount opponent;
    public int Rating;
	public int IP;
	public String status;
	public Info(int IP, int rating, GameAccount opponent, String status)
	{
		this.IP = IP;
		this.Rating = rating;	
		this.opponent=opponent;
		this.status = status;
	}
}
