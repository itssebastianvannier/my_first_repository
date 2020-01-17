def lsearch(list1,value):
    for i in range(len(arr)):
        if arr[i] == value:
            return i
        elif arr[i]>value:
            return -1

arr = [21,29,54,98,65,32,26,15]
print("Unsorted array is ",arr)
arr.sort()
print("Sorted array is :", arr)
value = int(input("Enter a value to search :"))
res = lsearch(arr,value)
if res == -1:
    print("Element is not present in the list")
else:
    print("Element is present at ", res)
