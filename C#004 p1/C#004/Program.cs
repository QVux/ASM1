// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhap ngay sinh nguoi thu nhat: ");
int day1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap thang sinh nguoi thu nhat: ");
int month1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap nam sinh nguoi thu nhat: ");
int year1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap ngay sinh nguoi thu hai: ");
int day2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap thang sinh nguoi thu hai: ");
int month2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap nam sinh nguoi thu hai: ");
int year2 = Convert.ToInt32(Console.ReadLine());
int diffm = month1 - month2 + (year1 - year2) * 12;
int diffd = day1 - day2;

if (diffm < 0)
{
    Console.WriteLine("Nguoi thu nhat lon tuoi hon nguoi thu hai");
}
else if (diffd < 0)
{
    Console.WriteLine("Nguoi thu nhat nho tuoi hon nguoi thu hai");
}
else
{
    if(diffd > 0)
    {
        Console.WriteLine("Nguoi mot nho tuoi hon nguoi hai");
    }
    else if (diffd < 0)
    {
        Console.WriteLine("Nguoi thu nhat lon tuoi hon nguoi thu hai");
    }
    else
    {
        Console.WriteLine("Nguoi thu nhat bang tuoi nguoi thu hai");
    }
}





