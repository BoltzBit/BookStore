﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Domain
{
    public class Livro
    {
        public Livro()
        {
            this.Autores = new List<Autor>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public DateTime DataLancamento { get; set; }

        //referencia ao id de categoria à qual o livro pertence
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<Autor> Autores { get; set; }
    }
}
