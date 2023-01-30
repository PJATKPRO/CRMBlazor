using CRMBlazor.Domain.EmailSnippets;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;


namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    public interface IEmailSnippetRepository
    {
        Task<EmailSnippet> Create(EmailSnippetId id, string title, string? header, string content, string? footer);
        Task<EmailSnippet> Get(EmailSnippetId id);
        Task<IReadOnlyList<EmailSnippet>> GetAll();
        Task Add(EmailSnippet emailSnippet);
        Task Delete(EmailSnippetId id);
        Task Update(EmailSnippet emailSnippet);
    }
}
