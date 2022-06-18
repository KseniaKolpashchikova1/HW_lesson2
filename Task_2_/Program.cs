Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра заданного числа = " + anyNumberText[2]);
}
else {
  Console.WriteLine("В Вашем числе нет третьей цифры");
}