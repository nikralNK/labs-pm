# Лабораторная работа 29: Стили в WPF

## Описание работы программы

Приложение демонстрирует создание и применение стилей в WPF. Показывает различие между стилизованной кнопкой с зелёным фоном, скруглёнными углами и триггерами, и стандартной кнопкой без стилей.

## Цель работы

Научиться:
- Создавать стили в WPF
- Использовать StaticResource для переиспользования ресурсов
- Применять триггеры для интерактивности
- Кастомизировать ControlTemplate
- Работать с Application.Resources

## Структура проекта

### WpfStylesApp.csproj

Стандартный файл проекта WPF:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows</TargetFramework>
    <UseWPF>true</UseWPF>
  </PropertyGroup>
</Project>
```

### App.xaml

Содержит глобальные ресурсы и стили приложения:

```xml
<Application.Resources>
    <SolidColorBrush x:Key="GreenBrush" Color="#FF4CAF50"/>
    <SolidColorBrush x:Key="DarkGreenBrush" Color="#FF388E3C"/>

    <Style x:Key="GreenButton" TargetType="Button">
        ...
    </Style>
</Application.Resources>
```

### MainWindow.xaml

Главное окно с двумя кнопками - стилизованной и стандартной.

## Концепции стилей в WPF

### 1. Зачем нужны стили

**Проблема без стилей:**

```xml
<Button Background="Green" Foreground="White" FontSize="16"
        FontWeight="Bold" Padding="20,10" Margin="10"/>
<Button Background="Green" Foreground="White" FontSize="16"
        FontWeight="Bold" Padding="20,10" Margin="10"/>
<Button Background="Green" Foreground="White" FontSize="16"
        FontWeight="Bold" Padding="20,10" Margin="10"/>
```

**Решение со стилями:**

```xml
<Style x:Key="GreenButton" TargetType="Button">
    <Setter Property="Background" Value="Green"/>
    <Setter Property="Foreground" Value="White"/>
    <Setter Property="FontSize" Value="16"/>
    <Setter Property="FontWeight" Value="Bold"/>
    <Setter Property="Padding" Value="20,10"/>
    <Setter Property="Margin" Value="10"/>
</Style>

<Button Style="{StaticResource GreenButton}"/>
<Button Style="{StaticResource GreenButton}"/>
<Button Style="{StaticResource GreenButton}"/>
```

**Преимущества:**
- Переиспользование кода
- Единая точка изменений
- Поддержка темизации
- Читаемость XAML

### 2. Структура стиля

```xml
<Style x:Key="GreenButton" TargetType="Button">
```

**x:Key:**
- Уникальный идентификатор стиля
- Используется для применения: `Style="{StaticResource GreenButton}"`
- Если не указан, стиль применяется автоматически ко всем элементам TargetType

**TargetType:**
- Тип элемента, к которому применяется стиль
- Позволяет использовать свойства типа без полного имени
- Обязателен для неявных стилей

### 3. Setters

```xml
<Setter Property="Background" Value="{StaticResource GreenBrush}"/>
<Setter Property="Foreground" Value="White"/>
<Setter Property="FontSize" Value="16"/>
```

**Setter** - устанавливает значение свойства:
- **Property** - имя dependency property
- **Value** - значение (может быть literal, StaticResource, DynamicResource, Binding)

### 4. StaticResource vs DynamicResource

**StaticResource:**
```xml
<Setter Property="Background" Value="{StaticResource GreenBrush}"/>
```
- Разрешается один раз при загрузке XAML
- Быстрее, использует меньше памяти
- Не обновляется при изменении ресурса

**DynamicResource:**
```xml
<Setter Property="Background" Value="{DynamicResource ThemeBrush}"/>
```
- Разрешается при первом использовании и отслеживается
- Обновляется при изменении ресурса
- Используется для темизации

## Ресурсы приложения

### Определение кистей

```xml
<SolidColorBrush x:Key="GreenBrush" Color="#FF4CAF50"/>
<SolidColorBrush x:Key="DarkGreenBrush" Color="#FF388E3C"/>
```

**SolidColorBrush:**
- Однотонная кисть для заливки
- Color в формате #AARRGGBB (Alpha, Red, Green, Blue)
- `#FF4CAF50` - Material Design Green 500
- `#FF388E3C` - Material Design Green 700

