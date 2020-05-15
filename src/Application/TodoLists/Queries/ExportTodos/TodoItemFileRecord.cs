using CinemaSeats.Application.Common.Mappings;
using CinemaSeats.Domain.Entities;

namespace CinemaSeats.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
