class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        pascalsTriangle = [[1]]
        if(numRows == 1): return pascalsTriangle

        for i in range(2, numRows + 1):
            newRow = [1]

            for j in range(0, i - 2):
                newRow.append(pascalsTriangle[i - 2][j] + pascalsTriangle[i - 2][j + 1])

            newRow.append(1)
            pascalsTriangle.append(newRow)

        return pascalsTriangle
