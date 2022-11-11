using System.Collections.Generic;
public interface ICategoryService
{
    List<Category> GetAll();
    Category GetById(int categoryId);
}