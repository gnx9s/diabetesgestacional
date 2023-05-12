Console.WriteLine("Diabetes Gestacional");

Console.WriteLine("");
Console.WriteLine("Digite o valor da glicemia (mg/dL) no seu sangue para obter o diagnósitco: ");
double valorglicemia = Convert.ToDouble(Console.ReadLine());

if (valorglicemia < 92 )
{
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Reavalie sua diabetes entre 24 a 28 semanas com TTOG de 75g de glicose!");
}
else if (valorglicemia > 92 && valorglicemia < 126)
{

Console.WriteLine("Quantidade de glicemia compatível com a diabetes gestacional!");
Console.ResetColor();
}
else if (valorglicemia > 126 && valorglicemia < 800)
{
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Diabete Mellitus na gravidez");
Console.ResetColor();
}
else if (valorglicemia > 800 && valorglicemia < 1500)
{
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Os valores de glicemia (mg/dL) estão muito elevados, procure um médico!");
Console.ResetColor();
}
else 
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Digite um valor válido para a glicemia no sangue!");
Console.ResetColor();
return;
}
