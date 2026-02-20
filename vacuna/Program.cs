using System;
using System.Collections.Generic;

class CampañaVacunación
{
    static void Main()
    {
        // ================================
        // 1. Generar ciudadanos ficticios
        // ================================
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // ================================
        // 2. Generar ciudadanos vacunados con Pfizer
        // ================================
        HashSet<string> pfizer = new HashSet<string>();
        Random rnd = new Random();
        while (pfizer.Count < 75)
        {
            int n = rnd.Next(1, 501); // Genera número aleatorio entre 1 y 500
            pfizer.Add("Ciudadano " + n); // Se asegura que no haya duplicados
        }

        // ================================
        // 3. Generar ciudadanos vacunados con AstraZeneca
        // ================================
        HashSet<string> astrazeneca = new HashSet<string>();
        while (astrazeneca.Count < 75)
        {
            int n = rnd.Next(1, 501);
            astrazeneca.Add("Ciudadano " + n);
        }

        // ================================
        // 4. Operaciones de teoría de conjuntos
        // ================================

        // 4a. Ciudadanos que han recibido al menos una vacuna
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astrazeneca); // Unión: todos los vacunados

        // 4b. Ciudadanos que no se han vacunado
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados); // Diferencia: ciudadanos - vacunados

        // 4c. Ciudadanos con ambas dosis (Pfizer y AstraZeneca)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca); // Intersección: vacunados en ambos conjuntos

        // 4d. Ciudadanos solo Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca); // Diferencia: Pfizer - AstraZeneca

        // 4e. Ciudadanos solo AstraZeneca
        HashSet<string> soloAstra = new HashSet<string>(astrazeneca);
        soloAstra.ExceptWith(pfizer); // Diferencia: AstraZeneca - Pfizer

        // ================================
        // 5. Mostrar resultados en consola
        // ================================
        Console.WriteLine("=== RESULTADOS CAMPAÑA DE VACUNACIÓN ===\n");
        Console.WriteLine("Ciudadanos que no se han vacunado: " + noVacunados.Count);
        Console.WriteLine("Ciudadanos con ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Ciudadanos solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Ciudadanos solo AstraZeneca: " + soloAstra.Count);

        // ================================
        // 6. Opcional: mostrar listado completo
        // ================================
        /*
        Console.WriteLine("\nListado de ciudadanos que no se han vacunado:");
        foreach (var c in noVacunados)
            Console.WriteLine(c);
        */
    }
}