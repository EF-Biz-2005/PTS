def remove_duplicates(arr):
    seen = set()
    result = []
    for num in arr:
        if num not in seen:
            seen.add(num)
            result.append(num)
    return result

# Example usage
numbers = [1, 3, 5, 3, 7, 1, 9, 5]
unique_numbers = remove_duplicates(numbers)
print("Original array:", numbers)
print("Array with duplicates removed:", unique_numbers)

