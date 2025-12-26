# Лабораторная работа 30: Файловые диалоги в WPF

## Описание работы программы

Текстовый редактор на WPF с использованием системных файловых диалогов OpenFileDialog и SaveFileDialog. Приложение демонстрирует открытие текстовых файлов, редактирование содержимого и сохранение с полной обработкой исключений.

## Цель работы

Освоить:
- Использование OpenFileDialog и SaveFileDialog из Microsoft.Win32
- Чтение и запись текстовых файлов через System.IO
- Обработку файловых исключений
- Формирование фильтров расширений
- Работу с путями через Path класс

## Структура проекта

### WpfFileDialogApp.csproj

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows</TargetFramework>
    <UseWPF>true</UseWPF>
  </PropertyGroup>
</Project>
```

### App.xaml / App.xaml.cs

Стандартная точка входа WPF-приложения.

### MainWindow.xaml

Интерфейс с меню, кнопками и TextBox для редактирования.

### MainWindow.xaml.cs

Логика работы с файлами и обработка исключений.

## Пространство имён Microsoft.Win32

### OpenFileDialog

```csharp
using Microsoft.Win32;

OpenFileDialog openFileDialog = new OpenFileDialog
{
    Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
    DefaultExt = ".txt",
    Title = "Открыть текстовый файл"
};

bool? result = openFileDialog.ShowDialog();
```

**Основные свойства:**
- **Filter** - фильтр расширений файлов
- **DefaultExt** - расширение по умолчанию
- **Title** - заголовок диалогового окна
- **FileName** - полный путь выбранного файла
- **InitialDirectory** - начальная директория
- **Multiselect** - множественный выбор
- **FileNames** - массив путей при Multiselect=true

### SaveFileDialog

```csharp
SaveFileDialog saveFileDialog = new SaveFileDialog
{
    Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
    DefaultExt = ".txt",
    Title = "Сохранить текстовый файл",
    FileName = "document.txt"
};

bool? result = saveFileDialog.ShowDialog();
```

**Дополнительные свойства:**
- **OverwritePrompt** - предупреждение при перезаписи (по умолчанию true)
- **CreatePrompt** - предупреждение при создании нового файла
- **FileName** - предлагаемое имя файла

### Общий базовый класс FileDialog

Оба диалога наследуются от FileDialog:

```
FileDialog
    ├── OpenFileDialog
    └── SaveFileDialog
