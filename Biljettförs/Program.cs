using System;
using System.Collections.Generic;
using System.IO;
public class Program
{
    List<ticket> Ticketsales = new List<ticket>();
    
    static void Main()
    {
        Program P = new Program();
        P.intro();
    }
    void intro()
    { 
        Console.WriteLine("Welcome to the ticket sale if you want to see the tickets type 'viewtickets' ");
        while (true)
        {
            string input = Console.ReadLine().ToLower();
            if (input == "viewtickets")
            {
                Console.WriteLine("\nAdult ticket is 100 kr and Adult age is between 18 and 65 \nSenior ticket is 75 kr and a Senior is 65+ years  \nKids ticket is 25 kr and kids counts as 18 years old or younger");
                Console.WriteLine("\nTo search after a special purchase search 'searcha' 'searchs' 'searchk'");
                Console.WriteLine("\nIf you want to see you're purchase type 'receipt' ");
                Console.WriteLine("\nTo buy tickets type buy tickets ");
            }
            else if (input == "buy tickets")
            {
                ticketbuy();
            }
            else if (input == "totalpurchase")
            {
                totalpurchases();
            }
            else if (input == "refund")
            {
                refund();
            }
            else if (input == "receipt")
            {
                receipt();
            }
            else if (input == "searcha")
            {
                searchforadultticket();
            }
            else if (input == "searchs")
            {
                searchforseniorticket();
            }
            else if(input == "searchk")
            {
                searchforkidsticket();
            }
        }
    }

