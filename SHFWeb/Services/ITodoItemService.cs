using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SHFWeb.Models;

namespace SHFWeb.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}
