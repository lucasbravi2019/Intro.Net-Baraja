using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Baraja
{
    private List<Carta> cardList = new List<Carta>();
    private List<Carta> monton = new List<Carta>();

    public List<Carta> CardList { get => cardList; set => cardList = value; }
    public List<Carta> Monton { get => monton; set => cardList = value; }
    public Baraja()
    {
        for (int i = 1; i <= 12; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (i == 8 || i == 9) break;

                string palo = "";

                if (j == 1) palo = "Espada";
                if (j == 2) palo = "Oro";
                if (j == 3) palo = "Basto";
                if (j == 4) palo = "Copa";

                this.CardList.Add(new Carta(number: i, palo: palo));
            }
        }
    }

    override
    public string ToString()
    {
        string baraja = "[\n";
        int index = 0;
        foreach (Carta carta in this.CardList)
        {
            if (index == 39)
            {
                baraja += carta + "\n";
            }
            else
            {
                baraja += carta + ",\n";
            }
            index++;
        }
        baraja += "\n]";
        return baraja;
    }

    public void Barajar()
    {
        this.CardList = this.CardList.OrderBy(card => Guid.NewGuid()).ToList();
    }

    public Carta SiguienteCarta()
    {
        if (this.CardList.Any())
        {
            Carta carta = this.CardList.First();
            this.cardList.Remove(carta);
            this.monton.Add(carta);
            return carta;
        } 
        else
        {
            Console.WriteLine("Llego al final");
            return null;
        }
    }

    public int CartasDisponibles()
    {
        return this.CardList.Count();
    }

    public List<Carta> DarCartas(int cantidad)
    {
        List<Carta> cartas = new List<Carta>();
        for (int i = 0; i < cantidad; i++)
        {
            Carta carta = this.SiguienteCarta();
            if (carta == null)
            {
                Console.WriteLine("No habian suficientes cartas");
                break;
            }
            cartas.Add(carta);
        }

        return cartas;
    }

    public List<Carta> CartasMonton()
    {
        return this.Monton;
    }

    public void MostrarBaraja()
    {
        if (CardList.Count == 0) Console.WriteLine("La baraja no tiene cartas");
        else Console.WriteLine(this.ToString());
    }

}

