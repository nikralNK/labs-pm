# Лабораторная работа 28: WPF версия лабораторной 17

## Описание работы программы

Переработка лабораторной работы 17 на WPF-технологию с новыми математическими функциями. Приложение демонстрирует работу с кнопками для смены цвета фона, вывода сообщений и вычисления сложных математических выражений.

## Цель работы

- Переход от Windows Forms к WPF
- Реализация интерфейса через XAML
- Вычисление новых математических функций
- Обработка событий в WPF

## Математические формулы

### Формула v:

```
v = ((1 + sin(x + y)²) / |x - (2 * y) / (1 + x² * y²)|) * x^|y| + cos(arctan(1 / z))²
```

**Компоненты:**
- Числитель: `1 + sin(x + y)²`
- Знаменатель: `|x - (2 * y) / (1 + x² * y²)|`
- Множитель: `x^|y|` (x в степени модуля y)
- Слагаемое: `cos(arctan(1 / z))²`

**Ограничения:**
- Знаменатель не должен быть равен нулю
- z не должен быть равен нулю (для arctan(1/z))

### Формула w:

```
w = |cos(x) - cos(y)|^(1 + 2*sin(y)²) * (1 + z + z²/2 + z³/3 + z⁴/4)
```

**Компоненты:**
- Основание степени: `|cos(x) - cos(y)|`
- Показатель степени: `1 + 2*sin(y)²`
- Полиномиальное слагаемое: `1 + z + z²/2 + z³/3 + z⁴/4`

**Особенности:**
- Полином представляет частичную сумму ряда Тейлора
- Всегда определено для любых x, y, z

## Структура проекта

### WpfLab28.csproj

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

Точка входа WPF-приложения с указанием `StartupUri="MainWindow.xaml"`.

### MainWindow.xaml

XAML-разметка интерфейса с использованием:
- Grid для общего layout
- StackPanel для горизонтальных рядов кнопок
- GroupBox для группировки элементов вычисления
- TextBox для ввода x, y, z
- TextBlock для вывода результатов и сообщений

### MainWindow.xaml.cs

Код-behind с обработчиками событий и логикой вычислений.

## Компоненты интерфейса

### Кнопки смены цвета фона

```xml
<Button Content="красный" Width="100" Height="40" Click="BtnRed_Click"/>
<Button Content="зеленый" Width="100" Height="40" Click="BtnGreen_Click"/>
<Button Content="синий" Width="100" Height="40" Click="BtnBlue_Click"/>
<Button Content="желтый" Width="100" Height="40" Click="BtnYellow_Click"/>
```

Обработчики устанавливают цвет фона окна:

```csharp
private void BtnRed_Click(object sender, RoutedEventArgs e)
{
    Background = new SolidColorBrush(Colors.Red);
}
```

### Кнопки вывода сообщений

```xml
<Button Content="привет" Width="100" Height="40" Click="BtnHello_Click"/>
<Button Content="до свидания" Width="120" Height="40" Click="BtnGoodbye_Click"/>
```

Изменяют текст в TextBlock:

```csharp
private void BtnHello_Click(object sender, RoutedEventArgs e)
{
    lblMessage.Text = "привет";
}
```

### Поля ввода

```xml
<TextBox x:Name="txtX" Width="100"/>
<TextBox x:Name="txtY" Width="100"/>
<TextBox x:Name="txtZ" Width="100"/>
```

Для ввода значений x, y, z.

### Кнопка вычисления

```xml
<Button Content="Вычислить" Width="100" Height="30" Click="BtnCalculate_Click"/>
```

### Поля вывода результатов

```xml
<TextBlock x:Name="lblResult1" FontSize="12"/>
<TextBlock x:Name="lblResult2" FontSize="12"/>
<TextBlock x:Name="lblError" Foreground="Red" FontSize="12"/>
```

## Реализация вычислений

### BtnCalculate_Click

```csharp
private void BtnCalculate_Click(object sender, RoutedEventArgs e)
{
    try
    {
        lblError.Text = "";

        if (!double.TryParse(txtX.Text, out double x))
        {
            lblError.Text = "Ошибка: некорректное значение X";
            return;
        }

        if (!double.TryParse(txtY.Text, out double y))
        {
            lblError.Text = "Ошибка: некорректное значение Y";
            return;
        }

        if (!double.TryParse(txtZ.Text, out double z))
        {
            lblError.Text = "Ошибка: некорректное значение Z";
            return;
        }
```

