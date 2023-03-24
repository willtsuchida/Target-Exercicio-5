Console.Write("Digite uma palavra ou frase: ");
String dado = Console.ReadLine();
String dadoInverso;

char[] arrayOrdenado = dado.ToCharArray();
int tamanhoArray = arrayOrdenado.Length;
char[] arrayInverso = new char[tamanhoArray];

for (int i = 0; i < arrayOrdenado.Length; i++)
{
    arrayInverso[tamanhoArray - 1] = arrayOrdenado[i];
    tamanhoArray--;
}

dadoInverso = new string(arrayInverso);

Console.WriteLine(dadoInverso);
