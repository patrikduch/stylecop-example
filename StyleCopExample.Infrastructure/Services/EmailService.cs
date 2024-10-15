namespace StyleCopExample.Infrastructure.Services;

using StyleCopExample.Application.Interfaces.Infrastructure;

public class EmailService : IEmailService
{
    public Task SendEmailTest(string email)
    {
        // TODO Send email
        return Task.CompletedTask;
    }
}
