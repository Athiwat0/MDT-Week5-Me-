public class Inventory{
    private Guitar[] guitar;

    public Inventory(Guitar[] guitar){
        this.guitar = guitar;
    }

    public Guitar GetGuitar(string serialNumber){
        foreach(Guitar guitar in guitar){
            if(guitar.GetSerialNumber().Equals(serialNumber)){
                return guitar;
            }
        }

        return null;
        
    }

    public Guitar GetGuitar(double price){
        foreach(Guitar guitar in guitar){
            if(guitar.GetPrice().Equals(price)){
                return guitar;
            }
        }

        return null;

    }

    public Guitar Search(Guitar searchGuitar){
        foreach(Guitar guitar in guitar){
            string serialNumber = searchGuitar.GetSerialNumber();
            double price = searchGuitar.GetPrice();
            if (guitar.GetSerialNumber().Equals(serialNumber)&& guitar.GetPrice().Equals(price)){
                return guitar;
            }

        }

        return null;
    }
}