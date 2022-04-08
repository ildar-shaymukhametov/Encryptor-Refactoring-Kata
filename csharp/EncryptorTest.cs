using Xunit;

public class EncryptorTest
{
    [Fact]
    public void Test()
    {
        var sentence = "This is just a test";
        var sut = new Encryptor();
        var actual = sut.CryptSentence(sentence);

        Assert.Equal("Vjku\"ku\"lwuv\"c\"vguv", actual);
    }
}

