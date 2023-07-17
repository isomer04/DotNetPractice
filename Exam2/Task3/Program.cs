//Write code to find what day (Sun, Mon, Tue, etc.) will be after 100 days from today using DateTime.Also print what month it will be.


DateTime nowTime = DateTime.Now;
DateTime after100 = nowTime.AddDays(100);


Console.WriteLine(after100.DayOfWeek);

Console.WriteLine(after100.Month);