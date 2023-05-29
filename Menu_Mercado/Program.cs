using System;

public class Menu_Mercado
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        //Se declara variable.
        String read;

        //Opciones por letra.
        Console.WriteLine(" --------------- Aplicación de Notas ---------------");
        Console.WriteLine("A: Salchichon - Leche - Yogurt - Bebida Energizante ");
        Console.WriteLine("B: Zanahoria - Remolahacha - Berenjena - Pepino ");
        Console.WriteLine("C: Papel Higienico - Accesorios de Higiene - Pasta de Dientes - Limpieza para Baño");

        //Que seleccione la opcion mientras el ReadLine está en pantalla de carga y coge el dato.
        Console.WriteLine("Elige una opción: ");
        read = Console.ReadLine();

        //Coge el dato read y lo pasa por alguno de los casos y finaliza mostrando en pantalla según la letra seleccionada.
        switch (read)
        {
            case "A":
                Console.WriteLine("Anotaste: Salchichon - Leche - Yogurt - Bebida Energizante ");
                break;
            case "B":
                Console.WriteLine("Anostaste: Zanahoria - Remolahacha - Berenjena - Pepino ");
                break;
            case "C":
                Console.WriteLine("Anostaste: Papel Higienico - Accesorios de Higiene - Pasta de Dientes - Limpieza para Baño");
                break;
        }

        Console.ReadKey();

    }
}