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

			switch (sel) {

			case 1:
				Console.Clear();
				Console.WriteLine ("+++Bienvenido+++");
				Console.ReadKey(true);
				break;
				
			case 2:
				Console.Clear();
				Console.WriteLine("+++Bienvenido+++");
				Console.ReadKey(true);
				break;

			case 3:
				Console.Clear();
				Console.WriteLine("+++Bienvenido+++");
				Console.ReadKey(true);
				break;

			default:
				Console.WriteLine("Seleccion Erronea");
				break;
			}
		}
	}
}
