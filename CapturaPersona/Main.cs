using System;

namespace CapturaPersona
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sel;

			Console.WriteLine ("Bienvenido al directorio de Personas \n Menu:\n1)Capturar nueva Persona\n2)Modificar Datos de una Persona\n3)Borrar Persona ");
			sel = Convert.ToInt32(Console.ReadLine());
			Console.Clear();

			switch (sel) {

			case 1:
				Console.WriteLine ("+++Bienvenido+++");
				Console.ReadKey(true);
				break;
				
			case 2:
				Console.WriteLine("+++Bienvenido+++");
				Console.ReadKey(true);
				break;

			case 3:
				Console.WriteLine("+++Bienvenido+++");
				Console.ReadKey(true);
				break;


			Default: 
					Console.WriteLine("Seleccion Erronea");

			}
		}
	}
}
