def binsearch(arr,value):
    low = 0
    high = len(arr)-1
    while low<= high:
        mid = (low+high)//2
        if arr[mid] > value:
            high = mid - 1
        elif arr[mid] < value:
            low = mid + 1
        else:
            return mid
    return -1
arr = [21,54,98,56,57,89,65,48,45]
arr.sort()
value = int(input("Enter value to search : "))
res = binsearch(arr,value)
if res == -1:
    print("Element is not present in the list")
else:
    print("Element is present at index ",res)
