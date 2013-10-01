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

		public void imprimirTabla (Hashtable hTabla, int llave)
		{
			IDictionaryEnumerator numerador = hTabla.GetEnumerator ();
			persona = new Persona();

			while (numerador.MoveNext()) {

				persona = (Persona)(hTabla[llave]);

				Console.WriteLine("Codigo: " + persona.codigo + "\n" + "Nombre: " + persona.nombre + "/n" + "Telefono: " + persona.telefono + "Facebook: www.facebook.com/" + persona.faceTag);
			}
       
		}
		public Hashtable funcionAgregar(Hashtable hTabla)
		{
			int elem;

			Console.WriteLine ("Cuantos elementops desea agregar??");
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
				}catch(Exception e){
					Console.WriteLine("Codigo repetido");
					goto retorno;
				}
			}
			return hTabla;
		}

		public Hashtable funcionModificar(Hashtable hTabla)
		{
			int buscar;

			Console.WriteLine ("cual registro dese modificar?");
			buscar = Convert.ToInt32 (Console.ReadLine ());

			if (hTabla.Contains(buscar)) {
				Console.WriteLine("Si se encuentra el registro");
				this.imprimirTabla(hTabla, buscar);

				Console.WriteLine("Desea editarlo");
				 
				persona = new Persona();


			}
			else Console.WriteLine("no esta");


			return hTabla;
		}
	}
}

