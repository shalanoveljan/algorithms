/*Console.WriteLine("Faktorialin tapilmasi");
Console.Write("Istediyiniz bir soz daxil edin:");
string word=Console.ReadLine();
int count = 0;
int factorial = 1;
for(int i = 0; i < word.Length; i++) 
    {
    if (word[i] == 't')
    {
        count++;

    }

    }
Console.WriteLine("{0} sozunde {1}sayda t herfi var",word,count);
for(int i = 1; i <= count; i++)
{
    factorial*= i;
}
Console.WriteLine("factorial:{0}", factorial);*/

/*Console.Write("arrayin olcusunu daxil edin:");
int size=Convert.ToInt32(Console.ReadLine());
string[] array=new string[size];

for(int i=0;i<size;i++)
{
    array[i] = Console.ReadLine();
}
Console.WriteLine("uzunlugu 5den kicik sozleri cap et:");

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 5)
    {
        Console.WriteLine(array[i]);
    }
}*/
#region numerical average
/*Console.Write("arrayin olcusunu daxil edin:");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
int sum = 0;
double edediorta;

for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine();
    sum = sum + array[i].Length;

}
edediorta = sum / array.Length;
Console.WriteLine("edediorta:{0}", edediorta);*/


#endregion


#region Sade eded ve murekkeb eded 

/*  Console.WriteLine("bir eded daxil edin");
  int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
  if (number > 1)
  {
      for(int i = 1; i <= number; i++)
  {
      if (number % i == 0)
          count++;
  }
      if (count==2)
      {
          Console.WriteLine("Bu eded sade ededdir");
      }
      else
      {
          Console.WriteLine("Bu eded murekkeb ededdir");
      }
  }
  else
  {
      Console.WriteLine("0 ve 1 ne sade nede murekkeb ededdir");
  }*/

#endregion

#region reverse number
/*
int number = Convert.ToInt32(Console.ReadLine());
int p;
int sum=0;
while (number != 0)
{
    p = number % 10;
    sum=sum*10+p;
    number=number/ 10;
} 
Console.WriteLine(sum)*/
#endregion
#region Polindrom number
/*int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int r,sum=0;
while (number1 != 0)
{
    r = number1 % 10;
    sum = sum*10 + r ;
    number1 = number1 / 10;
}
if (sum == number2)
{
    Console.WriteLine("bu polindrome ededlerdir");

}
else
{
    Console.WriteLine("bu polindrome eded deyil");
}*/


#endregion


#region Armstrong number

/*
 * Console.Write("eded daxil et:");
 * int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
double sum = 0;
int r;
int number1 = number;
int number2 = number;
//while (number1>0)
//{
//   number1= number1/ 10;
//     count++;
//}
while (number > 0)
{

    r = number % 10;
    sum = sum + Math.Pow(r, count);
    number = number / 10;

}
if (sum == number2)
{
    Console.WriteLine("armstrong");

}
else
{
    Console.WriteLine("not armstrong");
}*/

#endregion




#region Task1
/*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
int n=Convert.ToInt32(Console.ReadLine());
bool control = false;
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (n == arr[i])
    {

        control=true;
        break;
    }
    
    
}
Console.WriteLine(control);*/

#endregion


#region task2
/*int[] arr = { 1, 3, 6, 8 };
int count = 0;

for (int i = 0;i < arr.Length; i++)
{
    if (arr[i]%3==0) count++;
}

Console.WriteLine(count);*/

#endregion

#region task3
/*int N = Convert.ToInt32(Console.ReadLine());
if(N%3==0 && N % 7 == 0)
{
    Console.WriteLine("BU EDED 3-e ve 7-e tam bolunur");
}
else
{
    Console.WriteLine("BU EDED 3-e ve 7-e qaliqli  bolunur");
} */
#endregion

#region task4(find minimum number)
/*Console.WriteLine("ededleri daxil edin:");
int a=Convert.ToInt32(Console.ReadLine());  
int b=Convert.ToInt32(Console.ReadLine());  
int c=Convert.ToInt32(Console.ReadLine());
int min;

min = a;

if(a>b) min = b;
 if(b>c) min = c;
else
{
    min = a;
}
Console.WriteLine("minimum eded :{0}",min);*/

#endregion

#region task5(sum of digitsof number)
/*int n = Convert.ToInt32(Console.ReadLine());
int r;
int sum = 0;

while (n > 0)
{
   r = n % 10;
   sum = sum + r; 
   n = n / 10;
}
Console.WriteLine("sum:{0}",sum);*/
#endregion

#region task6(sort bubble sort)

/*int[] arr = { 5, 3, 67, 45, 32, 1 };
int temp;


for(int i = 0; i < arr.Length-1; i++)
{
    for(int j = 0; j < arr.Length-i-1; j++)
    {

        if (arr[j] > arr[j + 1])
        {
            temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
       }

}  
for(int k=0; k < arr.Length; k++)
{
    Console.Write(arr[k]+" ");
}*/

