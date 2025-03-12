namespace ConsoleAppPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "4444433555555 555666096667775553#";
            var result = Phone.ConvertToText(inputString);
            var expectedResult = "hello world";


            inputString = "34447288555#";
            result = Phone.ConvertToText(inputString);
            expectedResult = "dipaul";

            inputString = "446669086660777733802224427772 2228337770277770336789990444660222#";
            result = Phone.ConvertToText(inputString);
            expectedResult = "how to set character as empty in c";

            inputString = "7 7776668884443 3377770207666 66655506663330844777332377770844280222 26602233088777733 308666033993322288 80827777557777#";
            result = Phone.ConvertToText(inputString);
            expectedResult = "provides a pool of threads that can be used to execute tasks";

            // нажатие 1 и цикличный нажатие 7
            inputString = "7 7776668881114443 33333777777770207666 66655506663330844777332377770844280222 26602233088777733 308666033993322288 80827777557777#";
            result = Phone.ConvertToText(inputString);
            expectedResult = "provides a pool of threads that can be used to execute tasks";

            //*
            inputString = "7 7776668884443 33*3377770207666 66655506663330844777332377770844280222 26602233088777733 308666033993322288 80827777557777#";
            result = Phone.ConvertToText(inputString);
            expectedResult = "provides a pool of threads that can be used to execute tasks";
        }

      
    }
}
