using System;
class HelloWorld {
  static void Main() {
    string binary = "1010";
    int num = Convert.ToInt32(binary, 2);
    Console.WriteLine("Binary  to Int: " + num);
    
    string str = Convert.ToString(num, 2);
    Console.WriteLine("Int to Binary: " + str);
  }
}