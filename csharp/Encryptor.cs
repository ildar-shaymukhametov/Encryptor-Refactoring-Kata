public class Encryptor
{
    public String CryptSentence(String sentence)
    {
        char[] sentenceArray = sentence.ToCharArray();
        String result = "";
        for (int i = 0; i < sentenceArray.Length; i++)
        {
            int charValue = sentenceArray[i];
            result += (char) (charValue + 2);
        }

        return result;
    }
}

