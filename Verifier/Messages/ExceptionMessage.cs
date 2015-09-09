using System;

namespace Verifier.Reources
{
    public static class ExceptionMessage
    {
        // 30001
        public const String FileOpenError =
            "هنگام باز کردن فایل خطا رخ داده است، لطفا فایل مورد نظر را بررسی کرده و دوباره امتحان کنید";

        // 10002
        public const String ValidationBlank = "مقدار {0} نمی تواند خالی باشد.";

        // 20003
        public const String ValidationMaxLength = "اندازه ی مقدار {0} بیشتر از حد مجاز است.";

        // 30002
        public const String Format = 
            "فرمت فایل ورودی صحیح نمی باشد، لطفا فایل ورودی را بررسی کرده و دوباره امتحان کنید.";

        // 30003
        public const String FileNotFound =
            "فایل {0} یافت نشد، لطفا اطلاعات وارد شده را بررسی نموده و دوباره امتحان کنید.";

    }
}
