using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArrayProcessForm.Modules;

namespace ArrayProcessForm
{
    public partial class ArrayProcessForm : Form
    {
        private const string ArraySizeError = "Обрабатываемый массив должен содержать 10 чисел!";
        public ArrayProcessForm()
        {
            InitializeComponent();
        }

        private void AlertMsgBox(string message)
        {
            MessageBox.Show(message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void InfoMsgBox(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (DigitCountCalculator.Calculate(NumberInputTextBox.Text) < 4) AlertMsgBox("Требуется вводить четырёхзначные числа!");
            else if (NumbersListBox.Items.Count >= 10) AlertMsgBox(ArraySizeError);
            else
            {
                NumbersListBox.Items.Add(NumberInputTextBox.Text);
                progressBar1.Value = NumbersListBox.Items.Count;
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (NumbersListBox.Items.Count < 10) AlertMsgBox(ArraySizeError);
            else
            {
                List<int> numbersList = ArrayConverter.Convert(NumbersListBox.Items);
                int fittingNumbersCount = 0;

                foreach (int number in numbersList)
                {
                    if (DigitAverageCalculator.Calculate(number) < 7 && MaxDigitFinder.Find(number) == 7) fittingNumbersCount++;
                }

                if (fittingNumbersCount > 0) InfoMsgBox("Количество подходящих под условия чисел в массиве: " + fittingNumbersCount.ToString());
                else InfoMsgBox("В введённом массиве нет подходящих под условия числел");
            }
        }

        private void NumberInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
