using System.Globalization;
using BuenParche.Application.Common.Interfaces;
using BuenParche.Application.TodoLists.Queries.ExportTodos;
using BuenParche.Infrastructure.Files.Maps;
using CsvHelper;

namespace BuenParche.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