#endregion

#region task7(edediorta)

/*int m=Convert.ToInt32(Console.ReadLine());
double edediorta;
int sum = 0;
int count=0;
for(int n = 1; n < m; n++)
{
    if (n % 15 == 0)
    {
        sum = sum + n;
        count++;
    }

}
edediorta = (double)sum / count;

Console.WriteLine(edediorta);*/

#endregion

#region task8(reverse word or sentence)

/*string word=Console.ReadLine();
string newWord=string.Empty;
for(int i =word.Length-1; i >=0; i--)
{
    newWord += word[i];
}
Console.WriteLine(newWord);*/
#endregion

#region task9(limitden asagi olanlara faiz tetbiq edilerek totalin tapilmasi
//using System.Reflection.Metadata.Ecma335;
//using System.Security.Cryptography;
//using System.Xml.Schema;
//Console.WriteLine("artimfaizini daxil edin ");
//int percent = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("arrayin olcusunu  daxil edin ");
//int size = Convert.ToInt32(Console.ReadLine());
//double[] arr = new double[size];
//Console.WriteLine("{0}olculu arrayi doldurun", size);
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());

//}
//PerIncrease(percent, arr);
//static void PerIncrease(double per, double[] arr)
//{
//    double total = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < 20)
//        {
//            arr[i] = arr[i] + (arr[i] * per) / 100;

//        }
//        total = total + arr[i];
//    }
//    Console.WriteLine("total:{0}", total);

//}


#endregion

#region task10 palindrome string 
//using System.Text;

//string word=Console.ReadLine();
//StringBuilder sb = new StringBuilder();
//for (int i = word.Length-1; i >=0; i--)
//{
//    sb.Append(word[i]);

//}
//if (sb.ToString() == word)
//{
//    Console.WriteLine("these are polindrome");
//}

//else
//{
//    Console.WriteLine("are not palindrome");

//}
#endregion

#region Classworks
//static void SetArrayElements()
//{
//    Console.WriteLine("Enter valid array length");
//    string numberStr = Console.ReadLine();
//    int number;
//    bool result = int.TryParse(numberStr, out number);
//    if (!result)
//    {
//        Console.WriteLine("Please enter valid number");
//        return;
//    }
//    int[] arr = new int[number];

//    for (int i = 0; i < number; i++)
//    {
//        Console.WriteLine("Enter valid array element value");
//        bool resultNum = int.TryParse(Console.ReadLine(), out int num);

//        if (resultNum)
//        {
//            arr[i] = num;
//        }
//    }


//    foreach (int num in arr)
//    {
//        Console.WriteLine(num);
//    }
//}

//static int Max(int num1, int num2, int num3)
//{
//    if (num1 > num2 && num1 > num3)
//    {
//        return num1;
//    }
//    else if (num2 > num1 && num2 > num3)
//    {
//        return num2;
//    }
//    else
//    {
//        return num3;
//    }
//}

////bool result1 = int.TryParse(Console.ReadLine(), out int num1);
////bool result2 = int.TryParse(Console.ReadLine(), out int num2);
////bool result3 = int.TryParse(Console.ReadLine(), out int num3);

////Console.WriteLine(Max(num1, num2, num3));




//int[] arr = { 2, 4, -30, -100, 50, 23, 54, -200, 90 };//{-200,54,23,50,-100,-30,4,2}=>{ 2, 4, -30, -100, 50, 23,54,-200 }


//for (int i = 0; i < arr.Length / 2; i++)
//{
//    int current = arr[i];//2
//    arr[i] = arr[arr.Length - 1 - i];//23
//    arr[arr.Length - 1 - i] = current;//2
//}

//foreach (var item in arr)
//{
//    Console.WriteLine(item);

//}
#endregion

#region task11 n ustu m

//int n=Convert.ToInt32(Console.ReadLine());
//int m=Convert.ToInt32(Console.ReadLine());
//int result=1;
//for(int i = 1; i <= m; i++)
//{
//   result = result * n;
//}
//Console.WriteLine(result);
#endregion



#region task12(daxil edilen herf sozde varsa indexi yoxsa -1 qaytarilsin)
//string word=Console.ReadLine();
//char letter=Convert.ToChar(Console.ReadLine());
//static int Method(string word,char letter)
//{
//    for (int i = 0; i < word.Length; i++)
//    {
//        if (word[i] == letter)
//        {
//            return i;
//             break;
//        }

//    }
//    return -1;
//}
//int result =Method(word,letter);
//Console.WriteLine(result);
#endregion

#region task13(Fibanocci)
//using System.Diagnostics.Tracing;
//int size=Convert.ToInt32(Console.ReadLine());
//int[] arr=new int[size];
//arr[0]=0;
//arr[1]=1;
//for(int i = 2; i <arr.Length; i++)
//{
//    arr[i]=arr[i-1]+arr[i-2];

