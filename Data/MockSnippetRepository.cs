using System.Collections.Generic;
using WikiSnippets.Models;

namespace WikiSnippets.Data
{
    public class MockSnippetRepository : ISnippetRepository
    {
        public IEnumerable<Snippet> GetAllSnippets()
        {
            var snippets = new List<Snippet>{
                new Snippet { Id = 0, HowTo = "Start new WebAPI no .net", Line = "dotnet new webapi -n <project name>", Platform = "Any" },
                new Snippet { Id = 0, HowTo = "Create dir on unix", Line = "mkdir <dir name>", Platform = "Unix" },
                new Snippet { Id = 0, HowTo = "Create new file", Line = "touch <name of file>", Platform = "Unix" }
            };

            return snippets;
        }

        public Snippet GetSnippetById(int id)
        {
            return new Snippet { Id = 0, HowTo = "Start new WebAPI no .net", Line = "dotnet new webapi -n <project name>", Platform = "Any" };
        }
    }
}