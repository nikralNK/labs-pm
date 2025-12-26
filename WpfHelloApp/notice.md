# Лабораторная работа 27: Введение в WPF

## Описание работы программы

Первое WPF-приложение для изучения фундаментальных отличий WPF от Windows Forms, структуры проекта, базовых контейнеров макета (StackPanel, Grid, DockPanel) и обработки событий.

## Цель работы

Изучить:
- Структуру WPF-проекта
- Декларативную разметку XAML
- Контейнеры макета (StackPanel, Grid, DockPanel)
- Обработку событий в WPF
- Систему команд (Commands)

## Структура проекта

### WpfHelloApp.csproj

Файл проекта WPF-приложения:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows</TargetFramework>
    <Nullable>enable</Nullable>
    <UseWPF>true</UseWPF>
  </PropertyGroup>
</Project>
```

**Ключевые свойства:**
- `OutputType: WinExe` - создает Windows-приложение (не консоль)
- `TargetFramework: net8.0-windows` - целевая платформа .NET 8 для Windows
- `UseWPF: true` - включает поддержку WPF

### App.xaml

Точка входа приложения, определяет глобальные ресурсы и стартовое окно:

```xml
<Application x:Class="WpfHelloApp.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
    </Application.Resources>
</Application>
```

**Назначение:**
- `StartupUri` - указывает, какое окно открывается при запуске
- `Application.Resources` - глобальные ресурсы (стили, шаблоны, кисти)
- Управление жизненным циклом приложения

### App.xaml.cs

Код-behind для App.xaml:

```csharp
using System.Windows;

namespace WpfHelloApp
{
    public partial class App : Application
    {
    }
}
```

**Назначение:**
- Наследуется от `Application`
- Частичный класс (partial) - объединяется с кодом из XAML
- Может переопределять события: Startup, Exit, DispatcherUnhandledException

### MainWindow.xaml

Главное окно приложения с разметкой интерфейса:

```xml
<Window x:Class="WpfHelloApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Привет, WPF"
        Width="400"
        Height="250"
        WindowStartupLocation="CenterScreen">
```

**Назначение:**
- Наследуется от `Window`
- Содержит иерархию визуальных элементов
- Декларативное описание UI через XAML

### MainWindow.xaml.cs

Код-behind для MainWindow.xaml:

```csharp
using System.Windows;

namespace WpfHelloApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
```

**Назначение:**
- Наследуется от `Window`
- Частичный класс (partial) - связан с XAML
- `InitializeComponent()` - генерируется автоматически, загружает XAML
- Обработчики событий

## Контейнеры макета

### DockPanel

Контейнер, позволяющий "пристыковать" элементы к сторонам:

```xml
<DockPanel>
    <Menu DockPanel.Dock="Top">...</Menu>
    <StackPanel>...</StackPanel>
</DockPanel>
```

**Свойства:**
- `DockPanel.Dock` - сторона пристыковки (Top, Bottom, Left, Right)
- Последний дочерний элемент заполняет оставшееся пространство
- Используется для создания стандартных макетов (меню сверху, статус-бар снизу)

### StackPanel

Стековое размещение элементов (вертикальное или горизонтальное):

```xml
<StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
    <TextBlock Text="..." TextAlignment="Center" FontSize="16" Margin="5"/>
    <Button Content="Привет" Margin="5" Padding="10,5" Click="HelloButton_Click"/>
    <Button Content="Выход" Margin="5" Padding="10,5" Click="ExitButton_Click"/>
</StackPanel>
```

**Свойства:**
- `Orientation` - направление (Vertical по умолчанию, Horizontal)
- `VerticalAlignment` - вертикальное выравнивание (Center, Top, Bottom, Stretch)
- `HorizontalAlignment` - горизонтальное выравнивание (Center, Left, Right, Stretch)
- Элементы располагаются последовательно

### Grid (бонусное задание)

Табличная разметка с гибкой системой строк и столбцов:

```xml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*"/>
        <RowDefinition Height="Auto"/>
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*"/>
        <ColumnDefinition Width="*"/>
    </Grid.ColumnDefinitions>

    <TextBlock Grid.Row="0" Grid.Column="0" Grid.ColumnSpan="2" .../>
    <Button Grid.Row="1" Grid.Column="0" .../>
    <Button Grid.Row="1" Grid.Column="1" .../>
