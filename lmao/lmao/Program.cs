using System;

namespace lmao
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Reader r = new Reader ();
			Console.WriteLine (r.text);
			Writer w = new Writer("what's up?");
			Console.WriteLine (); //Need to fix output
			Console.ReadLine();
		}
	}
}
