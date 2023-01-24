using ExerciseOne.Models;

namespace ExerciseOne {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("==========================================");
            Console.WriteLine("Creating 2 SimCard objects");
            Console.WriteLine("Sim1: PhoneNumber - 12345678910, Network - Globe");
            Console.WriteLine("Sim2: PhoneNumber - 23456789101, Network - Smart");
            SimCard sc1 = new SimCard("12345678910", "Globe");
            SimCard sc2 = new SimCard("23456789101", "Smart");

            Console.WriteLine("==========================================");
            Console.WriteLine("Creating 2 MobilePhone objects");
            Console.WriteLine("MobilePhone1: Brand - Samsung, Color - White, Model - Galaxy S50, SimCard - Sim1");
            Console.WriteLine("MobilePhone2: Brand - Iphone, Color - White, Model - 11 Pro, SimCard - Sim2");
            MobilePhone mp1 = new MobilePhone("Samsung", "White", "Galaxy S50", sc1);
            MobilePhone mp2 = new MobilePhone("Iphone", "White", "11 Pro", sc2);

            Console.WriteLine("==========================================");
            Console.WriteLine("Creating 2 SmartPhone objects");
            Console.WriteLine("SmartPhone1: Brand - Iphone, Color - Black, Model - 12 Mini, SimCard - Sim1, Browser - Safari");
            Console.WriteLine("SmartPhone2: Brand - Iphone, Color - Purple, Model - 10 XS, SimCard - Sim2, Browser - Google Chrome");
            SmartPhone sp1 = new SmartPhone("Iphone", "Black", "12 Mini", sc1, "Safari");
            SmartPhone sp2 = new SmartPhone("Iphone", "Purple", "10 XS", sc2, "Google Chrome");

            Console.WriteLine("==========================================");
            Console.WriteLine("MobilePhone1 talking to MobilePhone2");
            mp1.Call(mp2);

            Console.WriteLine("==========================================");
            Console.WriteLine("SmartPhone1 talking to SmartPhone2");
            sp1.CallFromBrowser(sp2);

            Console.WriteLine("==========================================");
            Console.WriteLine("Swapping sims of MobilePhone1 and MobilePhone2");
            mp1.SwapSimCard(sc2);
            mp2.SwapSimCard(sc1);

            Console.WriteLine("==========================================");
            Console.WriteLine("MobilePhone1 talking to MobilePhone2 again (Phone Numbers should swap)");
            mp1.Call(mp2);


            Console.WriteLine("==========================================");
            Console.WriteLine("Adding applications to Smartphone 1");
            Console.WriteLine("- Facebook (10.5)");
            Console.WriteLine("- Instagram (5.5)");
            Console.WriteLine("- Twitter (6)");

            App fb = new App("Facebook", 10.5f);
            App ig = new App("Instagram", 5.5f);
            App twitter = new App("Twitter", 6);

            sp1.AddApplication(fb);
            sp1.AddApplication(ig);
            sp1.AddApplication(twitter);

            float total = 0.0f;

            foreach (App app in sp1.Applications) {
                total = total + app.Size;
            }

            Console.WriteLine($"Total size of apps in Smartphone 1: {total} ");

            total = 0.0f;
            foreach (App app in sp2.Applications) {
                total = total + app.Size;
            }

            Console.WriteLine($"Total size of apps in Smartphone 2: {total} ");
        }
    }
}