</Grid>
```

**Свойства размеров:**
- `*` (звездочка) - пропорциональное распределение
- `Auto` - размер по содержимому
- Число - фиксированный размер в пикселях

**Присоединенные свойства:**
- `Grid.Row` - индекс строки (начиная с 0)
- `Grid.Column` - индекс столбца (начиная с 0)
- `Grid.RowSpan` - объединение строк
- `Grid.ColumnSpan` - объединение столбцов

## Компоненты интерфейса

### Menu

Главное меню приложения:

```xml
<Menu DockPanel.Dock="Top">
    <MenuItem Header="Файл">
        <MenuItem Header="Выход" Click="MenuExit_Click"/>
    </MenuItem>
    <MenuItem Header="Справка">
        <MenuItem Header="О программе" Click="MenuAbout_Click"/>
    </MenuItem>
</Menu>
```

**Свойства:**
- `Header` - отображаемый текст пункта меню
- `Click` - событие нажатия
- Вложенность создает подменю

### TextBlock

Отображение текста (не редактируется):

```xml
<TextBlock Text="Добро пожаловать в первое WPF-приложение!"
           TextAlignment="Center"
           FontSize="16"
           Margin="5"/>
```

**Свойства:**
- `Text` - отображаемый текст
- `TextAlignment` - выравнивание (Center, Left, Right, Justify)
- `FontSize` - размер шрифта
- `Margin` - внешний отступ

### Button

Кнопка для взаимодействия:

```xml
<Button Content="Привет"
        Margin="5"
        Padding="10,5"
        Click="HelloButton_Click"/>
```

**Свойства:**
- `Content` - содержимое кнопки (текст или любой элемент)
- `Margin` - внешний отступ
- `Padding` - внутренний отступ
- `Click` - событие нажатия

## Обработчики событий

### HelloButton_Click

Обработчик кнопки "Привет":

```csharp
private void HelloButton_Click(object sender, RoutedEventArgs e)
{
    MessageBox.Show("Привет, мир!");
}
```

**Отличия от Windows Forms:**
- Использует `RoutedEventArgs` вместо `EventArgs`
- Поддерживает маршрутизацию событий (bubbling, tunneling)

### ExitButton_Click / MenuExit_Click

Закрытие окна:

```csharp
private void ExitButton_Click(object sender, RoutedEventArgs e)
{
    Close();
}
```

Метод `Close()` закрывает текущее окно.

### MenuAbout_Click

Диалог "О программе":

```csharp
private void MenuAbout_Click(object sender, RoutedEventArgs e)
{
    MessageBox.Show("WpfHelloApp\nВерсия 1.0\nЛабораторная работа 27", "О программе");
}
```

`MessageBox.Show()` - модальное диалоговое окно.

## Маршрутизация событий (Event Routing)

WPF поддерживает три стратегии маршрутизации:

1. **Direct** - событие обрабатывается только на элементе-источнике
2. **Bubbling** - событие поднимается от источника к корню дерева
3. **Tunneling** - событие спускается от корня к источнику (Preview события)

Пример:

```
Window → DockPanel → StackPanel → Button (Click)
   ↑         ↑           ↑          ↓
   └─────────┴───────────┴──────────┘ (Bubbling)
```

## Основные отличия WPF от Windows Forms

### 1. Разделение логики и представления

**Windows Forms:**
- Императивный код в InitializeComponent()
- Смешение UI и логики

**WPF:**
- Декларативный XAML для UI
- C# только для логики
- Поддержка MVVM паттерна

### 2. Система макетов

**Windows Forms:**
- Фиксированные координаты (X, Y)
- Anchor и Dock для базового позиционирования

**WPF:**
- Гибкие контейнеры (Grid, StackPanel, DockPanel)
- Адаптивное изменение размеров
- Пропорциональное распределение пространства (*)

### 3. Рендеринг

**Windows Forms:**
- GDI+ (программный рендеринг)
- Ограниченная производительность

**WPF:**
- DirectX (аппаратное ускорение)
- Векторная графика
- Высокая производительность

### 4. Стилизация

**Windows Forms:**
- Ограниченные возможности кастомизации
- Требуется перерисовка (OnPaint)

**WPF:**
- Стили и шаблоны (Templates)
- Полная кастомизация без кода
- Themes и ресурсы

## Адаптивность Grid-версии

MainWindowGrid.xaml демонстрирует адаптивное поведение:

```xml
<Grid.RowDefinitions>
    <RowDefinition Height="*"/>
    <RowDefinition Height="Auto"/>
