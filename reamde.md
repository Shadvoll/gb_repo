# Задача:

**Из массива строк создать новый массив строк, оставив длины, которые меньше или равны 3**

## Входные данные:

* Количество строк. Число *n*, вводимое с клавиатуры
* *n* строк, вводимые с клавиатуры.

## Выходные данные:

* Строки, длины которых меньше или равны 3


# Описание алгоритма. 

1. Считывание числа *n*
2. Считывание *n* строк 
3. Применение функции *FilterStrings*

    3.1. Опредление количества строк *m*, подходящее по условию через цикл.

    3.2. Создание нового массива для строк из *m* элементов

    3.3. Заполение массива по условию. Проходимся по оригинальному массиву, выбираем строки по условию, заносим в результирующий массив

    3.4. Результирующий массив возрващается
4. Вывод результирующего массива строк.