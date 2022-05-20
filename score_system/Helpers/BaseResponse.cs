namespace score_system.Helpers
{
    public class BaseResponse
    {
        public bool Ok { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public int Exito { get; set; }
        public int Fallo { get; set; }


        public BaseResponse() { }

        public BaseResponse(string message, object data, bool ok = false, int exito = 1, int fallo = 0)
        {
            Ok = ok;
            Message = message;
            Data = data;
            Exito = exito;
            Fallo = fallo;
        }
    }
}
