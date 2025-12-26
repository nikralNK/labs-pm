# Лабораторная работа 26: Использование нескольких компонентов управления

## Описание работы программы

Приложение демонстрирует работу различных компонентов управления Windows Forms: TabControl, ComboBox, ListBox, RadioButton, NumericUpDown и PictureBox. Каждая вкладка содержит один из компонентов управления и PictureBox для отображения изображений. Навигация между вкладками осуществляется кнопками.

## Основная функциональность

1. **TabControl** - содержит 4 вкладки для разных компонентов
2. **Вкладка 1: ComboBox** - выбор изображения из выпадающего списка
3. **Вкладка 2: ListBox** - выбор изображения из списка
4. **Вкладка 3: RadioButton** - выбор изображения с помощью переключателей
5. **Вкладка 4: NumericUpDown** - выбор изображения числовым контролом
6. **Навигация** - кнопки перехода между вкладками
7. **PictureBox** - отображение изображений в режиме Zoom

## Компоненты формы

### Основная структура

- **Form1** - главная форма (размер: 521×285)
  - FormBorderStyle: FixedSingle
  - MaximizeBox: False
  - StartPosition: CenterScreen
  - Text: "Использование нескольких компонентов"

### TabControl

- **tabControl1** - основной контейнер вкладок (размер: 497×261)
  - Содержит 4 вкладки (tabPage1-4)
  - SelectedIndex: 0 (по умолчанию первая вкладка)

### Вкладка 1: Работа с ComboBox

- **comboBox1** - выпадающий список (15, 20, размер: 140×25)
  - DropDownStyle: DropDownList (без возможности ввода)
  - Items: "Изображение 1", "Изображение 2", "Изображение 3"
  - Событие: SelectedIndexChanged

- **pictureBox1** - отображение изображения (170, 20, размер: 310×160)
  - BorderStyle: FixedSingle
  - SizeMode: Zoom

- **button1** - "Следующая страница" (340, 190, размер: 140×30)
  - Переход на вкладку 2

### Вкладка 2: Работа с ListBox

- **listBox1** - список выбора (15, 20, размер: 140×106)
  - Items: "Изображение 1", "Изображение 2", "Изображение 3"
  - Событие: SelectedIndexChanged

- **pictureBox2** - отображение изображения (170, 20, размер: 310×160)
  - BorderStyle: FixedSingle
  - SizeMode: Zoom

- **button2** - "Предыдущая страница" (15, 190, размер: 140×30)
  - Переход на вкладку 1

- **button3** - "Следующая страница" (340, 190, размер: 140×30)
  - Переход на вкладку 3

### Вкладка 3: Работа с RadioButton

- **panel1** - панель группировки (15, 20, размер: 140×120)
  - BorderStyle: FixedSingle
  - Содержит 3 RadioButton

- **radioButton1** - "Изображение 1" (10, 15)
  - Checked: True (выбран по умолчанию)
  - Событие: CheckedChanged

- **radioButton2** - "Изображение 2" (10, 45)
  - Событие: CheckedChanged

- **radioButton3** - "Изображение 3" (10, 75)
  - Событие: CheckedChanged

- **pictureBox3** - отображение изображения (170, 20, размер: 310×160)
  - BorderStyle: FixedSingle
  - SizeMode: Zoom

- **button4** - "Предыдущая страница" (15, 190, размер: 140×30)
  - Переход на вкладку 2

- **button5** - "Следующая страница" (340, 190, размер: 140×30)
  - Переход на вкладку 4

### Вкладка 4: Работа с NumericUpDown

- **numericUpDown1** - числовой контрол (15, 20, размер: 140×25)
  - Minimum: 0
  - Maximum: 2
  - Событие: ValueChanged

- **pictureBox4** - отображение изображения (170, 20, размер: 310×160)
  - BorderStyle: FixedSingle
  - SizeMode: Zoom

- **button7** - "Предыдущая страница" (15, 190, размер: 140×30)
  - Переход на вкладку 3

- **button6** - "Выход из программы" (340, 190, размер: 140×30)
  - Закрытие приложения

## Основные методы

### comboBox1_SelectedIndexChanged

Обработчик события выбора элемента в ComboBox:

```csharp
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    switch (comboBox1.SelectedIndex)
    {
        case 0:
            pictureBox1.Image = CreatePlaceholderImage("Изображение 1", Color.LightBlue);
            break;
        case 1:
            pictureBox1.Image = CreatePlaceholderImage("Изображение 2", Color.LightGreen);
            break;
        case 2:
            pictureBox1.Image = CreatePlaceholderImage("Изображение 3", Color.LightCoral);
            break;
    }
}
```

Использует SelectedIndex для определения выбранного элемента (0-2).

### listBox1_SelectedIndexChanged

Обработчик события выбора элемента в ListBox:

