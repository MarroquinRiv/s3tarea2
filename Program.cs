using System.Reflection;

byte edad;
byte respuesta;
Boolean permiso;

Console.WriteLine("Hola. ¿Cuál es tu edad?\n");
edad = (byte)Convert.ToInt32(Console.ReadLine());

try
{
    if (edad >= 16 && edad < 18)
    {
        Console.WriteLine("\n¿Tienes el permiso de tus padres?\n1. SÍ\n2. NO\n");
        respuesta = (byte)Convert.ToInt32(Console.ReadLine());

        switch (respuesta)
        {
            case 1:
                permiso = true;
                Console.WriteLine("\nPuedes tener una licencia.");
                break;

            case 2:
                permiso = false;
                Console.WriteLine("\nSigue insistiéndole a tus padres.");
                break;

            default:
                Console.WriteLine("\nUps, ingresa el número 1 o 2 para dar tu respuesta. ¡Gracias!");
                break;
        }
    }
    else if (edad >= 18)
    {
        Console.WriteLine("\nPuedes tener una licencia.");
    }
    else
    {
        Console.WriteLine("\nNo puedes tener una licencia.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\n¡No es posible! Ingresa una edad válida.");
    Console.Write("La exepción es: " + ex.Message);
}