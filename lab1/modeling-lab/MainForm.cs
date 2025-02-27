using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace modeling_lab
{
    public partial class MainForm : Form
    {
        InfixInputForm infixInputForm;
        AlphabetTableForm alphabetTableForm;

        List<char> stack = new List<char>();
        int stackPointer = 0;

        bool stopConv;

        string input = "";
        string output = "";
        string inProcess = ""; //отображение процесса удаления символов из исходной строки

        string[] decisionTableHeaders = {"$", "+", "-", "*", "/", "^", "(", ")", "F", "P" };
        string[] decisionTableRowHeaders = { "$", "+", "-", "*", "/", "^", "(", "F" };

        const long oneSecond = 10000000;

        int[,] desicionTable = {
            {4, 1, 1, 1, 1, 1, 1, 5, 1, 6 },
            {2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            {2, 2, 2, 1, 1, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 1, 1, 2, 1, 6 },
            {2, 2, 2, 2, 2, 2, 1, 2, 1, 6 },
            {5, 1, 1, 1, 1, 1, 1, 3, 1, 6 },
            {2, 2, 2, 2, 2, 2, 1, 2, 5, 6 }
        };

        Dictionary<string, string> functionToSymbol = new Dictionary<string, string>
            {
                {"arcsin", "а"}, {"arccos", "б"}, {"sin", "в"},
                {"cos", "г"}, {"arcctg", "д"}, {"arctg", "е"},
                {"ctg", "ж"}, {"tg", "з"}, {"ln", "и"},
                {"arsh", "к"}, {"arch", "л"}, {"arth", "м"},
                {"arcth", "н"}, {"sh", "о"}, {"ch", "п"},
                {"cth", "р"}, {"th", "с"}, {"abs", "т"},
                {"exp", "у"}, {"lg", "ф"}, {"round", "х"},
                {"trunc", "ц"}, {"fruc", "ч"}
        };



        public MainForm()
        {

            InitializeComponent();
            InitializeDecisionTable();

            automaticRadioButton.Checked = true;

            ArrowPanel arrowPanel = new ArrowPanel();
            arrowPanel.Size = new Size(125, 30); // Размер панели стрелки
            pointerFlowLayoutPanel.Controls.Add(arrowPanel); // Добавляем панель стрелки в элемент управления
        }

        private void InitializeDecisionTable()
        {
            int height = desicionTable.GetLength(0);
            int width = desicionTable.GetLength(1);

            this.decisionDataGridView.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.decisionDataGridView);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = desicionTable[r, c];
                }

                this.decisionDataGridView.Rows.Add(row);
            }

            foreach (DataGridViewColumn col in decisionDataGridView.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            
            for (int r = 0; r < decisionTableHeaders.Length; r++)
            {
                decisionDataGridView.Columns[r].HeaderText = decisionTableHeaders[r];
            }

            
            for (int r = 0; r < decisionTableRowHeaders.Length; r++)
            {
                decisionDataGridView.Rows[r].HeaderCell.Value = decisionTableRowHeaders[r];
            }
            
        }

        private void setInfixButton_Click(object sender, EventArgs e)
        {
            //Включаем форму ввода выражения

            infixInputForm = new InfixInputForm(this);
            infixInputForm.Show();
        }

        private void alphabetButton_Click(object sender, EventArgs e)
        {
            alphabetTableForm = new AlphabetTableForm(functionToSymbol);
            alphabetTableForm.Show();
        }

        internal void setInfixInput(string function)
        {
            input = function;
            inputTextBox.Text = function;

            inProcess = moveToOneSymbolAlphabet(input);
            inProgressTextBox.Text = function;
            
            output = string.Empty;
            outputTextBox.Text = output;
        }
        private void processConvertionStep()
        {
            int decisionCode = getDecisionCode(); // Получаем код решения

            // Обработка кода решения
            switch (decisionCode)
            {
                case 1:
                    sendToStack(); // Отправляем в стек
                    break;
                case 2:
                    sendFromStackToOutput(); // Перемещаем из стека в выход
                    break;
                case 3:
                    processBrackets(); // Обрабатываем скобки
                    break;
                case 4:
                    displayConvertationEndingMsg(); // Показываем сообщение о завершении преобразования
                    stopConv = true; // Устанавливаем флаг остановки преобразования
                    break;
                case 5:
                    displayErrorMsg(); // Отображаем ошибку
                    stopConv = true; // Устанавливаем флаг остановки преобразования
                    break;
                case 6:
                    sendToOutput(); // Отправляем в выход
                    break;
            }

            redrawPointer(); // Перерисовываем указатель
        }

        private void redrawPointer()
        {
            pointerFlowLayoutPanel.Controls.Clear(); // Очищаем панель указателя

            Panel panel;
            // Создаем панели для каждого элемента в стеке, кроме последнего
            for (int i = 0; i < stack.Count - 1; i++)
            {
                panel = new Panel();
                panel.Size = new Size(125, 30); // Устанавливаем размер панели

                pointerFlowLayoutPanel.Controls.Add(panel); // Добавляем панель в элемент управления
            }

            ArrowPanel arrowPanel = new ArrowPanel();
            arrowPanel.Size = new Size(125, 30); // Размер панели стрелки
            pointerFlowLayoutPanel.Controls.Add(arrowPanel); // Добавляем панель стрелки в элемент управления
        }

        private void redrawStack()
        {
            stackFlowLayoutPanel.Controls.Clear(); // Очищаем панель стека
            Panel panel;

            // Создаем панели для каждого элемента в стеке
            foreach (var element in stack)
            {
                panel = new Panel();
                panel.Size = new Size(125, 30); // Устанавливаем размер панели
                panel.BorderStyle = BorderStyle.FixedSingle; // Добавляем границы панели
                Label label = new Label();
                label.Text = element.ToString(); // Устанавливаем текст метки

                panel.Controls.Add(label); // Добавляем метку в панель
                stackFlowLayoutPanel.Controls.Add(panel); // Добавляем панель в элемент управления
            }
        }

        private async void processAutomatically()
        {
            // Цикл для автоматической обработки, пока не будет остановлено
            while (!stopConv)
            {
                processConvertionStep(); // Выполняем шаг преобразования
                await Task.Delay(new TimeSpan(oneSecond)); // Задержка в одну секунду
            }

            stopButton.Enabled = false; // Отключаем кнопку остановки
            startButton.Enabled = true; // Включаем кнопку старта
        }

        private int getDecisionCode()
        {
            // Получаем код решения из таблицы решений
            return desicionTable[getRow(), getCol()];
        }

        private int getCol()
        {
            int col = 0; // Переменная для хранения индекса столбца

            if (inProcess.Length != 0) // Проверяем, не пустая ли строка
            {
                // Определение столбца на основе первого символа входной строки
                switch (inProcess[0])
                {
                    case ' ':
                        col = 0;
                        break;
                    case '+':
                        col = 1;
                        break;
                    case '-':
                        col = 2;
                        break;
                    case '*':
                        col = 3;
                        break;
                    case '/':
                        col = 4;
                        break;
                    case '^':
                        col = 5;
                        break;
                    case '(':
                        col = 6;
                        break;
                    case ')':
                        col = 7;
                        break;
                    case 'в':
                    case 'г':
                    case 'з':
                    case 'и':
                        col = 8;
                        break;
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                        col = 9;
                        break;
                    default:
                        col = 0; // По умолчанию столбец 0
                        break;
                }
            }
            return col; // Возвращаем индекс столбца
        }

        private int getRow()
        {
            int row = 0; // Переменная для хранения индекса строки

            if (stack.Count != 0) // Проверяем, не пуст ли стек
            {
                // Определение строки на основе последнего элемента в стеке
                switch (stack.Last())
                {
                    case ' ':
                        row = 0;
                        break;
                    case '+':
                        row = 1;
                        break;
                    case '-':
                        row = 2;
                        break;
                    case '*':
                        row = 3;
                        break;
                    case '/':
                        row = 4;
                        break;
                    case '^':
                        row = 5;
                        break;
                    case '(':
                        row = 6;
                        break;
                    case 'в':
                    case 'г':
                    case 'з':
                    case 'и':
                        row = 7;
                        break;
                    default:
                        row = 0; // По умолчанию строка 0
                        break;
                }
            }
            return row; // Возвращаем индекс строки
        }

        private string moveToOneSymbolAlphabet(string str)
        {
            string result = str;

            // Замена символов по заданному алфавиту
            foreach (var pair in functionToSymbol)
            {
                result = result.Replace(pair.Key, pair.Value);
            }

            return result;
        }

        // Помещаем символ из входной строки в стек
        // Помещаем символ из входной строки в стек
        private void sendToStack()
        {
            stackPointer += 1;
            if (stackPointer < stack.Count)
            {
                stack[stackPointer] = inProcess[0]; // Обновляем существующий элемент
            }
            else
            {
                stack.Add(inProcess[0]); // Добавляем новый элемент
            }

            redrawStack(); // Обновляем отображение стека

            inProcess = inProcess.Substring(1); // Убираем обработанный символ из входной строки
            inProgressTextBox.Text = inProcess; // Обновляем текстовое поле
        }

        // Извлекаем символ из стека и отправляем его в выходную строку
        private void sendFromStackToOutput()
        {
            if (stackPointer > 0)
            {
                stackPointer -= 1;
            }
            else stackPointer = 0;

            output += stack.Last(); // Добавляем последний элемент стека в выход

            stack.RemoveAt(stackPointer); // Удаляем элемент из стека

            outputTextBox.Text = output; // Обновляем текстовое поле для выхода
        }

        // Удаляем ")" из входной строки и "(" из стека
        private void processBrackets()
        {
            if (stackPointer > 0)
            {
                stackPointer -= 1;
            }
            else stackPointer = 0;
             // Сдвигаем указатель стека

            inProcess = inProcess.Substring(1); // Убираем символ из входной строки
            inProgressTextBox.Text = inProcess; // Обновляем текстовое поле
            stack.RemoveAt(stackPointer); // Удаляем элемент из стека
        }


        // Успешное окончание преобразования
        private void displayConvertationEndingMsg()
        {
            MessageBox.Show("Преобразования выполнены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information); // Сообщение об успешном завершении

            stack = new List<char>();// Очищаем стек
        }

        // Обработка ошибки
        private void displayErrorMsg()
        {
            MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Сообщение об ошибке

            stopConv = true; // Устанавливаем флаг остановки
            startButton.Enabled = true; // Включаем кнопку старта
            stopButton.Enabled = false; // Выключаем кнопку остановки
        }

        // Пересылаем символ из входной строки в выходную
        private void sendToOutput()
        {
            output += inProcess[0]; // Добавляем символ в выход
            inProcess = inProcess.Substring(1); // Убираем символ из входной строки
            inProgressTextBox.Text = inProcess; // Обновляем текстовое поле
            outputTextBox.Text = output; // Обновляем текстовое поле для выхода
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (inProcess == string.Empty)
            {
                MessageBox.Show("Пустое выражение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            stopConv = false;
            processAutomatically();

            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopConv = true;

            MessageBox.Show("Работа приостановлена", "Стоп", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            stopButton.Enabled = false;
            startButton.Enabled = true;
        }

        private void oneStepButton_Click(object sender, EventArgs e)
        {
            processConvertionStep();
        }

        private void automaticRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void stepRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            oneStepButton.Enabled = true;
            startButton.Enabled = false;
            stopButton.Enabled = false;
        }
    }


    class ArrowPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Создаем объект для рисования
            using (Graphics g = e.Graphics)
            {
                // Определяем точки для рисования стрелки
                Pen p = new Pen(Color.Blue);
                p.Width = 5;
                p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                e.Graphics.DrawLine(p, 0, 15, 80, 15);
            }
        }
    }
}