    /*
     * Robin:
     * Jag hade försökt banta ner eller bryta upp ticketbuy metoden så att den inte är så lång. DU hade t.ex. göra
     * valutavärderna till variabler och endast ändrat de om man ville använda en annan valuta. Då hade du sparat
     * kanske 20-40 rader kod.
     */
    public  void ticketbuy()
    {
        ticket T = new ticket();
        Console.WriteLine("Wich currency would you like \n kr \n euro \n rupee ");
        string path = @"..\..\..\R.txt";
        string input = Console.ReadLine().ToLower();
        if (input == "kr")
       {
            int adultsprice = adult();
            int seniorprice = senior();
            int kidsprice = kid();

            T.adultstotal(adultsprice);
            T.seniortotal(seniorprice);
            T.kidstotal(kidsprice);
            int alltickets = adultsprice + seniorprice + kidsprice;
            int allprices = adultsprice * 100 + seniorprice * 75 + kidsprice * 25;


            int numberofiles = System.IO.File.ReadAllLines(path).Length;
            StreamWriter sw = new StreamWriter(path, append: true);
            sw.WriteLine(numberofiles +" A" + adultsprice + "S" + seniorprice + "K" + kidsprice + " total price is " + allprices + "kr");
            Console.WriteLine("The total amounts of tickets are " + alltickets);
            Console.WriteLine("The total cost is " + allprices + "kr");
            Console.WriteLine(adultsprice + " adult tickets " + "that cost " + adultsprice * 100);
            Console.WriteLine(seniorprice + " senior tickets " + "that cost " + seniorprice * 75);
            Console.WriteLine(kidsprice + " kid tickets " + "that cost " + kidsprice * 25);
            Ticketsales.Add(T);
            Console.WriteLine("\nTo see how many purchases you have" + " type 'totalpurchase' ");
            sw.Close();
        }
        else if (input == "euro")
        {
            int adultsprice = adult();
            int seniorprice = senior();
            int kidsprice = kid();
          
            T.adultstotal(adultsprice);
            T.seniortotal(seniorprice);
            T.kidstotal(kidsprice);
            int alltickets = adultsprice + seniorprice + kidsprice;
            int allprices = adultsprice * 9 + seniorprice * 7 + kidsprice * 2;

            int numberoflines = System.IO.File.ReadAllLines(path).Length;
            StreamWriter sw = new StreamWriter(path, append: true);
            sw.WriteLine(numberoflines + " A" + adultsprice + "S" + seniorprice + "K" + kidsprice + " total price is " + allprices + " euro");
            Console.WriteLine("The total amounts of tickets are " + alltickets);
            Console.WriteLine("The total cost is " + allprices + " euro");
            Console.WriteLine(adultsprice + " adult tickets " + "that cost " + adultsprice * 9);
            Console.WriteLine(seniorprice + " senior tickets " + "that cost " + seniorprice * 7);
            Console.WriteLine(kidsprice + " kid tickets " + "that cost " + kidsprice * 2);
            Ticketsales.Add(T);
            Console.WriteLine("\nTo see how many purchases you have" + " type 'totalpurchase' ");
            sw.Close();
        }  
        else if(input == "rupee")
        {
            int adultsprice = adult();
            int seniorprice = senior();
            int kidsprice = kid();
          
            T.adultstotal(adultsprice);
            T.seniortotal(seniorprice);
            T.kidstotal(kidsprice);
            int alltickets = adultsprice + seniorprice + kidsprice;
            int allprices = adultsprice * 750 + seniorprice * 563 + kidsprice * 188;

            int numberofiles = System.IO.File.ReadAllLines(path).Length;
            StreamWriter sw = new StreamWriter(path, append: true);
            sw.WriteLine(numberofiles + " A" + adultsprice + "S" + seniorprice + "K" + kidsprice + " total price is " + allprices + " rupee");
            Console.WriteLine("The total amounts of tickets are " + alltickets);
            Console.WriteLine("The total cost is " + allprices + " rupee");
            Console.WriteLine(adultsprice + " adult tickets " + "that cost " + adultsprice * 750);
            Console.WriteLine(seniorprice + " senior tickets " + "that cost " + seniorprice * 563);
            Console.WriteLine(kidsprice + " kid tickets " + "that cost " + kidsprice * 188);
            Ticketsales.Add(T);
            Console.WriteLine("\nTo see how many purchases you have" + " type 'totalpurchase' ");
            sw.Close();
        }
    }
    void totalpurchases()
    {
        Console.WriteLine(Ticketsales.Count);
    }
    public int adult()
    {
        int adultsprice;
        while (true)
        {
            try
            {
                Console.WriteLine("\nhow many adult tickets do you need?");
                adultsprice = int.Parse(Console.ReadLine());
                if (adultsprice >= 0 & adultsprice <= 100)
                {
                    return adultsprice;
                }
            }
            catch
            {

            }
        }
    }
    public int kid()
    {
        int kidsprice;
        while (true)
        {
            try
            {
                Console.WriteLine("\nhow many kids tickets do you need?");
                kidsprice = int.Parse(Console.ReadLine());

                if (kidsprice >= 0 & kidsprice <= 100)
                {
                    return kidsprice;
                }
            }
            catch
            {

            }
        }
    }
    public int senior()
    {
        int seniorprice;
        while (true)
        {
            try
            {
                Console.WriteLine("\nHow many senior tickets do you need?");
                seniorprice = int.Parse(Console.ReadLine());

                if (seniorprice >= 0 & seniorprice <= 100)
                {
                    return seniorprice;
                }
            }
            catch
            {

            }
        }
    }
    void receipt() 
    {
        if (Ticketsales.Count <= 0)
        {
            Console.WriteLine("You haven't bought any tickets");
        }

        else if (Ticketsales.Count > 0)
        {
            foreach (ticket T in Ticketsales)
            {
                Console.WriteLine("A" + T.atotaltickets + "S" + T.stotaltickets + "K" + T.ktotaltickets);
            }
        }
    }

