using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlaUI.UIA2;
using FlaUI.Core.AutomationElements;
using System.Collections.Generic;
using ArrayProcessForm.Modules;
using System.Threading;

namespace Lab1Tests.Tests
{
    [TestClass]
    public class SystemTests
    {
        private FlaUI.Core.Application app;
        private List<int> testData;
        private int testDataAnalysisResult;

        private void PrepareTestData()
        {
            testData = new List<int> { 1171, 1234, 5688, 2372, 1111, 1488, 1337, 1036, 8922, 9876 };

            testDataAnalysisResult = 3;
        }
        
        [TestMethod]
        private void StartApplication()
        {
            app = FlaUI.Core.Application.Launch(Environment.CurrentDirectory.Replace('\\', '/') + "/../../../ArrayProcessForm/bin/Debug/ArrayProcessForm.exe");
        }

        [TestMethod]
        private void InputNumbers()
        {
            using (var automation = new UIA2Automation())
            {
                var window = app.GetMainWindow(automation);
                var submitButton = window.FindFirstDescendant(cf => cf.ByName("Ввод")).AsButton();
                var textBox = window.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Edit)).AsTextBox();

                foreach (int number in testData)
                {
                    textBox.Text = number.ToString();
                    Thread.Sleep(50);
                    submitButton.Invoke();
                }
            }
        }

        [TestMethod]
        private void ProcessNumbers()
        {
            using (var automation = new UIA2Automation())
            {
                var window = app.GetMainWindow(automation);
                var processButton = window.FindFirstDescendant(cf => cf.ByName("Обработать")).AsButton();

                processButton.Invoke();
            }
        }

        [TestMethod]
        private void CompareResults()
        {
            using (var automation = new UIA2Automation())
            {
                var window = app.GetMainWindow(automation);
                var outputMessage = window.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Window)).AsWindow();
                var okButton = outputMessage.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button)).AsButton();
                var outputText = outputMessage.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Text)).AsTextBox();
                string result = outputText.Text;

                if (result != "В введённом массиве нет подходящих под условия числел")
                {
                    result = result.Remove(0, "Количество подходящих под условия чисел в массиве: ".Length);
                    Assert.AreEqual(testDataAnalysisResult, Int32.Parse(result));
                }

                okButton.Invoke();
            }
        }

        [TestMethod]
        private void CloseApplication()
        {
            app.Close();
            app.Dispose();
        }

        [TestMethod]
        public void TestApplicationFully()
        {
            PrepareTestData();
            StartApplication();
            InputNumbers();
            ProcessNumbers();
            CompareResults();
            CloseApplication();
        }


    }
    
    
}
