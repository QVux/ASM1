// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Xử lý các mệnh đề điều khiển trong C#");
/*
 * Viết chương trình kiểm tra 1 số nhập từ bàn phím là số chẵn hay số lẻ
 */
Console.WriteLine("Moi nhap so de kiem tra: ");
int number = Convert.ToInt32(Console.ReadLine());
// Chuyển đổi kiểu dữ liệu từ string về int 
// Vì mọi giá trị nhập từ thiết bị ngoại vi (bàn phím,...) thì kiểu dữ liệu luôn mặc định là string
// Hàm Convert.ToInt32: chuyển về số nguyên 32 bit 

// Ví dụ 1: Làm thế nào kiểm tra 1 số chẵn hay lẻ 
// Thuật toán: chia cho 2 để kiểm tra số dư

if (number % 2 == 0)
{
    Console.WriteLine("{0} la so chan", number);
}
else
{
    Console.WriteLine("{0} la so le", number);
}
// Kiểm tra xem năm đó có phải năm nhuận hay không
Console.WriteLine("Nhap so nam de kiem tra: ");
int year =  Convert.ToInt32(Console.ReadLine());
int mod4 = year % 4;
int mod100 = year % 100;
int mod400 = year % 400;
if (mod4 == 0 && mod100 != 0)
{
    Console.WriteLine("{0} la nam nhuan", year);
}
else if (mod400 == 0)
{
    Console.WriteLine("{0} la nam nhuan", year);
}
else
{
    Console.WriteLine("{0} khong la nam nhuan", year);
}

// Nhập vào 1 tháng và kiểm tra tháng đó có bao nhiêu ngày
int month = 12;
if (month == 1)
{
    // Thông báo kết quả 
}
else if (month == 2)
{
    //Thông báo kết quả
}
else
{
    // Thông báo kết quả 
}
// if...else lồng nhau (các điều kiện kiểm tra lồng nhau)

Console.WriteLine("Moi nhap thangs: ");
month = Convert.ToInt32(Console.ReadLine());
// Cấu trúc điều khiển switch...case
switch(month)
{
    case 1: // So sánh month có bằng 1 không?
        // thông báo kết quả
        Console.WriteLine("31 days");
        break;
    case 2: // So sánh month có bằng 2 không?
        // thông báo kết quả
        Console.WriteLine("28 days");
        break;
    case 3: // So sánh month có bằng 3 không?
        // thông báo kết quả
        Console.WriteLine("31 days");
        break;
    default:
        // thông báo kết quả
        Console.WriteLine("month invalid");
        break;
}

// Sử dụng if...else viết chương trình kiểm tra độ dài 3 cạnh nhập vào từ bàn phím có phải là một tam giác hay không?
// Math.Abs là lệnh viết trị tuyệt đối 
// VD: Math.Abs(1)
Console.WriteLine("Moi nhap canh a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Moi nhap canh b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Moi nhap canh c: ");
double c = Convert.ToDouble(Console.ReadLine());
if (a + b > c && a + c > b && c + b > a && a > Math.Abs(b - c) && b > Math.Abs(c - a) && c > Math.Abs(a - b)) 
{
    Console.WriteLine("Hop le");
}
else
{
    Console.WriteLine("Khong hop le");
}


