public class Fruit{

 private double Price{get;set;}
 private string Name{get;set;}

 public double GetPrice(){
    
    return Price;
 }

 public void SetPrice(double _price){
    Price=_price;
 }

  public string GetName(){
    return Name;
 }

 public void SetName(string _name){
    Name=_name;
 }

}