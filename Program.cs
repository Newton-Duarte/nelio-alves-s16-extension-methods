DateTime pastDate = new DateTime(2023, 08, 27, 12, 0, 0);
DateTime futureDate = new DateTime(2023, 09, 27, 12, 0, 0);


System.Console.Write("Duration of past date: ");
System.Console.WriteLine(pastDate.ElapsedTime());

System.Console.Write("Duration for future date: ");
System.Console.WriteLine(futureDate.FutureTime());


string sentence = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit";

System.Console.Write("Cut sentence (10): ");
System.Console.WriteLine(sentence.Cut(10));