namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task SaveAsync(TaskItem item);
        Task DeleteAsync(int id);
        Task<TaskItem> GetTaskAsync(int id);

    }
}
