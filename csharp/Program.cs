var encryptor = new Encryptor();
var sentence = encryptor.CryptSentence("This is just a test");
var words = GetWords(sentence);
PrintWords(words);

void PrintWords(String[] words)
{
    foreach (String word in words)
    {
        Console.WriteLine("<" + word + ">");
    }
}

String[] GetWords(String sentence)
{
    return sentence.Split(' ');
}