using System;

class Program
{
    static void Main()
    {
        Console.Title = "Equilibrio o Caos: Pensamiento Sistemico";

        int conocimiento = 25;
        int dinero = 60;
        int energia = 80;
        int estres = 15;

        Random random = new Random();

        Console.WriteLine("#############################################");
        Console.WriteLine("#             EQUILIBRIO O CAOS             #");
        Console.WriteLine("#      Leonardo Carvajal - Keiner Rios      #");
        Console.WriteLine("#############################################\n");

        Console.Write("¿Cual es tu nombre, estudiante?: ");
        string nombre = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Bienvenido, " + nombre + ". Estas por comenzar una semana crucial.");
        Console.WriteLine("En este mundo, nada ocurre de forma aislada. Una noche de fiesta");
        Console.WriteLine("te dara energia social, pero vaciara tu billetera y nublara tus");
        Console.WriteLine("estudios. Si tu energia llega a 0 o el estres a 100, habras fallado.");
        Console.WriteLine("\nTu mision: Mantener el sistema en marcha sin que colapse.");
        Console.WriteLine("\nPresiona ENTER para vivir el lunes...");
        Console.ReadLine();

        for (int dia = 1; dia <= 7; dia++)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("CAPITULO " + dia + ": El transcurso de la semana");
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("ESTADO ACTUAL DE " + nombre.ToUpper() + ":");
            Console.WriteLine("Conocimiento: " + conocimiento + " | Energia: " + energia);
            Console.WriteLine("Dinero: " + dinero + " | Estres: " + estres);
            Console.WriteLine("---------------------------------------------------------\n");

            int op = 0;

            if (dia == 1)
            {
                Console.WriteLine("LUNES: Suena la alarma y el cuerpo pesa. Un amigo te escribe:");
                Console.WriteLine("'No entres a clase, vamos a desayunar y a perder el tiempo'.");
                Console.WriteLine("1. Ignorar la tentacion y entrar a clase (Sientes que aprendes, pero te agotas)");
                Console.WriteLine("2. Aceptar la invitacion (Te relajas, pero el bolsillo y la mente lo sufren)");
                Console.WriteLine("3. Ir a la biblioteca por tu cuenta (Maximo enfoque, maximo cansancio)");
                op = LeerOpcion(3);

                if (op == 1) { conocimiento += 12; energia -= 10; estres += 5; }
                else if (op == 2) { energia += 15; dinero -= 15; conocimiento -= 8; estres -= 10; }
                else if (op == 3) { conocimiento += 20; energia -= 20; estres += 5; }
            }
            else if (dia == 3)
            {
                Console.WriteLine("MIERCOLES: El profesor asigna un proyecto grupal que vale el 40%.");
                Console.WriteLine("Tus compañeros parecen estar perdidos y alguien debe tomar el mando.");
                Console.WriteLine("1. Liderar y hacer la mayor parte (Dominas el tema, pero el estres sube)");
                Console.WriteLine("2. Esperar a que el grupo reaccione (Ahorras energia, pero la duda te estresa)");
                Console.WriteLine("3. Comprar materiales y libros para ayudar (Inviertes dinero para aprender mas)");
                op = LeerOpcion(3);

                if (op == 1) { conocimiento += 20; estres += 15; energia -= 20; }
                else if (op == 2) { estres += 20; conocimiento -= 5; }
                else if (op == 3) { dinero -= 30; conocimiento += 10; estres -= 5; }
            }
            else if (dia == 5)
            {
                Console.WriteLine("VIERNES: El cansancio acumulado se nota. Un local cercano te ofrece");
                Console.WriteLine("trabajar solo por hoy cubriendo un turno de emergencia.");
                Console.WriteLine("1. Aceptar el turno (Necesitas el dinero, aunque termines exhausto)");
                Console.WriteLine("2. Quedarte estudiando (El examen final se acerca y no te sientes listo)");
                Console.WriteLine("3. Dormir toda la tarde (Tu cuerpo necesita recuperar energia)");
                op = LeerOpcion(3);

                if (op == 1) { dinero += 40; energia -= 25; estres += 10; }
                else if (op == 2) { conocimiento += 15; estres += 10; }
                else if (op == 3) { energia += 20; estres -= 15; }
            }
            else if (dia == 7)
            {
                Console.WriteLine("DOMINGO: El momento de la verdad. El examen final esta frente a ti.");
                Console.WriteLine("La hoja esta llena de preguntas que desafian tu capacidad.");
                Console.WriteLine("1. Concentrarte al maximo (Usas toda tu energia para aprobar)");
                Console.WriteLine("2. Intentar sacar notas ocultas (El miedo a que te atrapen dispara tu estres)");
                Console.WriteLine("3. Entregar en blanco por agotamiento (Te liberas del estres, pero fracasas)");
                op = LeerOpcion(3);

                if (op == 1) { conocimiento += 25; estres += 20; energia -= 20; }
                else if (op == 2) { estres += 40; conocimiento -= 10; }
                else if (op == 3) { conocimiento -= 40; estres -= 20; }
            }
            else
            {
                GenerarEventoAleatorio(ref conocimiento, ref dinero, ref energia, ref estres, random);
            }

            if (energia > 100) energia = 100;
            if (estres < 0) estres = 0;

            Console.WriteLine("\n>> LOS RESULTADOS DEL DIA SON LOS SIGUIENTES:");
            Console.WriteLine("Despues de tus acciones, terminas con:");
            Console.WriteLine("Conocimiento: " + conocimiento + ", Dinero: " + dinero + ", Energia: " + energia + ", Estres: " + estres);

            if (energia <= 0 || estres >= 100)
            {
                Console.WriteLine("\n--- EL SISTEMA HA COLAPSADO ---");
                Console.WriteLine(energia <= 0 ? "Tu cuerpo no dio mas y terminaste en el hospital." : "La ansiedad te supero y perdiste el control de la semana.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\nPresiona ENTER para avanzar en la historia...");
            Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("=========================================================");
        Console.WriteLine("                 BALANCE FINAL DE LA HISTORIA            ");
        Console.WriteLine("=========================================================\n");

        if (conocimiento >= 60 && estres < 50)
        {
            Console.WriteLine("FINAL: EXITO SISTEMICO. Lograste navegar la tormenta con sabiduria.");
        }
        else if (conocimiento >= 40)
        {
            Console.WriteLine("FINAL: SUPERVIVENCIA. Sobreviviste a la semana, pero con cicatrices.");
        }
        else
        {
            Console.WriteLine("FINAL: FRACASO OPERATIVO. El sistema se mantuvo vivo, pero no cumplio su meta.");
        }

        Console.WriteLine("\n¿POR QUE ESTO ES PENSAMIENTO SISTEMICO?");
        Console.WriteLine("Este juego es una representacion simplificada de un sistema complejo.");
        Console.WriteLine("La relacion con el pensamiento sistemico se basa en tres pilares:");
        Console.WriteLine("1. Interconexion: Nada ocurre de forma aislada. Si decides trabajar por");
        Console.WriteLine("   dinero, estas afectando indirectamente tu capacidad de estudio y tu salud.");
        Console.WriteLine("2. Retroalimentacion: Tus decisiones de hoy crean el escenario de mañana.");
        Console.WriteLine("   Si acumulas estres hoy, el sistema se vuelve mas fragil para el futuro.");
        Console.WriteLine("3. Equilibrio Dinamico: No puedes ganar maximizando solo una variable.");
        Console.WriteLine("   Si solo buscas conocimiento, la energia se agota y el sistema muere.");
        Console.WriteLine("   El exito real es entender como fluye la energia entre todas las partes.");

        Console.ReadLine();
    }

    static int LeerOpcion(int max)
    {
        int op;
        Console.Write("\n¿Que decides hacer? (1-" + max + "): ");
        while (!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > max)
        {
            Console.Write("Opcion no valida. Piensa bien tu respuesta: ");
        }
        return op;
    }

    static void GenerarEventoAleatorio(ref int c, ref int d, ref int en, ref int es, Random r)
    {
        int ev = r.Next(1, 3);
        Console.WriteLine("SITUACION INESPERADA:");
        if (ev == 1)
        {
            Console.WriteLine("Tu computadora empieza a fallar y emite un ruido extraño.");
            Console.WriteLine("1. Llevarla al tecnico de inmediato (Sacas dinero que no tenias previsto)");
            Console.WriteLine("2. Intentar arreglarla tu mismo (Pierdes horas de estudio y te frustras)");
            int op = LeerOpcion(2);
            if (op == 1) { d -= 25; es += 10; } else { c -= 15; es += 5; }
        }
        else
        {
            Console.WriteLine("Un familiar te visita y decide invitarte a comer para distraerte.");
            Console.WriteLine("1. Aceptar y disfrutar el momento (Recuperas energia y bajas el estres)");
            Console.WriteLine("2. Decir que no puedes porque debes leer (Aumentas conocimiento pero te cansas)");
            int op = LeerOpcion(2);
            if (op == 1) { en += 15; es -= 10; d += 5; } else { c += 10; es += 10; }
        }
    }
}