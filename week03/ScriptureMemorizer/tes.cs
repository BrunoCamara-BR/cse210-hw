using System.Runtime.CompilerServices;

public class Password
{
    private string _password;

    public void setPassword(string text)
    {
        _password = text;
    }

    public string PasswordTips()
    {
        char[] pad = _password.ToCharArray();
        for (int i = 0; i < pad.Length / 2; i++)
        {
            pad[i] = '*';
        }
        return new string(pad);
    }
}