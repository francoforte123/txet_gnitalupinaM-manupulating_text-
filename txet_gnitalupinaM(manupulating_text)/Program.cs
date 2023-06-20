Console.Write("insert the text= ");
String text= Console.ReadLine();

Console.WriteLine("\n");
Console.WriteLine("you have insert this text= " + text);

String resultText = " ";

for(int i = text.Length; i > 0; i--){
    resultText += text[i-1];
}

Console.WriteLine("the result text is= " + resultText);


