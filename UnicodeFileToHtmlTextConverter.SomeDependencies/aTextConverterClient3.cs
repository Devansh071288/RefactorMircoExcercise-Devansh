using System;
namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter.SomeDependencies
{
    public class aTextConverterClient3
    {
        // A class with the only goal of simulating a dependency on UnicodeFileToHtmTextConverter
        // that has impact on the refactoring.

        private readonly UnicodeFileToHtmlTextConverter _textConverter;

        public aTextConverterClient3(UnicodeFileToHtmlTextConverter textConverter)
        // An IOC container will be responsible for providing this dependency via constructor injection
        {
            _textConverter = textConverter;

            ConvertToHtmlSample();
        }

        private void ConvertToHtmlSample()
        {
            string[] args = { "jetAnotherFilename.txt" };

            string html = _textConverter.ConvertToHtml(args[0]);
        }
    }
}