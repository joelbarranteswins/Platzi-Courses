person = {
  'name': 'nico',
  'last_name': 'molina',
  'langs': ['python', 'javascript'],
  'age': 99
}

print(person)

person['name'] = 'santi'
person['age'] -= 50
person['langs'].append('rust')
print(person)

del person['last_name']
person.pop('age')

print(person)

print('items')
print(person.items())

print('keys')
print(person.keys())

print('values')
print(person.values())
