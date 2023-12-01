namespace GymOrganization.Infrastructure.Results;

public class OperationResult<T> where T : class, new() 
{
    public ResultStatus Status { get; set; }
    public T? Result { get; set; }
    public Exception? Exception { get; set; }
    public string? ErrorMessage { get; set; }

     public static OperationResult<T> Invoke(Func<T?> func)
    {
        T? result;

        try
        {
            result = func();
        }
        catch (Exception e)
        {
            return ExceptionFail(e, errorMessage: e.Message);
        }

        return Success(result);
    }

     public static async Task<OperationResult<T>> InvokeNotNull(Func<Task<T?>> func)
     {
         T? result;
         try
         {
             result = await func();
             if (result is null)
                 throw new ArgumentException("Result is null");
         }
         catch (Exception e)
         {
             return ExceptionFail(e, errorMessage: e.Message);
         }

         return Success(result);
     }

    public static async Task<OperationResult<T>> Invoke(Func<Task<T?>> func)
    {
        T? result;

        try
        {
            result = await func();
        }
        catch (Exception e)
        {
            return ExceptionFail(e, errorMessage: e.Message);
        }

        return Success(result);
    }

    public static OperationResult<EmptyResult> Invoke(Action func)
    {
        try
        {
            func();
        }
        catch (Exception e)
        {
            return OperationResult<EmptyResult>.ExceptionFail(e, errorMessage: e.Message);
        }
    
        return OperationResult<EmptyResult>.Success(default);
    }
    
    public static async Task<OperationResult<EmptyResult>> Invoke(Func<Task> func)
    {
        try
        {
            await func();
        }
        catch (Exception e)
        {
            return OperationResult<EmptyResult>.ExceptionFail(e, errorMessage: e.Message);
        }
    
        return OperationResult<EmptyResult>.Success(default);
    }

    public static OperationResult<T> Success(T? result) =>
        new()
        {
            Status = ResultStatus.Success,
            Result = result
        };

    public static OperationResult<T> Fail(
            string? errorMessage,
            T? result = default,
            Exception? exception = null
        ) =>
        new()
        {
            Status = ResultStatus.Failure,
            Result = result,
            ErrorMessage = errorMessage,
            Exception = exception
        };

    public static OperationResult<T> ValidationFail(
            string? errorMessage,
            T? result = default,
            Exception? exception = null
        ) =>
        new()
        {
            Status = ResultStatus.ValidationError,
            Result = result,
            ErrorMessage = errorMessage,
            Exception = exception
        };

    public static OperationResult<T> ExceptionFail(
            Exception? exception,
            T? result = default,
            string? errorMessage = null
        ) =>
        new()
        {
            Status = ResultStatus.Exception,
            Result = result,
            ErrorMessage = errorMessage,
            Exception = exception
        };
}