// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;
bool run = true;
while (run)
{
    Console.WriteLine("==============Cab Invoice==============");
    Console.WriteLine("Select option: \n1.Calculate fare \n2.Multiple Rides");
    int op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            //Step 1-CalculateFare-NormalRide
            InvoiceGenerator invoice = new InvoiceGenerator();
            double fare = invoice.CalculateFare(3.0, 5);
            Console.WriteLine("Calculate Fare: {0}", fare);
            break;
        case 2:
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            MultipleRides[] rides = { new MultipleRides(3.0, 5), new MultipleRides(5, 10) };
            double totalfare = invoiceGenerator.CalculateFare(rides);            
            System.Console.WriteLine("Toatal Fare:" + totalfare);
            break;
        case 3:        
            InvoiceGenerator uc3 = new InvoiceGenerator();
            MultipleRides[] rides1 = { new MultipleRides(10, 20), new MultipleRides(15, 25), new MultipleRides(20, 30) };
            double Fare2 = uc3.CalculateFare(rides1);

            int NumOfRides = 3;
            double AverageFare = Fare2 / NumOfRides;

            Console.WriteLine("Total Number of Rides : " + NumOfRides);
            Console.WriteLine("The Aggregate Fare Value for All Rides :" + Fare2);
            Console.WriteLine("Average Fare per Ride :" + AverageFare + "\n");
            break;
        default:
            Console.WriteLine("Please choose the above Options only");
            break;
    }
}