**Преимущества выноса в ресурсы:**
- Переиспользование одного цвета в разных стилях
- Единая точка изменения цветовой схемы
- Семантические имена (GreenBrush вместо #FF4CAF50)

## Стиль GreenButton

### Базовые свойства

```xml
<Style x:Key="GreenButton" TargetType="Button">
    <Setter Property="Background" Value="{StaticResource GreenBrush}"/>
    <Setter Property="Foreground" Value="White"/>
    <Setter Property="FontSize" Value="16"/>
    <Setter Property="FontWeight" Value="Bold"/>
    <Setter Property="Padding" Value="20,10"/>
    <Setter Property="Margin" Value="10"/>
    <Setter Property="BorderThickness" Value="0"/>
    <Setter Property="Cursor" Value="Hand"/>
```

**Свойства:**
- **Background** - зелёный фон из ресурса
- **Foreground** - белый текст
- **FontSize** - размер шрифта 16
- **FontWeight** - жирное начертание
- **Padding** - внутренний отступ (20 по горизонтали, 10 по вертикали)
- **Margin** - внешний отступ 10 со всех сторон
- **BorderThickness** - без рамки
- **Cursor** - курсор-рука при наведении

### ControlTemplate - скруглённые углы

```xml
<Setter Property="Template">
    <Setter.Value>
        <ControlTemplate TargetType="Button">
            <Border Background="{TemplateBinding Background}"
                    BorderBrush="{TemplateBinding BorderBrush}"
                    BorderThickness="{TemplateBinding BorderThickness}"
                    CornerRadius="8">
                <ContentPresenter HorizontalAlignment="Center"
                                VerticalAlignment="Center"
                                Margin="{TemplateBinding Padding}"/>
            </Border>
        </ControlTemplate>
    </Setter.Value>
</Setter>
```

**ControlTemplate:**
- Полностью переопределяет визуальное представление кнопки
- **Border** - контейнер с возможностью скругления углов
- **CornerRadius="8"** - радиус скругления углов в пикселях
- **TemplateBinding** - связывает свойства шаблона со свойствами кнопки
- **ContentPresenter** - отображает содержимое кнопки (Content)

**Зачем нужен ControlTemplate:**
Стандартная кнопка WPF не имеет свойства для скругления углов. ControlTemplate позволяет заменить стандартный прямоугольник на Border с CornerRadius.

### Триггеры

```xml
<Style.Triggers>
    <Trigger Property="IsMouseOver" Value="True">
        <Setter Property="Background" Value="{StaticResource DarkGreenBrush}"/>
    </Trigger>
    <Trigger Property="IsPressed" Value="True">
        <Setter Property="Background" Value="#FF2E7D32"/>
    </Trigger>
</Style.Triggers>
```

**IsMouseOver Trigger:**
- Срабатывает при наведении мыши
- Меняет фон на тёмно-зелёный (#FF388E3C)
- Создаёт эффект hover

**IsPressed Trigger:**
- Срабатывает при нажатии кнопки
- Меняет фон на ещё более тёмный зелёный (#FF2E7D32)
- Создаёт визуальную обратную связь

**Приоритет триггеров:**
IsPressed имеет больший приоритет, чем IsMouseOver, так как объявлен позже.

## Виды триггеров в WPF

### 1. Property Trigger

```xml
<Trigger Property="IsEnabled" Value="False">
    <Setter Property="Opacity" Value="0.5"/>
</Trigger>
```

Реагирует на изменение dependency property.

### 2. DataTrigger

```xml
<DataTrigger Binding="{Binding Status}" Value="Error">
    <Setter Property="Background" Value="Red"/>
</DataTrigger>
```

Реагирует на значение привязки данных.

### 3. EventTrigger

```xml
<EventTrigger RoutedEvent="MouseEnter">
    <BeginStoryboard>
        <Storyboard>
            <DoubleAnimation Duration="0:0:0.2"
                           Storyboard.TargetProperty="Opacity"
                           To="0.7"/>
        </Storyboard>
    </BeginStoryboard>
</EventTrigger>
```

Реагирует на события и запускает анимации.

### 4. MultiTrigger

```xml
<MultiTrigger>
    <MultiTrigger.Conditions>
        <Condition Property="IsMouseOver" Value="True"/>
        <Condition Property="IsEnabled" Value="True"/>
    </MultiTrigger.Conditions>
    <Setter Property="Background" Value="Blue"/>
</MultiTrigger>
```

Срабатывает при выполнении всех условий одновременно.

## MainWindow.xaml

### Структура окна

```xml
<Grid>
    <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
        <TextBlock Text="Демонстрация стилей в WPF" .../>
        <Button Content="Зелёная стилизованная кнопка" Style="{StaticResource GreenButton}"/>
        <Button Content="Стандартная кнопка" .../>
        <TextBlock x:Name="lblMessage" .../>
    </StackPanel>
</Grid>
```

**StackPanel:**
- Вертикальное расположение элементов
- Центрирование по вертикали и горизонтали

### Применение стиля

```xml
<Button Content="Зелёная стилизованная кнопка"
        Style="{StaticResource GreenButton}"
        Click="GreenButton_Click"/>
```

**Style="{StaticResource GreenButton}":**
- Ищет ресурс с ключом "GreenButton"
- Применяет все Setters из стиля
- Применяет все Triggers из стиля

### Стандартная кнопка

```xml
<Button Content="Стандартная кнопка"
        Width="250"
        Height="40"
        Margin="10"
        Click="StandardButton_Click"/>
```

Без указания Style использует стандартный вид кнопки Windows.

## Обработчики событий

### MainWindow.xaml.cs

```csharp
private void GreenButton_Click(object sender, RoutedEventArgs e)
{
    lblMessage.Text = "Нажата зелёная стилизованная кнопка!";
}

private void StandardButton_Click(object sender, RoutedEventArgs e)
{
    lblMessage.Text = "Нажата стандартная кнопка!";
}
```

Простые обработчики, демонстрирующие работу кнопок.

## Наследование стилей (BasedOn)

Хотя в этой лабораторной не используется, важно знать:

```xml
<Style x:Key="BaseButton" TargetType="Button">
    <Setter Property="FontSize" Value="16"/>
    <Setter Property="Padding" Value="20,10"/>
</Style>

<Style x:Key="RedButton" TargetType="Button" BasedOn="{StaticResource BaseButton}">
    <Setter Property="Background" Value="Red"/>
    <Setter Property="Foreground" Value="White"/>
</Style>

<Style x:Key="BlueButton" TargetType="Button" BasedOn="{StaticResource BaseButton}">
    <Setter Property="Background" Value="Blue"/>
    <Setter Property="Foreground" Value="White"/>
</Style>
```

**BasedOn:**
- Наследует все Setters из базового стиля
- Позволяет переопределить или добавить свойства
- Создаёт иерархию стилей

## Неявные стили

Стиль без x:Key применяется автоматически ко всем элементам типа:

```xml
<Style TargetType="Button">
    <Setter Property="FontWeight" Value="Bold"/>
</Style>
```

Все Button в области действия ресурса станут жирными.

**Применение:**
- Для установки глобальных настроек
- Для создания единого стиля приложения
- Можно переопределить локально через `Style="{x:Null}"`

## Область действия ресурсов

### Application.Resources

```xml
<Application.Resources>
    <Style x:Key="GlobalStyle" .../>
</Application.Resources>
```

Доступен во всех окнах и элементах приложения.

### Window.Resources

```xml
<Window.Resources>
    <Style x:Key="WindowStyle" .../>
</Window.Resources>
```

Доступен только в этом окне.

### Control.Resources

```xml
<StackPanel.Resources>
    <Style x:Key="LocalStyle" .../>
</StackPanel.Resources>
```

Доступен только внутри StackPanel.

**Приоритет поиска:**
Локальные ресурсы → ресурсы родителя → ... → Window.Resources → Application.Resources

## TemplateBinding vs Binding

### TemplateBinding

```xml
<Border Background="{TemplateBinding Background}"/>
```

- Используется только в ControlTemplate
- Односторонняя привязка (от свойства элемента к шаблону)
- Быстрее, чем Binding
- Не поддерживает преобразователи

### Binding RelativeSource

```xml
<Border Background="{Binding Background, RelativeSource={RelativeSource TemplatedParent}}"/>
```

- Аналог TemplateBinding, но с полным функционалом Binding
- Поддерживает преобразователи
- Двусторонняя привязка
- Медленнее

## Пример работы

### Запуск приложения

1. Окно открывается с заголовком "Демонстрация стилей в WPF"
2. Центрированы два элемента:
   - Зелёная кнопка с скруглёнными углами
   - Стандартная серая кнопка

### Взаимодействие

**Наведение на зелёную кнопку:**
- Фон меняется с #FF4CAF50 на #FF388E3C (темнее)
- Курсор превращается в руку
- Плавного перехода нет (можно добавить через анимацию)

**Нажатие зелёной кнопки:**
- Фон меняется на #FF2E7D32 (ещё темнее)
- После отпускания возвращается к hover-цвету
- Текст под кнопками: "Нажата зелёная стилизованная кнопка!"

**Наведение на стандартную кнопку:**
- Стандартный hover-эффект Windows
- Светло-голубая подсветка

**Нажатие стандартной кнопки:**
- Стандартный pressed-эффект
- Текст под кнопками: "Нажата стандартная кнопка!"

## Расширенные возможности стилей

### 1. Анимации в триггерах

```xml
<Trigger Property="IsMouseOver" Value="True">
    <Trigger.EnterActions>
        <BeginStoryboard>
            <Storyboard>
                <ColorAnimation Duration="0:0:0.2"
                              Storyboard.TargetProperty="(Button.Background).(SolidColorBrush.Color)"
                              To="#FF388E3C"/>
            </Storyboard>
        </BeginStoryboard>
    </Trigger.EnterActions>
    <Trigger.ExitActions>
        <BeginStoryboard>
            <Storyboard>
                <ColorAnimation Duration="0:0:0.2"
                              Storyboard.TargetProperty="(Button.Background).(SolidColorBrush.Color)"
                              To="#FF4CAF50"/>
            </Storyboard>
        </BeginStoryboard>
    </Trigger.ExitActions>
</Trigger>
```

Создаёт плавный переход цвета.

### 2. Визуальные состояния (VisualStateManager)

```xml
<VisualStateManager.VisualStateGroups>
    <VisualStateGroup x:Name="CommonStates">
        <VisualState x:Name="Normal"/>
        <VisualState x:Name="MouseOver">
            <Storyboard>
                <ColorAnimation Duration="0:0:0.2" .../>
            </Storyboard>
        </VisualState>
    </VisualStateGroup>
</VisualStateManager.VisualStateGroups>
```

Более сложная система управления состояниями.

### 3. Attached Properties в стилях

```xml
<Style TargetType="Button">
    <Setter Property="Grid.Row" Value="0"/>
    <Setter Property="Grid.Column" Value="0"/>
</Style>
```

Можно устанавливать attached properties родительских контейнеров.

## Преимущества стилей

1. **DRY принцип** - Don't Repeat Yourself
2. **Централизованное управление** - одно место для изменений
3. **Темизация** - легко создавать темы (светлая/тёмная)
4. **Поддержка** - проще поддерживать единообразие
5. **Производительность** - стили применяются один раз при создании элемента
6. **Переиспользование** - один стиль для множества элементов
7. **Разделение ответственности** - дизайн отделён от логики

## Возможные улучшения

1. **Анимации** - плавные переходы цвета
2. **Больше триггеров** - IsEnabled, IsFocused
3. **Наследование** - базовый стиль для всех кнопок
4. **Themes** - переключение между светлой/тёмной темой
5. **Векторные иконки** - добавить Path в ContentTemplate
6. **Shadow effects** - DropShadowEffect для глубины
7. **Ripple effect** - эффект волны при нажатии

## Выводы

Лабораторная работа 29 демонстрирует:
- Создание и применение стилей в WPF
- Использование ресурсов приложения
- Кастомизацию внешнего вида через ControlTemplate
- Интерактивность через триггеры
- Отличие стилизованных и стандартных элементов
- Преимущества декларативного подхода к стилизации
