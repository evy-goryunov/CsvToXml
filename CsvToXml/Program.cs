using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToXml
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamReader mainReader = new StreamReader("data.csv");
			while (!mainReader.EndOfStream)
			{
				
				string[] s = mainReader.ReadLine().Split(';');
				for (int i = 0; i < s.Length; i++)
				{
					Console.OutputEncoding = Encoding.Default;
					Console.WriteLine(s[i]);
					
				}
			}
			
		}
	}
}
