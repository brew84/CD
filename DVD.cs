public class DVD
{
	private string title;
	private bool seen;
	private string type;
	
	public DVD(string title, string type)
	{
		seen = false;
		setTitle(title);
		setType(type);
	}
	
	public void setTitle(string title)
	{
		if (title != null)
		{
			this.title = title;
		}
	}
	
	public string getTitle()
	{
		return title;
	}
	
	public void setType(string type)
	{
		if (type == "DVD" || type == "BluRay")
		{
			this.type = type;
		}else
		{
			this.type = "not set";
			Console.WriteLine("Type not set! Type must be DVD or BluRay!");
		}
	}
	
	public string getType()
	{
		return type;
	}
	
	public void setToSeen()
	{
		seen = true;
	}
	
	public string haveSeen()
	{
		string seen;
		if (this.seen == true)
		{
			seen = "Yes";
			return seen;
		}
		else
		{
			seen = "No";
			return seen;
		}
		
	}
	
}
