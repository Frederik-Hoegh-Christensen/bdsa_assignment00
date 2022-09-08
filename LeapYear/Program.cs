namespace LeapYear;

public class LeapYearCalculator{
    public static void Main(string[] args){
        var lyc = new LeapYearCalculator();
        lyc.writeYayOrNay();
    }

    public bool isLeapYear(int year){
        if (year % 400 == 0)
        {
            return true;
        } else if (year % 100 == 0)
        {
            return false;
        } else if (year % 4 == 0)
        {
            return true;
        } else return false;
    }

    public void writeYayOrNay(){
        
        try
        {
              Console.WriteLine("Enter a year and hit [Enter]");
              int year = int.Parse(Console.ReadLine());
              if (year < 1582)
              {
                Console.WriteLine("The program can only handle years that a higher than 1581");
                Console.WriteLine("Enter another year and hit [Enter]");
                year = int.Parse(Console.ReadLine());
              }if (year % 400 == 0)
              {
                Console.WriteLine("yay");
              } else if (year % 100 == 0)
              {
                Console.WriteLine("nay");
              } else if (year % 4 == 0)
              {
                Console.WriteLine("yay");
              } else
              {
                Console.WriteLine("nay");
              }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
