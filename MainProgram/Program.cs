// Please read the comments below before modding/running this program!

// If the user does not enter a proper date, the user will get a run-time error.
// Before Modifying this, please note that the time units you can't use are months, years, decades, and centuries.

// Thanks For reading these comments, now you can do whatever you want!

Console.Write("(Example: 01/01/2000) Enter Your Birth Date: ");
string dob = Console.ReadLine();
DateTime dt = DateTime.Parse(dob);
TimeSpan ts = (DateTime.Now - dt);
Console.WriteLine($"You are {(int)ts.TotalSeconds} seconds old, (Note: The Value Is Rounded For This and all Values.)");
Thread.Sleep(2500);
Console.WriteLine($"You are {(int)ts.TotalMinutes} minutes old,");
Thread.Sleep(2500);
Console.WriteLine($"You are {(int)ts.TotalHours} hours old,");
Thread.Sleep(2500);
