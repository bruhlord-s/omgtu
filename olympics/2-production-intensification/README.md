# Интенсификация производства

Перед коллективом предприятия “Ни шагу назад” была поставлена задача наращивать каждый день производство продукции на 1.

Требуется определить, какой суммарный объем продукции будет выпущен предприятием за заданный период, если в первый день периода предприятие выпускало P единиц продукции.

### Примечания:

- период задается в виде двух календарных дат;
- длительность периода лежит в диапазоне от 1 до 60000;
- високосные годы учитываются по упрощенному правилу: високосным считается год, делящийся нацело на 4;
- день начала периода и день его окончания учитываются при подсчете суммарного объема продукции и длительности периода;
- все даты заданы корректно.

**Входной файл** содержит:

- в первой строке – дата начала периода в формате ДД.ММ.ГГГГ;
- во второй строке – дата окончания периода в формате ДД.ММ.ГГГГ;
- в третьей строке целое число – начальный выпуск продукции P (0  P  5000).

**Выходной файл** должен содержать суммарный объем продукции.

### Пример

```
Input.txt
12.05.2002
15.05.2002
10
Output.txt
46
```
