namespace EF_Core_08._Dapper_ORM;

internal interface IAuthorRepository
{
    Author Add(Author author);
    void AddAuthors(IEnumerable<Author> authors);
    void Remove(int id);
    void RemoveRange(int[] authorsId);
    Author Update(Author author);
    IEnumerable<Author> GetAll();
    Author GetById(int id);
}
