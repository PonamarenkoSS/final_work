# final_work
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
Описание блок-схемы: на входе даётся массив, элементы которого подлежат проверке на соответствие заданному условию. Для начала каждый элемент массива «прогоняется» по циклу проверки соответствия данному условию (количество символов элемента до 3 включительно). Таким образом вычисляется изначально обнулённая переменная, увеличиваемая на единицу при каждом соответствующем условии элементу. В дальнейшем данная переменная используются для создания нового массива, длина которого равна данной переменной. Создается новая обнулённая перемена, изначально соответствующая первому элементу нового массива (с индексом 0). Элементы исходного массива снова «прогоняются» по циклу проверки соответствия условию (количество символов элемента до 3 включительно). В случае, если элемент удовлетворяет условию, он записывается в новый массив, а переменная, соответствующая индексам нового массива, увеличивается на единицу. В конце выводится новый массив, все элементы которого соответствуют заданному условию.
В «кодовом» решении задачи пользователю изначально дополнительно предоставляется возможность ввести вручную каждый элемент массива (количество элементов – 5) при запуске программы. После ввода 5-ого элемента программа выводит массив пользователя, а затем – отформатированный массив, все элементы которого соответствуют заданному условию.