import random

m = 7
n = 5
matrix = [[random.randint(0,100) for j in range(m)] for i in range(n)]

# for i in range(len(matrix)):
#   for j in range(len(matrix[i])):
#     print(matrix[i][j], end=' * ')

# for i in range(len(matrix)):
#   print(matrix[i], end='\n')

sum = 0

for i in matrix[0]:
  if i > sum:
    sum = i
print(sum)
print(matrix[0])