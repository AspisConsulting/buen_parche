using BuenParche.Application.Common.Mappings;
using BuenParche.Domain.Entities;

namespace BuenParche.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