//}
//foreach(int i in arr)
//{
//    Console.WriteLine(i);
//}
#endregion

#region task14(daxil edilen edede qeder olanlarin cemi)
//int total = 0;
//Console.WriteLine("hansi edede qeder olan ededlerin cemi hesablanacaq?");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number > 0)
//{
//    for (int i = 0; i < number; i++)
//    {
//        total = total + i;
//    }
//    Console.WriteLine("total:{0}", total);

//}

//else
//{
//    Console.WriteLine("musbet eded daxil edilmelidir");
//}

#endregion

#region task15(verilen arrayde tek ededin olub olmamasi)
int[] arr = { 3, 2, 6, 4, 12, 16, 72, 18 };
bool control = true;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 != 0)
    {
        control = false; break;
    }

}

if (control)
{
    Console.WriteLine("result:{0}", control);
}
else
{
    Console.WriteLine("result:{0}", control);

}
#endregion

#region task16:MyCalculator
/*
Console.WriteLine("1ci ededi daxil et");
double number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2ci ededi daxil et");
double number2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("istediyiniz bir riyazi operator daxil edin");
Console.WriteLine("toplama(+)");
Console.WriteLine("cixma(-)");
Console.WriteLine("vurma(*)");
Console.WriteLine("bolme(/)");
string aperator = Console.ReadLine();

switch (aperator)
{
    case "+":
        Console.WriteLine(number1+ number2); break;
    case "-":
        Console.WriteLine(number1 - number2); break;
    case "*":
        Console.WriteLine(number1 * number2); break;
    case "/":
        if (number2 == 0)
        {
            Console.WriteLine("0-a bolme yoxdur");
            break;
        }
        Console.WriteLine(number1/number2); break;
    default:
        Console.WriteLine("Enter a valid operator");break;
} */


#endregion

#region Task5(reverse data of array in that array)
//Console.WriteLine("Arrayin uzunlugunu daxil edin");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("{0}uzunluqda arrayi doldurun", size);
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine("{0}-ci indexdeki ededi daxil edin", i);
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Output");

//foreach (int i in arr)
//{
//    Console.WriteLine(i);
//}
// static void Reverse(int[] arr)
//{

//    int temp = 0;
//    for (int i = 0; i < arr.Length / 2; i++)
//    {


//        temp = arr[arr.Length - i - 1];
//        arr[arr.Length - i - 1] = arr[i];
//        arr[i] = temp;


//    }

//}

//Reverse(arr);
//foreach (var item in arr)
//{
//    Console.WriteLine(item);








#endregion
#region Task:Capitalized(Method1)
//using System.Globalization;
//using System.Text;

//string NewSentence = Console.ReadLine();

//string NewSentence1 = NewSentence.ToLower();
//StringBuilder sb = new StringBuilder(NewSentence1[0].ToString().ToUpper());
//for (int i = 1; i < NewSentence1.Length; i++)
//{

//    if (char.IsWhiteSpace(NewSentence1[i - 1]))
//    {

//        sb.Append(NewSentence1[i].ToString().ToUpper());
//    }
//    else
//    {
//        sb.Append(NewSentence1[i]);

//    }

//}

//foreach (var item in sb.ToString())
//{
//    Console.Write(item);
//}
#endregion
#region Task:Capatalized(Method2)
//using System.Globalization;
//using System.Text;

//string NewSentence = Console.ReadLine();

//string NewSentence1 = NewSentence.ToLower();
//StringBuilder sb = new StringBuilder(NewSentence1[0].ToString().ToUpper());
//for (int i = 0; i < NewSentence1.Length - 1; i++)
//{

//    if (char.IsWhiteSpace(NewSentence1[i]))
//    {

//        sb.Append(NewSentence1[i + 1].ToString().ToUpper());
//    }
//    else
//    {
//        sb.Append(NewSentence1[i + 1]);
//    }
//}

//foreach (var item in sb.ToString())
//{
//    Console.Write(item);
//}

#endregion


#region Task:Capitalized(the best Method 3)
//string NewSentence = Console.ReadLine();
//string[] arr = NewSentence.Split(' ');
//string capitalize=string.Empty;
//foreach (string item in arr)
//{
//    capitalize += item[0].ToString().ToUpper() + item.Substring(1) + " ";

//}
//Console.WriteLine(capitalize);

#endregion

#region Capitalized(Method 4)
//string newSentence=Console.ReadLine();
//char[] arr = newSentence.ToLower().ToCharArray();
//arr[0]=char.ToUpper(arr[0]);
//for (int i = 1;i< arr.Length-1; i++)
//{

//    if (arr[i]==' ')
//    {
//       arr[i+1]=char.ToUpper(arr[i+1]);
//    }

//}
////foreach (var item in arr)
////{
////    Console.Write(item);

////}
//Console.WriteLine(new string(arr));

#endregion

