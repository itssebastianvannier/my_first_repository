def lsearch(list1,value):
    for i in range(len(arr)):
        if arr[i] == value:
            return i
    return -1
arr = [10,20,52,32,56,54,52]
res = lsearch(arr,53)
if res == -1:
    print('Element is not persent in the list')
else:
    print('Element is present at index',res)