**Валидация входных данных:**
- `double.TryParse` для безопасного преобразования
- Отдельные проверки для каждого параметра
- Вывод конкретной ошибки в lblError

### Вычисление v

```csharp
double sinXPlusY = Math.Sin(x + y);
double numeratorV = 1 + Math.Pow(sinXPlusY, 2);

double denominatorV = Math.Abs(x - (2 * y) / (1 + x * x * y * y));

if (denominatorV == 0)
{
    lblError.Text = "Ошибка: деление на ноль в формуле v";
    return;
}

double v = (numeratorV / denominatorV) * Math.Pow(Math.Abs(x), Math.Abs(y)) +
           Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);
```

**Шаги:**
1. Вычисление `sin(x + y)`
2. Числитель: `1 + sin²(x + y)`
3. Знаменатель: `|x - (2y) / (1 + x²y²)|`
4. Проверка деления на ноль
5. Степень: `x^|y|` через `Math.Pow(Math.Abs(x), Math.Abs(y))`
6. Слагаемое: `cos²(arctan(1/z))`

**Особенности:**
- `Math.Atan(1 / z)` - арктангенс
- `Math.Abs(y)` для корректной работы степени с отрицательными y
- Проверка знаменателя перед делением

### Вычисление w

```csharp
double cosX = Math.Cos(x);
double cosY = Math.Cos(y);
double baseW = Math.Abs(cosX - cosY);
double exponentW = 1 + 2 * Math.Pow(Math.Sin(y), 2);

double sumW = 1 + z + (z * z / 2) + (z * z * z / 3) + (z * z * z * z / 4);

double w = Math.Pow(baseW, exponentW) * sumW;
```

**Шаги:**
1. Вычисление `cos(x)` и `cos(y)`
2. Основание: `|cos(x) - cos(y)|`
3. Показатель: `1 + 2*sin²(y)`
4. Полином: `1 + z + z²/2 + z³/3 + z⁴/4`
5. Произведение степени и полинома

**Особенности:**
- Полином - частичная сумма ряда `e^z - 1` или приближение `ln(1+z)`
- Всегда корректно определён

### Вывод результатов

```csharp
lblResult1.Text = $"v = {v:F6}";
lblResult2.Text = $"w = {w:F6}";
```

Формат `F6` - 6 знаков после запятой.

### Обработка исключений

```csharp
catch (Exception ex)
{
    lblError.Text = $"Ошибка вычисления: {ex.Message}";
}
```

Ловит все неожиданные ошибки (переполнение, NaN и т.д.).

## Отличия от Windows Forms версии

### 1. Разметка интерфейса

**Windows Forms:**
```csharp
btnRed.Location = new Point(30, 30);
btnRed.Size = new Size(100, 40);
```

**WPF:**
```xml
<Button Content="красный" Width="100" Height="40"/>
```

### 2. Установка цвета фона

**Windows Forms:**
```csharp
BackColor = Color.Red;
```

**WPF:**
```csharp
Background = new SolidColorBrush(Colors.Red);
```

### 3. Обработка событий

**Windows Forms:**
```csharp
private void btnRed_Click(object sender, EventArgs e)
```

**WPF:**
```csharp
private void BtnRed_Click(object sender, RoutedEventArgs e)
```

### 4. Layout система

**Windows Forms:**
- Фиксированные координаты (X, Y)
- Anchor/Dock для адаптивности

**WPF:**
- Контейнеры (Grid, StackPanel)
- Автоматическое позиционирование
- Адаптивные размеры

## Пример работы

### Запуск приложения

1. Окно открывается с серым фоном
2. Текст "Начало работы" отображается под кнопками

### Смена цвета фона

**Действие:** Нажать кнопку "красный"
**Результат:** Фон окна становится красным

**Действие:** Нажать кнопку "зеленый"
**Результат:** Фон окна становится зеленым

### Вывод сообщений

**Действие:** Нажать кнопку "привет"
**Результат:** Текст меняется на "привет"

**Действие:** Нажать кнопку "до свидания"
**Результат:** Текст меняется на "до свидания"

### Вычисление функций

**Входные данные:**
- X = 1
- Y = 2
- Z = 0.5

**Нажать "Вычислить"**

**Промежуточные значения:**

