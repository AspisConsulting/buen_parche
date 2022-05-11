using BuenParche.Application.TodoLists.Queries.ExportTodos;

namespace BuenParche.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
