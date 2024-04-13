import random
print('Введите кол-во столбцов: ')
m = int(input())
print('Введите кол-во cтрок: ')
n = int(input())
matrix = [[random.randint(0,100) for j in range(m)] for i in range(n)]
print(matrix)

for i in matrix:
  print(i)

for i in range(len(matrix)):
  print(matrix[i])