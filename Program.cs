// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

int binarytodec()
{
    int decimalNumber = 0;
    string binaryProva = "01001";
    string[] arraybinary = new string[binaryProva.Length];
    int[] arraybinaryint = new int[binaryProva.Length];
    int j = 0;
    for (int i = arraybinary.Length; i > 0; i--)
    {

        arraybinary[j] = binaryProva.Substring(i - 1, 1);
        j++;
    }

    for (int i = 0; i < arraybinary.Length; i++)
    {

        arraybinaryint[i] = Convert.ToInt32(arraybinary[i]);

    }
    for (int i = 0; i < arraybinaryint.Length; i++)
    {
        decimalNumber += (arraybinaryint[i] * (int)Math.Pow(2, i));

    }

    return decimalNumber;
}
string toglispazi() //non riuscito
{
    string frasenormale = "";
    string frase = "Oggi              è        una           bella      giornata...   di         pioggia!!!";
    string[] fraserifatta = frase.Split(' ');

    for (int i = 0; i < fraserifatta.Length; i++)
    {
        //fraserifatta[i] = fraserifatta[i].Trim();
        //frasenormale+= fraserifatta[i].Trim() + " ";
        if (fraserifatta[i] == " ")
        {
            fraserifatta[i] = "";

        }
        else { frasenormale += fraserifatta[i] + " "; }

    }

    return frasenormale;
}// non riuscito 
void spezzameta()
{
    string frase = "La musica è libertà ";
    string nuovafrase1 = "";
    nuovafrase1 = frase.Substring(0, frase.Length / 2);
    Console.WriteLine(nuovafrase1);
    nuovafrase1 = nuovafrase1 = frase.Substring(frase.Length / 2);
    Console.WriteLine(nuovafrase1);
}
bool verificaPalindromo()
{
    string parola = "aNna ";
    bool verifica = false;
    string reversedword = "";
    parola = parola.Trim();
    parola = parola.ToLower();
    for (int i = parola.Length; i > 0; i--)
    {
        reversedword += parola[i - 1];
        if (reversedword == parola)
        {
            Console.WriteLine(reversedword);
            return true;
        }
    }


    return verifica;
}
string fraseparolereverse()
{
    string reversedSentence = "";
    string frase = "La musica è libertà ";
    frase = frase.Trim();
    frase = frase.ToLower();
    string[] saveFrase = frase.Split(' ');
    for (int i = saveFrase.Length; i > 0; i--)
    {
        reversedSentence += saveFrase[i - 1] + " ";
    }
    return reversedSentence;



}

//Console.WriteLine(binarytodec());
Console.WriteLine(toglispazi());
//spezzameta();
//Console.WriteLine(verificaPalindromo());
//Console.WriteLine(fraseparolereverse());

