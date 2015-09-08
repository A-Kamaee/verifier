using System;

namespace Verifier.Reources
{
    public static class ExceptionMessage
    {
        // 10001
        public const String BillOfLadingOpenError = 
            "هنگام باز کردن فایل بارنامه خطا رخ داده است، لطفا فایل مورد نظر را بررسی کرده و دوباره امتحان کنید";

        // 10101
        public const String ContainerOpenError =
            "هنگام باز کردن فایل کانتینر خطا رخ داده است، لطفا فایل مورد نظر را بررسی کرده و دوباره امتحان کنید";

        // 10201
        public const String RelationOpen =
            "هنگام باز کردن فایل ارتباطات خطا رخ داده است، لطفا فایل مورد نظر را بررسی کرده و دوباره امتحان کنید";

        // 10301
        public const String VoyagSave =
            "هنگام ذخیره فایل نهایی خطای نامشخص رخ داده است، لطفا اطلاعات وارد شده را بررسی کرده و دوباره امتحان کنید";

        // 10001
        public const String VoyageOpenError =
            "هنگام باز کردن فایل مانیفست خطا رخ داده است، لطفا فایل مورد نظر را بررسی کرده و دوباره امتحان کنید";

        // 20001
        public const String ValidationBlank = "مقدار {0} نمی تواند خالی باشد.";

        // 20003
        public const String ValidationMaxLength = "اندازه ی مقدار {0} بیشتر از حد مجاز است.";

        // 20002
        public const String Format = 
            "فرمت فایل ورودی صحیح نمی باشد، لطفا فایل ورودی را بررسی کرده و دوباره امتحان کنید.";

    }
}
