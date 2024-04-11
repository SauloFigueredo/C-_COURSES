using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoV1
{
	class LeituraDados
	{

		public static void lerDados()
		{
			//Escreve o dado do teclado e pula uma linha
			Console.WriteLine("Digite  seu algo");

			//Escreve o dado do teclado e mantem na mesma linha
			Console.Write("Digite  seu algo");

			Console.ReadLine();

			var let = new int[] { 14, 78, 89 };

			//Lê UMA LINHA  DO TECLADO
			Console.ReadLine();


			//Lê UM CARACTER  DO TECLADO
			Console.Read();

			//Lê UM CARACTER  DO TECLADO
			Console.ReadKey();



		}

	}
}
