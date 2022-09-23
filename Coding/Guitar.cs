public class Guitar{
    //public string[] Guitar01 = {"000001","5,000.52","Nhong","Stratocaster","Alder"};
    private string SerialNumber;
    private double price;
    private string builder;
    private string model;
    private string wood;

    public Guitar(string SerialNumber,double price,string builder,string model,string wood){
        this.SerialNumber = SerialNumber;
        this.price = price;
        this.builder = builder;
        this.model = model;
        this.wood = wood;
    }

    public string GetSerialNumber(){
        return this.SerialNumber;
    }
     public double GetPrice(){
        return this.price;
    }
     public string GetBuilder(){
        return this.builder;
    }
     public string GetModel(){
        return this.model;
    }
      public string GetWood(){
        return this.wood;
    }


    //public void PrintInfoGuitarInformation(){}

}