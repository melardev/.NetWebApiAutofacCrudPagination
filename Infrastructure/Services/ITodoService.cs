using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiAutofacCrudPagination.Entities;
using WebApiAutofacCrudPagination.Enums;

namespace WebApiAutofacCrudPagination.Infrastructure.Services
{
    public interface ITodoService
    {
        Task<Tuple<int, List<Todo>>> FetchMany(int page = 1, int pageSize = 5,
            TodoShow show = TodoShow.All);
        Task<Todo> Get(int todoId);
        Task<Todo> CreateTodo(Todo todo);
        Task<Todo> Update(int id, Todo todoFromUserInput);
        Task Delete(int todoId);
        Task DeleteAll();
        Task<Todo> Update(Todo todoFromDb, Todo todoFromUserInput);
        Task Delete(Todo todo);
    }
}