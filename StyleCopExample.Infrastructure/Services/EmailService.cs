using StyleCopExample.Application.Interfaces.Infrastructure;

namespace StyleCopExample.Infrastructure.Services;

public class EmailService : IEmailService
{
    public Task SendEmailTest(string email)
    {
        // TODO Send email
        return Task.CompletedTask;
    }
}
