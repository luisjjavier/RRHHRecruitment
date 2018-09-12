namespace RRHHRecruitment.Core.Contracts
{
    public interface IOperationResult<T>
    {
        string Message { get; }
        bool Success { get; }
        T Entity { get; }
    }
}