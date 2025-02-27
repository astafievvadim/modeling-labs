using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace modeling_lab
{
    public partial class InfixInputForm : Form
    {

        private readonly MainForm mainForm;

        SymbolType lastSymbol = SymbolType.StartedANewOne;

        int unsolvedBrackets = 0;

        public string function = "";

        List<Button> varButtons = new List<Button>();
        List<Button> bracketButtons = new List<Button>();
        List<Button> opButtons = new List<Button>();
        List<Button> funcButtons = new List<Button>();

        public InfixInputForm(MainForm main)
        { 
            InitializeComponent();
            initLists();

            infixLabel.Text = function;
            mainForm = main;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            // Проверяем, является ли нажатая кнопка объектом Button
            if (sender is Button clickedButton)
            {
                // Если нажатая кнопка - переменная и последний символ выражения соответствует определённым условиям
                if (varButtons.Contains(clickedButton) && (
                    lastSymbol == SymbolType.StartedANewOne ||
                    lastSymbol == SymbolType.Operation ||
                    lastSymbol == SymbolType.Function ||
                    lastSymbol == SymbolType.LeftBracket))
                {
                    // Добавляем текст кнопки к выражению
                    function += clickedButton.Text.ToString();

                    // Обновляем статус последнего символа
                    lastSymbol = SymbolType.Variable;
                }
                else if (bracketButtons.Contains(clickedButton)) // Если нажатая кнопка - скобка
                {
                    // Если нажата левая скобка
                    if (clickedButton == leftBracketButton && (
                        lastSymbol == SymbolType.StartedANewOne ||
                        lastSymbol == SymbolType.LeftBracket ||
                        lastSymbol == SymbolType.Operation ||
                        lastSymbol == SymbolType.Function))
                    {
                        unsolvedBrackets += 1; // Увеличиваем число незакрытых скобок
                        function += clickedButton.Text.ToString(); // Добавляем скобку к выражению

                        lastSymbol = SymbolType.LeftBracket; // Обновляем статус последнего символа
                    }
                    // Если нажата правая скобка
                    else if ((clickedButton == rightBracketButton) && (
                        lastSymbol == SymbolType.Variable ||
                        lastSymbol == SymbolType.RightBracket) &&
                        unsolvedBrackets > 0) // Проверяем, есть ли незакрытые скобки
                    {
                        unsolvedBrackets -= 1; // Уменьшаем число незакрытых скобок
                        function += clickedButton.Text.ToString(); // Добавляем скобку к выражению

                        lastSymbol = SymbolType.RightBracket; // Обновляем статус последнего символа
                    }
                }
                else if (opButtons.Contains(clickedButton) && lastSymbol != SymbolType.Operation) // Если нажатая кнопка - операция
                {
                    function += clickedButton.Text.ToString(); // Добавляем операцию к выражению
                    lastSymbol = SymbolType.Operation; // Обновляем статус последнего символа
                }
                else if (funcButtons.Contains(clickedButton) &&
                    lastSymbol != SymbolType.Variable &&
                    lastSymbol != SymbolType.RightBracket
                    ) // Если нажатая кнопка - функция
                {
                    function += clickedButton.Text.ToString() + "("; // Добавляем функцию и открывающую скобку
                    unsolvedBrackets += 1; // Увеличиваем число незакрытых скобок

                    lastSymbol = SymbolType.Function; // Обновляем статус последнего символа
                }
            }

            infixLabel.Text = function; // Обновляем отображение введённого выражения
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Проверяем, является ли выражение пустым
            if (lastSymbol == SymbolType.StartedANewOne)
            {
                MessageBox.Show("Пустое выражение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (unsolvedBrackets > 0) // Проверяем наличие незакрытых скобок
            {
                MessageBox.Show("В выражении есть незакрытые скобки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (lastSymbol == SymbolType.Variable || lastSymbol == SymbolType.RightBracket) // Проверяем допустимые последние символы
            {
                mainForm.setInfixInput(function); // Передаём выражение в основную форму
                Close(); // Закрываем текущее окно
                return;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close(); // Закрываем текущее окно
        }

        private void clearEverythingButton_Click(object sender, EventArgs e)
        {
            function = ""; // Очищаем выражение
            infixLabel.Text = function; // Обновляем отображение
            mainForm.setInfixInput(function); // Передаём очищенное выражение в основную форму

            lastSymbol = SymbolType.StartedANewOne; // Сбрасываем статус последнего символа

        }

        private void initLists()
        {
            // Инициализация списка кнопок переменных
            varButtons.Add(aButton);
            varButtons.Add(bButton);
            varButtons.Add(cButton);
            varButtons.Add(dButton);
            varButtons.Add(eButton);
            varButtons.Add(fButton);

            // Инициализация списка кнопок скобок
            bracketButtons.Add(leftBracketButton);
            bracketButtons.Add(rightBracketButton);

            // Инициализация списка кнопок операций
            opButtons.Add(plusButton);
            opButtons.Add(minusButton);
            opButtons.Add(multiplyButton);
            opButtons.Add(divideButton);

            // Инициализация списка кнопок функций
            funcButtons.Add(sineButton);
            funcButtons.Add(cosineButton);
            funcButtons.Add(logarithmButton);
            funcButtons.Add(tangentButton);
        }


        private void InfixInputForm_Load(object sender, EventArgs e)
        {

        }
    }

    enum SymbolType
    {
        StartedANewOne,
        Variable,
        LeftBracket,
        RightBracket,
        Operation,
        Function
    }


}
