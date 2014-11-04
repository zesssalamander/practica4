/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 04/11/2014
 * Time: 07:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
namespace practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			String via;
			
			do {
			int xd=0;
			Console.WriteLine("seleccione 1 leer");
			
			Console.WriteLine("seleccione 2 salir");
			try
            {
                using (StreamReader leer = new StreamReader(via, false))
                {
                	Console.WriteLine("via");
			Console.WriteLine("ejem: C:\\1");
			via=Console.ReadLine();
                    string line;
                    while ((line = leer.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("documento erroneo");
            }
			}while(via!=0);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}