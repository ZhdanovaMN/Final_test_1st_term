# Final test

_Задача_: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*
* ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
* ["1234", "1567", "-2", "computer science"] -> ["-2"]
* ["Russia", "Denmark", "Kazan"] -> []


Решение:

1. Создать заданный самостоятельно массив из строк.
2. Объявить метод GetShortWords типа string[], принимающий на вход массив. В теле метода объявить две переменные типа int: count и temp, присвоив им значение 0.
3. Внутри цикла for, где i меньше длины первого массива, пошагово увеличивая i на единицу, сделать проверку: если элемент i первого массива меньше или равен 3, то увеличивать переменную count на единицу.
4. По окончании цикла создать новый массив из строк с длиной count.
5. Внутри цикла for, где j меньше длины первого массива, пошагово увеличивая j на единицу, сделать проверку: если элемент j меньше или равен 3, то присваивоить переменной второго массива с индексом temp значение элемента j первого массива и увеличить переменную temp на 1.
6. Когда j станет равным длине первого массива, цикл for завершается, программа возвращает получившийся второй массив из строк.
7. Переменной типа string[] присвоить значение, возвращаемое  методом GetShortWords.
8. Создать метод PrintArray, который выводит массивы в консоль.
