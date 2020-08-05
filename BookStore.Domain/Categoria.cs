using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Domain
{
    public class Categoria
    {
        public Categoria()
        {
            this.Livros = new List<Livro>();
        }
        
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