Для v:
- `sin(1 + 2)` = `sin(3)` ≈ 0.141120
- `sin²(3)` ≈ 0.019915
- Числитель: `1 + 0.019915` ≈ 1.019915
- `1 + 1² * 2²` = `1 + 4` = 5
- `(2 * 2) / 5` = `4/5` = 0.8
- Знаменатель: `|1 - 0.8|` = 0.2
- Дробь: `1.019915 / 0.2` ≈ 5.099575
- `1^|2|` = `1^2` = 1
- `arctan(1/0.5)` = `arctan(2)` ≈ 1.107149
- `cos(1.107149)` ≈ 0.447214
- `cos²(...)` ≈ 0.2
- v ≈ `5.099575 * 1 + 0.2` ≈ 5.299575

Для w:
- `cos(1)` ≈ 0.540302
- `cos(2)` ≈ -0.416147
- `|0.540302 - (-0.416147)|` ≈ 0.956449
- `sin(2)` ≈ 0.909297
- `sin²(2)` ≈ 0.826821
- Показатель: `1 + 2 * 0.826821` ≈ 2.653642
- `0.956449^2.653642` ≈ 0.882
- z = 0.5
- Полином: `1 + 0.5 + 0.25/2 + 0.125/3 + 0.0625/4`
  = `1 + 0.5 + 0.125 + 0.041667 + 0.015625`
  ≈ 1.682292
- w ≈ `0.882 * 1.682292` ≈ 1.484

**Результат:**
```
v = 5.299575
w = 1.484000
```

### Обработка ошибок

**Сценарий 1: Некорректный ввод**

Входные данные:
- X = "abc"
- Y = 2
- Z = 3

**Результат:** "Ошибка: некорректное значение X"

**Сценарий 2: Деление на ноль**

Входные данные:
- X = 0.8
- Y = 0
- Z = 1

При этом знаменатель v:
- `1 + 0 * 0` = 1
- `(2 * 0) / 1` = 0
- `|0.8 - 0|` = 0.8

Деления на ноль не происходит.

**Сценарий 3: z = 0**

При z = 0 возникнет деление на ноль в `arctan(1/z)`:

**Результат:** Exception будет пойман и выведен в lblError

## Технические детали

### Использование Math

**Функции:**
- `Math.Sin(x)` - синус
- `Math.Cos(x)` - косинус
- `Math.Pow(base, exp)` - возведение в степень
- `Math.Abs(x)` - модуль
- `Math.Atan(x)` - арктангенс

### SolidColorBrush vs Color

**Windows Forms:**
```csharp
BackColor = Color.Red;
```

**WPF:**
```csharp
Background = new SolidColorBrush(Colors.Red);
```

WPF использует Brush для заливки, что даёт больше возможностей (градиенты, изображения и т.д.).

### Grid Layout

```xml
<Grid.RowDefinitions>
    <RowDefinition Height="Auto"/>
    <RowDefinition Height="Auto"/>
    <RowDefinition Height="Auto"/>
    <RowDefinition Height="*"/>
</Grid.RowDefinitions>
```

- `Auto` - размер по содержимому
- `*` - занимает оставшееся пространство

### GroupBox в WPF

```xml
<GroupBox Header="Задание 2: Вычисление функций" Padding="15">
    <Grid>...</Grid>
</GroupBox>
```

Header заменяет свойство Text из Windows Forms.

## Преимущества WPF-версии

1. **Декларативный UI** - XAML более читаем, чем код
2. **Адаптивность** - Grid автоматически подстраивается под размер окна
3. **Разделение логики** - XAML для UI, C# для логики
4. **Стилизация** - легко применить единый стиль ко всем кнопкам
5. **Векторная графика** - масштабирование без потери качества

## Возможные улучшения

1. **Стили для кнопок** - вынести общие свойства в ресурсы
2. **Data Binding** - связать TextBox с переменными через MVVM
3. **Validation Rules** - встроенная валидация в XAML
4. **Команды** - использовать ICommand вместо Click
5. **Анимация** - плавная смена цвета фона
6. **Темизация** - поддержка светлой/тёмной темы

## Выводы

Лабораторная работа 28 демонстрирует:
- Переход от Windows Forms к WPF
- Использование XAML для описания UI
- Реализацию сложных математических формул
- Обработку ошибок и валидацию ввода
- Преимущества WPF layout системы
