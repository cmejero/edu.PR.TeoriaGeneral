public void borrarCliente(List<ClienteDto> listaAntigua)
{

    string dniBuscar = mi.pedirDni();
    //Objeto específico: se elimina por referencia de memoria no por valores de los campos
    ClienteDto clienteABorrar = new ClienteDto();
    foreach (ClienteDto cliente in listaAntigua)
    {
        if (cliente.DniCliente.Equals(dniBuscar))
        {

            clienteABorrar = cliente;
            break;
        }
    }
    listaAntigua.Remove(clienteABorrar);













    private int mostrarMenuModificacionYSeleccion()
    {
        Console.WriteLine("0. Cerrar menú");
        Console.WriteLine("1. Nombre");
        Console.WriteLine("2. Apellido");
        Console.WriteLine("3. Teléfono");
        Console.WriteLine("4. Email");
        Console.WriteLine("5. Fecha de nacimiento");
        Console.WriteLine("6. Dni");
        Console.WriteLine("¿Qué campo quiere modificar?");
        int opcionUsuario = Convert.ToInt32(Console.ReadLine());
        return opcionUsuario;
    }

    private bool modificarCampoCliente(ClienteDto clienteAModificar, int opcionUsuario)
    {
        bool abrirMenu = true;
        switch (opcionUsuario)
        {
            case 0:
                abrirMenu = false;
                break;
            case 1:
                Console.WriteLine("Escriba nuevo nombre: ");
                clienteAModificar.NombreCliente = Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Escriba nuevo apellido: ");
                clienteAModificar.ApellidosCliente = Console.ReadLine();
                break;
            case 3:
                Console.WriteLine("Escriba nuevo teléfono: ");
                clienteAModificar.TlfCliente = Convert.ToInt32(Console.ReadLine());
                break;
            case 4:
                Console.WriteLine("Escriba nuevo email: ");
                clienteAModificar.EmailCliente = Console.ReadLine();
                break;
            case 5:
                Console.WriteLine("Escriba nuevo fecha nacimiento: ");
                clienteAModificar.FchNacimientoCliente = Console.ReadLine();
                break;
            case 6:
                Console.WriteLine("Escriba nuevo dni: ");
                clienteAModificar.DniCliente = Console.ReadLine();
                break;
            default:
                break;

        }
        return abrirMenu;
    }













    // Creamos una cola de enteros
    Queue<int> numeros = new Queue<int>();

    // Agregamos elementos a la cola
    numeros.Enqueue(10);
    numeros.Enqueue(20);
    numeros.Enqueue(30);

    // Mostramos todos los elementos de la cola
    Console.WriteLine("Elementos en la cola:");
    foreach (var numero in numeros)
    {
        Console.WriteLine(numero);
    }

    // Eliminamos el primer elemento de la cola
    int primerElemento = numeros.Dequeue();
    Console.WriteLine("Se eliminó el primer elemento de la cola: " + primerElemento);

    // Mostramos el nuevo primer elemento de la cola
    Console.WriteLine("Nuevo primer elemento de la cola: " + numeros.Peek());

    // Verificamos si un elemento específico está presente en la cola
    int valorBuscado = 20;
    bool encontrado = numeros.Contains(valorBuscado);
    Console.WriteLine("¿El valor " + valorBuscado + " está presente en la cola? " + encontrado);














    //Hay dos tipos de comparaciones que devuelven:
    //0, iguales; <0, primera fecha mayor; >0 segunda fecha mayor

    DateTime fecha1 = new DateTime(1990, 12, 1);
    DateTime fecha2 = new DateTime(1990, 12, 2);

    int c1 = DateTime.Compare(fecha1, fecha2);
    int c2 = fecha1.CompareTo(fecha2);




    //Formato con toString
    /*Además de lo visto anteriormente con los formatos definidos
     * dentro de la localización/cultura especificada
     * podemos definir nuestro propio formato con especificaciones
     * en el string*/
    DateTime fecha4 = new DateTime(1989, 11, 2, 11, 15, 16, 123);
    fecha4.ToString("yy - MM - ddThh:mm: ss.ms");
    // resultado: 1989-01-11T11:15:16.123









    // leer un archivo
    StreamReader sr = new StreamReader(rutaArchivo);

    string[] lineas = sr.ReadToEnd();

    // El foreach es con string porque el archivo nos devuelve todo en un string
    foreach (string linea in lineas)
    {

        // creamos una array separado por ;
        string[] alum = linea.Split(';');

        // Como sabemos el orden de los datos de los ficheros(ej: id: 17; nombre: carlos ; dni: 30259480J) introduciremos todo a mano
        // hay que convvertir los valores (ej : id a long) ya que son todos string
        alumnosDto alumno = new alumnosDto();
        alumno.id = alum[0];
        alumno.nombre = alum[1];
        alumno.dni = alum[2];

        listaAlumnos.Add(alumno);

    }
    sr.Close(); 





    // escribir en un archivo al cerrar la aplicacion

    StreamWriter st = new StreamWriter(rutaArchivo)

        foreach(alumnoDto alumnos in listaAlumnos)
    {

        string linea = alumnos.id + ';' + alumnos.nombre + ';' + alumnos.dni + ';';
    }
    st.Close();







    try { }
    catch (IOException e)
        {
    Console.WriteLine("Error al leer/escribir el archivo: " + e.Message);
}











    private long autoincrementarID(List<ProductoDto> pedido)
    {
        long nuevoId;
        int tamanioLista = pedido.Count;
        if (tamanioLista > 0)
        {
            nuevoId = pedido[tamanioLista - 1].IdProducto + 1;
        }
        else
        {
            nuevoId = 1;
        }
        return nuevoId;

    }















    //Algoritmo de ordenación: Burbuja

    int[] listaAOrdenar3 = { 9, 7, 8, 5, 4 };

    for (int i = 0; i < listaAOrdenar3.Length - 1; i++)
    {
        for (int j = 0; j < listaAOrdenar3.Length - 1 - i; j++)
        {
            if (listaAOrdenar3[j] > listaAOrdenar3[j + 1])
            {
                int aux = listaAOrdenar3[j];
                listaAOrdenar3[j] = listaAOrdenar3[j + 1];
                listaAOrdenar3[j + 1] = aux;
            }
        }
    }