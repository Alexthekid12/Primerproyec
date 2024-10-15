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
            Console.Write("Selecciona una opción: ");
            opcionValida = int.TryParse(Console.ReadLine(), out opcion);

            if (opcionValida && opcion >= 1 && opcion <= opciones.Length)
            {
                respuesta = opciones[opcion - 1];
            }
            else
            {
                Console.WriteLine("Opción no válida. Selecciona de nuevo.");
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
        Console.WriteLine("Estimado(a) estudiante, tu opinión es muy importante para nosotros.\n");

        
        Console.WriteLine("Sección 1: Información General");
        string[] carreras = { "Arquitectura", "Ingeniería en Sistemas Computacionales", "Turismo", "Contador Publico", "Otras" };
        MostrarOpciones("¿En qué carrera estás inscrito(a)?", carreras, out carrera);

        string[] semestres = { "1° a 2°", "3° a 4°", "5° a 6°", "7° a 8°", "9° o más" };
        MostrarOpciones("¿En qué semestre te encuentras?", semestres, out semestre);

        
        Console.WriteLine("\nSección 2: Satisfacción Académica");
        string[] calidades = { "Muy satisfactoria", "Satisfactoria", "Regular", "Insatisfactoria", "Muy insatisfactoria" };
        MostrarOpciones("¿Cómo evalúas la calidad de la enseñanza impartida por los profesores?", calidades, out calidadProfesores);

        string[] recursos = { "Totalmente", "Parcialmente", "Poco", "No cumplen" };
        MostrarOpciones("¿Los recursos de aprendizaje (bibliotecas, plataformas digitales, laboratorios) cumplen tus expectativas?", recursos, out recursosAprendizaje);

        string[] contenidos = { "Sí", "En algunos casos", "No" };
        MostrarOpciones("¿Consideras que el contenido de los cursos está actualizado y es relevante para tu carrera?", contenidos, out contenidoCursos);

        
        Console.WriteLine("\nSección 3: Servicios Administrativos");
        string[] atencion = { "Excelente", "Buena", "Regular", "Mala" };
        MostrarOpciones("¿Cómo calificas la atención en los servicios administrativos (matrícula, becas, secretaría)?", atencion, out atencionServicios);

        string[] dificultades = { "Nunca", "Alguna vez", "Frecuentemente" };
        MostrarOpciones("¿Has tenido alguna dificultad con el proceso de inscripción o matrícula?", dificultades, out dificultadesInscripcion);

        string[] accesibilidad = { "Muy accesibles", "Accesibles", "Poco accesibles", "No accesibles" };
        MostrarOpciones("¿Qué tan accesibles te resultan los servicios de soporte (tecnología, consultas académicas)?", accesibilidad, out accesibilidadSoporte);

        
        Console.WriteLine("\nSección 4: Infraestructura y Ambiente Universitario");
        string[] estado = { "Excelente", "Buena", "Regular", "Deficiente" };
        MostrarOpciones("¿Cómo valoras el estado de las instalaciones (aulas, laboratorios, áreas comunes)?", estado, out estadoInstalaciones);

        string[] seguridadOpciones = { "Sí, completamente", "A veces", "No" };
        MostrarOpciones("¿Te sientes seguro(a) en las instalaciones de la universidad?", seguridadOpciones, out seguridad);

        string[] ambiente = { "Excelente", "Bueno", "Regular", "Deficiente" };
        MostrarOpciones("¿Cómo calificarías el ambiente estudiantil en términos de apoyo, integración y convivencia?", ambiente, out ambienteEstudiantil);

        Console.WriteLine("\nSección 5: Comentarios Finales");
        Console.Write("¿Qué sugerencias tienes para mejorar los servicios o el ambiente en la universidad?\n");
        sugerencias = Console.ReadLine();

        Console.Write("¿Hay algún aspecto en particular que te gustaría que la universidad mejorara?\n");
        aspectosAMejorar = Console.ReadLine();


        Console.WriteLine("\nGracias por completar la encuesta. Estas fueron tus respuestas:");
        Console.WriteLine($"Carrera: {carrera}");
        Console.WriteLine($"Semestre: {semestre}");
        Console.WriteLine($"Calidad de los profesores: {calidadProfesores}");
        Console.WriteLine($"Recursos de aprendizaje: {recursosAprendizaje}");
        Console.WriteLine($"Contenido de los cursos: {contenidoCursos}");
        Console.WriteLine($"Atención de servicios: {atencionServicios}");
        Console.WriteLine($"Dificultades de inscripción: {dificultadesInscripcion}");
        Console.WriteLine($"Accesibilidad de soporte: {accesibilidadSoporte}");
        Console.WriteLine($"Estado de instalaciones: {estadoInstalaciones}");
        Console.WriteLine($"Seguridad: {seguridad}");
        Console.WriteLine($"Ambiente estudiantil: {ambienteEstudiantil}");
        Console.WriteLine($"Sugerencias: {sugerencias}");
        Console.WriteLine($"Aspectos a mejorar: {aspectosAMejorar}");
    }
}