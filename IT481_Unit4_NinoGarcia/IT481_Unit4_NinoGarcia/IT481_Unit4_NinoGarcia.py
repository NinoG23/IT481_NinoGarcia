# Module 1

def print_array(nums):
    for num in nums:
        print(num)


# Module 2

def find_min_value(nums, times):
    if not nums:
        return None
    limit = min(times, len(nums))
    return min(nums[:limit])


# Module 3

def check_two_values(nums, val1, val2):
    found1 = val1 in nums
    found2 = val2 in nums
    return found1, found2



# Test cases

def run_tests():
    
    # Moduel 1 Tests
    print("Test 1: [1, 2, 3]")
    print_array([1, 2, 3])
    
    print("Test 2: [10, -5, 0]")
    print_array([10, -5, 0])
    print("\n")

    # Module 2 Tests
    print("Test 1:", find_min_value([8, 3, 5, 1, 9, 2], 4))
    print("Test 2:", find_min_value([7, 2, 6], 10))
    print("\n")
   
    # Module 3 Tests
    print("Test 1:", check_two_values([8, 3, 5, 1, 9, 2], 3, 9))
    print("Test 2:", check_two_values([4, 6, 8], 2, 6)) 


# Run all tests
if __name__ == "__main__":
    run_tests()

