public class Program{
    static int num = 0;
    static void Main(string[] args){
        Console.WriteLine("=====================================");
        Console.WriteLine("Welcome to Shop Guitar");
        Console.WriteLine("=====================================");

        public void PrintInfoGuitarInformation(Guitar guitar){
            Console.WriteLine("Guitar Serial Number: {0}", Guitar.GetSerialNumber());
            Console.WriteLine("Guitar Ptice: {0}", Guitar.GetPrice());
            Console.WriteLine("Guitar Builder: {0}", Guitar.GetBuilder());
            Console.WriteLine("Guitar Model: {0}", Guitar.GetModel());
            Console.WriteLine("Guitar Wood: {0}", Guitar.GetWood());
        
        }

        Inventory inventory = new Inventory(InitializeInventory());


        Guitar guitar = new Guitar("0004",8354.52,"Ning","Stratocaster","Alder");
         

        static Guitar[] InitializeInventory(){
            Guitar[] guitars =
             {new Guitar("00001",5000.52,"Nhong","Stratocaster","Alder"),
             new Guitar("00002",7412.52,"Jame","Stratocaster","Alder"),
             new Guitar("00003",3917.52,"Jo","Stratocaster","Alder"),
             new Guitar("00004",8254.52,"Ning","Stratocaster","Alder"),
             new Guitar("00005",1234.52,"Nut","Stratocaster","Alder")
             };
        }


        //Console.Write("Please enter Serial Number Guitar : ");
        //num = int.Parse(Console.ReadLine());

    }

}