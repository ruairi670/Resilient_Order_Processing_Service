using DataModels.Data.DataTransferObjects.Base;

namespace DataModels.Data.DataTransferObjects
{
    public class NetworkTransferObject<T>
        //where T : BaseDTO
    {
        public T? TransferObject { get; set; }

        public Exception? Exception { get; set; }

        public NetworkTransferObject(T? transferObject, Exception? exception)
        {
            TransferObject = transferObject;
            Exception = exception;
        }
    }
}
