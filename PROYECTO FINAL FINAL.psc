Algoritmo sin_titulo
	votos_para_mario <- 0
	votos_para_rocio <- 0
	votos_para_pablo <- 0
	votos_para_jorge <- 0
	votos_para_diego <- 0
	votos <- 0
	porcentaje_de_mario <- 0
	porcentaje_de_rocio <- 0
	porcentaje_de_pablo <- 0
	porcentaje_de_jorge <- 0
	porcentaje_de_diego <- 0
	Repetir
		Escribir 'Selecciona el valor de voto.'
		Escribir '    1.- Mario Hernandez'
		Escribir '    2.- Rocio Jimenez'
		Escribir '    3.- Pablo Ordoñez'
		Escribir '    4.- Jorge Fonseca'
		Escribir '    5.- Diego Perez'
		Escribir '    :' Sin Saltar
		Repetir
			Leer voto
			Si voto<1 O voto>5 Entonces
				Escribir 'Valor incorrecto. Ingrésalo nuevamente.: ' Sin Saltar
			FinSi
		Hasta Que voto>=1 Y voto<=5
		votos <- votos+1
		Si voto=1 Entonces
			votos_para_mario <- votos_para_mario+1
		FinSi
		Si voto=2 Entonces
			votos_para_rocio <- votos_para_rocio+1
		FinSi
		Si voto=3 Entonces
			votos_para_pablo <- votos_para_pablo+1
		FinSi
		Si voto=4 Entonces
			votos_para_jorge <- votos_para_jorge+1
		FinSi
		Si voto=5 Entonces
			votos_para_diego <- votos_para_diego+1
		FinSi
		Escribir ''
		Repetir
			Escribir '¿Deseas repetir el proceso? (S/N):' Sin Saltar
			Leer tecla_repetir
		Hasta Que tecla_repetir='s' O tecla_repetir='n' O tecla_repetir='S' O tecla_repetir='N'
	Hasta Que tecla_repetir='n' O tecla_repetir='N'
	Si votos=0 Entonces
		porcentaje_de_mario <- 0
	SiNo
		porcentaje_de_mario <- 100.0*votos_para_mario/votos
	FinSi
	Si votos=0 Entonces
		porcentaje_de_rocio <- 0
	SiNo
		porcentaje_de_rocio <- 100.0*votos_para_rocio/votos
	FinSi
	Si votos=0 Entonces
		porcentaje_de_pablo <- 0
	SiNo
		porcentaje_de_pablo <- 100.0*votos_para_pablo/votos
	FinSi
	Si votos=0 Entonces
		porcentaje_de_jorge <- 0
	SiNo
		porcentaje_de_jorge <- 100.0*votos_para_jorge/votos
	FinSi
	Si votos=0 Entonces
		porcentaje_de_diego <- 0
	SiNo
		porcentaje_de_diego <- 100.0*votos_para_diego/votos
	FinSi
	Dimension candidatos[5]
	candidatos[1] <- porcentaje_de_mario
	candidatos[2] <- porcentaje_de_rocio
	candidatos[3] <- porcentaje_de_pablo
	candidatos[4] <- porcentaje_de_jorge
	candidatos[5] <- porcentaje_de_diego
	Para x<-1 Hasta 5 Hacer
		Escribir 'Posicion',x,': ',Posicion,candidatos[x]
	FinPara
	buffer <- 1
	Para i<-1 Hasta 5 Hacer
		Si (candidatos[i])>(buffer) Entonces
			buffer <- candidatos[i]
		FinSi
		Escribir candidatos[i]
	FinPara
	Escribir 'Valor de votos para Mario: ',votos_para_mario
	Escribir 'Valor de votos para Rocio: ',votos_para_rocio
	Escribir 'Valor de votos para pablo: ',votos_para_pablo
	Escribir 'Valor de votos para Jorge: ',votos_para_jorge
	Escribir 'Valor de votos para Diego: ',votos_para_diego
	Escribir 'Valor de votos: ',votos
	Escribir 'Valor de porcentaje de mario: ',porcentaje_de_mario
	Escribir 'Valor de porcentaje de rocio: ',porcentaje_de_rocio
	Escribir 'Valor de porcentaje de pablo: ',porcentaje_de_pablo
	Escribir 'Valor de porcentaje de Jorge: ',porcentaje_de_jorge
	Escribir 'Valor de porcentaje de Diego: ',porcentaje_de_diego
FinAlgoritmo
