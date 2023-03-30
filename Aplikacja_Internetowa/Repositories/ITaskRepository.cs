using Aplikacja_Internetowa.Models;

namespace Aplikacja_Internetowa.Repositories
{
    public interface ITaskRepository
    {

        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetAllActivate();
        void Add(TaskModel task);
        void Update(int taskId,TaskModel task);
        void Delete(int taskId);
    }
}
