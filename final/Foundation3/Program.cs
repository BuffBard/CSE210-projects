using System;

class Program
{
    static void Main(string[] args)
    {
        List<Address> addresses = [
            new Address("321 E 3rd S","El Paso","TX","USA"),
            new Address("4th and Elm","Calidor","Calamine","Phyrexia"),
            new Address("Dusty Creek", "Nowhere","NV","USA")
        ];
        Reception reception=new("Recpetion","Wedding","There will be cake","12-21-2024","11:30am",addresses[1],"fantasticweddings@phyreximail.com");
        OutdoorGathering ourtdoorGathering=new("Outdoor Gathering","Glamping","Camping but without the Camp or the -ing","Tomorrow","~4:00pm",addresses[2],"Duststorm");
        Lecture lecture=new("Lecture","Physics and How to Apply Them","We do Physics","12th November, 1991","22:00",addresses[1],"Elresh Norn",200);

        System.Console.WriteLine(reception.FullDetails());
        System.Console.WriteLine(reception.StandardDetails());
        System.Console.WriteLine(reception.ShortDetails());
        System.Console.WriteLine(ourtdoorGathering.FullDetails());
        System.Console.WriteLine(ourtdoorGathering.StandardDetails());
        System.Console.WriteLine(ourtdoorGathering.ShortDetails());
        System.Console.WriteLine(lecture.FullDetails());
        System.Console.WriteLine(lecture.StandardDetails());
        System.Console.WriteLine(lecture.ShortDetails());

    }
}