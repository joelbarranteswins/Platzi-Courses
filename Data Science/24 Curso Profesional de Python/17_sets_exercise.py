import random

def setMaker():
    
    max_set_1= random.randint(6,10)
    max_set_2 = random.randint(6,10)
    set1 = {random.randint(0,max_set_1) for s in range(10)} # Implement set comprehension
    set2 = {random.randint(0,max_set_2) for s in range(10)} # Implement set comprehension
    return [set1,set2]

def run():
    message="""
            ******************
            Set operations 
            ******************"""
    print(message)
    
    #Union between set's
    print("Union")
    set_list=setMaker()
    set_result = set_list[0] | set_list[1]
    print(f"Set 'union' between Set 1: {set_list[0]} and Set 2: {set_list[1]}")
    print(f'Set result: {set_result}')
    print("************************************************************************************")

    #Intersection between set's
    print("Intersection")
    set_list=setMaker()
    set_result = set_list[0] & set_list[1]
    print(f"Set 'intersection' between Set 1: {set_list[0]} and Set 2: {set_list[1]}")
    print(f'Set result: {set_result}')
    print("************************************************************************************")

    #Difference between set's
    print("Difference: Set1 - Set2")
    set_list=setMaker()
    set_result = set_list[0] - set_list[1]
    print(f"Set 'difference' between Set 1: {set_list[0]} and Set 2: {set_list[1]}")
    print(f'Set result: {set_result}')
    print("************************************************************************************")

    #Difference between set's
    print("Difference: Set2 - Set1")
    set_list=setMaker()
    set_result = set_list[1] - set_list[0]
    print(f"Set 'difference' between Set 2: {set_list[1]} and Set 1: {set_list[0]}")
    print(f'Set result: {set_result}')
    print("************************************************************************************")

    #Simetric Difference between set's
    print("Simetric Difference")
    set_list=setMaker()
    set_result = set_list[0] ^ set_list[1]
    print(f"Set 'difference' between Set 1: {set_list[0]} and Set 2: {set_list[1]}")
    print(f'Set result: {set_result}')
    print("************************************************************************************")

    #Clean set_result
    set_result.clear()

    #Implementing pop() function
    print("Implementing pop() function")
    set_result = {random.randint(0,20) for s in range(10)}
    print(set_result)
    for _ in range(len(set_result)):
        set_result.pop()
        print(set_result)
    set_result.clear()
    print("************************************************************************************")

    #Casting lists
    my_list = [random.randint(0,10) for s in range(0,20) if s%2==0]
    set_result = set(my_list)
    print(f'Casting of a list into a set') 
    print(f'List: {my_list}')
    print(f'Set(List): {set_result}')
    print("************************************************************************************")

    #Remove elements "Discard"
    random_number= random.randint(0,10)
    my_set = {random.randint(0,10) for s in range(0,10)}
    print(f'Discard element: {random_number} of the set: {my_set}') 
    print("Implementing Discard")
    my_set.discard(random_number)
    print(my_set)
    print("************************************************************************************")

    #Remove elements "Remove"
    random_number= random.randint(0,10)
    my_set = {random.randint(0,10) for s in range(0,10)}
    print(f'Remove element: {random_number} of the set: {my_set}') 
    print("Implementing Remove. If the element is not present it will raise an exception.")
    my_set.remove(random_number)
    print(my_set)
    print("************************************************************************************")

    # Add elements "Add"
    random_number= random.randint(0,10)
    my_set = {random.randint(0,10) for s in range(0,10)}
    print(f'Add element: {random_number} to the set: {my_set}') 
    print("Implementing Add. If the element is already in the set the add() method won't duplicate the element.")
    my_set.add(random_number)
    print(my_set)
    print("************************************************************************************")

    # Add elements "update"
    random_list= [random.randint(0,10) for l in range(0,5) if l%2==0]
    my_set = {random.randint(0,10) for s in range(0,10) if s%2==0}
    print(f'The list: {random_list}') 
    print(f'The set: {my_set}') 
    print("Implementing update")
    my_set.update(random_list)
    print(f'The set updated with the list: {my_set}')
    print("************************************************************************************")

if __name__ == "__main__":
    run()