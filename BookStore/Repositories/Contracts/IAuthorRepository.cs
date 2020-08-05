using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Repositories.Contracts
{
    public interface IAuthorRepository : IDisposable
    {
        //vai listar os autores
        List<Autor> Get();

        //pegar um autor pelo Id
        Autor Get(int id);

        //pega pelo nome
        List<Autor> GetByName(string name);

        //criar e salvar um autor novo
        bool Create(Autor autor);

        //vai editar e salvar alterções feitas em um autor
        bool Update(Autor autor);

        //vai deletar um autor
        void Delete(int id);

    }
}