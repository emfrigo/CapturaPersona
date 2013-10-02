using System;
using System.Collections;

namespace CapturaPersona
{
	public class Funciones
	{
		public Persona persona;
		public int tam;

		public Funciones ()
		{
		}

		public void imprimirTabla (Hashtable hTabla)
		{
			ICollection personas = hTabla.Values;

			foreach(object objeto in personas)
			{
			    Persona persona = (Persona)(objeto);
				Console.WriteLine("Codigo: " + persona.codigo + "\nNombre: " + persona.nombre + "\nTelefono: " + persona.telefono + "\nFacebook: www.facebook.com/" + persona.faceTag);
			}
       
		}

		public Hashtable funcionAgregar(Hashtable hTabla)
		{
			int elem;

			Console.WriteLine ("Cuantos elementos desea agregar??");
			elem = Convert.ToInt32 (Console.ReadLine ());



			for (int i=0; i<=elem-1; i++) {
			retorno:

				persona = new Persona ();

				Console.WriteLine ("Persona " + (i + 1));

				Console.Write ("Codigo: ");
				persona.codigo = Convert.ToInt32 (Console.ReadLine ());

				Console.Write ("Nombre: ");
				persona.nombre = Console.ReadLine ();

				Console.Write ("Telefono: ");
				persona.telefono = Console.ReadLine ();

				Console.Write ("Facebook: www.facebook/");
				persona.faceTag = Console.ReadLine ();

				try{
				hTabla.Add (persona.codigo, persona);
				}catch(Exception ){
					Console.WriteLine("\n*****Codigo repetido*****\n");
					goto retorno;
				}
			}

			return hTabla;
		}

		public Hashtable funcionModificar(Hashtable hTabla)
		{
			int buscar;

			this.imprimirTabla(hTabla);

			Console.WriteLine ("\ncual registro desea modificar?");
			buscar = Convert.ToInt32 (Console.ReadLine ());

			if (hTabla.ContainsKey(buscar)) {

				Persona persona = (Persona)(hTabla[buscar]);

				Console.WriteLine(persona.codigo + ":\n");
				Console.Write("Nuevo Nombre:");
				persona.nombre = Console.ReadLine();
				Console.Write("Nuevo Telefono: ");
				persona.telefono = Console.ReadLine();
				Console.WriteLine("Nuevo Face: www.facebook.com/");
				persona.faceTag = Console.ReadLine();

			}
			else Console.WriteLine("no esta");


			return hTabla;
		}

		public Hashtable funcionEliminar (Hashtable hTabla)
		{
			int eliminar;
			retorno:

			Console.WriteLine ("Que persona desea eliminar?");
			this.imprimirTabla (hTabla);

			eliminar = Convert.ToInt32 (Console.ReadLine ());

			if (hTabla.ContainsKey (eliminar))
				hTabla.Remove (eliminar);

			this.imprimirTabla (hTabla);
			Console.WriteLine ("Eliminar otro? \ns/n");

			char sel = Convert.ToChar (Console.ReadLine ());

			if (sel == 's') {
				Console.Clear();
				goto retorno;
			}
			return hTabla;
		}
	}
}

