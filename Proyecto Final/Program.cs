using System;

namespace sistema {
	class sistema {

		static void Main(string[] args) {
			double buffer;
			int i;
			double porcentaje_de_diego;
			double porcentaje_de_jorge;
			double porcentaje_de_mario;
			double porcentaje_de_pablo;
			double porcentaje_de_rocio;
			int posicion;
			string tecla_repetir;
			double voto;
            double votos;
			double votos_para_diego;
			double votos_para_jorge;
			double votos_para_mario;
			double votos_para_pablo;
			double votos_para_rocio;
			int x;
			votos_para_mario = 0;
			votos_para_rocio = 0;
			votos_para_pablo = 0;
			votos_para_jorge = 0;
			votos_para_diego = 0;
			votos = 0;
			porcentaje_de_mario = 0;
			porcentaje_de_rocio = 0;
			porcentaje_de_pablo = 0;
			porcentaje_de_jorge = 0;
			porcentaje_de_diego = 0;


            do {
				Console.WriteLine("Selecciona el valor de voto.");
				Console.WriteLine("    1.- Mario Hernandez");
				Console.WriteLine("    2.- Rocio Jimenez");
				Console.WriteLine("    3.- Pablo Ordoñez");
				Console.WriteLine("    4.- Jorge Fonseca");
				Console.WriteLine("    5.- Diego Perez");
				Console.Write("    :");
				do {
                     voto = Convert.ToInt32(Console.ReadLine());
                    if (voto<1 || voto>5) {
						Console.Write("Valor incorrecto. Ingrésalo nuevamente.: ");
					}
				} while (!(voto>=1 && voto<=5));
				votos = votos+1;
				if (voto==1) {
					votos_para_mario = votos_para_mario+1;
				}
				if (voto==2) {
					votos_para_rocio = votos_para_rocio+1;
				}
				if (voto==3) {
					votos_para_pablo = votos_para_pablo+1;
				}
				if (voto==4) {
					votos_para_jorge = votos_para_jorge+1;
				}
				if (voto==5) {
					votos_para_diego = votos_para_diego+1;
				}
				Console.WriteLine("");
				do {
					Console.Write("¿Deseas repetir el proceso? (S/N):");
					tecla_repetir = Console.ReadLine();
				} while (!(tecla_repetir.Equals("s") || tecla_repetir.Equals("n") || tecla_repetir.Equals("S") || tecla_repetir.Equals("N")));
			} while (!(tecla_repetir.Equals("n") || tecla_repetir.Equals("N")));
			if (votos==0) {
				porcentaje_de_mario = 0;
			} else {
				porcentaje_de_mario = 100.0*votos_para_mario/votos;
			}
			if (votos==0) {
				porcentaje_de_rocio = 0;
			} else {
				porcentaje_de_rocio = 100.0*votos_para_rocio/votos;
			}
			if (votos==0) {
				porcentaje_de_pablo = 0;
			} else {
				porcentaje_de_pablo = 100.0*votos_para_pablo/votos;
			}
			if (votos==0) {
				porcentaje_de_jorge = 0;
			} else {
				porcentaje_de_jorge = 100.0*votos_para_jorge/votos;
			}
			if (votos==0) {
				porcentaje_de_diego = 0;
			} else {
				porcentaje_de_diego = 100.0*votos_para_diego/votos;
			}
			double[] candidatos = new double[5];
			candidatos[0] = porcentaje_de_mario;
			candidatos[1] = porcentaje_de_rocio;
			candidatos[2] = porcentaje_de_pablo;
			candidatos[3] = porcentaje_de_jorge;
			candidatos[4] = porcentaje_de_diego;
			for (x=1;x<=5;x++) {
                posicion = 0;
                Console.WriteLine("posicion" + x+": "+ posicion + candidatos[x-1]);
            }
			buffer = 1;
			for (i=1;i<=5;i++) {
				if ((candidatos[i-1])>(buffer)) {
					buffer = candidatos[i-1];
				}
				Console.WriteLine(candidatos[i-1]);
			}
			Console.WriteLine("Valor de votos para Mario: "+votos_para_mario);
			Console.WriteLine("Valor de votos para Rocio: "+votos_para_rocio);
			Console.WriteLine("Valor de votos para pablo: "+votos_para_pablo);
			Console.WriteLine("Valor de votos para Jorge: "+votos_para_jorge);
			Console.WriteLine("Valor de votos para Diego: "+votos_para_diego);
			Console.WriteLine("Total votos: "+votos);
			Console.WriteLine("Valor de porcentaje de mario: "+porcentaje_de_mario);
			Console.WriteLine("Valor de porcentaje de rocio: "+porcentaje_de_rocio);
			Console.WriteLine("Valor de porcentaje de pablo: "+porcentaje_de_pablo);
			Console.WriteLine("Valor de porcentaje de Jorge: "+porcentaje_de_jorge);
			Console.WriteLine("Valor de porcentaje de Diego: "+porcentaje_de_diego);
		}

	}

}
