using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SHFWeb.Models;

namespace SHFWeb.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                
                IsDone = true ,
                Title = "苏州顺和丰家电科技有限公司",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new TodoItem
            {
                IsDone = false,
                Title = "从入门到专业品尝的忠实伴侣",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            var item3 = new TodoItem
            {
                IsDone = true,
                Title = "如何成为一个欠揍的大SB呀？",
                DueAt = DateTimeOffset.Now.AddDays(3)
            };   
            
            var item4 = new TodoItem
            {
                IsDone = true,
                Title = "如何成为一个欠揍的大SB呀？",
                DueAt = DateTimeOffset.Now.AddDays(4)
            };
               
            var item5 = new TodoItem
            {
                IsDone = false,
                Title = "如何成为一个欠揍的大SB呀？",
                DueAt = DateTimeOffset.Now.AddDays(5)
            };
               
            var item6 = new TodoItem
            {
                IsDone = true,
                Title = "如何成为一个欠揍的大SB呀？",
                DueAt = DateTimeOffset.Now.AddDays(6)
            };




            return Task.FromResult(new[]{item1,item2,item3,item4,item5,item6});

        }
    }
}