using System.Collections.Generic;
using WikiSnippets.Models;

namespace WikiSnippets.Data
{
    public interface ISnippetRepository
    {
        IEnumerable<Snippet> GetAllSnippets();
        Snippet GetSnippetById(int id);
    }
}