</Grid.RowDefinitions>
```

**Поведение:**
- Первая строка (`Height="*"`) - растягивается, занимая всё доступное пространство
- Вторая строка (`Height="Auto"`) - подстраивается под размер кнопок
- При изменении размера окна TextBlock остаётся центрированным
- Кнопки пропорционально занимают половину ширины каждая

**Преимущества:**
- Автоматическая адаптация под разные разрешения
- Сохранение пропорций
- Нет необходимости в ручном пересчёте координат

## Пример работы

### Запуск приложения (StackPanel версия)

1. Открывается окно "Привет, WPF" (400×250, по центру экрана)
2. Меню в верхней части: "Файл", "Справка"
3. По центру окна:
   - Текст приветствия
   - Кнопка "Привет"
   - Кнопка "Выход"

### Взаимодействие

**Кнопка "Привет":**
- Нажатие → MessageBox с текстом "Привет, мир!"

**Кнопка "Выход":**
- Нажатие → Закрытие приложения

**Меню → Файл → Выход:**
- Нажатие → Закрытие приложения

**Меню → Справка → О программе:**
- Нажатие → MessageBox с информацией о версии

### Grid версия (бонусное задание)

**Отличия:**
- TextBlock занимает всю первую строку (Grid.ColumnSpan="2")
- Кнопки размещены в отдельных столбцах второй строки
- При растягивании окна:
  - TextBlock остаётся центрированным
  - Кнопки пропорционально увеличиваются
  - Соотношение ширины кнопок 1:1 сохраняется

## Технические детали

### Пространства имён XAML

```xml
xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
```

- `xmlns` (по умолчанию) - основные элементы WPF (Button, Grid, etc.)
- `xmlns:x` - директивы XAML (x:Class, x:Name, etc.)

### x:Class

```xml
x:Class="WpfHelloApp.MainWindow"
```

Связывает XAML с частичным классом в C#.

### InitializeComponent()

Автоматически генерируемый метод, который:
1. Загружает XAML
2. Создаёт объекты элементов
3. Устанавливает свойства
4. Подключает обработчики событий

### RoutedEventArgs

В WPF события используют `RoutedEventArgs`:

```csharp
private void HelloButton_Click(object sender, RoutedEventArgs e)
```

**Дополнительные свойства:**
- `Source` - элемент, инициировавший событие
- `OriginalSource` - исходный элемент (до переопределения)
- `Handled` - флаг обработки (для прерывания маршрутизации)

## Преимущества WPF

1. **Декларативность** - UI описывается через XAML
2. **Разделение ответственности** - дизайн отделён от логики
3. **Data Binding** - автоматическая синхронизация данных
4. **Стилизация** - гибкие стили и шаблоны
5. **Векторная графика** - масштабирование без потери качества
6. **Анимация** - встроенная поддержка
7. **Производительность** - аппаратное ускорение DirectX

## Возможные улучшения

1. **Команды (Commands)** - вместо Click использовать ICommand
2. **Стили** - вынести общие свойства в ресурсы
3. **Data Binding** - связать кнопки с командами через ViewModel
4. **Анимация** - добавить плавные переходы
5. **Темизация** - поддержка светлой/тёмной темы
6. **Локализация** - вынести строки в ресурсы

## Запуск проекта

### Через командную строку:

```bash
dotnet build
dotnet run
```

### Через Visual Studio:

1. Открыть WpfHelloApp.csproj
2. F5 (запуск с отладкой) или Ctrl+F5 (без отладки)

## Структура файлов проекта

```
WpfHelloApp/
├── WpfHelloApp.csproj          # Файл проекта
├── App.xaml                     # Точка входа (XAML)
├── App.xaml.cs                  # Точка входа (C#)
├── MainWindow.xaml              # Главное окно (StackPanel версия)
├── MainWindow.xaml.cs           # Главное окно (C# код)
├── MainWindowGrid.xaml          # Главное окно (Grid версия)
├── MainWindowGrid.xaml.cs       # Главное окно Grid (C# код)
└── notice.md                    # Документация
```

## Выводы

1. **WPF** предоставляет современный подход к разработке desktop-приложений
2. **XAML** обеспечивает декларативное описание UI
3. **Контейнеры макета** создают адаптивный интерфейс
4. **Маршрутизация событий** упрощает обработку взаимодействий
5. **Разделение XAML/C#** способствует поддерживаемости кода
