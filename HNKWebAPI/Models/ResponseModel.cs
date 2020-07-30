namespace HNKWebAPI.Models {
    public class ResponseModel {
        public ResponseModel() {
            Code = 1;
            Message = "请求成功";
            DataCount = 0;
        }

        public int Code { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public int DataCount { get; set; }
    }
}
