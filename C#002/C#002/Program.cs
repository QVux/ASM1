// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hoc ve kieu du lieu cua bien");
// Kiểu dữ liệu là phạm vi của giá trị mà một biến lưu trữ 
// 1- Tìm hiểu về kiểu dữ liệu dạng số 
// Tìm hiểu về kiể số nguyên và số thực 
// int là kiểu số nguyên
int number = 10;
Console.WriteLine(number);
double number2 = 100.231;
Console.WriteLine(number2);
// float là kiểu số thực 
float number3 = 10.2f;
Console.WriteLine(number3);
float number4 = 20.54f;
float number5 = number3 + number4;
Console.WriteLine(number5);

const double PI = 3.14;
number = 50; // chính xác
// PI = 3.15; // Lỗi - vì là hằng số không thay đổi giá trị  
Console.WriteLine(PI);

double n1 = 17;
double n2 = 9;
double n3 = n1 / n2;
Console.WriteLine(n3);

// Kiểu dữ liệu Boolean
bool checking = true;
bool isValidate = false;
// Kiểu dữ liệu về kí tự (char)
char test = 'C'; // Dùng nháy đơn và chỉ lưu trữ 1 ký tự đơn duy nhất 
// Kiểu string - chuỗi: dùng dấu nháy kép để khai báo
string myStr = "Dang hoc ngon ngu C#";

int myNumber = 10;
double myNumber2 = (double)myNumber;
// Chuyển int về double
Console.WriteLine(myNumber2);
//string myTest = (string)test;// Sai - Vì không thể chuyển từ char sang string 

int i = 10;
int j = 9;
//int k = (++i) - (--j) + (i--) - (j++) + (i++) + (++j);
//  k =   11  -   8   +   11  -   8   +   10  +   10
// ++ đứng trước là tăng thêm 1 giá trị
// -- đứng trước là trừ đi 1 giá trị
// ++ đúng sau là ở thời điểm đó giá trị chưa bị tăng ngay mà đợi lệnh sau 
// -- đứng sau là ở thời điểm đó giá trị chưa bị giảm ngay mà đợi lệnh sau
//Console.WriteLine(k); // 26

int v = (j++) + (i++) - (--i) - (--j) + (++i) + (--j);
//  v =   9  +   10  -   10  -   9   +   11  +   8
Console.WriteLine(v);

int u = 5;
int t = 6;
int m = (u++) - (--u) + (++t) - (--t) + (u++) - (t--);
//  m =   5   -   4   +   7   -   6   +   4   -   6
Console.WriteLine(m);

