#Campaña de Vacunación COVID-19 (C#)
#Descripción del proyecto
Este proyecto simula una campaña de vacunación contra el COVID-19 utilizando conceptos de teoría de conjuntos en el lenguaje C#.
Se generan ciudadanos ficticios y se aplican operaciones de conjuntos para determinar:
•	Ciudadanos que no se han vacunado.
•	Ciudadanos que han recibido ambas dosis.
•	Ciudadanos que solo han recibido la vacuna de Pfizer.
•	Ciudadanos que solo han recibido la vacuna de AstraZeneca.
El objetivo es aprender a manipular conjuntos y aplicar operaciones como unión, intersección y diferencia de manera práctica.

#Requisitos
•	.NET SDK 7 o superior (https://dotnet.microsoft.com/download/dotnet)
•	Visual Studio Code o Visual Studio
•	Conexión a Internet para clonar el repositorio (opcional)

#Estructura del proyecto
#CampañaVacunacion/
│
├─ Program.cs         # Archivo principal con la lógica de la campaña
├─ CampañaVacunacion.csproj  # Proyecto de C# de consola
└─ README.md          # Documentación del proyecto

#Explicación del código
#1.	Generación de ciudadanos ficticios
HashSet<string> ciudadanos = new HashSet<string>();
for (int i = 1; i <= 500; i++)
    ciudadanos.Add("Ciudadano " + i);
Se crea un conjunto de 500 ciudadanos con nombres ficticios Ciudadano 1 hasta Ciudadano 500.
#2.	Vacunación aleatoria
o	Pfizer: 75 ciudadanos aleatorios
o	AstraZeneca: 75 ciudadanos aleatorios
HashSet<string> pfizer = new HashSet<string>();
HashSet<string> astrazeneca = new HashSet<string>();
Se usa Random para asignar las vacunas sin duplicados gracias a HashSet.
#3.	Operaciones de teoría de conjuntos
o	Unión: todos los vacunados
o	Intersección: ciudadanos con ambas dosis
o	Diferencia: ciudadanos no vacunados y los que tienen solo una vacuna
#Ejemplo de intersección:
HashSet<string> ambasDosis = new HashSet<string>(pfizer);
ambasDosis.IntersectWith(astrazeneca);
#4.	Mostrar resultados
Se imprimen los conteos de cada grupo en la consola:
Console.WriteLine("Ciudadanos que no se han vacunado: " + noVacunados.Count);

Cómo ejecutar el proyecto
#1.	Clonar el repositorio:
git clone <ENLACE_DEL_REPOSITORIO>
2.	Abrir la carpeta en Visual Studio Code o Visual Studio.
3.	Ejecutar el proyecto:
dotnet run
#4.	Revisar los resultados en la consola.

Contribuciones
Este proyecto es original y fue desarrollado como práctica académica de estructuras de datos y teoría de conjuntos en C#.

Autor
Johnny Vera 
Facultad de Ciewncia en Tegnoligía de la información 
Estudiante de la Universidad Estatal Amazónica


