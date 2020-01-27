using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Program
{
    List<ticket> Ticketsales = new List<ticket>();
    ticket T = new ticket();
    static void Main()
    {
        Program P = new Program();
        P.intro();
    }
    void intro()
    { 
        Console.WriteLine("Welcome to the ticket sale if you want to see the tickets type 'vt ");
        while (true)
        {
            string input = Console.ReadLine().ToLower();
            if (input == "vt")
            {
                Console.WriteLine("\nAdult ticket is 100 kr and Adult age is between 18 and 65 \nSenior ticket is 75 kr and a Senior is 65+ years  \nKids ticket is 25 kr and kids counts as 18 years old or younger");
                Console.WriteLine("\nTo buy tickets type bt ");            
            }
            else if (input == "bt")
            {
                listtickets();
            }
            else if(input == "tp")
            {
                totalpurchases();
            }
            else if(input == "refund")
            {
                refund();
            }
            else if(input == "receipt")
            {
                receipt();
            }
        }
    }
    public void listtickets()
    {
        Console.WriteLine("Wich currency would you like \n kr \n euro \n rupee ");
        string path = @"C:\Users\otto.svenbergfylkeg.CND8261PKR\Desktop\R.txt";
       
        string input = Console.ReadLine().ToLower();
       if (input == "kr")
       {
            int adultsprice = adult();
            int seniorprice = senior();
            int kidsprice = kid();

            StreamWriter sw = new StreamWriter(path);
            T.adultstotal(adultsprice);
            T.seniortotal(seniorprice);
            T.kidstotal(kidsprice);
            int alltickets = adultsprice + seniorprice + kidsprice;
            int allprices = adultsprice * 100 + seniorprice * 75 + kidsprice * 25;

            {
                sw.WriteLine("The total amounts of tickets are " + alltickets);
                sw.WriteLine("The total cost is " + allprices + "kr");
                sw.WriteLine(adultsprice + " adult tickets " + "that cost " + adultsprice * 100);
                sw.WriteLine(seniorprice + "\n" + " senior tickets " + "that cost " + seniorprice * 75);
                sw.WriteLine(kidsprice + " kid tickets " + "that cost " + kidsprice * 25 );

                Ticketsales.Add(T);
                Console.WriteLine("\nTo see how many purchases you have" + " type 'tp' ");
                sw.Close();
            }
        }
        else if (input == "euro")
        {
            int adultsprice = adult();
            int seniorprice = senior();
            int kidsprice = kid();
            StreamWriter sw = new StreamWriter(path);
            T.adultstotal(adultsprice);
            T.seniortotal(seniorprice);
            T.kidstotal(kidsprice);
            int alltickets = adultsprice + seniorprice + kidsprice;
            int allprices = adultsprice * 9 + seniorprice * 7 + kidsprice * 2;

            sw.WriteLine("The total amounts of tickets are " + alltickets);
            sw.WriteLine("The total cost is " + allprices + "euro");
            sw.WriteLine(adultsprice + " adult tickets " + "that cost " + adultsprice * 9);
            sw.WriteLine(seniorprice + "\n" + " senior tickets " + "that cost " + seniorprice * 7);
            sw.WriteLine(kidsprice + " kid tickets " + "that cost " + kidsprice * 2);

            Ticketsales.Add(T);
            Console.WriteLine("\nTo see how many purchases you have" + " type 'tp' ");
            sw.Close();
        }  
        else if(input == "rupee")
        {
            int adultsprice = adult();
            int seniorprice = senior();
            int kidsprice = kid();
            StreamWriter sw = new StreamWriter(path);
            T.adultstotal(adultsprice);
            T.seniortotal(seniorprice);
            T.kidstotal(kidsprice);
            int alltickets = adultsprice + seniorprice + kidsprice;
            int allprices = adultsprice * 750 + seniorprice * 563 + kidsprice * 188;

            sw.WriteLine("The total amounts of tickets are " + alltickets);
            sw.WriteLine("The total cost is " + allprices + "rupee");
            sw.WriteLine(adultsprice + " adult tickets " + "that cost " + adultsprice * 750);
            sw.WriteLine(seniorprice + "\n" + " senior tickets " + "that cost " + seniorprice * 563);
            sw.WriteLine(kidsprice + " kid tickets " + "that cost " + kidsprice * 188);

            Ticketsales.Add(T);
            Console.WriteLine("\nTo see how many purchases you have" + " type 'tp' ");
            sw.Close();
        }
    }
    public void totalpurchases()
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
            foreach(ticket T in Ticketsales)
            {
              
            }
        }
    }
    void refund()
    {
            if (Ticketsales.Count <= 0)
            {
                Console.WriteLine("You haven't bought any tickets");
            }
            else if (Ticketsales.Count >= 0)
            {
                Ticketsales.Remove(T);
                Console.WriteLine("You have now been refunded");
            }
    }
    public class ticket
    {
        public int totaltickets;

        public void adultstotal(int adultsprice )
        {
            totaltickets = adultsprice;
        }

        public void seniortotal(int seniorprice)
        {
            totaltickets = seniorprice;
        }

        public void kidstotal(int kidsprice)
        {
            totaltickets = kidsprice;
        }
    }
}