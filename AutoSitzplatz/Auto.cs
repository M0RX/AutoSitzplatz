using System;
using System.Text;

public class Auto
{
	private int sitzplaetze;
	private int belegung;

	public Auto(int size)
	{
		this.sitzplaetze = size;
		this.belegung = 0;
	}
	public void einsteigen(int anzahl)
    {
		if(belegung + anzahl > sitzplaetze)
        {
			Console.WriteLine("Ich bin schon voll");
        } else
        {
			belegung += anzahl;
			sendStatus();
        }
    }
	public void aussteigen(int anzahl)
    {
		if(belegung - anzahl < 0)
        {
			Console.WriteLine("So viele Menschen sitzten hier doch nicht!");
        } else
        {
			belegung -= anzahl;
			sendStatus();
        }
    }
	private void sendStatus()
    {
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Es sitzen {0} Menschen im Auto");
		Console.WriteLine(stringBuilder.ToString(), belegung);
    }
}
