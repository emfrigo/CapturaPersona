using System;
using System.Collections;

namespace CapturaPersona
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			int sel;
			Hashtable hTabla = new Hashtable();

		menu:
			Console.WriteLine ("Bienvenido al directorio de Personas \n Menu:\n1)Capturar nueva Persona\n2)Modificar Datos de una Persona\n3)Borrar Persona\n4)Salir ");

				sel = Convert.ToInt32(Console.ReadLine());

			switch (sel) {

			case 1:
				Console.Clear();
				Console.WriteLine ("+++Bienvenido+++");
				new Funciones().funcionAgregar(hTabla);
				Console.Clear();
				Console.ReadKey(true);
				break;
				
			case 2:
				Console.Clear();
				Console.WriteLine("+++Bienvenido+++");
				new Funciones().funcionModificar(hTabla);
				Console.ReadKey(true);
				break;

			case 3:
				Console.Clear();
				Console.WriteLine("+++Bienvenido+++");
				new Funciones().funcionEliminar(hTabla);
				Console.ReadKey(true);
				break;

			case 4:
				Environment.Exit(0);
				break;

			default:
				Console.WriteLine("Seleccion Erronea");
				Console.Clear();
				goto menu;
			}
			goto menu;
		}
	}
}