    /*
     * Robin:
     * I och med att man endast söker efter antal vuxna biljetter så går det inte att göra refunds på köp som är
     * långt ner i filen. Om man har flera köp med t.ex. 2 adult tickets så blir det alltid den första som tas bort.
     */
    public void refund()
    {
        if (Ticketsales.Count <= 0)
        {
                Console.WriteLine("You haven't bought any tickets");
        }
        else if (Ticketsales.Count >= 0)
        {
            bool nofind = false;
            Console.WriteLine("How many adult tickets do you're purchase have?");
            int tickettoremove = int.Parse(Console.ReadLine().ToLower());
            foreach (ticket T in Ticketsales)
            {
                if (tickettoremove == T.atotaltickets )
                {
                    Ticketsales.Remove(T);
                    Console.WriteLine("You have now been refunded");
                    nofind = true;
                    break;
                }
            }
            if (nofind == false)
            {
                Console.WriteLine("No purchase with that many tickets!");
            }
        }
    } 
    void searchforadultticket()
    {
        bool ticket = true;
        Console.WriteLine("how many adult tickets have you bought");
        try
        {
            int adultsprice = int.Parse(Console.ReadLine());
            if (adultsprice >= 0 & adultsprice <= 100)
            {
                foreach (ticket T in Ticketsales)
                {
                    if (adultsprice == T.atotaltickets)
                    {
                        Console.WriteLine("A" + T.atotaltickets + "S" + T.stotaltickets + "K" + T.ktotaltickets);
                        ticket = false;
                    }
                }
                if (ticket == true)
                {
                    Console.WriteLine("There is no purchase with that amount of adults tickets");
                }
            }
        }
        catch
        {

        }
    }
    void searchforseniorticket()
    {
        bool ticket = true;
        Console.WriteLine("how many senior tickets have you bought");
        try
        {
            int seniorprice = int.Parse(Console.ReadLine());
            if (seniorprice >= 0 & seniorprice <= 100)
            {
                foreach (ticket T in Ticketsales)
                {
                    if (seniorprice == T.stotaltickets)
                    {
                        Console.WriteLine("A" + T.atotaltickets + "S" + T.stotaltickets + "K" + T.ktotaltickets);
                        ticket = false;
                    }
                }
                if (ticket == true)
                {
                    Console.WriteLine("There is no purchase with that amount of senior tickets");
                }
            }
        }
        catch
        {

        }
    }
    void searchforkidsticket()
    {
        bool ticket = true;
        Console.WriteLine("how many kids tickets have you bought");
        try
        {
            int kidsprice = int.Parse(Console.ReadLine());
            if (kidsprice >= 0 & kidsprice <= 100)
            {
                foreach (ticket T in Ticketsales)
                {
                    if (kidsprice == T.ktotaltickets)
                    {
                        Console.WriteLine("A" + T.atotaltickets + "S" + T.stotaltickets + "K" + T.ktotaltickets);
                        ticket = false;
                    }
                }
                if (ticket == true)
                {
                    Console.WriteLine("There is no purchase with that amount of kidstickets");
                }
            }
        }
        catch
        {

        }
    }

    /*
     * Robin:
     * Varför tar adultstotal etc. emot ett pris som antal? Visar inte de hur många biljetter som är solda, inte priset?
     */
    class ticket
    {
        public int atotaltickets;
        public int stotaltickets;
        public int ktotaltickets;
        public void adultstotal(int adultsprice )
        {
            atotaltickets = adultsprice;
        }

        public void seniortotal(int seniorprice)
        {
            stotaltickets = seniorprice;
        }

        public void kidstotal(int kidsprice)
        {
            ktotaltickets = kidsprice;
        }
    }
}

/*
 * Robin:
 * Koden är överlag bra namngivet och robust. Hittar inga uppenbara kraschar. Jag skulle föredragit om du använde t.ex. 
 * camelCase och UpperCamelCase för variabler respektive metoder, men det är bara min preferens. 
 * 
 * Det finns ett par ställen där namnen förvirrar mig, så det hade varit värt att gå igenom koden en extra gång för
 * att se över det. 
 * 
 * Refund verkar inte fungera helt som den ska, men det är svårt att säga då jag inte hittar någon kravspec eller rapport.
 * 
 * Bra jobbat och fortsätt så här!
 */