public class EmailService : IEmailService
{
    public void EnviarEmail(string mensagem)
    {
        Console.WriteLine("Enviando email: " + mensagem);
    }
}