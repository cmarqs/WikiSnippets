using Microsoft.EntityFrameworkCore;
using WikiSnippets.Models;

namespace WikiSnippets.Data
{
    public class WikiSnippetContext : DbContext
    {
        public WikiSnippetContext(DbContextOptions<WikiSnippetContext> opt) : base(opt){

        }

        public DbSet<Snippet> Snippets { get; set; }
    }
}