# Описание основного алгоритма


## Шаг 1. Подсчет подходящих элементов

Нам необходимо посчитать количество подходях по условию элементов в исходном массиве - это будет размер итогового массива.
Для этого заводим переменную ***counter***.

```c#
int counter = 0;

foreach (var e in input)
{
    if (e.Length <= 3)
        counter++;
}
```

## Шаг 2. Проверка условия
Проверяем значение ***counter***: если равен 0, т.е. подходящих элементов в исходном массиве нет, сообщаем об этом и завершаем выполнение программы;
если не равен 0, то переходим к **следующему шагу**.

```c#
if (counter == 0)
    Console.WriteLine("Нужных строк нет");
else
{
    ...
```


## Шаг 3. Копирование подходях по условию строк

Объявляем ***output*** - новый/итоговый массив строк на ***counter*** элементов.
Проходим по исходному массиву ***input***, проверяя каждый элемент. И если этот элемент (строка) длины меньше либо равной 3, добавляем ее в итоговый массив ***output***.


```csharp
string[] output = new string[counter];

int index = 0;

foreach (var e in input)
{
    if (e.Length <= 3)
        output[index++] = e;
}                
```
Выводим итоговый массив и завершаем работу программы
```cs
foreach (var e in output)
{
    Console.WriteLine(e);
}
```
