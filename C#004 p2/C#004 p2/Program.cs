// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Tìm hiểu về kiến thức của vòng lặp ");


Console.WriteLine("Tìm hiểu kiến thức về vòng lặp ");

// Biểu diễn một vòng lặp: duyệt qua các số từ 1 đến 10 
// Điểm bắt đầu của vòng lặp là như thế nào
// Điểm kết thúc của mỗi vòng lặp là như thế nào
// Sau khi mỗi vòng lặp kết thúc thì mỗi vòng lặp tiếp theo sẽ được diễn ra như thế nào

int sum = 0;
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    sum += i;
}
Console.WriteLine(sum);
// Dung vong lap for
// Dung vong lap while
// Vong lap while: vong lap kiem tra dieu kien truoc

int j = 1;
while(j <= 10)
{
    Console.WriteLine(j);
    j++;
}

int k = 1;
do
{
    Console.WriteLine(k);
    k++;
} while (k <= 10);


 //Sử dụng vòng lặp while tính tổng các số chẵn từ 1 đến 30

int sumEven = 0;
int v = 1;
while (v <= 30)
{
    if (v % 2== 0)
    {
        sumEven += v; // x += y <==> x = x + y
    }
    v++;
}
Console.WriteLine(sumEven);

// Sử dụng vòng lặp do...while đếm xem có bao nhiêu số lẻ từ 1 đến 30 

int countOdd = 0;
int a = 1;
do
{
    if (a % 2 != 0)
    {
        countOdd++;
    }
    a++;

} while (a <= 30);
Console.WriteLine(countOdd);


for (int m = 1; m <= 10; m++)
{
    Console.WriteLine(m);
    if (m % 5 == 0)
    {
        break; // Dừng và thoát khỏi vòng lặp 
    }
}

for (int z = 1; z <= 10; z++)
{
    if (z < 6)
    {
        Console.WriteLine("Gia tri cua 1 : {0}", z);
        continue; // Vòng lặp có thể chạy tiếp 
    }
    Console.WriteLine("Gia tri cua 2: {0}", z);
}