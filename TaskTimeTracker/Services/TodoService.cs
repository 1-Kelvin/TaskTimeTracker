using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Services
{
    public class TodoService : ITodoService
    {
        readonly UserContext _context = null;

        public TodoService(UserContext context)
        {
            _context = context;
        }

        // TODO
        public async Task<bool> AddToDo(Todo toDo, User user)
        {
            return await Task.Run<bool>(
                () =>
                {
                    Todo td = _context.ToDos.FirstOrDefault(t => t.Id == toDo.Id);
                    User usr = _context.Users.FirstOrDefault(u => u.Id == user.Id);
                    if (td != null && usr != null)
                    {
                        td.User = usr;
                        td.UserID = usr.Id;
                        usr.ToDos.Add(td);

                        _context.SaveChanges();
                        return true;
                    }

                    return false;
                });
           

            throw new NotImplementedException();
        
        }

        public async Task<IEnumerable<Todo>> GetAll()
        {
            return await Task.Run<IEnumerable<Todo>>(
                () => _context.ToDos.Select(
                    todo => new Todo
                    {
                        Id = todo.Id,
                        Title = todo.Title,
                        Description = todo.Description,
                        ToFinish = todo.ToFinish
                    }));
        }

        public async Task<Todo> GetToDo(int id)
        {
            return await Task.Run<Todo>(
                () => _context.ToDos.FirstOrDefault(t => t.Id == id));
        }

        public async Task<bool> SaveToDoData(Todo toDo)
        {
            return await Task.Run<bool>( () =>
            {
              Todo td = _context.ToDos.FirstOrDefault(t => t.Id == toDo.Id);
              if (td != null)
              {
                  td.Title = toDo.Title;
                  td.Description = toDo.Description;
                  td.ToFinish = toDo.ToFinish;
                  td.Finished = toDo.Finished;
                  td.UserID = toDo.UserID;
                  _context.SaveChanges();
                  return true;
              }
                return false;
          });

        }
    }
}
