public class Encryptor
{
    public String CryptSentence(String sentence)
    {
        char[] sentenceArray = sentence.ToCharArray();
        String newWord = "";
        for (int i = 0; i < sentence.Length; i++)
        {
            int charValue = sentenceArray[i];
            newWord += (char) (charValue + 2);
        }

        return newWord;
    }
}

