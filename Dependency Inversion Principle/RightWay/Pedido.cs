public class Pedido
{
    private IEmailService _emailService;

    public Pedido(IEmailService emailService) // Dependência injetada
    {
        _emailService = emailService;
    }

    public void Processar()
    {
        Console.WriteLine("Pedido processado.");
        _emailService.EnviarEmail("Seu pedido foi processado com sucesso!");
    }
}