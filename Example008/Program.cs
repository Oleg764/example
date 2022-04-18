
  int a,b,c,max ;
{
  Console.WriteLine("Введите три числа : ");
 
  a = Convert.ToInt32(Console.ReadLine());
 
  b = Convert.ToInt32(Console.ReadLine());

  c = Convert.ToInt32(Console.ReadLine());
}
{max = a;
 if ( max<b ) 
  max=b;
}
{if (max<c )
  max=c;
}
Console.WriteLine(" MAX= {0} ", max);

Console.ReadLine();