```csharp
private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    switch (listBox1.SelectedIndex)
    {
        case 0:
            pictureBox2.Image = CreatePlaceholderImage("Изображение 1", Color.LightBlue);
            break;
        case 1:
            pictureBox2.Image = CreatePlaceholderImage("Изображение 2", Color.LightGreen);
            break;
        case 2:
            pictureBox2.Image = CreatePlaceholderImage("Изображение 3", Color.LightCoral);
            break;
    }
}
```

Аналогично ComboBox, использует SelectedIndex.

### radioButton1_CheckedChanged, radioButton2_CheckedChanged, radioButton3_CheckedChanged

Обработчики события изменения состояния RadioButton:

```csharp
private void radioButton1_CheckedChanged(object sender, EventArgs e)
{
    if (radioButton1.Checked)
    {
        pictureBox3.Image = CreatePlaceholderImage("Изображение 1", Color.LightBlue);
    }
}
```

**Важно:** Проверка `radioButton1.Checked` предотвращает двойное срабатывание (при снятии и установке флажка).

### numericUpDown1_ValueChanged

Обработчик события изменения значения NumericUpDown:

```csharp
private void numericUpDown1_ValueChanged(object sender, EventArgs e)
{
    switch ((int)numericUpDown1.Value)
    {
        case 0:
            pictureBox4.Image = CreatePlaceholderImage("Изображение 1", Color.LightBlue);
            break;
        case 1:
            pictureBox4.Image = CreatePlaceholderImage("Изображение 2", Color.LightGreen);
            break;
        case 2:
            pictureBox4.Image = CreatePlaceholderImage("Изображение 3", Color.LightCoral);
            break;
    }
}
```

Value приводится к int, так как имеет тип decimal.

### Методы навигации

Переключение между вкладками через свойство `tabControl1.SelectedIndex`:

```csharp
private void button1_Click(object sender, EventArgs e)
{
    tabControl1.SelectedIndex = 1; // Переход на вкладку 2
}

private void button2_Click(object sender, EventArgs e)
{
    tabControl1.SelectedIndex = 0; // Переход на вкладку 1
}

private void button3_Click(object sender, EventArgs e)
{
    tabControl1.SelectedIndex = 2; // Переход на вкладку 3
}

private void button4_Click(object sender, EventArgs e)
{
    tabControl1.SelectedIndex = 1; // Переход на вкладку 2
}

private void button5_Click(object sender, EventArgs e)
{
    tabControl1.SelectedIndex = 3; // Переход на вкладку 4
}

private void button7_Click(object sender, EventArgs e)
{
    tabControl1.SelectedIndex = 2; // Переход на вкладку 3
}
```

**Нумерация вкладок:** Начинается с 0 (0-3 для 4 вкладок).

### button6_Click

Закрытие приложения:

```csharp
private void button6_Click(object sender, EventArgs e)
{
    Close();
}
```

Вызывает метод Close() формы, завершающий работу приложения.

### CreatePlaceholderImage

Вспомогательный метод для создания изображений-заглушек:

```csharp
private Image CreatePlaceholderImage(string text, Color backgroundColor)
{
    int width = 310;
    int height = 160;
    Bitmap bitmap = new Bitmap(width, height);

    using (Graphics g = Graphics.FromImage(bitmap))
    {
        // Fill background
        g.Clear(backgroundColor);

        // Draw border
        using (Pen pen = new Pen(Color.Black, 2))
        {
            g.DrawRectangle(pen, 1, 1, width - 2, height - 2);
        }

        // Draw text
        using (Font font = new Font("Arial", 16, FontStyle.Bold))
        using (SolidBrush brush = new SolidBrush(Color.Black))
        {
            SizeF textSize = g.MeasureString(text, font);
            float x = (width - textSize.Width) / 2;
            float y = (height - textSize.Height) / 2;
            g.DrawString(text, font, brush, x, y);
        }
    }

    return bitmap;
}
```

Создает Bitmap с:
- Цветным фоном
- Черной рамкой (толщина 2px)
- Центрированным текстом (Arial, 16pt, Bold)

## Логика работы компонентов

### ComboBox

**Свойства:**
- **DropDownStyle: DropDownList** - запрещает ввод текста, только выбор из списка
- **Items** - коллекция элементов списка
- **SelectedIndex** - индекс выбранного элемента (-1 если ничего не выбрано)

**Событие SelectedIndexChanged** срабатывает при изменении выбора.

### ListBox

**Свойства:**
- **Items** - коллекция элементов списка
- **SelectedIndex** - индекс выбранного элемента
- **ItemHeight** - высота элемента (17px)

**Событие SelectedIndexChanged** срабатывает при выборе элемента.

### RadioButton

**Свойства:**
- **Checked** - состояние переключателя (true/false)
- **TabStop** - первый RadioButton имеет TabStop = true

**Группировка:** RadioButton размещены в Panel для автоматической группировки (только один может быть выбран).

**Событие CheckedChanged** срабатывает дважды:
1. При снятии флажка с предыдущего RadioButton (Checked = false)
2. При установке флажка на новый RadioButton (Checked = true)

