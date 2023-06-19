using System;
namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter.SomeDependencies
{
    public class aTextConverterClient1
    {
        // A class with the only goal of simulating a dependency on UnicodeFileToHtmTextConverter
        // that has impact on the refactoring.

        private readonly UnicodeFileToHtmlTextConverter _textConverter;
        public aTextConverterClient1(UnicodeFileToHtmlTextConverter textConverter)
        // An IOC container will be responsible for providing this dependency via constructor injection
        {
            _textConverter = textConverter;
            ConvertSampleFileToHtml();
        }

        private void ConvertSampleFileToHtml()
        {
            var filename = "aFilename.txt";

            var html = _textConverter.ConvertToHtml(filename);
        }
    }
}