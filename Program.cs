using System;
using System.IO;
using System.Text;

namespace Pratice.cs
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i1=0;
			string[]subjects={"English bee","Science Master","Mathematics(Rs Aggarwal)"};
			
			
			//Library Managment System
			while(i1<10)
			{
				Console.ForegroundColor= ConsoleColor.Red;
				
				Console.WriteLine("Chinmaya Vidyalaya");
				Console.WriteLine("Welcome to Homework Managment System");
				
				//Pins of classes
				Console.WriteLine("________________________________________");
				Console.WriteLine("Following class have following pins--");
				Console.WriteLine("Class-7 :: 33337");
				Console.WriteLine("Class-8 :: 44448");
				Console.WriteLine("Class-9 :: 55559");
				Console.WriteLine("Class-10 :: 66660");
				Console.WriteLine("Class-11 :: 34561");
				Console.WriteLine("Class-12 :: 64352");
				Console.WriteLine("________________________________________");
				
				//Pins input
				Console.Write("Enter your Registration number::");
				string regno=Console.ReadLine();
				
				Console.Write("Enter your pin given by your teacher::");
				string pin=Console.ReadLine();
				
				if(regno=="@@@@@"|| pin=="@@@@@")
				{
					string read1=File.ReadAllText("one.txt");
					string read2=File.ReadAllText("two.txt");
					string read3=File.ReadAllText("three.txt");
					Console.WriteLine(read1+" ");
					Console.Write("Last Issued By::");
					Console.Write(read2);
					Console.WriteLine(" Subject is::");
					Console.Write(read3);
					Console.WriteLine("______________________________________");
					Console.WriteLine("Please Any Key To Close The Application");
					break;
				}
				
				foreach(char i in pin)
				{
					if(i=='7')
					{
						Console.ForegroundColor=ConsoleColor.DarkCyan;
						Console.WriteLine("You are student of Class 7!");
						Console.WriteLine("Following books are available for you!");
						Console.WriteLine("English bee-7");
						Console.WriteLine("Science Master-7");
						Console.WriteLine("Mathematics(Rs Aggarwal)-7");
							
					}
					
					if(i=='8')
					{Console.ForegroundColor=ConsoleColor.White;
						Console.WriteLine("You are student of Class 8!");
						Console.WriteLine("Following books are available for you!");
						Console.WriteLine("English bee-8");
						Console.WriteLine("Science Master-8");
						Console.WriteLine("Mathematics(Rs Aggarwal)-8");
					}
					
					if(i=='9')
					{
						Console.ForegroundColor=ConsoleColor.DarkYellow;
						Console.WriteLine("You are student of Class 9!");
						Console.WriteLine("Following books are available for you!");
						Console.WriteLine("English bee-9");
						Console.WriteLine("Science Master-9");
						Console.WriteLine("Mathematics(Rs Aggarwal)-9");
					}
					
					if(i=='0')
					{
						Console.ForegroundColor=ConsoleColor.Magenta;
						Console.WriteLine("You are student of Class 10!");
						Console.WriteLine("Following books are available for you!");
						Console.WriteLine("English bee-10");
						Console.WriteLine("Science Master-10");
						Console.WriteLine("Mathematics(Rs Aggarwal)-10");
					}
					
					if(i=='1')
					{
						Console.ForegroundColor=ConsoleColor.Green;
						Console.WriteLine("You are student of Class 11!");
						Console.WriteLine("Following books are available for you!");
						Console.WriteLine("English bee-11");
						Console.WriteLine("Science Master-11");
						Console.WriteLine("Mathematics(Rs Aggarwal)-11");
					}
					
					if(i=='2')
					{
						Console.ForegroundColor=ConsoleColor.Blue;
						Console.WriteLine("You are student of Class 12!");
						Console.WriteLine("Following books are available for you!");
						Console.WriteLine("English bee");
						Console.WriteLine("Science Master-12");
						Console.WriteLine("Mathematics(Rs Aggarwal)-12");
					}
					
					
					
				}
				Console.WriteLine("__________________________________");
				Console.WriteLine("Which one you want to issue?::");
				string issue=Console.ReadLine();
				
				foreach(string i in subjects)
				{
					if(i==issue)
					{
						string issued="Issued!";
						
						Console.WriteLine("Issued! by",regno);
						File.WriteAllText("one.txt",issued);
						File.WriteAllText("two.txt",regno);
						File.WriteAllText("three.txt",issue);
					}
				}
				
				
				
				
			}
			
			Console.ReadLine();
			
    	}
		
	}
}