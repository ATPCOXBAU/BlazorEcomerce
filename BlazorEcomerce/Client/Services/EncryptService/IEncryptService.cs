namespace BlazorEcomerce.Client.Services.EncryptService
{
    public interface IEncryptService
    {
        byte[] EncryptStringToBytes_Aes(string plainText);
        string DecryptStringFromBytes_Aes(byte[] cipherText);
    }
}
