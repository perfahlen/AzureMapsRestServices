using System;

namespace AzureMapsToolkit
{
    public class Response<T>
    {
        public int HttpResponseCode { get; set; }

        public T Result { get; set; }

        public ErrorResponse Error { get; set; }

        public static Response<T> CreateResponse(T t)
        {
            var response = new Response<T>
            {
                HttpResponseCode = 200,
                Result = t
            };
            return response;
        }
        //TODO Solve HttpResponseCode
        public static Response<T> CreateErrorResponse(Exception x){
            var res = new Response<T>
            {
                Error =
                  new ErrorResponse
                  {
                      Error = new Error
                      {
                          Message = x.Message
                      }
                  }
            };
            return res;
        }
    }
}
