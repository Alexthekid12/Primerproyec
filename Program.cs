using System;

class Program
{
  
    static void MostrarOpciones(string pregunta, string[] opciones, out string respuesta)
    {
        Console.WriteLine(pregunta);
        for (int i = 0; i < opciones.Length; ++i)
        {
            Console.WriteLine($"{i + 1}. {opciones[i]}");
        }

        int opcion;
        bool opcionValida;
        respuesta = "";
        do { }
        {
            Console.Write("Selecciona una opci�n: ");
            opcionValida = int.TryParse(Console.ReadLine(), out opcion);

            if (opcionValida && opcion >= 1 && opcion <= opciones.Length)
            {
                respuesta = opciones[opcion - 1];
            }
            else
            {
                Console.WriteLine("Opci�n no v�lida. Selecciona de nuevo.");
                opcionValida = false;
            }

        } while (!opcionValida);
    }

    static void Main(string[] args)
    {
        string carrera, semestre, calidadProfesores, recursosAprendizaje, contenidoCursos;
        string atencionServicios, dificultadesInscripcion, accesibilidadSoporte;
        string estadoInstalaciones, seguridad, ambienteEstudiantil;
        string sugerencias, aspectosAMejorar;

        Console.WriteLine("Encuesta Universitaria");
        Console.WriteLine("Estimado(a) estudiante, tu opini�n es muy importante para nosotros.\n");

        
        Console.WriteLine("Secci�n 1: Informaci�n General");
        string[] carreras = { "Arquitectura", "Ingenier�a en Sistemas Computacionales", "Turismo", "Contador Publico", "Otras" };
        MostrarOpciones("�En qu� carrera est�s inscrito(a)?", carreras, out carrera);

        string[] semestres = { "1� a 2�", "3� a 4�", "5� a 6�", "7� a 8�", "9� o m�s" };
        MostrarOpciones("�En qu� semestre te encuentras?", semestres, out semestre);

        
        Console.WriteLine("\nSecci�n 2: Satisfacci�n Acad�mica");
        string[] calidades = { "Muy satisfactoria", "Satisfactoria", "Regular", "Insatisfactoria", "Muy insatisfactoria" };
        MostrarOpciones("�C�mo eval�as la calidad de la ense�anza impartida por los profesores?", calidades, out calidadProfesores);

        string[] recursos = { "Totalmente", "Parcialmente", "Poco", "No cumplen" };
        MostrarOpciones("�Los recursos de aprendizaje (bibliotecas, plataformas digitales, laboratorios) cumplen tus expectativas?", recursos, out recursosAprendizaje);

        string[] contenidos = { "S�", "En algunos casos", "No" };
        MostrarOpciones("�Consideras que el contenido de los cursos est� actualizado y es relevante para tu carrera?", contenidos, out contenidoCursos);

        
        Console.WriteLine("\nSecci�n 3: Servicios Administrativos");
        string[] atencion = { "Excelente", "Buena", "Regular", "Mala" };
        MostrarOpciones("�C�mo calificas la atenci�n en los servicios administrativos (matr�cula, becas, secretar�a)?", atencion, out atencionServicios);

        string[] dificultades = { "Nunca", "Alguna vez", "Frecuentemente" };
        MostrarOpciones("�Has tenido alguna dificultad con el proceso de inscripci�n o matr�cula?", dificultades, out dificultadesInscripcion);

        string[] accesibilidad = { "Muy accesibles", "Accesibles", "Poco accesibles", "No accesibles" };
        MostrarOpciones("�Qu� tan accesibles te resultan los servicios de soporte (tecnolog�a, consultas acad�micas)?", accesibilidad, out accesibilidadSoporte);

        
        Console.WriteLine("\nSecci�n 4: Infraestructura y Ambiente Universitario");
        string[] estado = { "Excelente", "Buena", "Regular", "Deficiente" };
        MostrarOpciones("�C�mo valoras el estado de las instalaciones (aulas, laboratorios, �reas comunes)?", estado, out estadoInstalaciones);

        string[] seguridadOpciones = { "S�, completamente", "A veces", "No" };
        MostrarOpciones("�Te sientes seguro(a) en las instalaciones de la universidad?", seguridadOpciones, out seguridad);

        string[] ambiente = { "Excelente", "Bueno", "Regular", "Deficiente" };
        MostrarOpciones("�C�mo calificar�as el ambiente estudiantil en t�rminos de apoyo, integraci�n y convivencia?", ambiente, out ambienteEstudiantil);

        Console.WriteLine("\nSecci�n 5: Comentarios Finales");
        Console.Write("�Qu� sugerencias tienes para mejorar los servicios o el ambiente en la universidad?\n");
        sugerencias = Console.ReadLine();

        Console.Write("�Hay alg�n aspecto en particular que te gustar�a que la universidad mejorara?\n");
        aspectosAMejorar = Console.ReadLine();


        Console.WriteLine("\nGracias por completar la encuesta. Estas fueron tus respuestas:");
        Console.WriteLine($"Carrera: {carrera}");
        Console.WriteLine($"Semestre: {semestre}");
        Console.WriteLine($"Calidad de los profesores: {calidadProfesores}");
        Console.WriteLine($"Recursos de aprendizaje: {recursosAprendizaje}");
        Console.WriteLine($"Contenido de los cursos: {contenidoCursos}");
        Console.WriteLine($"Atenci�n de servicios: {atencionServicios}");
        Console.WriteLine($"Dificultades de inscripci�n: {dificultadesInscripcion}");
        Console.WriteLine($"Accesibilidad de soporte: {accesibilidadSoporte}");
        Console.WriteLine($"Estado de instalaciones: {estadoInstalaciones}");
        Console.WriteLine($"Seguridad: {seguridad}");
        Console.WriteLine($"Ambiente estudiantil: {ambienteEstudiantil}");
        Console.WriteLine($"Sugerencias: {sugerencias}");
        Console.WriteLine($"Aspectos a mejorar: {aspectosAMejorar}");
    }
}