class Program
{
    static void Main()
    {
        IEmailService emailService = new EmailService(); // Criamos a implementação
        Pedido pedido = new Pedido(emailService); // Injeção de dependência
        pedido.Processar();
    }
}