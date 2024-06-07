# WAD_2
laboratory work on Windows Application Development

Создать новую форму, на форму добавить GroupBox, будем использовать для элементов
управления и выбрать для него заполнение справа (свойство Dock).
Добавить кнопку случайная функция - при выборе этой кнопки очищается старый рисунок,
сбрасывается масштаб и выбирается случайная функция из реализованных.
Добавить кнопку "Сохранить", по нажатию на данную кнопку открывавется стандартный
диалог сохранения файла и в случае подтверждения сохранения текущий вид отображенный
на панели сохраняется в выбранный файл.
Создать кнопку выбора цвета графика через ColorDialog.
Добавить кнопку позволяющую вызвать диалог выбора стиля фона. Реализовать диалог
выбора стиля фона (цвет, градиент, штриховка и т.д. Не менее 5 вариантов не считая
цвета.)
Добавить panel на форму и выбрать для нее полное заполнение оставшегося пространства.
В панели должен отображаться график выбранным цветом. График должен быть нарисован
на панели без использования компоненты Chart Должен заполняться фон выбранным
стилем. Должны отображаться оси координат X Y. Должен быть нарисован пунктирный
единичный круг с центром в (0,0).
Создать интерфейс IFunction с единственным методом посчитать в точке calc(x).
Реализовать классы пяти функций наследующих IFunction (sin, x*x, tg, x*x*x, 2x+5).
Реализовать масштабирование графика колесиком мышки (если текущий масштаб отличен от
единицы то писать текущий масштаб в правом верхнем углу). Реализовать смещение
графика путем нажатия мышкой на график, перетескиванием его и отпусканием кнопки.
Для избегания моргания графика при перетаскивании использовать принципы двойной
буферизации.
Форма и все ее содержимое должно поддерживать масштабирование (изменение границ
формы и соотвествующее изменение содержимого)

Доп. задание: добавить функцию создания кривой безье, при подтверждении создания она добавляется к функциям и её можно получить нажимая кнопку "Случайная функция"
