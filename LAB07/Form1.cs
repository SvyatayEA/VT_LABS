using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace LAB07
{
    public partial class Form1 : Form
    {
        // ListBox — список элементов управления и диалогов (левая часть интерфейса)
        private ListBox listBox;

        // root — основной контейнер, делит форму на 2 части (меню + контент)
        private TableLayoutPanel root;

        // header — заголовок справа, показывает выбранный пункт
        private Label header;

        // content — контейнер для динамического размещения элементов
        private TableLayoutPanel content;

        // timer — используется в заданиях (например, часы или ProgressBar)
        private System.Windows.Forms.Timer timer;

        // Цвета темы интерфейса (тёмная тема)
        // Общий Цвет Фона
        private Color bg = Color.FromArgb(43, 43, 43);

        // Цвет правой панели
        private Color panelBg = Color.FromArgb(60, 63, 65);

        // Цвет Шрифта
        private Color fg = Color.FromArgb(169, 183, 198);

        // =========================
        // Задание 1: Конструктор формы
        // =========================
        public Form1()
        {
            // TODO:
            // 1. Установить заголовок формы (Text) "Лабораторная 7"
            // 2. Задать размеры формы (Size) 1000x600
            // 3. Установить шрифт (Font) JetBrains Mono NL, 20
            // 4. Применить цвета (BackColor, ForeColor) bg, fg
            // 5. Создать/инициализировать TableLayoutPanel (root)
            // 6. Настроить 2 (ColumnCount) колонки ColumnStyles.Add
            // (фиксированная SizeType.Absolute (размер 300) + растягиваемая SizeType.Percent(100%))
            // 7. Добавить root в Controls
            // 8. Вызвать InitListBox()
            // 9. Вызвать InitRightPanel()
            this.Text = "Лабораторная 7";
            this.Size = new Size(1000, 600);
            this.Font = new Font("JetBrains Mono NL", 20);
            this.BackColor = bg;
            this.ForeColor = fg;

            root = new TableLayoutPanel();
            root.Dock = DockStyle.Fill;
            root.ColumnCount = 2;
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            this.Controls.Add(root);

            InitListBox();
            InitRightPanel();
        }

        // =========================
        // Задание 2: Инициализация ListBox
        // =========================
        private void InitListBox()
        {
            // TODO:
            // 1. Создать/инициализировать ListBox (listbox)
            // 2. Dock = Fill
            // 3. Настроить цвета (фон = panelBg, текст = fg)
            // 4. Убрать рамку (BorderStyle = None)
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            listBox.BackColor = panelBg;
            listBox.ForeColor = fg;
            
            // 5. Добавить элементы списка Items.Add(new string[]{}) (строго в таком порядке):
            //    "DateTimePicker"
            //    "NumericUpDown"
            //    "PictureBox"
            //    "TrackBar"
            //    "Timer"
            //    "ProgressBar"
            //    "ComboBox"
            //    "MessageBox"
            //    "ColorDialog"
            //    "OpenFileDialog"
            //    "FontDialog"
            //    "Немодальное окно"
            listBox.Items.AddRange(new string[] { "DateTimePicker", "NumericUpDown", "PictureBox", "TrackBar", "Timer", "ProgressBar", "ComboBox", "MessageBox", "ColorDialog", "OpenFileDialog", "FontDialog", "Немодальное окно" });

            // 6. Подписаться на событие SelectedIndexChanged
            //    (обработчик: OnSelect)
            listBox.SelectedIndexChanged += OnSelect;
            // 7. Добавить ListBox в root:
            //    - колонка 0, строка 0 (левая часть интерфейса)
            root.Controls.Add(listBox, 0, 0);
        }

        // =========================
        // Задание 3: Правая панель (заголовок + контент)
        // =========================
        private void InitRightPanel()
        {
            // TODO:
            // 1. Создать TableLayoutPanel right (правая часть)
            // 2. Dock = Fill (растянуть на все занимаемое место)
            // 3. Разделить на 2 строки (RowCount = 2)
            // 4. Настроить строки RowStyles.Add
            // (фиксированная SizeType.Absolute (размер 60) + растягиваемая SizeType.Percent(100%))
            // 5. Создать/инициализировать Label (header)
            // 6. Настроить выравнивание и отступы (Dock(Fill), Padding(10), TextAlign(ContentAlignment.MiddleLeft))
            TableLayoutPanel right = new TableLayoutPanel();
            right.Dock = DockStyle.Fill;
            right.RowCount = 2;
            right.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            right.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            header = new Label(); 
            header.Dock = DockStyle.Fill;
            header.Padding = new Padding (10);
            header.TextAlign = ContentAlignment.MiddleLeft;



            // 7. Создать/инициализировать TableLayoutPanel (content)
            // 8. Включить прокрутку AutoScroll(true), Dock (Fill), Padding(20), BackColor(panelBg)
            // 9. Добавить header и content в right
            // 10. Добавить right в root (правая колонка) 1, 0

            content = new TableLayoutPanel();
            content.AutoScroll = true;
            content.Dock = DockStyle.Fill;
            content.Padding = new Padding(20);
            content.BackColor = panelBg;

            right.Controls.Add(header);
            right.Controls.Add(content);
            root.Controls.Add(right);


        }

        // =========================
        // Задание 4: Заголовок
        // =========================
        private void SetHeader(string text)
        {
            // TODO:
            // 1. Установить текст header:
            //    "Демонстрация работы: " + text

            header.Text = "Демонстрация работы: " + text;
        }

        // =========================
        // Задание 5: Очистка панели
        // =========================
        private void Clear()
        {
            // TODO:
            // 1. Очистить  content.Controls.Clear()
            // 2. Очистить RowStyles
            // 3. Сбросить RowCount (0)
            // 4. Остановить timer (если используется)
            // если timer != 0, Stop()

            content.Controls.Clear();
            content.RowStyles.Clear();
            content.RowCount = 0;

            if(timer != null)
            {
                timer.Stop();
            }
        }

        // =========================
        // Готовый метод (использовать)
        // =========================
        private void AddControl(Control c)
        {
            c.Dock = DockStyle.Top;
            c.Margin = new Padding(0, 0, 0, 15);
            c.BackColor = panelBg;
            c.ForeColor = fg;

            content.RowCount++;
            content.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            content.Controls.Add(c, 0, content.RowCount - 1);
        }

        // =========================
        // Задание 6: Обработка выбора
        // =========================
        private void OnSelect(object sender, EventArgs e)
        {
            // TODO:
            // 1. Вызвать Clear()
            // 2. Получить выбранный элемент string selected в ListBox (SelectedItem)
            // 3. Установить заголовок через SetHeader(выбраный элемент)
            // 4. Через switch (listBox.SelectedIndex) вызвать нужный метод

            Clear();

            string selected = listBox.SelectedItem.ToString();

            SetHeader(selected);

            switch(listBox.SelectedIndex)
            {
                case 1:
                    NumericDemo();
                    break;
                case 3:
                    TrackDemo();
                    break;
                case 5:
                    ProgressDemo();
                    break;
                case 7:
                    MessageDemo();
                    break;
                case 9:
                    FileDemo();
                    break;
                case 11:
                    NonModalDemo();
                    break;
            }

        }

        // =========================
        // Задание 7: DateTimePicker
        // =========================
        private void DateTimeDemo()
        {
            // TODO:
            // 1. Создать DateTimePicker dt
            // 2. Создать Label lb (Autosize = True)
            // 3. Обработать событие ValueChanged с помощью лямбда-выражения (s, e) =>
            // 4. Выводить дату в lb (dt.Value.ToLongDateString();)
            // 5. Добавить dt, lb через AddControl()

            // Example:
            // При выборе даты в DateTimePicker,
            // в Label отображается:
            // "Понедельник, 1 января 2026 г."
        }

        // =========================
        // Задание 8: NumericUpDown
        // =========================
        private void NumericDemo()
        {
            // TODO:
            // 1. Создать NumericUpDown num
            // 2. Задать диапазон (например 0–100) Minumum, Maximum
            // 3. Создать Label lb (Autosize=True)
            // 4. Обработать ValueChanged для num с помощью лямбда-выражения (s, e) =>
            // 5. Выводить num.Value в lb
            // 5. Добавить num, label через AddControl()

            NumericUpDown num = new NumericUpDown();
            num.Minimum = 0;
            num.Maximum = 100;
            Label lb = new Label();
            lb.AutoSize = true;

            num.ValueChanged += (s, e) => lb.Text = num.Value.ToString();

            AddControl(num);
            AddControl(lb);


            // Example:
            // Пользователь увеличивает значение до 42
            // Label показывает:
            // "Значение: 42"
        }

        // =========================
        // Задание 9: PictureBox
        // =========================
        private void PictureDemo()
        {
            // TODO:
            // 1. Создать PictureBox pb
            // 2. Настроить SizeMode (Zoom)
            // 3. Натроить BorderStyle (BorderStyle.FixedSingle)
            // 4. Создать кнопку load (AutoSize = true, Text="Загрузить")
            // 5. Обработать нажатие на кнопку Click с помощью лямбда-выражения (s, e) =>
            // 6. Использовать/создать OpenFileDialog dlg 
            // 7. Загрузить изображение pb.Image = Image.FromFile(dlg.FileName)
            // если dlg.ShowDialog() == DialogResult.OK
            // 8. Добавить pb, load через AddControl()

            // Example:
            // Пользователь выбирает файл "cat.jpg"
            // В PictureBox отображается изображение кота
        }

        // =========================
        // Задание 10: TrackBar
        // =========================
        private void TrackDemo()
        {
            // TODO:
            // 1. Создать TrackBar track
            // 2. Создать Label label (AutoSize=True)
            // 3. Обработать Scroll для label с помощью лямбда-выражения (s, e) =>
            // 4. Выводить значение track.Value в label
            // 5. Добавить track, label через AddControl()
            
            TrackBar track = new TrackBar();
            Label label = new Label();
            label.AutoSize = true;

            track.Scroll += (s, e) => label.Text = track.Value.ToString();


            AddControl(track);
            AddControl(label);

            // Example:
            // Пользователь передвигает ползунок на 75
            // Label показывает:
            // "Значение: 75"
        }

        // =========================
        // Задание 11: Timer
        // =========================
        private void TimerDemo()
        {
            // TODO:
            // 1. Создать Label label (AutoSize=True)
            // 2. Создать Timer timer
            // 3. Задать Интервал (Interval) = 1000
            // 4. Обработать Tick для timer с помощью лямбда-выражения (s, e) =>
            // 5. Изменить текст label на DateTime.Now.ToLongTimeString()
            // 6. Запустить timer (Start())
            // 7. Добавить label через AddControl()

            // Example:
            // Каждую секунду обновляется время:
            // "14:23:01"
            // "14:23:02"
            // "14:23:03"
        }

        // =========================
        // Задание 12: ProgressBar
        // =========================
        private void ProgressDemo()
        {
            // TODO:
            // 1. Создать ProgressBar bar
            // 2. Создать кнопку Button start (AutoSize = true, Text = "Старт")
            // 3. Создать Timer timer (Interval=100)
            // 4. Обработать Tick для timer с помощью лямбда-выражения (s, e) =>
            // 5. Если bar.Value < 100, увеличить bar.Value на 1
            // иначе остановить Timer (stop)
            // 6. Обработать нажатие на кнопку start Click с помощью лямбда-выражения (s, e) =>
            // bar.Value задать равным 0, стартовать timer
            // 7. Добавить bar, start через AddControl()

            ProgressBar bar = new ProgressBar();

            Button start = new Button();
            start.AutoSize = true;
            start.Text = "Старт";

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


            timer.Interval = 100;

            timer.Tick += (s, e) =>
            {
                if (bar.Value < 100)
                {
                    bar.Value++;
                }
                else
                {
                    timer.Stop();
                }
            };

            start.Click += (s, e) =>
            bar.Value = 0;
            timer.Stop();

            AddControl(bar);
            AddControl(start);

            // Example:
            // После нажатия кнопки:
            // ProgressBar постепенно заполняется от 0 до 100%
        }

        // =========================
        // Задание 13: ComboBox
        // =========================
        private void ComboDemo()
        {
            // TODO:
            // 1. Создать ComboBox combo
            // 2. Добавить элементы в combo Items.AddRange(как в задании 2) (например: Красный, Зелёный, Синий)
            // 3. Создать Label label (Autosize=True)
            // 4. Обработать выбор SelectedItemChanged для combo с помощью лямбда-выражения (s, e) =>
            // изменить текст label на combo.SelectedItem.ToString()
            // 5. Добавить combo, label через AddControl()

            // Example:
            // Пользователь выбирает "Зелёный"
            // Label показывает:
            // "Выбор: Зелёный"
        }

        // =========================
        // Задание 14: MessageBox
        // =========================
        private void MessageDemo()
        {
            // TODO:
            // 1. Создать кнопку show (AutoSize = true)
            // 2. Обработать нажатие на кнопку show Click с помощью лямбда-выражения (s, e) =>
            // 3. Показать MessageBox.Show с текстом "Пример Модального Окна"
            // 4. Добавить show через AddControl()

            Button show = new Button();
            show.AutoSize = true;

            show.Click += (s, e) => MessageBox.Show("Пример Модального Окна");


            AddControl(show);
        }

        // =========================
        // Задание 15: ColorDialog
        // =========================
        private void ColorDemo()
        {
            // TODO:
            // 1. Создать кнопку Button color (AutoSize = true, Text="Выбрать Цвет")
            // 2. Обработать нажатие на кнопку color Click с помощью лямбда-выражения (s, e) =>
            // 3. Открыть/создать ColorDialog dlg
            // 4. Изменить цвет панели content.BackColor = dlg.Color, если dlg.ShowDialog() == DialogResult.OK 
            // 5. Добавить color через AddControl()

            // Example:
            // Пользователь выбирает синий цвет
            // Фон панели меняется на синий
        }

        // =========================
        // Задание 16: OpenFileDialog
        // =========================
        private void FileDemo()
        {
            // TODO:
            // 1. Создать кнопку Button file (AutoSize = true, Text="Открыть Файл")
            // 2. Обработать нажатие на кнопку file Click с помощью лямбда-выражения (s, e) =>
            // 3. Открыть/создать OpenFileDialog dlg
            // 4. Показать MessageBox с текстом dlg.FileName, если dlg.ShowDialog() == DialogResult.OK 
            // 5. Добавить file через AddControl()

            Button file = new Button();
            file.AutoSize = true;
            file.Text = "Открыть Файл";

            file.Click += (s, e) =>
            {
                OpenFileDialog dlg = new OpenFileDialog();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(dlg.FileName);
                }
            };
            

            AddControl(file);

            // Example:
            // Пользователь выбирает файл:
            // "C:\\Users\\User\\file.txt"
            // Путь отображается в MessageBox
        }

        // =========================
        // Задание 17: FontDialog
        // =========================
        private void FontDemo()
        {
            // TODO:
            // 1. Создать кнопку Button font (AutoSize = true, Text="Выбрать Шрифт")
            // 2. Обработать нажатие на кнопку font Click с помощью лямбда-выражения (s, e) =>
            // 3. Открыть/создать FontDialog dlg
            // 4. Создать Label label (Autosize=True, Text="Текст", Font=dlg.Font) и добавить через AddControl(), если dlg.ShowDialog() == DialogResult.OK 
            // 5. Добавить file через AddControl()

            // Example:
            // Пользователь выбирает шрифт Arial, 18pt
            // Текст Label меняется на выбранный стиль
        }

        // =========================
        // Задание 18: Немодальное окно
        // =========================
        private void NonModalDemo()
        {
            // TODO:
            // 1. Создать кнопку Button form (AutoSize = true, Text="Выбрать Шрифт")
            // 2. Обработать нажатие на кнопку form Click с помощью лямбда-выражения (s, e) =>
            // 3. Создать новую форму Form f (Text="Немодальное Окно")
            // 4. Показать f (Show())
            // 5. Добавить form через AddControl()

            Button form = new Button();
            form.AutoSize = true;
            form.Text = "Выбрать Шрифт";

            form.Click += (s, e) =>
            {
                Form f = new Form();
                f.Text = "Немодальное Окно";
                f.Show();
            };

            

            AddControl(form);

            // Example:
            // Открывается новое окно,
            // при этом основное окно остаётся доступным
        }
    }
}

