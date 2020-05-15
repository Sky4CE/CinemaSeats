using CinemaSeats.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace CinemaSeats.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
