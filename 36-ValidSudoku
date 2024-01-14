class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        rowSets = []
        colSets = []
        sqaSets = []
        for i in range(9): rowSets.append(set())
        for i in range(9): colSets.append(set())
        for i in range(9): sqaSets.append(set())

        rowIndex = 0
        colIndex = 0

        sqaAbsIndex = 0
        sqaIndex = 0

        currnetSqaRow = 0

        currentCell = board[rowIndex][colIndex]

        for idx in range(1, (9 * 9) + 1):
            currentSquare = sqaIndex + (3 * currnetSqaRow)
            if(currentCell in rowSets[rowIndex]): 
                return False
            elif(currentCell != '.'): rowSets[rowIndex].add(currentCell)

            if(currentCell in colSets[colIndex]): 
                return False
            elif(currentCell != '.'): colSets[colIndex].add(currentCell)
            
            if(currentCell in sqaSets[currentSquare]): 
                return False
            elif(currentCell != '.'): sqaSets[currentSquare].add(currentCell)

            print((rowIndex, colIndex, currentSquare, sqaIndex, currnetSqaRow))

            if((colIndex + 1) % 9 == 0): colIndex = 0
            else: colIndex += 1
            
            if((idx + 1) % 9 == 0):
                rowIndex += 1

            if(idx % 9 == 0):
                sqaAbsIndex += 1

            if(colIndex % 3 == 0):
                sqaIndex += 1
                if(sqaIndex % 3 == 0): sqaIndex = 0

            if((idx + 1) % 27 == 0): currnetSqaRow += 1 

            currentCell = board[rowIndex][colIndex]

        return True