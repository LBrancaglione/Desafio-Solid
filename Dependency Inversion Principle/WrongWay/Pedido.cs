public class Pedido
{
    private EmailService _emailService;

    public Pedido()
    {
        _emailService = new EmailService(); // Dependência direta de EmailService
    }

    public void Processar()
    {
        // Lógica de processamento do pedido
        Console.WriteLine("Pedido processado.");
        _emailService.EnviarEmail("Seu pedido foi processado com sucesso!");
    }
}