```

**Общие свойства:**
- FileName / FileNames
- Filter / FilterIndex
- DefaultExt
- InitialDirectory
- Title
- CheckFileExists
- CheckPathExists

## Фильтры расширений

### Синтаксис фильтра

```csharp
Filter = "Описание1|маска1|Описание2|маска2"
```

**Примеры:**

```csharp
Filter = "Текстовые файлы (*.txt)|*.txt"
```

Один тип файлов.

```csharp
Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
```

Два варианта: только .txt или все файлы.

```csharp
Filter = "Документы Word|*.doc;*.docx|Изображения|*.png;*.jpg;*.gif|Все файлы|*.*"
```

Несколько масок в одном фильтре через точку с запятой.

### FilterIndex

```csharp
openFileDialog.FilterIndex = 2;
```

Устанавливает активный фильтр (нумерация с 1).

### DefaultExt

```csharp
DefaultExt = ".txt"
```

Если пользователь вводит имя без расширения, система автоматически добавляет `.txt`.

**Пример:**
- Ввод: `myfile`
- Результат: `myfile.txt`

## Жизненный цикл работы с диалогом

### 1. Создание и настройка

```csharp
OpenFileDialog dialog = new OpenFileDialog
{
    Filter = "...",
    DefaultExt = "...",
    Title = "..."
};
```

### 2. Отображение диалога

```csharp
bool? result = dialog.ShowDialog();
```

**Возвращаемые значения:**
- `true` - пользователь нажал "OK"
- `false` - пользователь нажал "Cancel"
- `null` - диалог закрыт без выбора

### 3. Обработка результата

```csharp
if (result == true)
{
    string filePath = dialog.FileName;
}
```

### 4. Файловая операция

```csharp
string content = File.ReadAllText(filePath);
```

## Чтение файлов

### File.ReadAllText

```csharp
string content = File.ReadAllText(filePath);
```

**Особенности:**
- Читает весь файл в строку
- Автоматически определяет кодировку (UTF-8, UTF-16)
- Простой, но не подходит для больших файлов

**С явной кодировкой:**

```csharp
string content = File.ReadAllText(filePath, Encoding.UTF8);
```

### File.ReadAllLines

```csharp
string[] lines = File.ReadAllLines(filePath);
```

Возвращает массив строк (каждая строка - элемент массива).

### StreamReader для больших файлов

```csharp
using (StreamReader reader = new StreamReader(filePath))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        // Обработка строки
    }
}
```

Читает файл построчно, экономит память.

## Запись файлов

### File.WriteAllText

```csharp
File.WriteAllText(filePath, txtContent.Text);
```

**Особенности:**
- Перезаписывает существующий файл
- Создаёт новый файл, если не существует
- Автоматически закрывает файл

**С кодировкой:**

```csharp
File.WriteAllText(filePath, content, Encoding.UTF8);
```

### File.AppendAllText

```csharp
File.AppendAllText(filePath, "\nДополнительная строка");
```

Добавляет текст в конец файла без перезаписи.

### StreamWriter для построчной записи

```csharp
using (StreamWriter writer = new StreamWriter(filePath))
{
    foreach (string line in lines)
    {
        writer.WriteLine(line);
    }
}
```

## Обработка исключений

### Типы исключений при работе с файлами

#### UnauthorizedAccessException

```csharp
catch (UnauthorizedAccessException)
{
    MessageBox.Show("Ошибка: нет прав доступа к файлу");
}
```

**Возникает когда:**
- Нет прав на чтение/запись
- Файл открыт другим процессом в монопольном режиме
- Попытка записи в системную директорию

#### FileNotFoundException

```csharp
catch (FileNotFoundException)
{
    MessageBox.Show("Ошибка: файл не найден");
}
```

**Возникает когда:**
- Файл был удалён между ShowDialog() и ReadAllText()
- Неверный путь
- Файл на сетевом диске, который отключился

#### PathTooLongException

```csharp
catch (PathTooLongException)
{
    MessageBox.Show("Ошибка: путь к файлу слишком длинный");
}
```

**Возникает когда:**
- Путь превышает 260 символов (MAX_PATH в Windows)
- Имя файла превышает 255 символов

#### IOException

```csharp
catch (IOException ex)
{
    MessageBox.Show($"Ошибка ввода-вывода: {ex.Message}");
}
```

**Возникает когда:**
- Проблемы с диском
- Файл используется другим процессом
- Недостаточно места на диске

#### Exception (общий)

```csharp
catch (Exception ex)
{
    MessageBox.Show($"Неожиданная ошибка: {ex.Message}");
}
```

Ловит все остальные исключения.

### Правильный порядок catch-блоков

```csharp
try
{
    // Файловая операция
}
catch (UnauthorizedAccessException) { }
catch (FileNotFoundException) { }
catch (PathTooLongException) { }
catch (IOException ex) { }
catch (Exception ex) { }
```

**Важно:** Более специфичные исключения должны идти перед общими.

## Реализация в MainWindow.xaml.cs

### Поле currentFilePath

```csharp
private string? currentFilePath = null;
```

Хранит путь к текущему открытому файлу:
- `null` - файл не открыт
- Используется для предложения имени при сохранении
- Обновляется после открытия и сохранения

### Метод OpenFile()

```csharp
private void OpenFile()
{
    OpenFileDialog openFileDialog = new OpenFileDialog
    {
        Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
        DefaultExt = ".txt",
        Title = "Открыть текстовый файл"
    };

    bool? result = openFileDialog.ShowDialog();

    if (result == true)
    {
        try
        {
            string filePath = openFileDialog.FileName;
            string content = File.ReadAllText(filePath);

            txtContent.Text = content;
            currentFilePath = filePath;
            lblFileName.Text = $"Открыт файл: {Path.GetFileName(filePath)}";
        }
        catch (UnauthorizedAccessException)
        {
            MessageBox.Show("Ошибка: нет прав доступа к файлу", "Ошибка доступа",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show("Ошибка: файл не найден", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (IOException ex)
        {
            MessageBox.Show($"Ошибка ввода-вывода: {ex.Message}", "Ошибка I/O",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Неожиданная ошибка: {ex.Message}", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
```

**Последовательность:**
1. Создание диалога с фильтрами
2. Отображение диалога
3. Если пользователь выбрал файл (result == true):
   - Чтение содержимого
   - Отображение в TextBox
   - Сохранение пути
   - Обновление метки
4. Обработка всех возможных исключений

### Метод SaveFile()

```csharp
private void SaveFile()
{
    SaveFileDialog saveFileDialog = new SaveFileDialog
    {
        Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
        DefaultExt = ".txt",
        Title = "Сохранить текстовый файл",
        FileName = currentFilePath != null ? Path.GetFileName(currentFilePath) : "document.txt"
    };

    bool? result = saveFileDialog.ShowDialog();

    if (result == true)
    {
        try
        {
            string filePath = saveFileDialog.FileName;
            File.WriteAllText(filePath, txtContent.Text);

            currentFilePath = filePath;
            lblFileName.Text = $"Сохранён файл: {Path.GetFileName(filePath)}";

            MessageBox.Show("Файл успешно сохранён!", "Успех",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (UnauthorizedAccessException)
        {
            MessageBox.Show("Ошибка: нет прав доступа для сохранения файла", "Ошибка доступа",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (PathTooLongException)
        {
            MessageBox.Show("Ошибка: путь к файлу слишком длинный", "Ошибка пути",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (IOException ex)
        {
            MessageBox.Show($"Ошибка ввода-вывода: {ex.Message}", "Ошибка I/O",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Неожиданная ошибка: {ex.Message}", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
```

**Особенности:**
- Предлагает имя текущего файла или "document.txt"
- Записывает содержимое TextBox
- Показывает уведомление об успехе
- Обрабатывает PathTooLongException (специфично для сохранения)

## Path класс

### Path.GetFileName

```csharp
string fileName = Path.GetFileName(@"C:\Users\Documents\file.txt");
```

Возвращает: `"file.txt"`

### Path.GetDirectoryName

```csharp
string dir = Path.GetDirectoryName(@"C:\Users\Documents\file.txt");
```

Возвращает: `"C:\Users\Documents"`

### Path.GetExtension

```csharp
string ext = Path.GetExtension(@"C:\file.txt");
```

Возвращает: `".txt"`

### Path.GetFileNameWithoutExtension

```csharp
string name = Path.GetFileNameWithoutExtension(@"C:\file.txt");
```

Возвращает: `"file"`

### Path.Combine

```csharp
string path = Path.Combine(@"C:\Users", "Documents", "file.txt");
```

Возвращает: `"C:\Users\Documents\file.txt"`

Корректно обрабатывает разделители пути.

## MainWindow.xaml

### DockPanel для layout

```xml
<DockPanel Margin="10">
    <Menu DockPanel.Dock="Top">...</Menu>
    <StackPanel DockPanel.Dock="Top">...</StackPanel>
    <TextBox>...</TextBox>
</DockPanel>
```

**DockPanel:**
- Menu пристыкован к верху
- StackPanel с кнопками тоже сверху
- TextBox заполняет оставшееся пространство

### Menu

```xml
<Menu DockPanel.Dock="Top">
    <MenuItem Header="Файл">
        <MenuItem Header="Открыть" Click="MenuOpen_Click"/>
        <MenuItem Header="Сохранить" Click="MenuSave_Click"/>
        <Separator/>
        <MenuItem Header="Выход" Click="MenuExit_Click"/>
    </MenuItem>
    <MenuItem Header="Справка">
        <MenuItem Header="О программе" Click="MenuAbout_Click"/>
    </MenuItem>
</Menu>
```

**Separator** - горизонтальная линия между пунктами меню.

### Кнопки и метка

```xml
<StackPanel Orientation="Horizontal">
    <Button Content="Открыть файл" Width="120" Height="30" Click="BtnOpen_Click"/>
    <Button Content="Сохранить файл" Width="120" Height="30" Click="BtnSave_Click"/>
    <TextBlock x:Name="lblFileName" FontStyle="Italic"/>
</StackPanel>
```

Горизонтальное расположение кнопок и метки с именем файла.

### TextBox для редактирования

```xml
<TextBox x:Name="txtContent"
         AcceptsReturn="True"
         TextWrapping="Wrap"
         VerticalScrollBarVisibility="Auto"
         HorizontalScrollBarVisibility="Auto"
         FontFamily="Consolas"
         FontSize="12"/>
```

**Свойства:**
- **AcceptsReturn="True"** - многострочный режим, Enter создаёт новую строку
- **TextWrapping="Wrap"** - перенос длинных строк
- **VerticalScrollBarVisibility="Auto"** - вертикальная прокрутка при необходимости
- **FontFamily="Consolas"** - моноширинный шрифт для кода
- **FontSize="12"** - размер шрифта

## Множественный выбор файлов

Хотя в этой лабораторной не реализовано, важно знать:

```csharp
OpenFileDialog dialog = new OpenFileDialog
{
    Multiselect = true,
    Filter = "..."
};

if (dialog.ShowDialog() == true)
{
    string[] files = dialog.FileNames;

    foreach (string file in files)
    {
        string content = File.ReadAllText(file);
    }
}
```

**FileNames** (множественное число) возвращает массив путей.

## Асинхронное чтение (дополнительно)

Для больших файлов:

```csharp
private async void BtnOpen_Click(object sender, RoutedEventArgs e)
{
    OpenFileDialog dialog = new OpenFileDialog();

    if (dialog.ShowDialog() == true)
    {
        try
        {
            string content = await File.ReadAllTextAsync(dialog.FileName);
            txtContent.Text = content;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
```

**ReadAllTextAsync** не блокирует UI-поток.

## Пример работы

### Сценарий 1: Открытие файла

1. **Пользователь:** Нажимает "Открыть файл"
2. **Система:** Показывает OpenFileDialog
3. **Пользователь:** Выбирает `test.txt`
4. **Программа:**
   - Читает содержимое файла
   - Отображает в TextBox
   - Метка: "Открыт файл: test.txt"

### Сценарий 2: Редактирование и сохранение

1. **Пользователь:** Изменяет текст в TextBox
2. **Пользователь:** Нажимает "Сохранить файл"
3. **Система:** Показывает SaveFileDialog с именем "test.txt"
4. **Пользователь:** Выбирает путь и имя
5. **Программа:**
   - Записывает содержимое TextBox в файл
   - Показывает "Файл успешно сохранён!"
   - Метка: "Сохранён файл: test.txt"

### Сценарий 3: Ошибка доступа

1. **Пользователь:** Пытается открыть файл без прав доступа
2. **Программа:**
   - Перехватывает UnauthorizedAccessException
   - Показывает MessageBox: "Ошибка: нет прав доступа к файлу"
   - TextBox остаётся без изменений

### Сценарий 4: Файл удалён

1. **Пользователь:** Выбирает файл в диалоге
2. **Система:** Файл удаляется другим процессом
3. **Программа:**
   - Перехватывает FileNotFoundException
   - Показывает MessageBox: "Ошибка: файл не найден"

## Безопасность и лучшие практики

### 1. Всегда оборачивайте в try-catch

```csharp
try
{
    File.ReadAllText(path);
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

### 2. Проверяйте результат диалога

```csharp
if (dialog.ShowDialog() == true)
{
    // Только если пользователь нажал OK
}
```

### 3. Используйте Path.Combine

```csharp
string path = Path.Combine(directory, filename);
```

Вместо конкатенации строк.

### 4. Освобождайте ресурсы

```csharp
using (StreamReader reader = new StreamReader(path))
{
    // Автоматически закроется
}
```

### 5. Валидация путей

```csharp
if (!File.Exists(path))
{
    MessageBox.Show("Файл не существует");
    return;
}
```

## Ограничения файловых диалогов

1. **Нельзя стилизовать** - внешний вид определяется ОС
2. **Нет предпросмотра** - требуется создавать собственное окно
3. **Ограниченная кастомизация** - только базовые свойства
4. **Блокирующий вызов** - ShowDialog() блокирует окно

**Для сложных сценариев** создают собственные окна с ListView, TreeView и т.д.

## Возможные улучшения

1. **Недавние файлы** - список последних открытых файлов
2. **Автосохранение** - периодическое сохранение через Timer
3. **Отслеживание изменений** - флаг "файл изменён"
4. **Подтверждение** - предупреждение о несохранённых изменениях
5. **Drag & Drop** - перетаскивание файлов в окно
6. **Поиск/замена** - функции текстового редактора
7. **Синтаксис** - подсветка для различных языков

## Выводы

Лабораторная работа 30 демонстрирует:
- Использование OpenFileDialog и SaveFileDialog в WPF
- Чтение и запись текстовых файлов
- Полную обработку файловых исключений
- Работу с фильтрами расширений
- Управление состоянием приложения (currentFilePath)
- Интеграцию меню и кнопок для одинаковых действий
- Правильное информирование пользователя через MessageBox
