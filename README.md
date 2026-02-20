# 🏥 Campaña de Vacunación COVID-19 (C#)

## Descripción del proyecto
Este proyecto simula una **campaña de vacunación contra el COVID-19** utilizando conceptos de **teoría de conjuntos** en el lenguaje **C#**.

Se generan ciudadanos ficticios y se aplican operaciones de conjuntos para determinar:

- Ciudadanos que **no se han vacunado**.  
- Ciudadanos que han recibido **ambas dosis**.  
- Ciudadanos que solo han recibido la vacuna de **Pfizer**.  
- Ciudadanos que solo han recibido la vacuna de **AstraZeneca**.  

El objetivo es **aprender a manipular conjuntos** y aplicar operaciones como **unión, intersección y diferencia** de manera práctica.

---

## Requisitos
- .NET SDK 7 o superior: [Descargar aquí](https://dotnet.microsoft.com/en-us/download/dotnet)  
- Visual Studio Code o Visual Studio  
- Conexión a Internet para clonar el repositorio (opcional)  

---

## Estructura del proyecto
CampañaVacunacion/
│
├─ Program.cs # Archivo principal con la lógica de la campaña
├─ CampañaVacunacion.csproj # Proyecto de C# de consola
└─ README.md # Documentación del proyecto


---

## Explicación del código

### 1. Generación de ciudadanos ficticios
```csharp
HashSet<string> ciudadanos = new HashSet<string>();
for (int i = 1; i <= 500; i++)
    ciudadanos.Add("Ciudadano " + i);

Se crea un conjunto de 500 ciudadanos con nombres ficticios Ciudadano 1 hasta Ciudadano 500.

2. Vacunación aleatoria

Pfizer: 75 ciudadanos aleatorios

AstraZeneca: 75 ciudadanos aleatorios

HashSet<string> pfizer = new HashSet<string>();
HashSet<string> astrazeneca = new HashSet<string>();

Se utiliza Random para asignar las vacunas sin duplicados gracias a HashSet.

3. Operaciones de teoría de conjuntos

Unión: todos los vacunados

Intersección: ciudadanos con ambas dosis

Diferencia: ciudadanos no vacunados y los que tienen solo una vacuna

Ejemplo de intersección:

HashSet<string> ambasDosis = new HashSet<string>(pfizer);
ambasDosis.IntersectWith(astrazeneca);

4. Mostrar resultados

Se imprimen los conteos de cada grupo en la consola:
Console.WriteLine("Ciudadanos que no se han vacunado: " + noVacunados.Count);

Cómo ejecutar el proyecto

Clonar el repositorio:

git clone [ENLACE_DEL_REPOSITORIO>](https://github.com/jhony2025/Conjuntoenc-.git)

Abrir la carpeta en Visual Studio Code o Visual Studio.

Ejecutar el proyecto:

dotnet run

Revisar los resultados en la consola.

Contribuciones

Este proyecto es original y fue desarrollado como práctica académica de estructuras de datos y teoría de conjuntos en C#.

Autor

Johnny Vera
Facultad de Ciencia en Tecnología de la Información
Estudiante de la Universidad Estatal Amazónica