**Решение:** Проверка `if (radioButton.Checked)` выполняет действие только при установке.

### NumericUpDown

**Свойства:**
- **Value** - текущее значение (тип decimal)
- **Minimum** - минимальное значение (по умолчанию 0)
- **Maximum** - максимальное значение (установлено 2)

**Событие ValueChanged** срабатывает при изменении значения (кнопками или вводом).

### PictureBox

**Свойства:**
- **SizeMode: Zoom** - масштабирует изображение с сохранением пропорций
- **BorderStyle: FixedSingle** - черная рамка вокруг элемента
- **Image** - отображаемое изображение

**SizeMode.Zoom** решает проблему "скачущих" размеров изображений, упомянутую в задании.

## Навигация между вкладками

### Схема навигации:

```
Вкладка 1 (ComboBox)
    ↓ [Следующая] (button1)
Вкладка 2 (ListBox)
    ↓ [Следующая] (button3) ← [Предыдущая] (button2)
Вкладка 3 (RadioButton)
    ↓ [Следующая] (button5) ← [Предыдущая] (button4)
Вкладка 4 (NumericUpDown)
    [Выход] (button6) ← [Предыдущая] (button7)
```

**Особенности:**
- Вкладка 1: только кнопка "Следующая"
- Вкладки 2-3: кнопки "Предыдущая" и "Следующая"
- Вкладка 4: кнопки "Предыдущая" и "Выход из программы"

## Цветовая схема изображений

Каждое изображение имеет уникальный цвет фона:

- **Изображение 1**: LightBlue (голубой)
- **Изображение 2**: LightGreen (зеленый)
- **Изображение 3**: LightCoral (коралловый)

Единая цветовая схема для всех вкладок обеспечивает визуальную согласованность.

## Особенности реализации

1. **SizeMode.Zoom** - автоматическое масштабирование изображений с сохранением пропорций
2. **DropDownList** - запрет ввода текста в ComboBox
3. **Panel для RadioButton** - автоматическая группировка переключателей
4. **Проверка Checked** - предотвращение двойного срабатывания RadioButton
5. **Приведение типов** - `(int)numericUpDown1.Value` для работы с decimal
6. **Using блоки** - автоматическое освобождение графических ресурсов
7. **Центрирование текста** - вычисление позиции через MeasureString
8. **Единообразие** - все PictureBox имеют одинаковый размер (310×160)
9. **FixedSingle** - запрет изменения размера формы для стабильного layout

## Пример работы

### Последовательность действий:

1. **Запуск приложения** - открывается вкладка "Работа с ComboBox"
2. **Выбор в ComboBox** - выбираем "Изображение 2"
   - В pictureBox1 отображается зеленое изображение с текстом "Изображение 2"
3. **Переход на вкладку 2** - нажимаем "Следующая страница"
4. **Выбор в ListBox** - кликаем на "Изображение 3"
   - В pictureBox2 отображается коралловое изображение с текстом "Изображение 3"
5. **Переход на вкладку 3** - нажимаем "Следующая страница"
6. **Выбор RadioButton** - выбираем "Изображение 1"
   - В pictureBox3 отображается голубое изображение с текстом "Изображение 1"
7. **Переход на вкладку 4** - нажимаем "Следующая страница"
8. **Выбор числа** - устанавливаем значение 1
   - В pictureBox4 отображается зеленое изображение с текстом "Изображение 2"
9. **Выход** - нажимаем "Выход из программы"
   - Приложение закрывается

## Преимущества архитектуры

1. **Модульность** - каждая вкладка независима
2. **Переиспользование кода** - метод CreatePlaceholderImage для всех изображений
3. **Единообразие** - все компоненты оформлены в едином стиле
4. **Удобная навигация** - интуитивные кнопки перехода
5. **Визуальная обратная связь** - изображения меняются мгновенно
6. **Простота расширения** - легко добавить новые вкладки или изображения

## Технические детали

### Индексация элементов

Все компоненты выбора используют индексацию с 0:
- ComboBox.SelectedIndex: 0, 1, 2
- ListBox.SelectedIndex: 0, 1, 2
- NumericUpDown.Value: 0, 1, 2
- TabControl.SelectedIndex: 0, 1, 2, 3

### Управление ресурсами

Using блоки обеспечивают правильное освобождение:
- Graphics
- Pen
- Font
- SolidBrush

### Создание графики

Graphics.FromImage(bitmap) создает контекст рисования:
1. Clear - заливка фона
2. DrawRectangle - рисование рамки
3. MeasureString - вычисление размера текста
4. DrawString - отрисовка текста

## Возможные улучшения

1. **Реальные изображения** - загрузка из файлов вместо заглушек
2. **Анимация** - плавная смена изображений
3. **История** - сохранение выбранных изображений
4. **Настройки** - выбор цветовой схемы
5. **Экспорт** - сохранение текущего изображения в файл
6. **Клавиатура** - навигация через Ctrl+Tab
7. **Tooltip** - подсказки для элементов управления
