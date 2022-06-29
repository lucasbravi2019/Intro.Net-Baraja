Baraja baraja = new Baraja();
int opcion = 0;
while (opcion != 7)
{
    MostrarMenu();
    try
    {
        opcion = int.Parse(Console.ReadLine());
        if (opcion > 7 || opcion < 1) throw new Exception();
        EscogerOperacion(opcion);
    }
    catch (Exception)
    {
        Console.WriteLine("Especifico un valor invalido");
    }
    
}

void EscogerOperacion(int operacion)
{
    switch (operacion)
    {
        case 1: OpcionUno();
            break;
        case 2: OpcionDos();
            break;
        case 3: OpcionTres();
            break;
        case 4: OpcionCuatro();
            break;
        case 5: OpcionCinco();
            break;
        case 6: OpcionSeis();
            break;
        case 7: OpcionSiete();
            break;
        default: throw new Exception("Ocurrio un error");
    }
}

void OpcionUno()
{
    baraja.Barajar();
}

void OpcionDos()
{
    Console.WriteLine(baraja.SiguienteCarta());
}

void OpcionTres()
{
    Console.WriteLine($"Cartas disponibles: {baraja.CartasDisponibles()}");
}

void OpcionCuatro()
{
    try
    {
        Console.WriteLine("Cuantas cartas desea dar?");
        int cantidadCartas = int.Parse(Console.ReadLine());
        if (cantidadCartas > 40 || cantidadCartas < 1) throw new Exception();
        baraja.DarCartas(cantidadCartas).ForEach(carta => Console.WriteLine(carta));
    }
    catch (Exception)
    {
        Console.WriteLine("Especifico un valor invalido");
        OpcionCuatro();
    }
}

void OpcionCinco()
{
    baraja.CartasMonton().ForEach(carta => Console.WriteLine(carta));
}

void OpcionSeis()
{
    baraja.MostrarBaraja();
}

void OpcionSiete()
{
    Console.WriteLine("Programa finalizado");
}

void MostrarMenu()
{
    Console.WriteLine("\n***************************************");
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("1. Barajar");
    Console.WriteLine("2. Mostrar siguiente carta");
    Console.WriteLine("3. Mostrar cartas disponibles");
    Console.WriteLine("4. Dar cartas");
    Console.WriteLine("5. Mostrar cartas del monton");
    Console.WriteLine("6. Mostrar baraja");
    Console.WriteLine("7. Salir");
    Console.WriteLine("***************************************");
}
