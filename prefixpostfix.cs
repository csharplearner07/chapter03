using System;

namespace operations
{
  class  Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int postfixIncrement = x++;  //1- qiymat beradi, keyin oshiradi
      int prefixIncrement = ++x;  //1- oshiradi, keyin qiymat beradi
      Type theTypeOfAnInteger = typeof(int);
      string nameOfVariable = nameof(x);
      int howManyBytesInAnInteger = sizeof(int);
    }
  }
}
