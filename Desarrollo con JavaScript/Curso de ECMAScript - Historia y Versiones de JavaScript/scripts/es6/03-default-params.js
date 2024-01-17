function newUser(name, age, country) {
  var name = name || 'Default Name';
  var age = age || 0;
  var country = country || 'Default Country';
  console.log(name, age, country);
}

newUser();
newUser('Ricardo', 23, 'MX');

function newAdmin(name = 'Default Name', age = 0, country = 'Default Country') {
  console.log(name, age, country);
}

newAdmin();
newAdmin('Ricardo', 23, 'MX');