using FlaUI.Core;
using FlaUI.UIA3;
using NUnit.Framework;

namespace Edi.UITests
{
    public class OpenFileTests
    {
        
        private const string EdiPath = @"C:\QATest\Edi\Debug\Edi.exe";

        private Application _app = null!;
        private UIA3Automation _automation = null!;

        [SetUp]
        public void SetUp()
        {
            _app = Application.Launch(EdiPath);
            _automation = new UIA3Automation();
        }

        [Test]
        public void LaunchEdi_MainWindowAppears()
        {
            var window = _app.GetMainWindow(_automation, TimeSpan.FromSeconds(15));

            Console.WriteLine("Main window title: " + window.Title);
            Assert.That(window, Is.Not.Null);
        }

        [TearDown]
        public void TearDown()
        {
            _app?.Close();
            _automation?.Dispose();
        }
    }
}
