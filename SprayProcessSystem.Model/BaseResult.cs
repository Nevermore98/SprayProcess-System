namespace SprayProcessSystem.Model
{
    public class BaseResult
    {
        public Constants.Result Result { get; set; } = Constants.Result.Fail;
        public string Message { get; set; } = string.Empty;
    }

    public class BaseResult<T> : BaseResult
    {
        public List<T>? Data { get; set; }
    }
}
