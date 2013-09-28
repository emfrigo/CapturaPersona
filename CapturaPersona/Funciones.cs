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
		}

		public void funcionAgregar ()
		{
			int elem;
			hTabla = new Hashtable();

			Console.WriteLine ("Cuantos elementops desea agregar??");
			elem = Convert.ToInt32 (Console.ReadLine ());



			for (int i=0; i<=elem-1; i++) {

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

				hTabla.Add (persona.codigo, persona);
				Console.Clear ();
			}
			imprimirTabla(hTabla);
		}

		public void imprimirTabla (Hashtable hTabla)
		{
			foreach (int key in hTabla.Keys)
				Console.WriteLine (String.Format ("{0}: {1}", key, hTabla [key]));
		

			Console.WriteLine ("La tabla:"); 


			IDictionaryEnumerator enumerador = hTabla.GetEnumerator(); 

			while ( enumerador.MoveNext() ) { 

				Persona Mos = new Persona();

				Mos = (Persona)(hTabla[enumerador.Key]); 
				Console.Write ("Codigo:"); 
				Console.WriteLine (Mos.codigo); 
				Console.Write ("Nombre:"); 
				Console.WriteLine (Mos.nombre); 
				Console.Write ("Telefono:"); 
				Console.WriteLine (Mos.telefono); 
				Console.Write ("Facebook: www.facebook.com/:"); 
				Console.WriteLine (Mos.faceTag); 
				Console.WriteLine();
			}
		}
	
	}
}

