using System;
namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter.SomeDependencies
{
    public class aTextConverterClient2
    {
        // A class with the only goal of simulating a dependency on UnicodeFileToHtmTextConverter
        // that has impact on the refactoring.


        private readonly UnicodeFileToHtmlTextConverter _textConverter;

        public aTextConverterClient2(UnicodeFileToHtmlTextConverter textConverter)
        // An IOC container will be responsible for providing this dependency via constructor injection
        {
            _textConverter = textConverter;

            ConverttoHTMLSample();
        }

        private void ConverttoHTMLSample()
        {
            var html = _textConverter.ConvertToHtml("anotherFilename.txt");
        }

    }
}