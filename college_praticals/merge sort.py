def MergeSort(A):
    if len(A) > 1:
        mid = len(A) // 2
        left = A[:mid]
        right = A[mid:]
        MergeSort(left)
        MergeSort(right)
        i = j = k = 0
        while i < len(left) and j < len(right):
            if left[i] < right[j]:
                A[k] = left[i]
                i = i + 1
            else:
                A[k] = right[j]
                j = j + 1
            k = k + 1

        while i < len(left):
            A[k] = left[i]
            i = i + 1
            k = k + 1

        while j < len(right):
            A[k] = right[j]
            j = j + 1
            k = k + 1

A = [534, 246, 933, 127, 277, 321, 454, 565, 220]
MergeSort(A)
print(A)
