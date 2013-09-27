using System;
using System.Collections;

namespace CapturaPersona
{
	public class Funciones
	{
		public Hashtable hTabla;
		public Persona persona;
		public int tam;

		public Funciones ()
		{
			hTabla = new Hashtable();
		}

		public void imprimirTabla ()
		{
			foreach(int key in hTabla.Keys)
				  Console.WriteLine(String.Format("{0}: {1}", key, hTabla[key]));
		}
	
		public void funcionAgregar ()
		{
			char s;

			persona = new Persona ();

			for (int i=0; i<=1; i++) {
				Console.WriteLine("Persona " + (i+1));

				Console.Write("Codigo: ");
				persona.codigo = Convert.ToInt32(Console.ReadLine());

				Console.Write("Nombre: ");
				persona.nombre = Console.ReadLine();

				Console.Write("Telefono: ");
				persona.telefono = Console.ReadLine();

				Console.Write("Facebook: www.facebook/");
				persona.faceTag = Console.ReadLine();

				hTabla.Add(persona.codigo,persona);
					Console.Clear();
				}		
			}

		}

	}

