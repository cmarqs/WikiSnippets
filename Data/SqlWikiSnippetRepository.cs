using System.Collections.Generic;
using System.Linq;
using WikiSnippets.Models;

namespace WikiSnippets.Data{
    public class SqlWikiSnippetRepository : ISnippetRepository
    {
        private readonly WikiSnippetContext _context;

        public SqlWikiSnippetRepository(WikiSnippetContext context)
        {
            _context = context;
        }
        public IEnumerable<Snippet> GetAllSnippets()
        {
            return _context.Snippets.ToList();
        }

        public Snippet GetSnippetById(int id)
        {
            return _context.Snippets.FirstOrDefault(p => p.Id == id);
        }
    }
}